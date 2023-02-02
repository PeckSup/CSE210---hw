using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(2);
        Fraction fraction12 = new Fraction(1,2);

        int fractionNumerator = fraction1.GetNumerator();
        Console.WriteLine($"Numerator: {fractionNumerator}");
        int fractionDenominator = fraction1.GetDenominator();
        Console.WriteLine($"Denominator: {fractionDenominator}");
        string fractionString = fraction1.GetFractionString();
        Console.WriteLine(fractionString);
        double fractionDecimal = fraction1.GetDecimalValue();
        Console.WriteLine(fractionDecimal);

        fraction1.SetNumerator(5);
        fraction1.SetDenominator(10);

        fractionNumerator = fraction1.GetNumerator();
        Console.WriteLine($"Numerator: {fractionNumerator}");
        fractionDenominator = fraction1.GetDenominator();
        Console.WriteLine($"Denominator: {fractionDenominator}");
        fractionString = fraction1.GetFractionString();
        Console.WriteLine(fractionString);
        fractionDecimal = fraction1.GetDecimalValue();
        Console.WriteLine(fractionDecimal);

        fractionNumerator = fraction2.GetNumerator();
        Console.WriteLine($"Numerator: {fractionNumerator}");
        fractionDenominator = fraction2.GetDenominator();
        Console.WriteLine($"Denominator: {fractionDenominator}");
        fractionString = fraction2.GetFractionString();
        Console.WriteLine(fractionString);
        fractionDecimal = fraction2.GetDecimalValue();
        Console.WriteLine(fractionDecimal);

        fractionNumerator = fraction12.GetNumerator();
        Console.WriteLine($"Numerator: {fractionNumerator}");
        fractionDenominator = fraction12.GetDenominator();
        Console.WriteLine($"Denominator: {fractionDenominator}");
        fractionString = fraction12.GetFractionString();
        Console.WriteLine(fractionString);
        fractionDecimal = fraction12.GetDecimalValue();
        Console.WriteLine(fractionDecimal); 

    }
}