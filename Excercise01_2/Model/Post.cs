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

        Post()
        {
            this._vote = 0;
        }

        public long Id { get => _id; set => _id = value; }
        public long Vote { get => _vote;}
        public string Username { get => _username; set => _username = value; }
        public string Content { get => _content; set => _content = value; }

        public bool VoteUp()
        {
            this._vote = this._vote++;
            return true;
        }
        public bool VoteDown()
        {
            this._vote = this._vote--;
            return true;
        }

    }
}
