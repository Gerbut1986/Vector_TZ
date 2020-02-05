                                              Tasks for Trainee Software Developer
Algorithms 
TASK 1. Rail Fence Cipher. Encoding and Decoding
Create two functions to encode and then decode a string using the Rail Fence Cipher. This cipher is used to encode a string by placing each character successively in a diagonal along a set of "rails". First start off moving diagonally and down. When you reach the bottom, reverse direction and move diagonally and up until you reach the top rail. Continue until you reach the end of the string. Each "rail" is then read left to right to derive the encoded string.

For example, the string "WEAREDISCOVEREDFLEEATONCE" could be represented in a three-rail system as follows:
 
The encoded string would be:
WECRLTEERDSOEEFEAOCAIVDEN

1.	Write a function/method that takes 2 arguments, a string and the number of rails, and returns the ENCODED string.
2.	Write a second function/method that takes 2 arguments, an encoded string and the number of rails, and returns the DECODED string.

For both encoding and decoding, assume number of rails >= 2 and that passing an empty string will return an empty string.

=------------------------------------------------------------------------------------------------------------------------------------=

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
