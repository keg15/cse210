// Keeps track of the book, chapter, and verse information
//have attributes for the book, chapter, and verse, as well as a second "end verse" to handle the case of Proverbs 3:5-6.
//have at least two different constructors to account for cases where there is a single verse or multiple verses
//DECLARES the reference and scriptures
public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse = "0";

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public void Display()
    {
        if(_endVerse == "0")
        {
            Console.WriteLine($"{_book} {_chapter}:{_verse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
    }
}