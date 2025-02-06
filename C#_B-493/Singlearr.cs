using System;

namespace Array
{
	class singlearr
	{
		public static void Main()
		{
			Console.WriteLine("Enter size of array : ");
			int size = Convert.ToInt32(Console.ReadLine());
			//int [] arr = new int[5] {10,20,30,40,50};
			int [] arr = new int[size];
			//int [] arr = {12,34,56,78,90};
			
			Console.WriteLine("Enter value of array : ");
			
			for(int i=0;i<arr.Length;i++)
			{
				Console.WriteLine("arr[{0}] : " ,i );
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			
			Console.WriteLine("Print value of array : ");
			
			for(int i=0;i<arr.Length;i++)
			{
				Console.WriteLine("arr[{0}] : {1}" ,i,arr[i]);
				//int arr[i] = Convert.ToInt32(ReadLine());
			}
			Console.ReadLine();
			
		}
	}
}