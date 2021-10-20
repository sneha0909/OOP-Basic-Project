# OOP-Basic-Project

1st laboratory project (Part 1)
Required time - 4 classes and 1st midterm; Points for project - 10
 
Project need to implement as console .NET application. For data output use console (System.Console). Information how to create a .net console application in manual.

For project naming use template below:
LastName_Project_1_Variant (for example Skiba_Project_1_2)
Variant for student will be assigned on first laboratory class;
 
Part 1 -  Implement class for working with amount of money;
Points for this task - 5;
Deadline for implementation and passing before points will be divided by 2 - First midterm; 
Task details:
In class need to define two fields:
Integer part of the number - ulong in C#;
Fractional part of the number - ushort in C#;
Access to fields only from access methods or properties.
In class need to define and implement methods described below:

Access methods to class fields (separate methods for integer and fractional parts) (AM1, AM2)
Method for displaying whole number in string format (MD)
Methods for setting new values in class fields. Need methods for separate parts setting and method for whole number setting (input parameter is string which you need to split for parts and generate your number) (MS1, MS2, MS3);
Must be implemented default constructor for fields initializing (C1)
1 variant: integer part of number must be initialized with random number in range from 10 to 255 (including boundary values) / 5; fractional part of number must be initialized with random number in range from 1 to 99 (not including boundary values) + random number in range from 10 to 66 (including boundary values);
2 variant: integer part of number must be initialized with random number in range from 23 to 133 (not including boundary values) * 4; fractional part of number must be initialized with random number in range from 15 to 77 (not including boundary values) - random number in range from 5 to 25 (not including boundary values);
3 variant: integer part of number must be initialized with random number in range from 1 to 111 (including boundary values) - 4; fractional part of number must be initialized with random number in range from 1 to 155 (including boundary values) * random number in range from 2 to 7 (not including boundary values);

Implement constructor with parameters:
Constructor with one parameter (C2):
1 variant:  input parameter to constructor is integer part of number, fractional part of number must be initialized with random number in range from 1 to 15 (including boundary values);
2 variant:  input parameter to constructor is integer part of number, fractional part of number must be initialized with random number in range from 5 to 25 (not including boundary values);
3 variant: input parameter to constructor is  fractional part of number,  integer part of number must be initialized with random number in range from 6 to 88 (including boundary values);
Constructor with 2 parameters - integer and fractional part of number both parameters for constructor. (C3);
Copy constructor (C4);
Constructor with string parameter (C5): input is string with number, you must split it by integer and fractional part and generate number;

Method for adding two money amounts (parameters for function is 2 numbers, integer and fractional parts) (MAdd);
Method for adding two money amounts(MAdd2) (parameter is object of same type as your class);
Method for adding two money amounts(MAdd3) (parameter is string);
Method for subtraction two money amounts (parameters for function is 2 numbers, integer and fractional parts) (MSub);
Method for subtraction two money amounts (parameter is object of same type as your class) (MSub2);
Method for subtraction two money amounts (parameter is string) (MSub3);
Method for comparing two money amounts (parameter for function is object with other money amount with which current compare) (MEq);
Method which returns 1 if input money amount object is greater than current and 0 if less. If equals return -1 (MComp);

In main program class create array for 10+ elements and fill this array with your objects and:
Calculate total sum of all money amounts (CalcSumm);
Calculate how many equal objects you have (CalcEq);
Find maximum money amount object (FMax);
Find minimum money amount object (FMin);
