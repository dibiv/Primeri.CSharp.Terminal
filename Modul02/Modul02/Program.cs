using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string Program_name = "Modul02 - Примери";
			string Program_version = "1.0";

			//Събиране на числа
			a = 10;
			b = 5;

			sum = a + b;

			//За програмата
			Console.WriteLine ( Program_name );
			Console.WriteLine ( "Версия: " + Program_version + "\n\n" );


			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write ( b );
			Console.Write ( " = " );
			Console.WriteLine ( sum ); 

			//Допълнителни оператори
			Console.WriteLine ("\nИзползване на += ");
			a += b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на -= ");
			a -= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на *= ");
			a *= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на ++ ");
			a++;
			Console.WriteLine ( a );

			Console.WriteLine ("Стандартно делене: " +  (7 / 4).ToString ()); // -> 2
			Console.WriteLine ("Остатък от делене: " +  (7 % 4).ToString ()); // -> 1



		}
	}
}
