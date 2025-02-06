using System;

class Swap
{
	public static void Main()
	{
			int a;
			int b;
			
			Console.Write("\nEnter value of A");
			a = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("\nEnter value of B");
			b = Convert.ToInt32(Console.ReadLine());
			
			a = a+b;
			b = a-b;
			a = a-b;
			
			Console.Write("\nAfter Swap : ");
			Console.Write("\nValue of A = " + a);
			Console.Write("\nValue of B = " + b);
	}
}