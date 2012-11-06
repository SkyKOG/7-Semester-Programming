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

/*

The Explainaition : 

Well conceptually speaking the IConvertible interface is like oprator overloading or 
dynamic type converion in C++.

In the above progam the ComplexNumber structure has been interfaced with IConvertible 
(struct ComplexNumber : IConvertible) this allows the structure to recieve/return type information at runtime.

The property IFormatProvider provider recieves the type information and depending weather its a string/double 
carries out the respective funtion.

For all other data types and exception is thrown. 

In short the IConvertible interface allows the programmer to "convert" and entire object to one of the basic data
tyoes or other types as the requirement may be.

*/