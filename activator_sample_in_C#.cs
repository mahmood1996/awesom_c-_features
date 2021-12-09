using System;

public class Program
{
	public static void Main()
	{
		createInstance<SomeObject>().SomeMethod("Instance created From main");
	}
	
	public static T createInstance<T> () {
		return (T) Activator.CreateInstance(typeof(T));
	}
}

public class SomeObject {
	public void SomeMethod(String message) {
		Console.WriteLine("OK " + message);
	}
}
