using System.Collections.Generic;
public class Video
{
    public string Title {get; set; }
    public string Author {get; set; }
    public int LengthInSeconds {get; set; }
    private List<Comment> Comments {get; set; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
    public List<Comment> GetComments()
    {
        return Comments;
    }
}