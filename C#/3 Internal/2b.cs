//Author : SkyKOG

using System;

public class Program
{
    public static void Main(string[] args)
    {
        ComplexNumber c = new ComplexNumber(5, -6);
        Console.WriteLine("Conversion to string: {0}", Convert.ToString(c));
        Console.WriteLine("Conversion to double: {0}", Convert.ToDouble(c));
    }
}

public struct ComplexNumber : IConvertible
{
    private double real;
    private double imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public double ToDouble(IFormatProvider provider)
    {
        return this.real;
    }

    public string ToString(IFormatProvider provider)
    {
        return this.real.ToString() + "," this.imaginary.ToString() + "i";
    }

    public allOtherFormats ToallOtherFormats(IFormatProvider provider)
    {
        throw new InvalidCastException();
    }
}

