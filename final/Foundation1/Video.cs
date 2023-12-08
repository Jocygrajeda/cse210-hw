
using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int LengthSeconds { get; }
    private List<Comment> Comments { get; }

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
        Comments = new List<Comment>();
    }

    //method to add a comment
    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName, commentText);
        Comments.Add(newComment);
    }

    //method to get the number of comments
    public int GetNumComments()
    {
        return Comments.Count;
    }

    //method to get list of comments
    public IReadOnlyList<Comment> GetComments()
    {
        return Comments.AsReadOnly();
    }

    //method to display video information
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumComments()}");

        Console.WriteLine("Comments:");
        foreach (Comment comment in Comments)
        {
            Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
        }

        Console.WriteLine("\n");
    }
}
