// CompactDisc

CompactDisc theWall = new CompactDisc("Pink Floyd", "Rock", 80);
Console.WriteLine(theWall);

theWall.songs.Add("In the Flesh?");
theWall.songs.Add("The thin Ice");
theWall.songs.Add("Another Brick in the Wall, part 1");
theWall.songs.Add("The Happiest Days of Our Lives");
theWall.songs.Add("TAnother Brick in the Wall, part 2");

foreach (string song in theWall.songs)
{
    Console.WriteLine(song);
}
Console.WriteLine($"This Album has {theWall.songCount()} songs on it");

// lets practice copying -- we actually have the same object referenced by two variables

CompactDisc another = theWall;
Console.WriteLine(another.artist);





class CompactDisc
{
    public string artist;
    public string genre;
    public int duration;
    public List<string> songs;    

    public CompactDisc(string _artist, string _genre, int _duration)
    {
        artist = _artist;
        genre = _genre;
        duration = _duration;
        songs = new List<string>();
    }

    public int songCount()
    {
        return songs.Count;
    }

    public override string ToString()
    {
        return $"Artist: {artist}, Genre: {genre}, Duration: {duration} minutes";
    }
}
