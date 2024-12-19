<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.distanceTextBox = New System.Windows.Forms.TextBox()
		Me.movecontinous_radiobutton = New System.Windows.Forms.RadioButton()
		Me.movedistance_radiobutton = New System.Windows.Forms.RadioButton()
		Me.xPlusButton = New System.Windows.Forms.Button()
		Me.xMinusButton = New System.Windows.Forms.Button()
		Me.yPlusButton = New System.Windows.Forms.Button()
		Me.yMinusButton = New System.Windows.Forms.Button()
		Me.openGCodeButton = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.graphPanel = New System.Windows.Forms.Panel()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.GroupBox1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.distanceTextBox)
		Me.GroupBox1.Controls.Add(Me.movecontinous_radiobutton)
		Me.GroupBox1.Controls.Add(Me.movedistance_radiobutton)
		Me.GroupBox1.Location = New System.Drawing.Point(453, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(221, 116)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "GroupBox1"
		'
		'distanceTextBox
		'
		Me.distanceTextBox.Location = New System.Drawing.Point(121, 33)
		Me.distanceTextBox.Name = "distanceTextBox"
		Me.distanceTextBox.Size = New System.Drawing.Size(100, 22)
		Me.distanceTextBox.TabIndex = 2
		'
		'movecontinous_radiobutton
		'
		Me.movecontinous_radiobutton.AutoSize = True
		Me.movecontinous_radiobutton.Location = New System.Drawing.Point(6, 74)
		Me.movecontinous_radiobutton.Name = "movecontinous_radiobutton"
		Me.movecontinous_radiobutton.Size = New System.Drawing.Size(122, 20)
		Me.movecontinous_radiobutton.TabIndex = 1
		Me.movecontinous_radiobutton.TabStop = True
		Me.movecontinous_radiobutton.Text = "Move continuos"
		Me.movecontinous_radiobutton.UseVisualStyleBackColor = True
		'
		'movedistance_radiobutton
		'
		Me.movedistance_radiobutton.AutoSize = True
		Me.movedistance_radiobutton.Location = New System.Drawing.Point(6, 33)
		Me.movedistance_radiobutton.Name = "movedistance_radiobutton"
		Me.movedistance_radiobutton.Size = New System.Drawing.Size(113, 20)
		Me.movedistance_radiobutton.TabIndex = 0
		Me.movedistance_radiobutton.TabStop = True
		Me.movedistance_radiobutton.Text = "Movedistance"
		Me.movedistance_radiobutton.UseVisualStyleBackColor = True
		'
		'xPlusButton
		'
		Me.xPlusButton.Location = New System.Drawing.Point(12, 309)
		Me.xPlusButton.Name = "xPlusButton"
		Me.xPlusButton.Size = New System.Drawing.Size(75, 23)
		Me.xPlusButton.TabIndex = 3
		Me.xPlusButton.Text = "X+"
		Me.xPlusButton.UseVisualStyleBackColor = True
		'
		'xMinusButton
		'
		Me.xMinusButton.Location = New System.Drawing.Point(115, 309)
		Me.xMinusButton.Name = "xMinusButton"
		Me.xMinusButton.Size = New System.Drawing.Size(75, 23)
		Me.xMinusButton.TabIndex = 4
		Me.xMinusButton.Text = "X-"
		Me.xMinusButton.UseVisualStyleBackColor = True
		'
		'yPlusButton
		'
		Me.yPlusButton.Location = New System.Drawing.Point(216, 309)
		Me.yPlusButton.Name = "yPlusButton"
		Me.yPlusButton.Size = New System.Drawing.Size(75, 23)
		Me.yPlusButton.TabIndex = 5
		Me.yPlusButton.Text = "Y+"
		Me.yPlusButton.UseVisualStyleBackColor = True
		'
		'yMinusButton
		'
		Me.yMinusButton.Location = New System.Drawing.Point(332, 309)
		Me.yMinusButton.Name = "yMinusButton"
		Me.yMinusButton.Size = New System.Drawing.Size(75, 23)
		Me.yMinusButton.TabIndex = 6
		Me.yMinusButton.Text = "Y-"
		Me.yMinusButton.UseVisualStyleBackColor = True
		'
		'openGCodeButton
		'
		Me.openGCodeButton.Location = New System.Drawing.Point(442, 309)
		Me.openGCodeButton.Name = "openGCodeButton"
		Me.openGCodeButton.Size = New System.Drawing.Size(75, 23)
		Me.openGCodeButton.TabIndex = 7
		Me.openGCodeButton.Text = "Open GCode"
		Me.openGCodeButton.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Location = New System.Drawing.Point(49, 65)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(281, 154)
		Me.PictureBox1.TabIndex = 8
		Me.PictureBox1.TabStop = False
		'
		'graphPanel
		'
		Me.graphPanel.Location = New System.Drawing.Point(65, 86)
		Me.graphPanel.Name = "graphPanel"
		Me.graphPanel.Size = New System.Drawing.Size(200, 100)
		Me.graphPanel.TabIndex = 9
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(44, 3)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(286, 278)
		Me.TextBox1.TabIndex = 10
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(401, 204)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(221, 47)
		Me.TextBox2.TabIndex = 11
		Me.TextBox2.Text = "C:\Users\kgdlm\Downloads\linearmove_test.txt"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(686, 361)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.graphPanel)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.openGCodeButton)
		Me.Controls.Add(Me.yMinusButton)
		Me.Controls.Add(Me.yPlusButton)
		Me.Controls.Add(Me.xMinusButton)
		Me.Controls.Add(Me.xPlusButton)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents distanceTextBox As TextBox
	Friend WithEvents movecontinous_radiobutton As RadioButton
	Friend WithEvents movedistance_radiobutton As RadioButton
	Friend WithEvents xPlusButton As Button
	Friend WithEvents xMinusButton As Button
	Friend WithEvents yPlusButton As Button
	Friend WithEvents yMinusButton As Button
	Friend WithEvents openGCodeButton As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents graphPanel As Panel
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
End Class
