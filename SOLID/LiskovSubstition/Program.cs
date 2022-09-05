
/*
 * Bir X sınıfı Y sınıfına miras veriyorsa; Y sınıfı X'in davranışını DEĞİŞTİREMEZ 
 * Değiştiriyorsa: Miras söz konusu değildir.
 */
var rectangle = getGeometry(9);
Console.WriteLine(rectangle.GetArea());


IGeometry getGeometry(int width, int? height = 1)
{
    //bir biçimde kare dönüyor...
    if (height.HasValue && height.Value > 1)
    {
        return new Rectangle { Width = width, Height = height.Value };
    }
    return new Square() { Height = width };
}

public interface IGeometry
{
    int GetArea();

}
public class Rectangle : IGeometry
{
    protected int width;
    protected int height;
    public int Width { get { return width; } set { width = value; } }
    public int Height { get { return height; } set { height = value; } }

    public int GetArea()
    {
        return width * height;
    }


}
public class Square : IGeometry

{
    public int Height { get; set; }

    public int GetArea()
    {
        return Height * Height;
    }
}
