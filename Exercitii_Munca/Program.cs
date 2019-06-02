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

			//Console.WriteLine("EX 6.");
			//rezolvare_Exercitii.AnBisect();
			//Console.WriteLine();

			Console.WriteLine("EX 7.");
			rezolvare_Exercitii.Duminca();
			Console.WriteLine();

			//Console.WriteLine("EX 8.");
			//rezolvare_Exercitii.convertorTemperatura();
			//Console.WriteLine();

			Console.WriteLine("EX 9.");
			rezolvare_Exercitii.Extension_of_filename();
			Console.WriteLine();

			Console.WriteLine("EX 10.");
			rezolvare_Exercitii.Diferenta(10);
			rezolvare_Exercitii.Diferenta(20);
			Console.WriteLine();

			Console.WriteLine("EX 11.");
			rezolvare_Exercitii.Suma(25, 18);
			rezolvare_Exercitii.Suma(25, 125);
			rezolvare_Exercitii.Suma(42, 42);
			rezolvare_Exercitii.Suma(1001, 21321);
			rezolvare_Exercitii.Suma(233432, 32323);
			Console.WriteLine();

			Console.WriteLine("EX 12.");
			rezolvare_Exercitii.Verificare(1);
			rezolvare_Exercitii.Verificare(20);
			rezolvare_Exercitii.Verificare(50);
			rezolvare_Exercitii.Verificare(100);
			rezolvare_Exercitii.Verificare(400);
			rezolvare_Exercitii.Verificare(341);
			rezolvare_Exercitii.Verificare(500);
			Console.WriteLine();

			Console.WriteLine("EX 13.");
			rezolvare_Exercitii.Pozitivitate(-25, 18);
			rezolvare_Exercitii.Pozitivitate(25, -32);
			rezolvare_Exercitii.Pozitivitate(42, 32);
			rezolvare_Exercitii.Pozitivitate(-42, -23);
			Console.WriteLine();

			Console.WriteLine("EX 14.");
			rezolvare_Exercitii.Pycaractere("Python");
			rezolvare_Exercitii.Pycaractere("Incinta");
			rezolvare_Exercitii.Pycaractere("asdadasPythonsadasdsa");
			Console.WriteLine();

			Console.WriteLine("Ex 15.");
			rezolvare_Exercitii.StergeCaracterul("removeoneofus");
			Console.WriteLine();

			Console.WriteLine("Ex 16.");
			rezolvare_Exercitii.AdaugaCapte("liverpool");
			Console.WriteLine();

			Console.WriteLine("Ex 17.");
			rezolvare_Exercitii.Multiplu_treisapte(211);
			Console.WriteLine();

			Console.WriteLine("Ex 18.");
			rezolvare_Exercitii.Javaverificare("Javasadasdsad");
			rezolvare_Exercitii.Javaverificare("abcJavadef");
			Console.WriteLine();

			Console.WriteLine("Ex 19.");
			Console.WriteLine(rezolvare_Exercitii.Script("Javascriptttt"));
			Console.WriteLine(rezolvare_Exercitii.Script("Javaascriptttt"));
			Console.WriteLine(rezolvare_Exercitii.Script("asds"));
			Console.WriteLine();

			Console.WriteLine("Ex 20.");
			Console.WriteLine(rezolvare_Exercitii.Caracteremici("as"));
			Console.WriteLine(rezolvare_Exercitii.Caracteremici("ABCliverpool"));
			Console.WriteLine();






			Console.Read();
		}

		

	}
}
