class Convloop
{
	public static void main(String[] args)
	{
		//string to char converted
		// Declare and initialize a String
        String s = "Hello";
		int len = s.length();
        //System.out.println(len);		
		
        
        // Extract the first character from the String using charAt() method
        //char c = s.charAt(0); // Get the character at index 0

        //System.out.println("Character at index 0: " + c);
		
		for(int i=0;i<len;i++)
		{
			char c = s.charAt(i);
			System.out.println("Character at index: " + c);
			
		}
		
	}
}