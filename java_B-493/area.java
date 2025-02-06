class area
{
	public static void main(String[] args)
	{
		int l = 10;
		int w = 5;
		int r = 4;
		float pi = 3.14f;
		
		square square = new square(); 
		square.squa(l);
		
		rectangle rectangle = new rectangle();
		rectangle.recta(l,w);
		
		circle circle = new circle();
		circle.circ(r,pi);
	}
}

class rectangle
{
	public static void recta(int l,int w)
	{
		System.out.println("Area of rectangle = " + l*w);
	}
} 

class square
{
	public static void squa(int l)
	{
		System.out.println("Area of square = " + l*l);
	}
}

class circle
{
	public static void circ(int r,float pi)
	{
		System.out.println("Area of circle= " + pi*r*r);		
	}
}