using System;
namespace Demo
{
	class Datatypesize
	{
		public static void Main()
		{
			Console.WriteLine("Character Size " + sizeof(char) + " byte");
			Console.WriteLine("Integer Size " + sizeof(int) + " byte");
			Console.WriteLine("Short Size " + sizeof(short) + " byte");
			Console.WriteLine("Long Size " + sizeof(long) + " byte");
			Console.WriteLine("Float Size " + sizeof(float) + " byte");
			Console.WriteLine("Double Size " + sizeof(double) + " byte");
			Console.WriteLine("Decimal Size " + sizeof(decimal) + " byte");
		//	Console.WriteLine("Decimal Size " + sizeof(dynamic) + " byte");
		//	Console.WriteLine("Decimal Size " + sizeof(string) + " byte");
			
			Console.ReadLine();
			
		}
	}
}