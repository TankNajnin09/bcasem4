using System;

namespace ObjectData
{
	class Object
	{
		public static void Main()
		{
			object a = 43;
			//a = Console.ReadLine();
			//It will accept all type of data
			Console.WriteLine("Allocated msg = " + a);
			
			//a = Convert.ToInt32(Console.ReadLine());
			//It will accept only integer type of data
			a = Console.ReadLine();
			Console.WriteLine("User entered msg = " + a);
			
			Console.WriteLine("Size of object A " + sizeof(a) + " byte");						
			
			Console.ReadLine();
		}
	}
}