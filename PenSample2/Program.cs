Pen gelPen = new Pen("Green", 5.0, "Gel", "Medium");
gelPen.Print();

Pen feltPen = new Pen("Blue", 4.0, "Felt", "Small");
feltPen.Print();

gelPen.Draw(5);
gelPen.Print();
gelPen.Draw(7);
gelPen.Print();

Console.WriteLine();
Console.WriteLine(gelPen);

class Pen
{
    public string inkColor;
    public double lenght;
    public string pointType;
    public string pointSize;
    public int inkAmount;

    public Pen(string _inkColor, double _length, string _pointType, string _pointSize)
    {
        inkColor = _inkColor;
        lenght = _length;   
        pointType = _pointType;
        pointSize = _pointSize;
        inkAmount = 10;
    }

    public void Print()
    {
        Console.Write("This Pen: ");
        Console.WriteLine($" Color:{inkColor}, Length: {lenght}, Type: {pointType}, Size: {pointSize}, Amount: {inkAmount}");
    }

    public void Draw(int lineLength)
    {

        if(lineLength > inkAmount)
        {
            Console.WriteLine("Sorry not enough ink for that!");
            return;
        }
        inkAmount -= lineLength;
        if(inkAmount < 0)
        {
            inkAmount = 0;
        }
    }

    public void Refill()
    {
        inkAmount = 10;
    }

    public override string ToString()
    {
        return $"color: {inkColor}  Length: {lenght}  Type: {pointType}  Size: {pointSize}  Amount: {inkAmount}";
    }
}