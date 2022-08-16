
List<Circle> circleList = new List<Circle>();
List<Rectangle> rectangleList = new List<Rectangle>();
List<Sphere> sphereList = new List<Sphere>();
double counterOfCircles = 0;
double counterOfRectangles = 0;
double counterOfSpheres = 0;

double numOfCircles = 1;
double numOfRectangles = 1;
double numOfSpheres = 1;

do
{

    Console.Write("What Shape would you like to use? Press 1 for Circle, Press 2 for Rectangle, Press 3 for Sphere:  ");
    string chosenShape = Console.ReadLine();
    double shapeNum = 0;
    bool parseIsGood = double.TryParse(chosenShape, out shapeNum);
    bool isGood = false;
    while (!isGood)
    {
        if (!parseIsGood)
        {
            Console.WriteLine("Please Enter  valid number for the shape we want to use.");
            chosenShape = Console.ReadLine();
            shapeNum = 0;
            parseIsGood = double.TryParse(chosenShape, out shapeNum);
            isGood = false;
        }
        else
        {
            isGood = true;
        }

    }
    switch (shapeNum)
    {

        case 1:
            shapeCircle(numOfCircles, circleList, counterOfCircles);
            counterOfCircles++;
            numOfCircles++;
            break;
        case 2:
            ShapeRectangle(numOfRectangles, rectangleList, counterOfRectangles);
            counterOfRectangles++;
            numOfRectangles++;
            break;
        case 3:
            ShapeSphere(numOfSpheres, sphereList, counterOfSpheres);
            counterOfSpheres++;
            numOfSpheres++;
            break;
        default:
            Console.WriteLine("Please make sure the number is either 1, 2 or 3: ");

            break;

    }

} while (KeepGoing());

Console.WriteLine($"GoodBye.You Created {counterOfCircles} Circle(s), {counterOfRectangles} Rectangle(s), and {counterOfSpheres} Sphere(s)");
Console.WriteLine();

foreach (Circle circle in circleList)
{
    Console.WriteLine(circle);
    Console.WriteLine();
}
foreach (Rectangle rectangle in rectangleList)
{
    Console.WriteLine(rectangle);
    Console.WriteLine();
}
foreach (Sphere sphere in sphereList)
{
    Console.WriteLine(sphere);
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

static void shapeCircle(double _numOfShape, List<Circle> _circleList, double _counter)
{
    Console.WriteLine("Please Enter a Radius: ");
    string radiusNum = Console.ReadLine();
    double Radius = 0;
    bool parseSuccess = double.TryParse(radiusNum, out Radius);
    bool correctInput = false;
    Circle newCircle = new Circle(0, 0);
    Rectangle newRectangle = new Rectangle(0, 0, 0);
    Sphere newSphere = new Sphere(0, 0);
    while (!correctInput)
    {
        if (!parseSuccess)
        {
            Console.WriteLine("Please Enter a Valid number for the Radius");
            radiusNum = Console.ReadLine();
            Radius = 0;
            parseSuccess = double.TryParse(radiusNum, out Radius);
            correctInput = false;
        }
        else
        {
            newCircle = new Circle(Radius, _numOfShape);
            correctInput = true;
        }

    }
    newCircle.CalculateCircumfrence();
    newCircle.CalculateArea();
    Console.WriteLine(newCircle.ToString());
    _circleList.Add(newCircle);
    _counter++;
    _numOfShape++;
}
static void ShapeRectangle(double _numOfShape, List<Rectangle> _RectangleList, double _counter)
{
    Console.WriteLine("Please Enter a length and Width:  ");
    string LengthNum = Console.ReadLine();
    double Length = 0;
    string WidthNum = Console.ReadLine();
    double Width = 0;
    bool parseSuccess = double.TryParse(LengthNum, out Length);
    bool parseSuccess2 = double.TryParse(WidthNum, out Width);
    bool correctInput = false;
    Circle newCircle = new Circle(0, 0);
    Rectangle newRectangle = new Rectangle(0, 0, 0);
    Sphere newSphere = new Sphere(0, 0);
    while (!correctInput)
    {
        if (!parseSuccess && !parseSuccess2)
        {
            Console.WriteLine("Please Enter a Valid number for the Length and Width: ");
            LengthNum = Console.ReadLine();
            Length = 0;
            WidthNum = Console.ReadLine();
            Width = 0;
            parseSuccess = double.TryParse(LengthNum, out Length);
            parseSuccess2 = double.TryParse(WidthNum, out Width);
            correctInput = false;
        }
        else if (!parseSuccess)
        {
            Console.WriteLine("Please Enter a Valid number for the Length: ");
            LengthNum = Console.ReadLine();
            Length = 0;
            parseSuccess = double.TryParse(LengthNum, out Length);
            correctInput = false;

        }
        else if (!parseSuccess2)
        {
            Console.WriteLine("Please Enter a Valid number for the Width: ");
            WidthNum = Console.ReadLine();
            Width = 0;
            parseSuccess2 = double.TryParse(WidthNum, out Width);
            correctInput = false;

        }
        else
        {
            newRectangle = new Rectangle(Length, Width, _numOfShape);
            correctInput = true;
        }

    }
    newRectangle.CalculatePerimeter();
    newRectangle.CalculateAreaofRec();
    Console.WriteLine(newRectangle.ToString());
    _RectangleList.Add(newRectangle);
    _counter++;
    _numOfShape++;
}
static void ShapeSphere(double _numOfShape, List<Sphere> _SphereList, double _counter)
{
    Console.WriteLine("Please Enter a Radius: ");
    string radiusNum = Console.ReadLine();
    double Radius = 0;
    bool parseSuccess = double.TryParse(radiusNum, out Radius);
    bool correctInput = false;
    Circle newCircle = new Circle(0, 0);
    Rectangle newRectangle = new Rectangle(0, 0, 0);
    Sphere newSphere = new Sphere(0, 0);
    while (!correctInput)
    {
        if (!parseSuccess)
        {
            Console.WriteLine("Please Enter a Valid number for the Radius");
            radiusNum = Console.ReadLine();
            Radius = 0;
            parseSuccess = double.TryParse(radiusNum, out Radius);
            correctInput = false;
        }
        else
        {
            newSphere = new Sphere(Radius, _numOfShape);
            correctInput = true;
        }

    }
    newSphere.CalculationForsurfaceArea();
    newSphere.CalculationForVolume();
    Console.WriteLine(newSphere.ToString());
    _SphereList.Add(newSphere);
    _counter++;
    _numOfShape++;
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





class Rectangle
{
    public double rectangleNum;
    public double Length;
    public double Width;
    public double perimeter;
    public double area;

    public Rectangle(double _Length, double _Width, double _rectangleNum)
    {
        Length = _Length;
        Width = _Width;
        this.rectangleNum = _rectangleNum;
    }
    public double CalculatePerimeter()
    {
        this.perimeter = 2 * (Length + Width);
        return perimeter;
    }
    public double CalculateAreaofRec()
    {
        this.area = Length * Width;
        return area;
    }

    public override string ToString()
    {
        return $"Rectangle Number {rectangleNum} has A Length of: {Length}, A Width of: {Width}, A Perimeter of: {perimeter} An Area of: {area}";

    }
}


class Sphere
{
    public double sphereNum;
    public double radius;
    public double surfaceArea;
    public double volume;

    public Sphere(double _radius, double _sphereNum)
    {
        this.radius = _radius;
        this.sphereNum = _sphereNum;
    }
    public double CalculationForsurfaceArea()
    {
        this.surfaceArea = 4 * Math.PI * (radius * radius);
        return surfaceArea;
    }
    public double CalculationForVolume()
    {
        this.volume = 4 / 3 * Math.PI * (radius * radius * radius);
        return volume;
    }
    public override string ToString()
    {
        return $"The Radius of Sphere {sphereNum}  is: {radius}, The Surface Area is: {surfaceArea}, The Volume is: {volume}";
    }
}                                                                                                                                                                                                                                                                   