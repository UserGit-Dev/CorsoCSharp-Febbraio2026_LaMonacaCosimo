public abstract class ShapeCreator
{
    public IShape? CreateShape(string type)
    {
        if (type.Equals("circle", StringComparison.OrdinalIgnoreCase)) return new Circle();
        else if (type.Equals("square", StringComparison.OrdinalIgnoreCase)) return new Square();
        else return null;
    }
}