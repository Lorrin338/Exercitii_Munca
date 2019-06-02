using System;
using System.Collections.Generic;
using System.Globalization;                                                 //"HH:mm:ss tt"
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercitii_Munca
{
	class Rezolvare_exercitii
	{

		//// 1. Write a   function to display the current day and time in the following format.
		//      ◦ Sample Output : 
		//                  ◦ Today is : Tuesday.
		//                  ◦ Current time is : 10 PM : 30 : 38
		public void Current_Date()
		{
			Console.WriteLine("Today is : " + DateTime.Now.DayOfWeek);
			Console.WriteLine("Current time is : " + String.Format("{0:T}", DateTime.Now));
		}


		// 2. Write a function to print the contents of the current window

		public void Print_Preview()
		{
			//PrintPreviewControl printPreview = new PrintPreviewControl();
			//printPreview.Show();
		}


		//3. Write a   function to get the current date
		//◦ Expected Output : mm-dd-yyyy, mm/dd/yyyy, dd-mm-yyyy, dd/mm/yyyy

		public void DateFormats()
		{
			Console.WriteLine(DateTime.Now.ToString("MM-dd-yyyy"));
			Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
			Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy"));
			Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));

			// Daca folosesc "mm" imi va afisa minutele in loc de luna curenta

		}

		// 4. Write a   function to find the area of a triangle where lengths of the three of its sides are 5, 6, 7.
		// √s x (s-a) x (s-b) x (s-c)

		public void ArieTriunghi()
		{
			int a = 5;
			int b = 6;
			int c = 7;
			int semipermitru = (a + b + c) / 2;

			double suprafata = Math.Sqrt(semipermitru * (semipermitru - a) * (semipermitru - b) * (semipermitru - c));
			Console.WriteLine("Aria triunghiului este {0}", suprafata);
		}

		// 5. Write a function to rotate the string 'w3resource' in right direction by periodically removing one letter from the end of the string and attaching it to the front

		public void Oglindit()
		{
			string neoglindit = "w3resource";
			string oglindit = String.Empty;

			for (int i = neoglindit.Length - 1; i >= 0; i--)
			{
				oglindit = oglindit + neoglindit[i];
			}
			Console.WriteLine(oglindit);
		}

		// 6. Write a function to determine whether a given year is a leap year in the Gregorian calendar

		public void AnBisect()
		{
			int An;
			Console.Write("Introduceti anul : ");
			An = Convert.ToInt32(Console.ReadLine());
			if ((An % 4 == 0 && An % 100 != 0) || (An % 400 == 0))
			{
				Console.WriteLine(An + " este an bisect ");
			}
			else
			{
				Console.WriteLine(An + " nu este an bisect");
			}
			Console.ReadLine();
		}

		internal void JavaVerificare(string v)
		{
			throw new NotImplementedException();
		}

		// 7. Write a  function to find 1st January is being a Sunday between 2014 and 2050

		public void Duminca()
		{
			for (int i = 2014; i <= 2050; i++)
			{
				DateTime datacautata = new DateTime(i, 1, 1);
				if (datacautata.DayOfWeek == DayOfWeek.Sunday)
				{
					Console.WriteLine(datacautata.ToShortDateString());
				}
			}
		}


		// 8.Write a function to convert temperatures to and from Celsius, Fahrenheit.
		//◦ Expected Output : 
		//    1. 60°C is 140 °F
		//    2. 45°F is 7.222222222222222°C

		public void convertorTemperatura()
		{
			double f, c;
			Console.WriteLine("Introduceti temperatura in grade Celsius:");
			c = Convert.ToDouble(Console.ReadLine());
			f = c * 9 / 5 + 32;
			Console.WriteLine(c + "°C in Fahrenheit este: " + f + "°F");
			Console.WriteLine("Introduceti temperatura in grade Fahrenheit:");
			f = Convert.ToDouble(Console.ReadLine());
			c = (f - 32) * 5 / 9;
			Console.WriteLine(f + "°F in Celsius is: " + c + "°C");
			Console.ReadLine();
		}

		// 9. Write a exercise to get the extension of a filename. (5 inputs)

		public void Extension_of_filename()
		{
			string fileName = @"C:\Users\Lorin\Desktop\Documentatie Lorin Vacarasu.pdf";
			FileInfo fisier = new FileInfo(fileName);
			Console.WriteLine("File Extension: {0}", fisier.Extension);


		}

		// 10. Write a function to get the difference between a given number and 13, if the number is greater than 13 return double the absolute difference. ( example with 5 inputs)

		public void Diferenta(int n)
		{
			if (n <= 13)
			{
				Console.WriteLine(13 - n);
			}
			else
			{
				Console.WriteLine((13 - n) * 2);
			}

		}

		// 11. Write a function to compute the sum of the two given integers. If the two values are same, then returns triple their sum. (5 inputs)

		public void Suma(int a, int b)
		{
			if (a > b || a < b)
			{
				Console.WriteLine(a + b);
			}
			else if (a == b)
			{
				Console.WriteLine(3 * (a + b));

			}
		}

		// 12. Write a function to check a given integer is within 20 of 100 or 400. (5 inputs)

		public void Verificare(int n)
		{
			if ((n > 20 && n < 100) || (n > 20 && n < 400))
			{
				Console.WriteLine(n + " se afla intre intervalul specificat");
			}
			else
			{
				Console.WriteLine(n + " nu se afla in intervalul specificat");
			}
		}

		// 13. Write a   function to check from two given integers, if one is positive and one is negative.

		public void Pozitivitate(int a, int b)
		{

			if (a < 0 && b > 0)
			{
				Console.WriteLine(a + " este numar negativ" + " si " + b + " este numar pozitiv");
			}
			else if (a > 0 && b < 0)
			{
				Console.WriteLine(b + " este numar negativ" + " si " + a + " este numar pozitiv");
			}
			else if (a > 0 && b > 0)
			{
				Console.WriteLine("Ambele numere sunt pozitive");
			}
			else if (a < 0 && b < 0)
			{
				Console.WriteLine("Ambele numere sunt negative");
			}


		}

		// 14.Write a function to create a new string adding "Py" in front of a given string. If the given string begins with "Py" then return the original string. (3 inputs/runs)

		public void Pycaractere(string s)
		{
			string ss = s.Substring(0, 2);

			if (ss == "Py")
			{
				Console.WriteLine(s);
			}
			else
			{
				Console.WriteLine("Py" + s);
			}
		}

		// 15. Write a function to remove a character at the specified position of a given string and return the new string.

		public void StergeCaracterul(string s)
		{
			Console.WriteLine(s.Remove(5, 1));

		}

		// 16. Write a function to create a new string from a given string with the first character of the given string added at the front and back.

		public void AdaugaCapte(string s)
		{
			string primul = s.Substring(0, 1);
			Console.WriteLine(primul + s + primul);
		}

		// 17. Write a function check if a given positive number is a multiple of 3 or a multiple of 7.

		public void Multiplu_treisapte(int a)
		{
			Console.WriteLine(a % 3 == 0 || a % 7 == 0 ? true : false);
		}

		// 18. Write a   function to check if a string starts with 'Java' and false otherwise.

		public void Javaverificare(string s)
		{
			if (s.Length < 4)
			{
				Console.WriteLine(false); ;
			}

			string ss = s.Substring(0, 4);

			if (ss == "Java")
			{
				Console.WriteLine(true);
			}
			else
			{
				Console.WriteLine(false);
			}
		}

		// 19. Write a function to check if a string "Script" presents at 5th (index 4) position in a given string, if "Script" presents in the string return the string without "Script" otherwise return the original one

		public string Script (string s)
		{	
			if (s.Length < 6)
			{
				return s;
			}

			else if (s.Substring(4,6).Equals("script"))
			{
				return s.Replace("script", "");
			}
			else
			{
				return s;
			}
		}

		// 20. Write a function to create new string with first 3 characters are in lower case. If the string length is less than 3 convert all the characters in upper case

		public string Caracteremici(string s)
		{
			if (s.Length < 3)
			{
				return s.ToUpper();
			}

			string ss = s.Substring(0, 3);

			return ss.ToLower() + s.Substring(3,s.Length -3);

		
		} 


	}
}
