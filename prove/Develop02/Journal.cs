public class Journal
{
  public Journal()
  {
  }
  public List<Entry> _entry = new List<Entry>();

  public void Display()
  {
    foreach(Entry entry in _entry)
    {
      entry.Display();
    }
  }

  public void ReadFile() 
  {
    string filename = "myJournal.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);
    foreach (string line in lines)
    {
      string[] parts = line.Split("|");
      Entry newEntry = new Entry();

      newEntry.date = parts[0];
      newEntry._prompts = parts[1];
      newEntry._entry = parts[2];
      
      _entry.Add(newEntry);
    }
  }

  public void SaveFile()
  {
    string fileName = "myJournal.txt";
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      foreach(Entry entry in _entry)
      {
        outputFile.WriteLine($"{entry.date}|{entry._prompts}|{entry._entry}");
      }
    }
  }
}