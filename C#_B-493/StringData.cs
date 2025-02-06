using System;

namespace StringData
{
	class StringData
	{
		public static void Main()
		{
			string a;
			string b;
			
			Console.WriteLine("Enter value of A = ");
			a = Console.ReadLine();
			
			Console.WriteLine("Enter value of B = ");
			b = Console.ReadLine();
			
			Console.WriteLine("Value of A = " + a);
			Console.WriteLine("Value of B = " + b);
			
			Console.WriteLine("Size of string A " + sizeof(a) + " byte");
			Console.WriteLine("Size of string B " + sizeof(b) + " byte");

		}
	}
}