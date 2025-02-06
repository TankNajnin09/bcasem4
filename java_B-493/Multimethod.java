class Multimethod
{
	static void check()
	{
		System.out.println("Static...");
	}
	void checktwo()
	{
		System.out.println("Nonstatic...");
	}
	public static void main(String [] args)
	{
		Multimethod nonsta = new Multimethod();
		nonsta.check();
		nonsta.checktwo();
		System.out.println("My java file...");
	}
}