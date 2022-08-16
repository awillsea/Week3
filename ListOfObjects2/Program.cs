
//
//section 1: Create and populate the list of songs
//


List<Song> playList = new List<Song>();

Song song1 = new Song("The Beatles", "I Want to Hold Your Hand", "Rock", 1964);
playList.Add(song1);

song1 = new Song("Pink Flyod", "Comfortably Numb", "Progressive", 1979);
playList.Add(song1);

song1 = new Song("Britney Spears", "Toxic","Pop", 2003);
playList.Add(song1);

playList.Add(new Song("Dave Brubeck", "Take 5", "Jazz", 1959));


//
//Section 2: Print out the titles
Console.WriteLine("Here is your playlist: ");

foreach(Song next in playList)
{
    Console.WriteLine(next.Title);
}


//
// section 3: Ask the user for a song and print out the details
//
Console.WriteLine("Which song title do you want more info on: ");
string mysong = Console.ReadLine();

Song found = FindSong(playList, mysong);
if (found == null)
{
    Console.WriteLine("Sorry, We dont have that song");
}
else
{
    Console.WriteLine(found);
}


//
// section 4: A "helper Method" that searches the list by title.
//            Side note: we need to pass the list in. Fact of life...
//
static Song FindSong(List<Song> thelist, string thetitle)
{
    
    foreach(Song next in thelist)
    {
        if(next.Title.ToLower() == thetitle.ToLower())
        {
            return next;
        }
    }
    return null;
}




class Song
{
    public string Artist;
    public string Title;
    public string Genre;
    public int Year;

    public Song(string _Artist, string _Title, string _Genre, int _Year)
    {
        Artist = _Artist;
        Title = _Title;
        Genre = _Genre;
        Year = _Year;
    }
    public override string ToString()
    {
        return $"\"{Title}\" by {Artist} from {Year} ({Genre})";
    }
}