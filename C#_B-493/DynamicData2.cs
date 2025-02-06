using System;

namespace DynamicData
{
	class Dynamic
	{
		public static void Main()
		{
			dynamic msg = "Hello";
			Console.WriteLine("Allocated msg = " + msg);
			
			msg = Console.ReadLine();
			Console.WriteLine("User entered msg = " + msg);				
			
			Console.ReadLine();
		}
	}
}