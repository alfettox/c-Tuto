class Post
{
    private string Title;
    private string Description;
    private DateTime creationDateTime;
    private int vote = 0;

    public void SetTitle(string title)
    {
        this.Title = title;
    }

    public string GetTitle()
    {
        return this.Title;
    }

    public void SetDescription(string description)
    {
        this.Description = description;
    }

    public void UpVote()
    {
        this.vote++;
    }

    public void DownVote()
    {
        this.vote--;
    }

    public void PrintPostDetails()
    {
        Console.WriteLine(this.Title);
        Console.WriteLine(this.Description);
        Console.WriteLine(this.creationDateTime.ToString("yyyy-MM-dd HH:mm:ss"));
        Console.WriteLine("LIKES " + this.vote + "\n");
    }
}