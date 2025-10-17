// File: Fraction.cs

public class Fraction
{
    // Attributes (private for encapsulation)
    private int _top;
    private int _bottom;

    // --- Constructors ---
    
    // Constructor 1: No parameters, defaults to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: One parameter for the top, denominator defaults to 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: Two parameters for top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // --- Getters and Setters ---

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // --- Methods for Representation ---

    public string GetFractionString()
    {
        // Returns the fraction in the format "top/bottom"
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        // To get a double result, we must cast one of the integers to a double
        // before performing the division.
        return (double)_top / (double)_bottom;
    }
}