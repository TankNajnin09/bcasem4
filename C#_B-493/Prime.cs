using System;

class Prime
{
	public static void Main()
	{
		int i;
		
		for(i=2;i<=100;i++)
		{
			int fact,count=0;
			
			for(fact=1;fact<=i;fact++)
			{
				if(i%fact==0)
				{
					count++;
				}
			}
			
			if(count<=2)
			{
				Console.Write("\n" + i);
			}
		}
		
		Console.ReadLine();
	}
}