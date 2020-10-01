using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Record
  {
    public string Title { get; set; }
    public int Id { get; }
    private static List<Record> _instances = new List<Record> {};

    public Record(string inputTitle)
    {
      Title = inputTitle;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Record> GetAllRecords()
    {
      return _instances;
    }

    public static void ClearAllRecords()
    {
      _instances.Clear();
    }

    public static Record FindRecord(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}