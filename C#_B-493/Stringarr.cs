using System;

namespace Array
{
	class Stringarr
	{
		public static void Main()
		{
			Console.Write("Enter size of string array : ");
			int size = Convert.ToInt32(Console.ReadLine());
			
			string [] arr = new string[size];
			
			Console.WriteLine("\n\nEnter value of string array : \n");
			
			for(int i=0;i<arr.Length;i++)
			{
				Console.Write("Enter {0} string = " , i);
				arr[i] = Console.ReadLine();
			}
			
			Console.Write("\n\nPrint string : \n");
			
			foreach(string n in arr)
			{
				Console.WriteLine(n);
			}
			
			Console.ReadLine();
			
		}
	}
}