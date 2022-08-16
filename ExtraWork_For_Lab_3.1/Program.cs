
double circlecounter = 0;
double numOfCircle = 1;
List<Circle> circleList = new List<Circle>();

do
{

    Console.WriteLine("Please Enter a Radius: ");
    string radiusNum = Console.ReadLine();
    double circleRadius = 0;
    bool parseSuccess = double.TryParse(radiusNum, out circleRadius);
    bool correctInput = false;
    Circle newOne = new Circle(0, 0);
    while (!correctInput)
    {
        if (!parseSuccess)
        {
            Console.WriteLine("Please Enter a Valid number for the Radius");
            radiusNum = Console.ReadLine();
            circleRadius = 0;
            parseSuccess = double.TryParse(radiusNum, out circleRadius);
            correctInput = false;
        }
        else
        {
            newOne = new Circle(circleRadius, numOfCircle);
            correctInput = true;
        }

    }
    newOne.CalculateCircumfrence();
    newOne.CalculateArea();
    Console.WriteLine(newOne.ToString());
    circleList.Add(newOne);
    circlecounter++;
    numOfCircle++;
} while (KeepGoing());

Console.WriteLine($"GoodBye.You Created {circlecounter} Circle Objects");
Console.WriteLine();

foreach (Circle circle in circleList)
{
    Console.WriteLine(circle);
    Console.WriteLine();
}

static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to go again? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}
class Circle
{
    public double circleNum;
    public double radius;
    public double circumference;
    public double area;

    public Circle(double _radius, double _circleNum)
    {
        this.radius = _radius;
        this.circleNum = _circleNum;
    }
    public double CalculateCircumfrence()
    {
        this.circumference = 2 * Math.PI * radius;
        return circumference;
    }

    public double CalculateArea()
    {
        this.area = Math.PI * (radius * radius);
        return area;
    }

    public override string ToString()
    {
        return $" The radius of Circle {circleNum} is {radius}, The Circumference is {circumference:0.##}, The Area is: {area:0.##}";
    }
}




//Rectangle rec1 = new Rectangle(5, 10);
////rec1.CalculatePerimeter();
//Console.WriteLine(rec1.CalculatePerimeter());
//rec1.CalculateAreaofRec();
//Console.WriteLine(rec1);
class Rectangle
{
    public double Length;
    public double Width;
    public double perimeter;
    public double area;

    public Rectangle(double _Length, double _Width)
    {
        Length = _Length;
        Width = _Width;
    }
    public double CalculatePerimeter()
    {
        this.perimeter = 2 * (Length + Width);
        return perimeter;
    }
    public void CalculateAreaofRec()
    {
        this.area = Length * Width;
        Console.WriteLine(area);
    }

    public override string ToString()
    {
        return $"The Length is: {Length}, The Width is: {Width}, The Perimeter is: {perimeter} The Area is: {area}";

    }
}