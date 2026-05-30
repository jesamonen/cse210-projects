using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video();
        video1.Title = "C# Basics";
        video1.Author = "John";
        video1.Length = 600;

        video1.Comments.Add(new Comment { Name = "Mary", Text = "Great video!" });
        video1.Comments.Add(new Comment { Name = "Paul", Text = "Very helpful." });
        video1.Comments.Add(new Comment { Name = "Jane", Text = "Thanks!" });

        videos.Add(video1);

        // Video 2
        Video video2 = new Video();
        video2.Title = "SQL Tutorial";
        video2.Author = "David";
        video2.Length = 900;

        video2.Comments.Add(new Comment { Name = "Mike", Text = "Awesome!" });
        video2.Comments.Add(new Comment { Name = "Sarah", Text = "Easy to follow." });
        video2.Comments.Add(new Comment { Name = "Chris", Text = "Nice work." });

        videos.Add(video2);

        // Video 3
        Video video3 = new Video();
        video3.Title = "Web Design Basics";
        video3.Author = "Sarah";
        video3.Length = 1200;

        video3.Comments.Add(new Comment { Name = "Tom", Text = "Great tips!" });
        video3.Comments.Add(new Comment { Name = "Anna", Text = "Very useful." });
        video3.Comments.Add(new Comment { Name = "Mark", Text = "Thanks for sharing." });

        videos.Add(video3);

        // Video 4
        Video video4 = new Video();
        video4.Title = "Introduction to Programming";
        video4.Author = "James";
        video4.Length = 1500;

        video4.Comments.Add(new Comment { Name = "Peter", Text = "Excellent lesson." });
        video4.Comments.Add(new Comment { Name = "Grace", Text = "I learned a lot." });
        video4.Comments.Add(new Comment { Name = "Linda", Text = "Very clear explanation." });

        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}