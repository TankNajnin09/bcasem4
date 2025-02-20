import java.util.Scanner; 

class Multiarr
{
	public static void main(String[] args)
	{
		
		Scanner object = new Scanner(System.in);
		
		System.out.print("\nEnter size of row : ");
		int row = object.nextInt();	

		System.out.print("\nEnter size of column : ");
		int col = object.nextInt();	
		
		int [][] arr = new int[row][col];
		
		//int [][] arr = new int[2][2];	
		
		/*arr[0][0] = 1;
		arr[0][1] = 2;
		arr[1][0] = 3;
		arr[1][1] = 4;*/
		
		System.out.println("\nEnter value of array : ");
			
		for(int i=0;i<arr.length;i++)
		{
			for(int j=0;j<arr[i].length;j++)
			{
				System.out.print("arr [" + i + "][" + j + "]: ");
				arr[i][j] = object.nextInt();
			}
		}
		
		System.out.println("\n\nPrint value of array : ");
		
		for(int i=0;i<arr.length;i++)
		{
			for(int j=0;j<arr[i].length;j++)
			{
				System.out.println("arr [" + i + "][" + j + "] : " + arr[i][j]);
			}
		}
		
	}
}