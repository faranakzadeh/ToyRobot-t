# ToyRobot-t

Toy Rboto Code:

Git Hub Link: git@github.com:faranakzadeh/ToyRobot-t.git

This C# .NET solution is a simulator of a toy robot that moves on on a square table top.

Main file : Program.cs
The application runs in a single executable file which can be opened by double clicking it. The user can follow instructions on the console and also use it to type their input.
-behavoiurs :
	This class is used to simulate the behaviour of the toy.
    	It calls the interfaces from other classes to make a behaviour object.
    	Methods for this object include processing the string and
    	rendering the report.
-borad :
	This class is the board that the toy sits on. It has a properties for rows and colums.
    	There is also a method for checking if the position of the toy is valid.
-ConsoleChecker 
	this method takes a string array and compares the first element to the list of commands
        f the command doesn't exist then an error is thrown, otherwise the command is returned
-Toy 
	This clas will find the direction.
Design Patterns Used:

A class is used to represent user input data, validate it and return appropriate object types or error messages. The class has no dependencies and it's methods are unit tested before being set to work with the rest of the application.

Instruction:
PLACE X,Y,FACING : This puts the toy on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST. If the toy is already placed, issuing another valid PLACE command will place the toy in the newly specified location.
MOVE : This moves the toy one unit forward in the direction it is currently facing.
LEFT : This rotates the toy 90 degrees to the left (i.e. counter-clockwise) without changing the position.
RIGHT : This rotates toy 90 degrees to the right (i.e. clockwise) without changing the position.
REPORT : This announces the X,Y and direction of the toy by printing to the console.

Test: run ToyRobot-t.exe and type example: 
PLACE 0,0,NORTH
MOVE
REPORT


Faranak Zadeh 8/11/2020



