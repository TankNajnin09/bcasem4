using System;

namespace array
{
	class Jagged
	{
		public static void Main()
		{
			int [][] arr= new int [3][];
			arr[0] = new int[2];
			arr[1] = new int[3];
			arr[2] = new int[1];
			
			Console.WriteLine(arr[2].Length);
			
			Console.ReadLine();
		}
	}
}