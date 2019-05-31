using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii_Munca
{
	class Program
	{
		

		static void Main(string[] args)
		{
			Rezolvare_exercitii rezolvare_Exercitii = new Rezolvare_exercitii();
			Console.WriteLine("EX 1.");
			rezolvare_Exercitii.Current_Date();
			Console.WriteLine();

			//Console.WriteLine("EX 2.");
			//rezolvare_Exercitii.Print_Preview();

			Console.WriteLine("EX 3.");
			rezolvare_Exercitii.DateFormats();
			Console.WriteLine();

			Console.WriteLine("EX 4.");
			rezolvare_Exercitii.ArieTriunghi();
			Console.WriteLine();

			Console.WriteLine("EX 5.");
			rezolvare_Exercitii.Oglindit();
			Console.WriteLine();






			Console.Read();
		}

		

	}
}
