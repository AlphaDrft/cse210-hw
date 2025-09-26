using System;
using System.Collections.Generic;

class Comment
{
    private string commenterName;
    private string text;

    public Comment(string name, string text)
    {
        this.commenterName = name;
        this.text = text;
    }

    public string GetName()
    {
        return commenterName;
    }

    public string GetText()
    {
        return text;
    }
}

class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
        }

        Console.WriteLine();
    }
}

class VideoManager
{
    private List<Video> videos = new List<Video>();

    public void AddVideo(Video video)
    {
        videos.Add(video);
    }

    public List<Video> GetAllVideos()
    {
        return videos;
    }

    public void DisplayAllVideos()
    {
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        VideoManager manager = new VideoManager();

        Video video1 = new Video("Learning C#", "Alice", 600);
        video1.AddComment(new Comment("Bob", "Great tutorial!"));
        video1.AddComment(new Comment("Charlie", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Diana", "I learned a lot!"));
        manager.AddVideo(video1);

        Video video2 = new Video("OOP Basics", "John", 720);
        video2.AddComment(new Comment("Eve", "Clear and concise."));
        video2.AddComment(new Comment("Frank", "Can you make more videos like this?"));
        manager.AddVideo(video2);

        Video video3 = new Video("Design Patterns Intro", "Sarah", 900);
        video3.AddComment(new Comment("Grace", "This was amazing!"));
        video3.AddComment(new Comment("Heidi", "Excited for the next one."));
        video3.AddComment(new Comment("Ivan", "Very informative."));
        video3.AddComment(new Comment("Judy", "Thanks for sharing!"));
        manager.AddVideo(video3);

        manager.DisplayAllVideos();
    }
}