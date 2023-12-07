class PostArchive
{
    private static PostArchive instance;
    private Stack<Post> posts;

    private PostArchive()
    {
        posts = new Stack<Post>();
    }

    public static PostArchive Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new PostArchive();
            }
            return instance;
        }
    }

    public void AddPost(Post post)
    {
        posts.Push(post);
    }

    public void PrintAllPosts()
    {
        foreach (var post in posts)
        {
            post.PrintPostDetails();
        }
    }

    public void RemovePost()
    {
        if (posts.Count > 0)
        {
            Post currPost = posts.Pop();
            Console.WriteLine("Post {0} removed", currPost.GetTitle());
        }
        else
        {
            Console.WriteLine("No posts to remove.");
        }
    }
}