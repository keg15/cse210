// Keeps track of a single word and whether it is shown or hidden.
//have a constructor that should likely accept the text of the word to save it as an attribute. In addition, the constructor will
    //need to set the initial visibility of the word (whether it is shown or hidden).
//KEEPS track of a single word (from Scripture) and knows it it is hidden or not

public class Word
{
    private string _word;
    private bool _isHidden;
    private string _displayWord;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
        _displayWord = word;
    }

    public void Hide()
    {
        _isHidden = true;
        _displayWord = "";
        for (int i = 0; i < _word.Length; i++)
        {
            _displayWord += "_";
        }
    }

    public void Show()
    {
        _isHidden = false;
        _displayWord = _word;
    }

    public void Display()
    {
        Console.Write(_displayWord);
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}