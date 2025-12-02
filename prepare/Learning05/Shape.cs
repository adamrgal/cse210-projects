public interface Ishape
{
    double GetArea();
}
class Shape : Ishape 
{
    private static string _color;

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }
    public double GetArea()
    {
        return 2.0; 
    }
}