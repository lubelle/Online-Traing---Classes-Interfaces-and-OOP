using System;

namespace PropertyDemo
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Vote { get; private set; }

        public Post(int vote)
        {
            Vote = vote;
        }
        public void UpVote()
        {
            Vote += 1;
        }
        public void DownVote()
        {
            if (Vote >= 1)
                Vote -= 1;
        }
    }
}
