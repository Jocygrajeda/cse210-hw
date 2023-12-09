public class Comment
{
    //properties to store commenters name and comment text
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    public Comment(string commenterName, string commentText)//constructor
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}