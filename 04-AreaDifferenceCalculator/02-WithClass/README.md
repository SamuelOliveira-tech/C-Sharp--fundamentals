# Triangle Area Comparison Using Class (C#)

This project is a C# console application that calculates and compares the areas of two triangles using Object-Oriented Programming (OOP) concepts.

Unlike the procedural version, this implementation encapsulates triangle data and the area calculation inside a dedicated 'Triangle' class, improving code organization and readability.

## Features

- Uses a custom 'Triangle' class
- Stores triangle sides as object attributes
- Calculates triangle area using Heron's formula
- Reads user input using 'CultureInfo.InvariantCulture'
- Compares the areas of two triangles
- Displays the triangle with the largest area

## Concepts Practiced

- Object-Oriented Programming (OOP)
- Classes and objects
- Attributes and methods
- Encapsulation
- Mathematical formulas (Heron's formula)
- 'double' precision
- Conditional statements

- ### Program.cs

- Handles user input and output
- Creates two 'Triangle' objects
- Assigns values to object attributes
- Calls the 'Area()' method
- Compares triangle areas

### Triangle.cs

- Defines the 'Triangle' class
- Public attributes:
  - 'A'
  - 'B'
  - 'C'
- Method:
  - 'Area()' — calculates the triangle area using Heron's formula

## How It Works

1. Two `Triangle` objects are created.
2. The user enters the three side lengths for each triangle.
3. The program calculates the area of each triangle.
4. The areas are displayed with four decimal places.
5. The triangle with the larger area is shown.
6. If both areas are equal, the program informs the user.
