using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning to Code", "Video Academy", 300);
        video1.AddToList(new Comment("John", "Great video!"));


        Video video2 = new Video("Basic of Abstraction", "Video Academy", 800);
        video2.AddToList(new Comment("Bob", "Loved the examples."));

        Video video3 = new Video("Constructors", "Video Academy", 1500);
        video3.AddToList(new Comment("Tom", "I had no idea constructors were this important!" ));

        Video video4 = new Video("Ecapsulation", "Video Academy", 760);
        video4.AddToList(new Comment("Mark", "Great explanation, thank you!"));

        List<Video> videos = new List<Video> {video1, video2,video3, video4};

            foreach(Video video in videos)

            {
                video.Display();
            }
    }
}