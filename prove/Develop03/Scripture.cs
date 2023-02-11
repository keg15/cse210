//  Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text
//member variables for a reference and all of the words in the scripture
//a constructor that accepts both a reference and the text of the scripture
    //by passing the text of the scripture as a single string with all of the words in it.
    //Then, the constructor would have the responsibility of creating the list, and splitting up the
    //words in the string to create Word objects for each one and put them in the list.
//GETS all the info and hides or displays the words

public class Scripture
{
    private Reference _reference;
    private List<Word> _word = new List<Word>();
    public Scripture(Reference reference, string passage)
    {
       _reference = reference;
       string[] parts = passage.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _word.Add(word);
        }
    }

    public void Display()
    {
        _reference.Display();
        foreach(Word word in _word)
        {
            word.Display();
            Console.Write(" ");
        }
    }

    public bool isCompletelyHidden()
    {
        foreach (Word word in _word)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
        
    }

    public void HideWords()
    {
        Random rnd = new Random();
        int num = rnd.Next(0, _word.Count);
        for ( int i=0; i<3; i++)
        {
            _word[num].Hide();
            num = rnd.Next(0, _word.Count);
        }
    }
}
