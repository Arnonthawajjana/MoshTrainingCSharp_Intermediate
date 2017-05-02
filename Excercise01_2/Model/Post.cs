using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01_2.Model
{
    class Post
    {
        private long _id;
        private long _vote;
        private String _username;
        private String _content;

        public Post()
        {
            _vote = 0;
        }
        public Post(long id,String username,String content):this()
        {
            _id = id;
            _username = username;
            _content = content;
        }

        public long Id { get => _id; set => _id = value; }
        public long Vote { get => _vote;}

        public string Username
        {
            get => _username;
            set
            {
                if (_username.Equals(String.Empty)) _username = value;
                else Console.WriteLine("Change username DENIED!!");
            }
        }
        public string Content { get => _content; set => _content = value; }

        public bool VoteUp()
        {
            _vote = _vote+1;
            return true;
        }
        public bool VoteDown()
        {
            _vote = _vote-1;
            return true;
        }

    }
}
