using System.ComponentModel;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

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

    // public int top {get; set;}

    // public int bottom {get; set;}

    public string GetFractionString()
    {
        int numerator = GetTop();
        int denominator = GetBottom();

        return $"{numerator.ToString()}/{denominator.ToString()}";
    }

    public double GetDecimalValue()
    {
        double numerator = GetTop();
        double denominator = GetBottom();

        double value = numerator / denominator;
        return value;
    }

}