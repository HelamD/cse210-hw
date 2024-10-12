using System; 
using System.Collections.Generic;
class Video

{
    public  string _tittle;
    public string _author;
    public int _length;

    private List<Comment> _comments = new List<Comment>();

    public void AddToList(Comment comment)
    {
        _comments.Add(comment);
    }


    public int GetNumberComment()
    {
        return _comments.Count;
    }


    public Video (string aTittle , string aAuthor, int aLength)
    {
        _tittle = aTittle;
        _author = aAuthor;
        _length = aLength;
    }
   
     public void Display()
     {
        Console.WriteLine($"Title {_tittle}, Author {_author}");
        Console.WriteLine($"Number of comments {GetNumberComment()}");

        foreach (Comment comment in _comments)
            {
                Console.WriteLine($"Comment by {comment.Commenter}: {comment.Text}");

            }
        Console.WriteLine();
     }

}