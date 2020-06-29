// First Programming Assignment
// by Gabriella Di Gregorio DIG15624188

using System;

class assignment1
{
	static void Main(string[] args)
	{
		Console.WriteLine("\nPlease assign values to a, b, c and d...");
		
		double a;
		Console.Write("a: ");
		a = Double.Parse(Console.ReadLine());
		
		double b;
		Console.Write("b: ");
		b = Double.Parse(Console.ReadLine());
		
		double c;
		Console.Write("c: ");
		c = Double.Parse(Console.ReadLine());
		
		double d;
		Console.Write("d: ");
		d = Double.Parse(Console.ReadLine());
		
		// Creating an array
		double[] numbers = new double[4]; 
		numbers[0] = a;
		numbers[1] = b;
		numbers[2] = c;
		numbers[3] = d;
		
		// Sorting the array
		Array.Sort(numbers);		
		Console.Write("\nYour chosen numbers from smallest to largest are: ");
		foreach(double number in numbers)
		{
			Console.Write(number + ", ");
		}
		
		Console.WriteLine("\nThe minimum value is: {0}", numbers[0]);
		
		// Calculating the median
		double median; 
		median = (numbers[1] + numbers[2]) / 2;		
		Console.WriteLine("The median is: {0}", median);
		
		// Calculating the mean
		double mean; 
		mean = (a + b + c + d) / 4;		
		Console.WriteLine("The mean is: {0}", mean);
		
		Console.ReadLine();
		
	}
}

		