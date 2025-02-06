using System;
class Userasend
{
	public static void Main()
	{
		int i;
		int a;
		Console.Write("\nEnter value of int A = ");
		a = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Acending Number : ");
		for(i=1;i<=a;i++)
		{
			Console.WriteLine(i);
		}
		
		Console.Read();
	}
}