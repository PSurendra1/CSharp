using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept
{
    public class Demo2Methods
    {

       
 
        }
            namespace SquareAreaCalculator
    {
        class Program
        { 
            static void Main(string[] args)
            {
                // Calculate and display the area of a triangle
                double baseLength = GetDoubleInput("Enter the base length of the triangle: ");
                double height = GetDoubleInput("Enter the height of the triangle: ");
                double triangleArea = AreaOfTriangle(baseLength, height);
                Console.WriteLine($"The area of the triangle is: {triangleArea}");

                // Calculate and display the area of a square
                double sideLength = GetDoubleInput("Enter the side length of the square: ");
                double squareArea = AreaOfSquare(sideLength);
                Console.WriteLine($"The area of the square is: {squareArea}");
            }

            // Method to calculate the area of a triangle
            public static double AreaOfTriangle(double baseLength, double height)
            {
                double area = baseLength * height / 2;
                return area;
            }

            // Method to calculate the area of a square
            public static double AreaOfSquare(double sideLength)
            {
                double area = sideLength * sideLength;
                return area;
            }

            // Helper method to get user input as a double
            public static double GetDoubleInput(string prompt)
            {
                Console.Write(prompt);
                double input;
                while (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write(prompt);
                }
                return input;
            }
        }
    }

}
    

