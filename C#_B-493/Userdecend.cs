using System;
class Userdecend
{
	public static void Main()
	{
		int a;
		Console.Write("\nEnter value of int A = ");
		a = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Decending Number : ");
		while(a>=0)
		{
			Console.WriteLine(a);
			a--;
		}
		
		Console.Read();
	}
}