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
        public int UpVote()
        {
            return Vote += 1;
        }
        public int DownVote()
        {
            if (Vote >= 1)
                Vote -= 1;

            return Vote;
        }
    }
}
