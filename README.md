# 2-Axis CNC Controller  

## Overview  
This project is a 2-axis CNC controller designed for precision movements and automated cutting tasks. It supports functionalities like:  
- Continuous jogging  
- Distance-based movement  
- G-code execution for path cutting  

The project integrates **VB.NET** for the user interface and **Arduino UNO** for motor control of machines.  

---

## Features  
- **Continuous Jogging:** Smooth manual motor movements.  
- **Distance-Based Movement:** Set exact distances for precise positioning.  
- **G-Code Execution:** Parse and execute G-code files for automated operations.  

---

## Technology Stack  
- **Software:** VB.NET, Arduino IDE, grbl
- **Hardware:** Stepper motors, drivers, Arduino Uno  

---

## Getting Started  

### Prerequisites and procedure for testing
- Arduino Uno and CNC hardware setup.  
- grbl installed on Arduino Uno. For uploading grbl on Arduino Uno, download the ZIP file of this link https://github.com/grbl/grbl and add to the arduino interface.
- All the wirings should be done refering arduino Uno wiring diagram to the stepper drives.
![GRBL Pin Layout](https://github.com/kgdlmahender/CNC-2-axis-controller/raw/master/Grbl_Pin_Layout.webp)
- VB.NET installed (Visual Studio recommended). Download the zip file of this CNC 2 axis controller and open in visual studio.
- Check the correct COMPort which is connected to arduino Uno and rename the COMPort number in the code.
- After running, a form(controlling interface) will be opened and you can jog, move a distance or upload a gcode and run the machine.


### Installation  
1. Clone the repository:  
   ```bash
   [git clone https://github.com/kgdlmahender/2-Axis-CNC-Controller.git
](https://github.com/kgdlmahender/CNC-2-axis-controller)
