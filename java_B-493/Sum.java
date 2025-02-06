class Sum
{
	public static void main(String[] args)
	{
		//Binary 
		int bin1 = 0b0000; //Binary prefix(0b)
		int bin2 = 0b1111; //Binary prefix(0b)
		Binary.binsum(bin1,bin2);
		
		//Octal
		int oct1 = 07; //Octal prefix(0)
		int oct2 = 05; //Octal prefix(0)
		Octal.octsum(oct1,oct2);
		
		//Decimal
		int dec1 = 10; //Decimal
		int dec2 = 9;  //Decimal
		Decimal.decsum(dec1,dec2);
		
		//Hexadecimal
		int hexa1 = 0xa; //Hexadecimal (prefix 0x)
		int hexa2 = 0xb; //Hexadecimal (prefix 0x)
		Hexadecimal.hexasum(hexa1,hexa2);
		
	}
}

class Binary
{
	public static void binsum(int bin1,int bin2)
	{ 
	
		System.out.println("First binary = " + bin1);
		System.out.println("Second binary = " + bin2);
		System.out.println("Sum of binary = " + (bin1+bin2));
	}
}

class Octal
{
	public static void octsum(int oct1,int oct2)
	{
		System.out.println("First octal = " + oct1);
		System.out.println("second octal = " + oct2);
		System.out.println("Sum of octal = " + (oct1+oct2));
	}
}

class Decimal
{
	public static void decsum(int dec1,int dec2)
	{
		System.out.println("First decimal = " + dec1);
		System.out.println("second decimal = " + dec2);
		System.out.println("Sum of decimal = " + (dec1+dec2));
	}
}

class Hexadecimal
{
	public static void hexasum(int hexa1,int hexa2)
	{
		System.out.println("First hexadecimal = " + hexa1);
		System.out.println("second hexadecimal = " + hexa2);
		System.out.println("Sum of hexadecimal = " + (hexa1+hexa2));
	}
}