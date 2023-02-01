using System;
public class FractionLearning3
{
    private int _top;
    private int _bottom;

    public FractionLearning3()
    {
        _top = 1;
        _bottom = 1;
    }

    public FractionLearning3(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public FractionLearning3(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = ($"{_top}/{_bottom}");
        return text;
    }

    public double GetDeciamlValue()
    {
        return (double)_top / (double)_bottom;
    }
}