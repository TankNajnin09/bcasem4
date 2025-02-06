import java.util.Scanner; //in php import in C# using

class Userval
{
	public static void main(String[] args)
	{
		
		Scanner object = new Scanner(System.in);
		System.out.print("Enter Name : ");
		String username = object.nextLine();	
		
		System.out.print("Enter Gender : ");		
		char gender = object.next().charAt(0);
		//char gender = object.next();

		System.out.print("Enter Age : ");
		int age = object.nextInt();
		
		System.out.print("Enter Mobile number : ");
		long mobileno = object.nextLong();
		
		System.out.print("Enter Percentage : ");
		//double per = object.nextDouble();
		float per = object.nextFloat();
		
		System.out.println("\n\nMy Name = " + username);
		System.out.println("Gender = " + gender);	
		System.out.println("Age = " + age);	
		System.out.println("Mobile number = " + mobileno);
		System.out.println("PErcentage = " + per);
		
	}
}