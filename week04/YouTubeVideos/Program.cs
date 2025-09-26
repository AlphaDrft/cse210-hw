using System;
using System.Collections.Generic;

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{Name}: {Text}");
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }

    private List<Comment> Comments { get; set; } = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (var comment in Comments)
        {
            comment.Display();
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "Alice", 600);
        video1.AddComment(new Comment("Bob", "Great tutorial!"));
        video1.AddComment(new Comment("Charlie", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Diana", "I learned a lot!"));

        Video video2 = new Video("OOP Basics", "John", 720);
        video2.AddComment(new Comment("Eve", "Clear and concise."));
        video2.AddComment(new Comment("Frank", "Can you make more videos like this?"));

        Video video3 = new Video("Design Patterns Intro", "Sarah", 900);
        video3.AddComment(new Comment("Grace", "This was amazing!"));
        video3.AddComment(new Comment("Heidi", "Excited for the next one."));
        video3.AddComment(new Comment("Ivan", "Very informative."));
        video3.AddComment(new Comment("Judy", "Thanks for sharing!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.Display();
        }
    }
}