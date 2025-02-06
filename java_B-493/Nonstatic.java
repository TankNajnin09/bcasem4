class Nonstatic
{
	void check()
	{
		System.out.println("Non Static...");		
	}
	public static void main(String [] args)
	{
		Nonstatic nonsta = new Nonstatic();
		System.out.println("My java file...");
		nonsta.check();
		//check();
	}
}