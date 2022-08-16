car first = new car("Nissan", "Sentra", "Silver");

Console.WriteLine(first.getMake());
Console.WriteLine(first.getModel());
Console.WriteLine(first.getColor());
first.setColor("Red");
Console.WriteLine(first.getColor());
first.setColor("White");
Console.WriteLine(first.getColor());


color pianoColor = color.Black; // We have 4 possible choices.
Console.WriteLine(pianoColor);
pianoColor = color.Red;
Console.WriteLine(pianoColor);




enum color
{
    Red,
    Blue,
    Black,
    Silver
}


class car
{
    // Attributes that cannot be changed
    private string make;
    private string model;

    //Attributives that can be changed
    private color carColor;

    public car(string _make, string _model, color _color)
    {
        make = _make;
        model = _model;
        carColor = _color;
    }
    // Make and Model only have a getter method, so we can only look at it. we cannot change it.
    public string getMake()
    {
        return make;
    }

    public string getModel()
    {
        return model;
    }
    
    //Color has both a getter and a setter so we can look at it and change it.
    public color getColor()
    {
        return carColor;
    }

    public void setColor(string _color)
    {
        //// Lets do some validation to make sure it is a valid color
        //if(_color == "Red" || _color == "Blue" || _color == "Black" || _color == "Silver")
        //{
        //    color = _color;
        //}
        carColor = _color;
    }

}