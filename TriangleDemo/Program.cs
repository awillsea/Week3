Triangle first = new Triangle();
first.length = 4;
first.height = 3;
double area = first.getArea();
Console.WriteLine(area);
Console.WriteLine(first.getHypotenuse());
Console.WriteLine(first.getPerimeter());

class Triangle
{

    // we have a package, like a capsule.
    // The Verb we use is "Encapsulate".
    // We've packaged length and Height in a triangle concept.
    //we have "encapsulated" length and height into a triangle.
    public double length;
    public double height;
    public double area;
    

    public double getArea()
    {
       this.area =  length * height / 2;
       return this.area;
    }

    public double getHypotenuse()
    {
        return Math.Sqrt(length * length + height * height);
    }

    public double getPerimeter()
    {
        return length + height + getHypotenuse();
    }
}