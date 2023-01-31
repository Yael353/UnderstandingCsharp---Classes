using System;

namespace Exercise1
{
    internal class Program
    {
        /*
         * Create a class named Square that contains fields for area and the length of a side and whose constructor
         * requires a parameter for the length of one side of a Square. The constructor assigns its parameter to the 
         * length of the square's side field and calls a private method that computes the area field. Also include 
         * read only properties to get a square side and area. in the main method create an array of ten square objects 
         * with sides that have values of 1 trough 10. Display the values for each square. 
         */
        static void Main(string[] args)
        {
            Square[] squares = new Square[10];
            for (int i = 0; i < squares.Length; i++)
            {
                squares[i] = new Square(i + 1);
                Console.WriteLine($"Length: {squares[i].lengthSide,2} Area: {squares[i].area,2}");
            }

        }


    }
}