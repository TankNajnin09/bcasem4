using System;

namespace Array
{
	class Jaggedarr
	{
		public static void Main()
		{
			Console.Write("Enter size of array row : ");
			int row = Convert.ToInt32(Console.ReadLine());
			int [][] arr=new int[row][];
			
			Console.WriteLine("Enter value of array : \n");
			
			for(int i=0;i<arr.Length;i++)
			{
				Console.Write("\nEnter size of {0} row's column : " , i+1);
				int col = Convert.ToInt32(Console.ReadLine());
				
				arr [i] =new int[col];
				
				for(int j=0;j<arr[i].Length;j++)
				{
					Console.Write("arr[{0},{1}] : " ,i,j);
					arr[i][j] = Convert.ToInt32(Console.ReadLine());					
				}
			}
			
			Console.WriteLine("\n\nPrint value of array :");
			
			for(int i=0;i<arr.Length;i++)
			{
				for(int j=0;j<arr[i].Length;j++)
				{
					Console.WriteLine("arr[{0},{1}] : {2}" ,i,j,arr[i][j]);
				}
				Console.Write("\n");
			}
			
			Console.WriteLine("\n\nPrint value of array as a matrix : \n");
			
			for(int i=0;i<arr.Length;i++)
			{
				for(int j=0;j<arr[i].Length;j++)
				{
					//Console.WriteLine("arr[{0},{1}] : {2}" ,i,j,arr[i][j]);
					Console.Write(arr[i][j] + " ");
				}
				Console.Write("\n");
			}
			
			Console.ReadLine();
			
		}
	}
}