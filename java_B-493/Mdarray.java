import java.util.Scanner; 

class Mdarray
{
	public static void main(String[] args)
	{
		
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
			for(int j=0;j<arr[i].length;j++)
			{
				for(int k=0;k<arr[i][j].length;k++)
				{
					System.out.println("arr [" + i + "][" + j + "][" + k + "] : " + arr[i][j][k]);
				}
			}
		}
		
	}
}
