import java.util.Scanner; 

class Singlearr
{
	public static void main(String[] args)
	{
		
		Scanner object = new Scanner(System.in);
		
		System.out.print("\nEnter size of row : ");
		int row = object.nextInt();	
		
		int [] arr = new int[row];	
		
		System.out.println("\nEnter value of array : ");
			
		for(int i=0;i<arr.length;i++)
		{
			System.out.print("arr " + i + " : ");
			arr[i] = object.nextInt();
		}
		
		System.out.println("\n\nPrint value of array : ");
		
		for(int i=0;i<arr.length;i++)
		{
			System.out.println("arr " + i + " : " + arr[i]);
		}
		
	}
}