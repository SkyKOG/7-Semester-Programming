/*
Author : SkyKOG
Assuming this is a calculator program ... 
Only the Exception parts of code is shown ...
*/

using System;

class Exercise
{
	public static void Main()
	{
		int Number1, Number2;
		char Operator;

		try 
		{
			Console.Write("First Number:  ");
			Number1 = int.Parse(Console.ReadLine());

			Console.Write("An Operator (+, -, * or /): ");
			Operator = char.Parse(Console.ReadLine());
			if( Operator != '+' && Operator != '-' &&
				Operator != '*' && Operator != '/' )
				throw new Exception("Invalid Operator");

			Console.Write("Second Number: ");
			Number2 = int.Parse(Console.ReadLine());

			if( Operator == '/' && Number2 == 0)
				throw new DivideByZeroException("Division by zero is not allowed");
		}
		catch(FormatException)
		{
			Console.WriteLine("The number you typed is not valid");
		}
		catch(DivideByZeroException ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}