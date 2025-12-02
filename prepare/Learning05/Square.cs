class Square : Ishape
{
    private double _side; 

    public double Side
    {
        get { return _side; }
        set { _side = value; }

    }
    public double GetArea()
    {
        return _side * 2; 
    }
}