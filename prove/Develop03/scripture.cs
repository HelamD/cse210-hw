class Scriptures
{
    private List<Word> _words;
    private Reference _reference;

    // Constructor to initialize reference and words from scriptureText
    public Scriptures(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the scripture text into individual words
        foreach (string word in scriptureText.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Method to get the full scripture text, including hidden words
    public string GetScriptureText()
    {
        string text = _reference.GetReferenceText() + "\n";

        foreach (Word word in _words)
        {
            text += word.GetWord() + " "; // Get each word or blank if hidden
        }

        return text.Trim(); // Remove extra spaces
    }

    // Method to hide random words
    public void HideWords()
    {
        Random rand = new Random();
        int numberToHide = 3; // Number of words to hide each time

        for (int i = 0; i < numberToHide; i++) // Corrected loop condition
        {
            int index = rand.Next(_words.Count); // Get random word index

            // Only hide the word if it isn't already hidden
            if (!_words[index].Ishidden())
            {
                _words[index].HideWord(); // Hide the word
            }
        }
    }

    // Method to check if all words are hidden
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.Ishidden()) // If any word is not hidden, return false
            {
                return false;
            }
        }
        return true; // If all words are hidden, return true
    }
}
