
List<Song> playList = new List<Song>();

Song song1 = new Song("The Beatles", "I Want to Hold Your Hand", "Rock", 1964);
playList.Add(song1);

Song song2 = new Song("Pink Floyd", "Comfortably Numb", "Progressive", 1979);
playList.Add(song2);

Song song3 = new Song("Britney Spears", "Toxic", "Pop", 2003);
playList.Add(song3);


Console.WriteLine("Here are you songs:");


foreach (Song song in playList)
{
    Console.WriteLine(song.Title);
}
Console.WriteLine();
Console.Write("Which song do you want more details on: ");
string mysong = Console.ReadLine();
class Song
{
    public string Artist;
    public string Title;
    public string Genre;
    public int Year;

    public Song ( string _Artist, string _Title, string _Genre, int _Year)
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