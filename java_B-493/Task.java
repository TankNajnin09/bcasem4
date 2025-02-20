import java.util.Scanner; 

class Task
{
	public static void main(String[] args)
	{
		int countcol=0;
		int countrow=0;
		int countblock=0;
		
		Scanner object = new Scanner(System.in);
		
		System.out.print("\nEnter size of block : ");
		int block = object.nextInt();	
		
		System.out.print("\nEnter size of row : ");
		int row = object.nextInt();	

		System.out.print("\nEnter size of column : ");
		int col = object.nextInt();	
		
		int arr [][][] = new int[block][row][col];
		
		
		System.out.println("\nEnter value of array : ");
		
		for(int i=0;i<arr.length;i++)
		{
			for(int j=0;j<arr[i].length;j++)
			{
				for(int k=0;k<arr[i][j].length;k++)
				{
					System.out.print("arr [" + i + "][" + j + "][" + k + "]: ");
					arr[i][j][k] = object.nextInt();
				}
			}
		}
		
		System.out.println("\n\nPrint value of array : ");
		
		for(int i=0;i<arr.length;i++)
		{
			countblock++;
			System.out.print("{");
			for(int j=0;j<arr[i].length;j++)
			{
				countrow++;
				System.out.print(" {");
				for(int k=0;k<arr[i][j].length;k++)
				{
					countcol++;
					System.out.print(arr[i][j][k]);
					if(countcol<arr[i][j].length)
					{
						System.out.print(" , ");
					}
				}
				System.out.print("} ");
				if(countrow<arr[i].length)
				{
					System.out.print(" , ");
				}
			}
			if(countblock<arr[i][j].length)
			{
				System.out.print(" , ");
			}
			System.out.print("} ");
		}
		
	}
}
