class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

//For scriptures with single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }


    //For scriptures with multiples verses
    public Reference(string book, int chapter, int startVerse, int endVerse )
    {

    
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReferenceText()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }

}   
