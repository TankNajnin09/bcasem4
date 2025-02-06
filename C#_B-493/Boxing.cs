using System;

namespace Box
{
	class Boxing
	{
		public static void Main()
		{
			int num;  //Value type is int and assigned value 23
			Console.WriteLine("Enter value of num = ");
			num = Convert.ToInt32(Console.ReadLine());
			object obj = num;  //Boxing (implicit)
			Console.WriteLine("Value of num = " + num);
			Console.WriteLine("Value of obj = " + obj);
			Console.ReadLine();
		}
	}
}