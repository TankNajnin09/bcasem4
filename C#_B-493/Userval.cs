using System;
class Userval
{
	public static void Main()
	{
		int a;
        double b;
		float c;
		string d;
		char e;
		
		Console.Write("\nEnter value of int A = ");
		a = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("\nEnter value of double B = ");
	    b = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("\nEnter value of float C = ");
	    c = float.Parse(Console.ReadLine());
		
		Console.Write("\nEnter value of string D = ");
		d = Console.ReadLine();
		
		Console.Write("\nEnter value of char e = ");
	    e = Convert.ToChar(Console.ReadLine());
		
		Console.Write("\nValue of Int A ={0} " , a);
		Console.Write("\nValue of Double Float B ={0} " , b);
		Console.Write("\nValue of Float C ={0} " , c);
		Console.Write("\nValue of String D ={0} " , d);
		Console.Write("\nValue of Char E ={0} " , e);
		
		Console.Read();
	}
}