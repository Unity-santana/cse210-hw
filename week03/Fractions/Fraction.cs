public class Fraction
{
    // Private attributes (Encapsulation!)
    private int _top;
    private int _bottom;

    // Constructor 1: Default (1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: Whole number (e.g., 5 → 5/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: Custom fraction
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for top
    public int GetTop()
    {
        return _top;
    }

    // Setter for top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for bottom
    public void SetBottom(int bottom)
    {
        if (bottom != 0) // Prevent division by zero
        {
            _bottom = bottom;
        }
    }

    // Method: Return fraction string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method: Return decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}