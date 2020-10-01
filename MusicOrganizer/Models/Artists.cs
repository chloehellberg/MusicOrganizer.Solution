using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    public string Name { get; set; }
    public int Id { get; }
    public List<Record> Records { get; set; }
    private static List<Artist> _instances = new List<Artist> {};

    public Artist(string inputName)
    {
      Name = inputName;
      Records = new List<Record>{};
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Artist> GetAllArtists()
    {
      return _instances;
    }

    public static void ClearAllArtists()
    {
      _instances.Clear();
    }

    public static Artist FindArtist(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddRecord(Record recordToBeAdded)
    {
      Records.Add(recordToBeAdded);
    }

  }
}