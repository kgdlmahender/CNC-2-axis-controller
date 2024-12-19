Imports System.IO
Imports System.IO.Ports
Imports System.Drawing

Public Class Form1
  Dim moveContinuous As Boolean = False
  Dim moveDistance As Boolean = False
  Dim xCurrent As Single = 0
  Dim yCurrent As Single = 0
  Dim path As New List(Of PointF)
  Dim context As String
  Private Const StepsPerRevolution As Integer = 400
  Private Const PitchCircleDiameter As Double = 6.0
  Dim WithEvents serialPort1 As New SerialPort()

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Configure the serial port
    SerialPort1.BaudRate = 9600
    serialPort1.PortName = "COM24" ' Replace with your actual COM port
    serialPort1.DataBits = 8
    SerialPort1.Parity = Parity.None
    SerialPort1.StopBits = StopBits.One
    SerialPort1.Handshake = Handshake.None
    SerialPort1.Encoding = System.Text.Encoding.Default

    ' Open the serial port
    SerialPort1.Open()
    PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
  End Sub

  ' Event handler for when data is received
  Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serialPort1.DataReceived
    Dim data As String = serialPort1.ReadLine() ' Read the incoming data
    UpdateTextBox(data) ' Update the UI
  End Sub

  ' Method to update the UI
  Private Sub UpdateTextBox(data As String)
    If InvokeRequired Then
      Invoke(New Action(Of String)(AddressOf UpdateTextBox), data)
    Else
      TextBox1.AppendText(data & Environment.NewLine)
    End If
  End Sub

  Private Sub movecontinous_radiobutton_CheckedChanged(sender As Object, e As EventArgs) Handles movecontinous_radiobutton.CheckedChanged
    moveContinuous = movecontinous_radiobutton.Checked
    moveDistance = Not moveContinuous
  End Sub

  Private Sub movedistance_radiobutton_CheckedChanged(sender As Object, e As EventArgs) Handles movedistance_radiobutton.CheckedChanged
    moveDistance = movedistance_radiobutton.Checked
    moveContinuous = Not moveDistance
  End Sub

  Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles xPlusButton.MouseDown, xMinusButton.MouseDown, yPlusButton.MouseDown, yMinusButton.MouseDown
    Dim command As String = ""
    Dim direction As String = CType(sender, Button).Name
    Dim readsignalfromarduoino As String

    Select Case direction
      Case "xPlusButton"
        command = "X+"
      Case "xMinusButton"
        command = "X-"
      Case "yPlusButton"
        command = "Y+"
      Case "yMinusButton"
        command = "Y-"
    End Select

    If moveContinuous Then


      SerialPort1.WriteLine("MOVE" & command)
      ' context = "MOVE" & command
      'readsignalfromarduoino = SerialPort1.ReadExisting(4)


      'TextBox1.Text = readsignalfromarduoino
    ElseIf moveDistance Then
      Dim distance As String = distanceTextBox.Text
      SerialPort1.WriteLine("DISTANCE" & command & distance)
      'readsignalfromarduoino = SerialPort1.ReadExisting(4)


      'TextBox1.Text = readsignalfromarduoino

    End If
  End Sub

  Private Sub Button_MouseUp(sender As Object, e As MouseEventArgs) Handles xPlusButton.MouseUp, xMinusButton.MouseUp, yPlusButton.MouseUp, yMinusButton.MouseUp
    If moveContinuous Then
      SerialPort1.WriteLine("STOP")
      'TextBox1.Text = "MouseUp"
    End If
  End Sub

  Private Function CalculateSteps(distance As Double) As Integer
    Dim circumference As Double = Math.PI * PitchCircleDiameter
    Dim revolutions As Double = distance / circumference
    ' TextBox1.Text = "steps"
    'TextBox1.Text = revolutions * StepsPerRevolution

    Return CInt(revolutions * StepsPerRevolution)


  End Function

  Private Sub openGcodeButton_Click(sender As Object, e As EventArgs) Handles openGCodeButton.Click
    Try
      Dim filePath As String = TextBox2.Text
      If File.Exists(filePath) Then
        Dim gCodeLines As String() = File.ReadAllLines(filePath)
        For Each line As String In gCodeLines
          Dim stepsToMove As Integer = ParseGCode(line)
          If stepsToMove > 0 Or stepsToMove < 0 Then
            If Not serialPort1.IsOpen Then
              serialPort1.Open()
            End If
            serialPort1.WriteLine(stepsToMove.ToString())
            ' Delay to allow the motor to complete the movement
            System.Threading.Thread.Sleep(500)
          End If
        Next
      Else
        MessageBox.Show("File not found. Please enter a valid file path.")
      End If
    Catch ex As Exception
      MessageBox.Show("Error processing G-code file: " & ex.Message)
    End Try
  End Sub

  Private Function ParseGCode(line As String) As Integer
    Dim stepsToMove As Integer
    If line.StartsWith("G01") OrElse line.StartsWith("G1") Then
      Dim parts As String() = line.Split(" ")

      For Each part As String In parts

        If part.StartsWith("X") Then
          Dim distance As Double
          If Double.TryParse(part.Substring(1), distance) Then



            stepsToMove = CalculateSteps(distance)

          End If
        End If
      Next
    End If
    'TextBox1.Text = stepsToMove
    Return stepsToMove
  End Function

  'Private Sub openGcodeButton_Click(sender As Object, e As EventArgs) Handles openGCodeButton.Click
  '  Dim openFileDialog As New OpenFileDialog
  '  openFileDialog.Filter = "G-code Files|*.nc;*.txt"

  '  If openFileDialog.ShowDialog() = DialogResult.OK Then
  '    Dim lines As String() = File.ReadAllLines(openFileDialog.FileName)
  '    path.Clear()
  '    xCurrent = 0
  '    yCurrent = 0
  '    For Each line In lines
  '      parseGCode(line)
  '      'DrawPath()
  '      System.Threading.Thread.Sleep(100)  ' Allow Arduino time to process each command
  '    Next
  '  End If
  'End Sub


  'Private Sub parseGCode(gcodeLine As String)
  '  gcodeLine = gcodeLine.Trim()

  '  If gcodeLine.StartsWith("G0") Or gcodeLine.StartsWith("G1") Then
  '    Dim xIndex As Integer = gcodeLine.IndexOf("X"c)
  '    Dim yIndex As Integer = gcodeLine.IndexOf("Y"c)

  '    If xIndex <> -1 Then
  '      Dim spaceIndex As Integer = gcodeLine.IndexOf(" ", xIndex)
  '      If spaceIndex = -1 Then spaceIndex = gcodeLine.Length
  '      Dim xDistance As Single = Val(gcodeLine.Substring(xIndex + 1, spaceIndex - xIndex - 1))
  '      xCurrent += xDistance
  '      serialPort1.WriteLine("G1 X" & xDistance) ' Send to Arduino
  '    End If

  '    If yIndex <> -1 Then
  '      Dim spaceIndex As Integer = gcodeLine.IndexOf(" ", yIndex)
  '      If spaceIndex = -1 Then spaceIndex = gcodeLine.Length
  '      Dim yDistance As Single = Val(gcodeLine.Substring(yIndex + 1, spaceIndex - yIndex - 1))
  '      yCurrent += yDistance
  '      serialPort1.WriteLine("G1 Y" & yDistance) ' Send to Arduino
  '    End If

  '    path.Add(New PointF(xCurrent, yCurrent))
  '  End If
  'End Sub

  Private Sub DrawPath()
    Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
    Dim g As Graphics = Graphics.FromImage(bmp)

    ' Draw the path
    If path.Count > 1 Then
      For i As Integer = 0 To path.Count - 2
        g.DrawLine(Pens.Red, path(i), path(i + 1))
      Next
    End If

    ' Draw the current position
    If path.Count > 0 Then
      g.FillEllipse(Brushes.Blue, path.Last().X - 5, path.Last().Y - 5, 10, 10)
    End If

    PictureBox1.Image = bmp
    g.Dispose()
  End Sub


End Class
