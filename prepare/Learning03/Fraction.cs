using System;

class Fraction
{
    private int _top = 0;
    private int _bottom = 0;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction (int top, int bottom)
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

    public string GetFractionString()
    {
        string stringTop = _top.ToString();
        string stringBottom = _bottom.ToString();
        string stringPresentation = stringTop + "/" + stringBottom;
        return stringPresentation;
        
    }
    public double GetDecimalValue()
    {
        double doubleTop = Convert.ToDouble(_top);
        double doubleBottom = Convert.ToDouble(_bottom);
        double decimalResult = doubleTop / doubleBottom;
        return decimalResult;

    }
}