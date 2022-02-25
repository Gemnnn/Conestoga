using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5Group23P1
{
	class Student
	{
		private string _Name;
		private uint _Age;
		private string _Address;

		//Default constructor
		public Student()
		{
			this._Name = "";
			this._Age = 0;
			this._Address = "";
		}

		public Student(string name, uint age, string address)
		{
			this._Name = name;
			this._Age = age;
			this._Address = address;
		}

		//to send a name from class.
		public string GetStudentName()
		{
			return _Name;
		}

		//Display student information
		public void DisplayStudentInformation(int index)
		{
			Console.WriteLine("----------------------------------------------------------------------------");
			Console.WriteLine("Display student record");
			Console.WriteLine(index + ". Name : "+_Name+ ", Age : " +_Age + ", Address : " + _Address);
			Console.WriteLine("----------------------------------------------------------------------------");
		}

		//Set name, age and address to modify
		public void EditStudentInformation(string name, uint age, string address)
		{
			this._Name = name;
			this._Age = age;
			this._Address = address;
		}
	}
}
