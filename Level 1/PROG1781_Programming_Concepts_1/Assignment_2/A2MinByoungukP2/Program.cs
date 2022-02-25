/*
 * Program ID: A2MinByoungukP2
 * 
 * Purpose: Assignment2
 * 
 * Revision History:
 *  created by Byounguk Min October 2020
 *  
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2MinByoungukP2
{
    class Program
    {
        static double GetMethod(double lengthDouble)
        {    //Area of a square
            return (lengthDouble * 2);
        }
        static double GetMethod(double baseDouble, double heightDouble)
        {   //Area of a triangle
            return (baseDouble * heightDouble) / 2;
        }
        static double GetMethod(double lengthDouble, double widthDouble, double heightDouble)
        {   //Volume of a cube
            return(lengthDouble * widthDouble * heightDouble);
        }
        static double GetMethod(float piFloat, double radiusDouble)
        {   //Volume of a sphere
            return (4 / 3 * piFloat * (radiusDouble * radiusDouble * radiusDouble));
        }
        static void Main(string[] args)
        {
            //Declaring Variables
            int selectInteger;
            string selectString;
            string lengthString;
            string baseString;
            string heightString;
            string widthString;
            string radiusString;
            double widthDouble;
            double lengthDouble;
            double result1Double;
            double result2Double;
            double result3Double;
            double result4Double;
            float piFloat;
            double baseDouble;
            double heightDouble;
            double radiusDouble;

            //Initializing Variables
            selectInteger = 0;
            selectString = "";
            lengthString = "";
            baseString = "";
            heightString = "";
            widthString = "";
            radiusString = "";
            widthDouble = 0;
            lengthDouble = 0;
            result1Double = 0;
            result2Double = 0;
            result3Double = 0;
            result4Double = 0;
            piFloat = 3.14159f;
            baseDouble = 0;
            heightDouble = 0;
            radiusDouble = 0;

            Console.WriteLine("[Select one option: 1.Square 2.Triangle 3.Cube 4.Sphere]");
            Console.Write("Answer with number: ");
            selectString = Console.ReadLine();
            selectInteger = int.Parse(selectString);

            if (selectInteger == 1)
            {
                Console.Write("Enter your length: ");
                lengthString = Console.ReadLine();
                lengthDouble = double.Parse(lengthString);

                //Running GetMethod 1
                result1Double = GetMethod(lengthDouble);
                Console.WriteLine("Your result is: " + result1Double);
            }
            else if (selectInteger == 2)
            {
                Console.Write("Enter your base: ");
                baseString = Console.ReadLine();
                baseDouble = double.Parse(baseString);

                Console.Write("Enter your height: ");
                heightString = Console.ReadLine();
                heightDouble = double.Parse(heightString);

                //Running GetMethod 2
                result2Double = GetMethod(baseDouble, heightDouble);
                Console.WriteLine("Your result is: " + result2Double);
            }
            else if (selectInteger == 3)
            {
                Console.Write("Enter your length: ");
                lengthString = Console.ReadLine();
                lengthDouble = double.Parse(lengthString);

                Console.Write("Enter your width: ");
                widthString = Console.ReadLine();
                widthDouble = double.Parse(widthString);

                Console.Write("Enther your height: ");
                heightString = Console.ReadLine();
                heightDouble = double.Parse(heightString);

                //Running GetMethod 3
                result3Double = GetMethod(lengthDouble, widthDouble, heightDouble);
                Console.WriteLine("Your result is: " + result3Double);
            }
            else
            {
                Console.Write("Enter your radius: ");
                radiusString = Console.ReadLine();
                radiusDouble = double.Parse(radiusString);

                //Running Getmethod 4
                result4Double = GetMethod(piFloat, radiusDouble);
                Console.WriteLine("Your result is: " + result4Double);
            }
            Console.ReadLine();
        }
    }
}
