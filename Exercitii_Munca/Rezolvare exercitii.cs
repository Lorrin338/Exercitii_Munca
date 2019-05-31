using System;
using System.Collections.Generic;
using System.Globalization;                                                 //"HH:mm:ss tt"
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

			// Daca folosesc mm imi va afisa minutele in loc de luna curenta

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
			Console.WriteLine("Aria triunghiului este {0}", suprafata );
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
	}
}
