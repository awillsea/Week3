List<Movies> movieList = new List<Movies>();
movieList.Add(new Movies("Black Phone", "Horror"));
movieList.Add(new Movies("Resident Evil", "Horror"));
movieList.Add(new Movies("28 Days Later", "Horror"));
movieList.Add(new Movies("The Thing", "Horror"));
movieList.Add(new Movies("Hereditary", "Horror"));
movieList.Add(new Movies("Hustle", "Drama"));
movieList.Add(new Movies("Red", "Drama"));
movieList.Add(new Movies("Cast Away", "Drama"));
movieList.Add(new Movies("127 Hours", "Drama"));
movieList.Add(new Movies("Interstellar", "Scifi"));
movieList.Add(new Movies("The Last Samurai", "Drama"));
movieList.Add(new Movies("Jurassic Park", "Scifi"));
movieList.Add(new Movies("Planet of the Apes", "Scifi"));
movieList.Add(new Movies("Pacific Rim", "Scifi"));
movieList.Add(new Movies("StarWars: Episode II - Attack of the Clones", "Scifi"));
movieList.Add(new Movies("Up", "Animated"));
movieList.Add(new Movies("Bugs Life", "Animated"));
movieList.Add(new Movies("How to Train your Dragon", "Animated"));
movieList.Add(new Movies("The Iron Giant", "Animated"));
movieList.Add(new Movies("Shrek", "Animated"));

//foreach(Movies next in movieList)
//{
//    Console.WriteLine(next.Title());
//}

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine();
Console.WriteLine($"There are {movieList.Count} movies in this list");
//Console.Write("What category are you interested in? Press 1 for Animated, Number 2 for Drama, Number 3 for Horror, Number 4 for Scifi: ");
Console.Write("What category are you interested in?:  ");
foreach (Movies next in movieList)
{
    if (next.categories.ToLower() == "animated")
    {
        Console.WriteLine(next.Title());
    }
}

//string movieIntrest = Console.ReadLine();
//int numSelection = 0;
//vaildSelection(movieList, movieIntrest, numSelection);
//CategorySelection(movieList, numSelection);














//static void vaildSelection(List<Movies> _movieList, string _movieIntrest, int _numSelection)
//{
//    bool parseSuccess = int.TryParse(_movieIntrest, out _numSelection);
//    bool validInput = false;
//    while (!validInput)
//    {
//        if (!parseSuccess)
//        {
//            Console.Write("Please Make sure you Entered only one of the following:\nNumber 1 for Animated, Number 2 for Drama, Number 3 for Horror, Number 4 for Scifi:  ");
//            _movieIntrest = Console.ReadLine();
//            _numSelection = 0;
//            parseSuccess = int.TryParse(_movieIntrest, out _numSelection);
//            validInput = false;
//        }
//        else
//        {
//            if (_numSelection < 0 || _numSelection > 3)
//            {
//                Console.WriteLine("Please Make sure you Entered only one of the following:\nNumber 1 for Animated, Number 2 for Drama, Number 3 for Horror, Number 4 for Scifi:  ");
//                _movieIntrest = Console.ReadLine();
//                _numSelection = 0;
//                parseSuccess = int.TryParse(_movieIntrest, out _numSelection);
//                validInput = false;

//            }
//            else
//            {
//                validInput = true;
//            }
//        }
//    }


//}




//static void CategorySelection(List<Movies> _moivelist, int _numSelection)
//{
//    if (_numSelection == 1)
//    {
//        foreach (Movies next in _moivelist)
//        {
//            if (next.categories.ToLower() == "animated")
//            {
//                Console.WriteLine(next.Title());
//            }

//        }
//    }
//    else if (_numSelection == 2)
//    {
//        foreach (Movies movies in _moivelist)
//        {
//            Console.WriteLine(movies);
//        }
//    }
//    else
//    {
//        foreach (Movies movies in _moivelist)
//        {
//            Console.WriteLine(movies);
//        }
//    }

//}









class Movies
{
    private string title;
    public string categories;

    public Movies(string _title, string _categoties)
    {
        this.title = _title;
        this.categories = _categoties;
    }

    public string Title()
    {
        return title;
    }

    //public string Categories()
    //{
    //    return categories;
    //}

}