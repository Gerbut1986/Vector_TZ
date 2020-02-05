OOP
TASK 1. Sortable Shapes
Although shapes can be very different by nature, they can be sorted by the size of their area.

Task:
Create 4 different shapes (Square, Rectangle, Triangle, Circle) that can be part of a sortable list. The sort order is based on the size of their respective areas:
●	The area of a Square is the square of its side
●	The area of a Rectangle is width multiplied by height
●	The area of a Triangle is base multiplied by height divided by 2
●	The area of a Circle is the square of its radius multiplied by π

The default sort order of a list of shapes is ascending on area size:
Example:
var side = 1.1234D;
var radius = 1.1234D;
var base = 5D;
var height = 2D;
var shapes = new List<Shape>{ new Square(side),
                            new Circle(radius),
                            new Triangle(base, height) };
shapes.Sort();
In the result your shapes should be sorted correctly ascending on area size.

Note: Use the correct π constant for your circle area calculations:
System.Math.PI
