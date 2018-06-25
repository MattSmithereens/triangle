using System;
using System.Collections.Generic;

namespace Triangles
{

    public class Triangle
    {

        private int largeSide = 0;

        public static void Main()
        {
            Sides sidesObj = new Sides();
            sidesObj.SetSideLengths();
            Console.WriteLine(new Triangle().CheckSides(sidesObj.GetSideOne(), sidesObj.GetSideTwo(), sidesObj.GetSideThree()));
        }

        public string CheckSides(int side1, int side2, int side3)
        {
            string response = "";
            List<int> sideArray = new List<int> { side1, side2, side3 };

            foreach (int i in sideArray)
            {
                if (largeSide <= i)
                {
                    largeSide = i;
                }
            }

            sideArray.Remove(largeSide);
            side2 = sideArray[0];
            side3 = sideArray[1];

            if (largeSide >= (side2 + side3))
            {
                response = "This is not a triangle!";
            }
            else if ((largeSide * largeSide) == ((side2 * side2) + (side3 * side3))) {
                response = "This is a right triangle";
            }
            else if (largeSide == side2 && largeSide == side3)
            {
                response = "Triangle is Equilateral!";
            }
            else if (largeSide == side2 || largeSide == side3 || side2 == side3)
            {
                response = "Triangle is Isosceles!";
            }
            else
            {
                response = "Triangle is Scalene!";
            }

            return response;

        }
    }

    public class Sides
    {
        private int sideOne, sideTwo, sideThree;

        public void SetSideLengths() 
        {
            Console.WriteLine("Enter A Length For Side 1");
            sideOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter A Length For Side 2");
            sideTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter A Length For Side 3");
            sideThree = int.Parse(Console.ReadLine());
        }

        public int GetSideOne() {
            return sideOne;
        }

        public int GetSideTwo() {
            return sideTwo;
        }

        public int GetSideThree() {
            return sideThree;
        }
        
    }


}
