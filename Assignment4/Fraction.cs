using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction()
    {
        Numerator = 0;
        Denominator = 0;
    }

    public Fraction(int num, int den)
    {
        this.Numerator = num;
        this.Denominator = den;
    }

    // Declare a Numerator property of type int
    public int Numerator
    {
        get
        {
            return this.numerator;
        }
        set
        {
            this.numerator = value;
        }
    }

    // Declare a Denominator property of type int
    // https://stackoverflow.com/questions/367192/why-does-property-set-throw-stackoverflow-exception
    public int Denominator
    {
        get
        {
            return this.denominator;
        }
        set
        {
            this.denominator = value;
        }
    }

    // Overload + operator to add two fraction objects
    public static Fraction operator +(Fraction a, Fraction b)
    {

        if ((a.Denominator == 0) || (b.Denominator == 0))
        {
            throw new ArgumentException("Invalid Denominator");
        }

        // multiply the  numerator and Denominator of Fraction 'a' by Denominator of 'b'.  
        // Multiply the numerator and Denominator of Fraction 'b' by the Denominator of 'a'

        int num = (a.Numerator * b.Denominator) + (b.Numerator * a.Denominator);
        int den = a.Denominator * b.Denominator;

        Fraction result = new Fraction(num, den);

        return result;
    }

    // Overload - operator to subtract two fraction objecfts
    public static Fraction operator -(Fraction a, Fraction b)
    {

        if ((a.Denominator == 0) || (b.Denominator == 0))
        {
            throw new ArgumentException("Invalid Denominator");
        }

        int num = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
        int den = a.Denominator * b.Denominator;

        Fraction result = new Fraction(num, den);

        return result;

    }

    // Overload * operator to multiply two fraction objects
    public static Fraction operator *(Fraction a, Fraction b)
    {
        int numerator = a.Numerator * b.Numerator;

        int Denominator = a.Denominator * b.Denominator;

        // https://stackoverflow.com/questions/19138195/c-sharp-assign-data-to-properties-via-constructor-vs-instantiating
        Fraction product = new Fraction
        {
            Numerator = numerator,
            Denominator = Denominator
        };
        return product;
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        if ((a.Denominator == 0) || (b.Denominator == 0))
        {
            throw new ArgumentException("Invalid Denominator");

        }
        // The classic copy, change, flip method
        Fraction result = a * new Fraction(b.Denominator, b.Numerator);

        return result;
    }

    public override string ToString()
    {
        return Numerator + "/" + Denominator;
    }
}