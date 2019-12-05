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
		if(food == "Chipotle") {
			Console.WriteLine("OMG I LOVEEE CHIPOTLEE!");
		}
		Console.WriteLine("I like " + food + " too!");
		Console.WriteLine("What is your favorite game?");
		string game = Console.ReadLine();
		if(game == "Roblox") {
			Console.WriteLine("Roblox is a great game!");
		}
		Console.WriteLine("I like " + game + ". It is a good game!");
	}
}
