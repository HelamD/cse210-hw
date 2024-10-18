using System.Security.Cryptography.X509Certificates;

class Word{
    private string _text;
    private bool _hidtext;

    public Word (string text)
    {
        _text = text;
        _hidtext = false;
    }
    
 public void HideWord()
 {
    _hidtext = true;
 }

 public string GetWord()
    {
        if (_hidtext)
        {
            return "___";
        }

        else 
        {
            return _text;
        }

        
    }
public bool Ishidden()
{
    return _hidtext;
}
    
}