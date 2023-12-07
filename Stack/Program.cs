using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        public static void Main(string[] args)
        {
            var postArchive = PostArchive.Instance;

            var post = new Post();
            post.SetTitle("New Post");
            post.SetDescription("This is the post content \nThis is a new line");
            post.UpVote();
            post.DownVote();

            postArchive.AddPost(post);

            var post2 = new Post();
            post2.SetTitle("New Post2");
            post2.SetDescription("This is the post content2 \nThis is a new line2");
            post2.UpVote();
            postArchive.AddPost(post2);

            postArchive.PrintAllPosts();

            postArchive.RemovePost();
            postArchive.RemovePost();
            postArchive.RemovePost();
        }
    }
}
