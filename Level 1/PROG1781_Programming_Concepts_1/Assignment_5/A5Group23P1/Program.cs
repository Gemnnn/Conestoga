/*
 * Program Id: A5Group23P1
 *
 * Purpose: To manage students information by class.
 * 
 * Revision History:
 *        created Dec 2020 by Sangbong Park, Byunguk Min
 *        
 *        Team Member: Sangbong Park and Byunguk Min
 *                
 *        Sangbong Park	: Coding, reviewing and testing.
 *        Byunguk Min   : Coding, reviewing and testing.
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5Group23P1
{
	class Program
	{
		//Enter number of student
		static uint EnterNumgerOfStudent()
		{
			//Declare and initialize variables.
			uint numberOfStudentInteger = 0;
			bool retryOptioinBoolean = true;

			while (retryOptioinBoolean)
			{
				try
				{
					Console.Write("Please enter the student number : ");
					numberOfStudentInteger = uint.Parse(Console.ReadLine().Trim());
					retryOptioinBoolean = false;
				}
				catch (FormatException)
				{
					Console.WriteLine("ERROR : Input must be number.");
				}
				catch (OverflowException)
				{
					Console.WriteLine("ERROR : Out of ragend number is detected.");
				}
				catch (Exception)
				{
					Console.WriteLine("ERROR : Unexpected error is occured.");
				}
			}

			return numberOfStudentInteger;
		}

		//Choose one option
		static string EnterOption()
		{
			//Declare and initialize variables.
			bool retryOptioinBoolean = true;
			string option = "";

			while (retryOptioinBoolean)
			{
				try
				{
					Console.Write("Please enter one option (A ~ D) : ");
					option = Console.ReadLine().Trim();
					if( option.Length > 1)
					{
						throw new OverflowException();
					}
					else if(char.IsLetter(option[0]) != true){
						throw new FormatException();
					}
					retryOptioinBoolean = false;
				}
				catch (FormatException)
				{
					Console.WriteLine("ERROR : Input must be a letter.");
				}
				catch (OverflowException)
				{
					Console.WriteLine("ERROR : Input must be one alpabat (A ~ D)");
				}
				catch (Exception)
				{
					Console.WriteLine("ERROR : Unexpected error is occured.");
				}
			}

			return option.ToUpper();
		}

		//Enter name by user
		static string EnterName()
		{
			//Declare and initialize variables.
			string firstNameString = "";
			string lastNameString = "";
			string nameString = "";
			bool retryOptioinBoolean = true;

			while (retryOptioinBoolean)
			{
				try
				{
					Console.Write("Please enter the first name : ");
					firstNameString = Console.ReadLine().TrimEnd();

					foreach (char letter in firstNameString)
					{
						if(char.IsLetter(letter) != true || letter == ' ')
						{
							throw new FormatException();
						}
					}

					Console.Write("Please enter the last name : ");
					lastNameString = Console.ReadLine().TrimEnd();

					foreach (char letter in firstNameString )
					{
						if (char.IsLetter(letter) != true || letter == ' ')
						{
							throw new FormatException();
						}
					}
					nameString = char.ToUpper(firstNameString[0]) + firstNameString.ToLower().Substring(1) + " " + char.ToUpper(lastNameString[0]) + lastNameString.ToLower().Substring(1);

					if(nameString == "")
					{
						throw new FormatException();
					}
					retryOptioinBoolean = false;
				}
				catch(FormatException)
				{
					Console.WriteLine("ERROR : please enter letters only.");
				}
				catch (Exception)
				{
					Console.WriteLine("ERROR : Unexpected error is occured.");
				}
			}
	
			return nameString;
		}

		//Enter age by user
		static uint EnterAge()
		{
			//Declare and initialize variables.
			bool retryOptioinBoolean = true;
			uint ageInteger = 0;

			while (retryOptioinBoolean)
			{
				try
				{
					Console.Write("Please enter the age : ");
					ageInteger = uint.Parse(Console.ReadLine().Trim());
					retryOptioinBoolean = false;
				}
				catch (FormatException)
				{
					Console.WriteLine("ERROR : Input must be number.");
				}
				catch (OverflowException)
				{
					Console.WriteLine("ERROR : Out of ragend number is detected.");
				}
				catch (Exception)
				{
					Console.WriteLine("ERROR : Unexpected error is occured.");
				}
			}
			return ageInteger;
		}

		//Enter address by user
		static string EnterAddress()
		{
			//Declare and initialize variables.
			bool retryOptioinBoolean = true;
			string addressString = "";

			while (retryOptioinBoolean)
			{
				try
				{
					Console.Write("Please enter the address : ");
					addressString = Console.ReadLine().Trim();
					retryOptioinBoolean = false;
				}
				catch (Exception)
				{
					Console.WriteLine("ERROR : Unexpected error is occured.");
				}
			}
			return addressString;
		}

		//Check if there is an existed record.
		static int CheckNameExist(Student[] studentArray, string nameString, int currentIndexInteger)
		{
			//Declare and initialize variables.
			int indexNumberInteger = -1;

			for (int i = 0; i < currentIndexInteger; i++)
			{
				if (nameString == studentArray[i].GetStudentName())
				{
					indexNumberInteger = i;
				}
			}

			return indexNumberInteger;
		}

		//Option A
		static int AddStudent(Student[] studentArray, int currentIndexInteger)
		{
			//Declare and initialize variables.
			string nameString = "";
			uint ageInteger = 0;
			string addressString = "";
			bool retryOptioinBoolean = true;

			Console.WriteLine("============================================================================");
			Console.WriteLine("A. Add a new student");
			Console.WriteLine("============================================================================");

			while (retryOptioinBoolean)
			{
				Console.WriteLine();

				//Check if it is available to store the data.
				if(currentIndexInteger == studentArray.Length)
				{
					Console.WriteLine("ERROR : It is not stored anymore.");
					break;
				}

				//User prompts to enter name
				nameString = EnterName();
				
				//Check if student record exisits
				if(CheckNameExist(studentArray, nameString, currentIndexInteger) != -1)
				{
					Console.WriteLine("ERROR : student record already exists. Please enter student name again");
					continue;
				}

				//User prompts to enter age and address.
				ageInteger = EnterAge();
				addressString = EnterAddress();

				//Record the entered data to the object.
				studentArray[currentIndexInteger] = new Student(nameString, ageInteger, addressString);

				//User decides to exit.
				Console.Write("\nPlease enter \"Quit\" to return to main menu : ");
				if(Console.ReadLine().Trim().ToUpper() == "QUIT")
				{
					retryOptioinBoolean = false;
				}
				currentIndexInteger++;
			}

			return currentIndexInteger;
		}

		//Option B
		static void EditStudentRecord(Student[] studentArray, int currentIndexInteger)
		{
			//Declare and initialize variables.
			string nameString = "";
			string addressString = "";
			uint ageInteger = 0;
			int indexNumberInteger = 0;

			Console.WriteLine("============================================================================");
			Console.WriteLine("B. Edit an existing student record");
			Console.WriteLine("============================================================================\n");

			Console.WriteLine("----------------------------------------------------------------------------");
			Console.WriteLine("Check old information");
			Console.WriteLine("----------------------------------------------------------------------------");

			//User prompts a name.
			nameString = EnterName();
			indexNumberInteger = CheckNameExist(studentArray, nameString, currentIndexInteger);

			//Check if record exists
			if (indexNumberInteger == -1)
			{
				Console.WriteLine("ERROR : Student record does not exists.");
			}
			else
			{
				Console.WriteLine("----------------------------------------------------------------------------");
				Console.WriteLine("SUCCESS : Student record exits. Display student record");
				Console.WriteLine("----------------------------------------------------------------------------");

				//display the same data with entered data.
				studentArray[indexNumberInteger].DisplayStudentInformation(indexNumberInteger);
				Console.WriteLine("Modify student information");
				//Enter new data
				nameString = EnterName();

				if (CheckNameExist(studentArray, nameString, currentIndexInteger) == -1)
				{
					ageInteger = EnterAge();
					addressString = EnterAddress();

					//update new data.
					studentArray[indexNumberInteger].EditStudentInformation(nameString, ageInteger, addressString);
				}
				else
				{
					Console.WriteLine("ERROR : student record already exists.\n");
				}
				
				
			}
		}

		//Option C
		static void DisplayStudentInforamtion(Student[] studentArray, int currentIndexInteger)
		{
			//Declare and initialize variables.
			string nameString = "";
			bool retryOptioinBoolean = true;
			int indexNumberInteger = 0;

			Console.WriteLine("============================================================================");
			Console.WriteLine("C. Display the name, age, and address of the student");
			Console.WriteLine("============================================================================\n");


			while (retryOptioinBoolean)
			{
				//Check if there is exsiting record
				if (currentIndexInteger == 0)
				{
					Console.WriteLine("ERROR : No student record exists");
					break;
				}

				//Get name for display
				nameString = EnterName();
				indexNumberInteger = CheckNameExist(studentArray, nameString, currentIndexInteger);
				try
				{
					//if there is no same data, exception handling occurs
					if (indexNumberInteger == -1)
					{
						throw new Exception();
						
					}
					//Display prompted data.
					studentArray[indexNumberInteger].DisplayStudentInformation(indexNumberInteger);
				}
				catch (Exception)
				{
					Console.WriteLine("ERROR : student record does not exists.");
				}
				finally
				{
					Console.Write("Press enter/any key to return to the main menu : ");
					if (Console.ReadLine() == "")
					{
						retryOptioinBoolean = false;
					}
					else
					{
						retryOptioinBoolean = false;
					}
				}
			}
		}

		static void Main(string[] args)
		{
			//Declare and initialize variables.
			uint numberOfStudentInteger = 0;
			int currentIndexInteger = 0;
			bool retryOptioinBoolean = true;
			string optionString = "";

			Student[] studentArray;

			//Get student number for the database
			numberOfStudentInteger = EnterNumgerOfStudent();
			studentArray = new Student[numberOfStudentInteger];
			Console.WriteLine();

			//Program performs until the user enters the "D."
			while (retryOptioinBoolean)
			{
				//Main menu displays
				Console.WriteLine("============================================================================");
				Console.WriteLine("A. Add a new student");
				Console.WriteLine("B. Edit an existing student record");
				Console.WriteLine("C. Display the name, age, and address of the student");
				Console.WriteLine("D. Exit the program");
				Console.WriteLine("============================================================================");
				Console.WriteLine();

				//Get an option
				optionString = EnterOption();

				//Choose one option
				switch (optionString)
				{
					case "A":
						//Option A : Add student
						currentIndexInteger = AddStudent(studentArray, currentIndexInteger);
						break;
					case "B":
						//Option B : Edit student
						EditStudentRecord(studentArray, currentIndexInteger);
						break;
					case "C":
						//Option C : Display student
						DisplayStudentInforamtion(studentArray, currentIndexInteger);
						break;
					case "D":
						//Option D : Exit the program
						retryOptioinBoolean = false;
						break;
					default:
						Console.WriteLine("ERROR : Please enter from A to D.");
						break;
				}
			}

			Console.WriteLine("\nThank you. Have a great day");
			Console.ReadLine();

		}
	}
}
