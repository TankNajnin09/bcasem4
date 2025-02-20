using System;

namespace Array
{
	class Multiarr
	{
		public static void Main()
		{
			Console.Write("Enter size of row : ");
			int row = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter size of column : ");
			int col = Convert.ToInt32(Console.ReadLine());
			int [,] arr = new int[row,col];
			
			//Console.WriteLine(arr.GetLength(1));
			Console.WriteLine("\n\nEnter value of array : ");
			
			for(int i=0;i<arr.GetLength(0);i++)
			{
				for(int j=0;j<arr.GetLength(1);j++)
				{
					Console.Write("arr[{0},{1}] : " ,i,j);
					arr[i,j] = Convert.ToInt32(Console.ReadLine());		
				}
			}
			
			Console.WriteLine("\n\nPrint value of array : ");
			
			for(int i=0;i<arr.GetLength(0);i++)
			{
				for(int j=0;j<arr.GetLength(1);j++)
				{
					//Console.WriteLine("arr[{0},{1}] : {2}" ,i,j,arr[i,j]);
					Console.Write(arr[i,j] + "\t" );
				}
				Console.Write("\n");
			}
			Console.ReadLine();
			
		}
	}
}