using System;

abstract class Person
{
	abstract public void fun();
}

sealed class Child : Person
{
	sealed override public void fun()
	{
		Console.WriteLine("XYZ...");
	}
}


class Seal_cls
{
	public static void Main()
	{
		Child  c = new Child();
		c.fun();
		//c.xyz();
	}
}