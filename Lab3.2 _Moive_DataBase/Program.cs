List<Movies> movieList = new List<Movies>();
movieList.Add(new Movies("Black Phone", "Horror", 102 , 2021));
movieList.Add(new Movies("Resident Evil", "Horror", 100, 2002));
movieList.Add(new Movies("28 Days Later", "Horror", 113, 2002));
movieList.Add(new Movies("The Thing", "Horror", 109, 1982));
movieList.Add(new Movies("Hereditary","Horror", 127, 2018 ));
movieList.Add(new Movies("Hustle","Drama", 117, 2022));
movieList.Add(new Movies("Parasite", "Drama", 132, 2019));
movieList.Add(new Movies("Cast Away","Drama", 143, 2000));
movieList.Add(new Movies("127 Hours","Drama", 94, 2010));
movieList.Add(new Movies("Interstellar","Scifi", 169, 2014));
movieList.Add(new Movies("The Last Samurai","Drama", 154, 2003));
movieList.Add(new Movies("Jurassic Park","Scifi", 127, 1993));
movieList.Add(new Movies("Planet of the Apes","Scifi", 112, 1968 ));
movieList.Add(new Movies("Pacific Rim","Scifi", 131, 2013));
movieList.Add(new Movies("StarWars: Episode II - Attack of the Clones","Scifi",120, 2002));
movieList.Add(new Movies("Up","Animated", 96, 2009));
movieList.Add(new Movies("Bugs Life", "Animated", 95, 1998));
movieList.Add(new Movies("How to Train your Dragon","Animated", 98, 2010));
movieList.Add(new Movies("The Iron Giant","Animated", 86, 1999));
movieList.Add(new Movies("Shrek","Animated", 90, 2001));



Console.WriteLine("======================================");
Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine("======================================");

Console.WriteLine();
Console.WriteLine($"There are {movieList.Count} movies in this list");
Console.WriteLine();
do
{
    Console.Write("What category are you interested in?\nPress 1 for Animated, Number 2 for Drama, Number 3 for Horror, Number 4 for Scifi:  ");


    string movieIntrest = Console.ReadLine();
    int numSelection = 0;
    bool parseSuccess = int.TryParse(movieIntrest, out numSelection);
    bool validInput = false;
    while (!validInput)
    {
        if (!parseSuccess)
        {
            Console.Write("Please Make sure you Entered only one of the following:\nNumber 1 for Animated, Number 2 for Drama, Number 3 for Horror, Number 4 for Scifi:  ");
            movieIntrest = Console.ReadLine();
            numSelection = 0;
            parseSuccess = int.TryParse(movieIntrest, out numSelection);
            validInput = false;
        }
        else if (numSelection < 0 || numSelection > 4)
        {
            Console.WriteLine("Please Make sure you Entered only one of the following:\nNumber 1 for Animated, Number 2 for Drama, Number 3 for Horror, Number 4 for Scifi:  ");
            numSelection = int.Parse(Console.ReadLine());
            validInput = false;

        }
        else
        {

            validInput = true;

        }

    }
    CategorySelection(movieList, numSelection);
} while (KeepGoing());





static void CategorySelection(List<Movies> _movielist, int _numSelection)
{
    if (_numSelection == 1)
    {
        Console.WriteLine();
        Console.WriteLine($"You have Selected Number {_numSelection} for Animated Movies");
        Console.WriteLine();
        Console.WriteLine("Here is the List for Animated Movies: ");
        Console.WriteLine();

        foreach (Movies next in _movielist)
        {
            if (next.Categories() == "Animated")
            {
                Console.WriteLine(next.ToString());
                Console.WriteLine();
                
            }

        }
    }
    else if (_numSelection == 2)
    {
        Console.WriteLine();
        Console.WriteLine($"You have Selected Number {_numSelection} for Drama Movies");
        Console.WriteLine();
        Console.WriteLine("Here is the List for Drama Movies: ");
        Console.WriteLine();

        foreach (Movies next in _movielist)
        {
            if (next.Categories() == "Drama")
            {
                Console.WriteLine(next.ToString());
                Console.WriteLine();
            }
        }
    }
    else if (_numSelection == 3)
    {
        Console.WriteLine();
        Console.WriteLine($"You have Selected Number {_numSelection} for Horror Movies");
        Console.WriteLine();
        Console.WriteLine("Here is the List for Horror Movies: ");
        Console.WriteLine();
       
        foreach (Movies next in _movielist)
        {
            if (next.Categories() == "Horror")
            {
                Console.WriteLine(next.ToString());
                Console.WriteLine();
            }
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"You have Selected Number {_numSelection} for Scifi Movies");
        Console.WriteLine();
        Console.WriteLine("Here is the List for Scifi Movies: ");
        Console.WriteLine();

        foreach (Movies next in _movielist)
        {
            if (next.Categories() == "Scifi")
            {
                Console.WriteLine(next.ToString());
                Console.WriteLine();
            }
        }
    }

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



class Movies
{
    private string title;
    private string categories;
    private double runTime;
    private double yearReleased;

    public Movies(string _title, string _categoties, double _runTime, double _yearReleased)
    {
        this.title = _title;
        this.categories = _categoties;
        this.runTime = _runTime;
        this.yearReleased = _yearReleased;
    }

    public string Title() 
    {
        return title;
    }

    public string Categories()
    {
        return categories;
    }

    public double RunTime()
    {
        return runTime;
    }

    public double ReleaseDate()
    {
        return yearReleased;
    }

    public override string ToString()
    {
        return $"The movie \"{title}\", is {runTime} minutes long and came out in {yearReleased}";
    }
}