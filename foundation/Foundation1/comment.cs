using System;
using System.Collections.Generic;
class Comment
{
    public string Commenter { get; set;}
    public string Text {get ; set;}

    public Comment(string commenterName, string commenterText)
    {
        Commenter = commenterName;
        Text = commenterText;
    }
}

