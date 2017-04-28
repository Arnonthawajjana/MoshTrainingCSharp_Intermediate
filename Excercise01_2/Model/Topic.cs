using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01_2.Model
{
    class Topic
    {
        private long _id;
        private String _topicName;
        private List<Post> _postList;

        Topic()
        {
            this._postList = new List<Post>();
        }

        public long Id { get => _id; set => _id = value; }
        public string TopicName { get => _topicName; set => _topicName = value; }
        public List<Post> PostList { get => _postList; }
        public bool AddPost(Post postItem)
        {
            return true;
        }

        public bool UpdatePost(Post postItem)
        {
            return true;
        }

        public bool DeletePost(long id)
        {
            return true;
        }


    }
}
