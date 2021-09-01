# How to work with
## How install project:
Before getting started, you need to download the project.
  With this command:
 ```
 git clone https://github.com/Holiks-Serbuchev/CalculatorNew.git
 cd CalculatorNew
 dotnet build
 dotnet run
 ```
 ## How to use:
When the user enters the calculator, he will offer to enter the numbers that you will use for arithmetic operations.

   
   ![alt text](https://i.imgur.com/eWbGDh2_d.webp?maxwidth=760&fidelity=grand)
   
After entering the necessary numbers, the user will be prompted to select the sign of the operation.

![alt text](https://i.imgur.com/DbW0uuX_d.webp?maxwidth=760&fidelity=grand)

* The calculator has several functions:
    * Addition;
    * Subtraction;
    * Multiplication;
    * Division;
    * Equal;
    * Purification.
    
After selecting the sign of the operation, a response appears on the screen.

![alt text](https://i.imgur.com/HLnAaQV_d.webp?maxwidth=760&fidelity=grand)

* After the response appears, the user will be prompted to choose an option:
  * Continue the program and clear the values;
  * Continue working with number;
  * Exit.
  
![alt text](https://i.imgur.com/YAQfr1v_d.webp?maxwidth=760&fidelity=grand)

An example of using the program:

![hippo](https://i.imgur.com/DJjBuOj.gif)

# Architecture
This application was written in C#.
1) The beginning of the program begins in the __Main(string[] args)__ function.
2) The __ConvertNumber__ function is responsible for converting values to __double__ type.
2) There is also a __Calculator__ class in which there are functions for calculating.
4) The __Calculator__ class has an __Operation__ function that calls you to do arithmetic operations.
5) The __Calculator__ class has a __PrintCommands__ function that allows you to print commands.
6) The __Calculator__ class has an __EndPrintCommands__ function that allows you to select the aftermath of the calculator action.
