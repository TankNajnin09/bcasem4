class Convert
{
	public static void main(String[] args)
	{
		//char to string converted
		 // Define a char array  
        char[] charArray = {'H', 'e', 'l', 'l', 'o'};  
        // Convert char array to String using String.copyValueOf()  
        String myString = String.copyValueOf(charArray);         
        // Display the converted String  
        System.out.println("Converted from Char to String is: " + myString);  
		
		//string to char converted
		// Declare and initialize a String
        String s = "Hello";
        
        // Extract the first character from the String using charAt() method
        char c = s.charAt(0); // Get the character at index 0

        System.out.println("Character at index 0: " + c);

	}
}
