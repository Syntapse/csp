using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("What is your favorite food?");
		string food = Console.ReadLine();
		int dwStartTime = System.Environment.TickCount;

                while (true)

                {

                    if (System.Environment.TickCount - dwStartTime > 2000) break;

                }
		Console.WriteLine("I like " + food + " too!");
	}
}