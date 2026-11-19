public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int LikeCount { get; set; }
    public string[] Comments { get; set; }
    public bool IsPublished { get; set; }

    public Post(string t, string d)
    {
        Title = t;
        Description = d;
    }

    public void Publish()
    {
        System.Console.WriteLine("The post is published.");
        IsPublished = true;
    }

    public void Like()
    {
        LikeCount++;
    }

    public void Comment(string message)
    {
        Comments = message;
    }
}
