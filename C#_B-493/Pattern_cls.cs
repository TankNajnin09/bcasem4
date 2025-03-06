using System;

class Pattern_cls
{
	public static void Main()
	{
		//Enter number of star
		double num = 5;
		/*Console.Write("\nEnter number of star in parameter = ");
		num = Convert.ToInt32(Console.ReadLine());
		*/
		//Check number is greater than 4 or not
		if(num>4)
		{
			//check number is even or odd
			if(num%2==0)
			{
				Console.WriteLine("You enter {0} is not valid... \nWe converted in {1}..." , num,num-1);
				num--;		
			}
			Console.WriteLine("Num = {0}" , num);
		
			//find mid number of total star number
			double midnum = (num/2)+0.5;
			Console.WriteLine("Middle number is = {0}" , midnum);		
			
			//For print swastik
			for(int i=1;i<=num;i++)
			{
				for(int j=1;j<=num;j++)
				{ 
					if( ((i==midnum) || (j==midnum)) || 
						((i==1&&j>=3) || (i==1&&j==1)) || 
						((i==2&&j==1) || (i==2&&j==3)) || 
						((i==4&&j==3) || (i==4&&j==5)) || 
						((i==5&&j<=3) || (i==5&&j==5)))
					{
						Console.Write("* ");
					}
					else
						Console.Write("  ");
				}
				Console.WriteLine();
			}

		}
		//if number is Less than or equal to 4
		else
		{
			Console.WriteLine("Your entered number is not valid...");
		}
		
		Console.ReadLine();
	}
}