public class Literalsdemo
{
	public static void main(String[] args)
	{
		//Integer Literals
		int decimalliteral = 100; //Decimal
		int binaryliteral = 0b0010; //Binary (prefix 0b)
		int octalliteral = 0144; //octal (prefix 0)
		int hexaliteral = 0x64; //hexadecimal (prefix 0x)
		
		//Floating-point Literals
		float floatliteral = 2.718f;
		
		//Character Literals
		char charliteral = 'A';
		
		//String Literals
		String stringliteral = "Hello,world!";

		//Boolean Literals
		boolean trueliteral = true;
		boolean falseliteral = false;
		
		//Null Literals (for objects)
		String nullliteral = null;
		
		System.out.println("Decimal = " + decimalliteral);
		System.out.println("Binary = " + binaryliteral);
		System.out.println("octal = " + octalliteral);
		System.out.println("hexadecimal = " + hexaliteral);
		System.out.println("float = " + floatliteral);
		System.out.println("char = " + charliteral);
		System.out.println("String = " + stringliteral);
		System.out.println("boolean true = " + trueliteral);
		System.out.println("boolean false = " + falseliteral);
		System.out.println("null = " + nullliteral);

	}
}