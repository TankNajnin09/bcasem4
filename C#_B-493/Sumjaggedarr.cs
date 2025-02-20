using System;

namespace Array
{
	class Sumjaggedarr
	{
		public static void Main()
		{
			Console.Write("Enter size of array row : ");
			int row = Convert.ToInt32(Console.ReadLine());
			int [][] arr=new int[row][];
			
			for(int i=0;i<arr.Length;i++)
			{
				Console.Write("Enter size of {0} row's column : " , i);
				int col = Convert.ToInt32(Console.ReadLine());
				arr [i] =new int[col];
			}
			
			Console.WriteLine("\n\nEnter value of array : ");
			
			for(int i=0;i<arr.Length;i++)
			{
				
				//arr [i] =new int[col];
				
				for(int j=0;j<arr[i].Length;j++)
				{
					Console.Write("arr[{0},{1}] : " ,i,j);
					arr[i][j] = Convert.ToInt32(Console.ReadLine());					
				}
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
			
			for(int i=0;i<arr.Length;i++)
			{
				int Sum=0;
				for(int j=0;j<arr[i].Length;j++)
				{
					Sum = Sum+arr[i][j];
				}
				Console.Write("\n\nSum of {0} row = {1}\n" , i , Sum);
			}
			
			Console.ReadLine();
			
		}
	}
}