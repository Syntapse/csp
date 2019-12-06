using System;
					
public class Program
{
	public static void Main()
	{
        Console.WriteLine("What is 10 to the power of 3");
        string re1 = Console.ReadLine();
        if(re1 == "1000" | re1 == "1,000") {
            Console.WriteLine("Good Job!");
        }else {
            Console.WriteLine("Wrong");
        }
        Console.WriteLine("What is the 2nd prime number?");
        string re2 = Console.ReadLine();
        if(re2 == "3") {
            Console.WriteLine("Correct!");
        }else {
            Console.WriteLine("Wrong");
        }
	}
}
