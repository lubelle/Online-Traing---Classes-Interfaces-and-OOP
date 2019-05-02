using System;

namespace PropertyDemo
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; private set; }
        public int Vote { get; private set; }

        public Post()
        {
            Created = DateTime.Now;
            Vote = 0;
        }
        public void UpVote()
        {
            Vote += 1;
        }
        public void DownVote()
        {
            if (Vote > 0)
                Vote -= 1;
        }
    }
}
