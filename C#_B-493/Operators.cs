using System;

namspace Operator
{
	class Operators
	{
		static void Main()
    {
       
		// Using different arithmetic operators
	    int x = 8, y = 4;

        Console.WriteLine("Addition: " + (x + y));
        Console.WriteLine("Subtraction: " + (x - y));
        Console.WriteLine("Multiplication: " + (x * y));
        Console.WriteLine("Division: " + (x / y));
        Console.WriteLine("Modulo: " + (x % y));

        // Compare using different
          // relational operators
		int x = 10, y = 20;
		  
        Console.WriteLine(x == y);
        Console.WriteLine(x != y);
        Console.WriteLine(x > y);
        Console.WriteLine(x < y);
        Console.WriteLine(x >= y);
        Console.WriteLine(x <= y);
    }
	}
}