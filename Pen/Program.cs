
Pen firstPen = new Pen();
// first pen is an object that has four variables.

firstPen.inkColor = "blue";
firstPen.length = 4.5;
firstPen.pointType = "Gel";
firstPen.pointSize = "small";
firstPen.inkAmount = 5;

Console.WriteLine(firstPen.inkColor);
Console.WriteLine(firstPen.length);
Console.WriteLine(firstPen.pointType);
Console.WriteLine(firstPen.pointSize);
Console.WriteLine(firstPen.inkAmount);

Console.WriteLine("Lets draw with firstpen");

firstPen.draw();
Console.WriteLine($"The ink is now {firstPen.inkAmount}");
Console.WriteLine();

Pen secondPen = new Pen();
secondPen.inkColor = "Red";
secondPen.length = 4.5;
secondPen.pointType = "Ball Point";
secondPen.pointSize = "Medium";
secondPen.inkAmount = 2;

Console.WriteLine(secondPen.inkColor);
Console.WriteLine(secondPen.length);
Console.WriteLine(secondPen.pointType);
Console.WriteLine(secondPen.pointSize);
Console.WriteLine(secondPen.inkAmount);


Console.WriteLine("lets do two drawings with secondpen");
secondPen.draw();
secondPen.draw();
Console.WriteLine($"second pen now has ink level {secondPen.inkAmount}");
Console.WriteLine($"firstpen still has ink level {firstPen.inkAmount}");

secondPen.draw();
Console.WriteLine($"second pen now has ink level {secondPen.inkAmount}");


secondPen.refill();
Console.WriteLine($"secondpen now had ink level {secondPen.inkAmount}");

Console.WriteLine();
Console.WriteLine("lets refill firstpen with green ink");
firstPen.refill("green");
Console.WriteLine($"First Pen has ink {firstPen.inkColor}");
Console.WriteLine($"First pen has ink level {firstPen.inkAmount}");

Pen thirdpen = new Pen();
Console.WriteLine(thirdpen.inkAmount);

Console.WriteLine();

Pen fourthpen = new Pen("green");
Console.WriteLine(fourthpen.inkAmount);
Console.WriteLine(fourthpen.inkColor);


class Pen
{
    public string inkColor;
    public double length;
    public string pointType;
    public string pointSize;
    public int inkAmount;

    public Pen()
    {
        inkAmount = 10;
        inkColor = "black";
    }
    public Pen(string _inkColor) 
    {
        inkColor = _inkColor;
        inkAmount = 10;
    }

    public void draw()
    {
        if(inkAmount > 0)
        {
            inkAmount--;
        }
    }

    public void refill()
    {
        inkAmount = 10;
    }

    public void refill(string newcolor)
    {
        inkColor = newcolor;
        inkAmount = 10;
    }

}