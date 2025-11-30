using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //videos
        Video video1 = new Video("C# Basic Tutorial", "John Doe", 600);
        Video video2 = new Video("Advanced C# Programing", "Jane Smith", 1200);
        Video video3 = new Video("Youtube API Overview", "Michael Hopper", 900);

        //comentaris de los videos 
        video1.AddComment(new Comment("Alice", "Great tutorial! Very clear."));
        video1.AddComment(new Comment("Bob", "Nice video!"));
        video2.AddComment(new Comment("Charlie", "Amazing video!"));

        video2.AddComment(new Comment("Martha", "Great tutorial! Very clear."));
        video2.AddComment(new Comment("Lucas", "Nice video!"));
        video2.AddComment(new Comment("Millie", "Amazing video!"));

        video3.AddComment(new Comment("Karol", "Great tutorial! Very clear."));
        video3.AddComment(new Comment("Bobby", "Nice video!"));
        video3.AddComment(new Comment("Chesnot", "Amazing video!"));

        List<Video> Videos= new List<Video>() { video1, video2, video3};

        foreach (Video video in Videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine($"Comments:");
            
            foreach(Comment comment in video.GetComments())
            {
                Console.WriteLine($"-{comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}