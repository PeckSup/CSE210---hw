using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int number1)
    {
        _numerator = number1;
        _denominator = 1;
    }

    public Fraction(int number1, int number2)
    {
        _numerator = number1;
        _denominator = number2;
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetNumerator(int number)
    {
        _numerator = number;
    }

    public void SetDenominator(int number)
    {
        _denominator = number;
    }

    public string GetFractionString()
    {
        string returnFraction = _numerator + "/" + _denominator;
        return returnFraction;
    }

    public double GetDecimalValue()
    {
        double decimalValue = _numerator / _denominator;
        return decimalValue;
    }
}