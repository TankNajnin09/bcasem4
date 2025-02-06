using System;

namespace DynamicData
{
	class Dynamic
	{
		public static void Main()
		{
			dynamic a;
			a = Console.ReadLine();
			//It will accept all type of data
			Console.WriteLine(a);
			
			a = Convert.ToInt32(Console.ReadLine());
			//It will accept only integer type of data
			
			Console.WriteLine(a);
			
			//Console.WriteLine("Size of dynamic A " + sizeof(a) + " byte");
			
			Console.ReadLine();
		}
	}
}