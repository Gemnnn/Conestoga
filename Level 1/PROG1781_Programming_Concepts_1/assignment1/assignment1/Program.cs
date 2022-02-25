/*
 * Program ID: Assignment1
 * 
 * Purpose: Assignment
 * 
 * Revision History:
 *  created by Byounguk Min Sept 2020
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameString;
            string emailString;
            string experienceString;
            string countryString;
            double celsiusDouble;
            double fahrenheitDouble;

            nameString = "";
            emailString = "";
            experienceString = "";
            countryString = "";
            celsiusDouble = 0;
            fahrenheitDouble = 0;

            Console.Write("Please Enter your Name: ");
            nameString = Console.ReadLine();
            Console.Write("Please Enter your E-mail: ");
            emailString = Console.ReadLine();
            Console.Write("please Enter Cliius: ");
            celsiusDouble = int.Parse(Console.ReadLine());
            Console.Write("Please Enter your Experience(Low, Moderate, or High): ");
            experienceString = Console.ReadLine();
            Console.Write("Please Enter your Country: ");
            countryString = Console.ReadLine();

            fahrenheitDouble = (celsiusDouble * 9 / 5) + 32;
         
            Console.WriteLine("Your Name Assignment1 Part2");

            Console.WriteLine("Name: " + nameString);
            Console.WriteLine("Email: " + emailString);
            Console.WriteLine("The Celsius temp of " + celsiusDouble +
                " degrees converts to in " + fahrenheitDouble + " Fahrenheit.");
            Console.WriteLine("Experience: " + experienceString + 
                " previous programming experience");
            Console.WriteLine("Country: " + countryString);
            Console.ReadLine();
        }
    }
}
