using System;

namespace Unbox
{
	class Unboxing
	{
		public static void Main()
		{
			/*object obj = 23;
			int i = (int)obj;  // Unboxing (explicit)*/
			
			/*int num;  //Value type is int and assigned value 23
			Console.WriteLine("Enter value of num = ");
			num = Convert.ToInt32(Console.ReadLine());
			object obj = num;  //Boxing (implicit)*/
			
			object obj;
			
			/*Console.WriteLine("Enter integer value of obj = ");			
			obj = Convert.ToInt32(Console.ReadLine());*/
			//int i = (int)obj;			
			
			/*Console.Write("\nEnter value of float obj = ");
	        obj = float.Parse(Console.ReadLine());*/
			//float i = (float)obj;			
			
			/*Console.Write("\nEnter value of double obj = ");
			obj = Convert.ToDouble(Console.ReadLine());*/
			//double i = (double)obj;
			
			/*Console.Write("\nEnter value of string obj = ");
			obj = Console.ReadLine();*/
			//string i = (string)obj;
			
			Console.Write("\nEnter value of char obj = ");
			obj = Convert.ToChar(Console.ReadLine());
			char i = (char)obj;
			
			Console.WriteLine("Value of obj = " + obj);
			Console.WriteLine("Value of i = " + i);			
			Console.ReadLine();
		}
	}
}