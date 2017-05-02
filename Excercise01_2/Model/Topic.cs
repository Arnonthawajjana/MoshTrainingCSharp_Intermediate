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
        private Func<Post, Post, bool> CheckByID = (post, postItem) => post.Id == postItem.Id;

        public Topic()
        {
            _postList = new List<Post>();
        }
        // use ': this()' for call default constructor
        public Topic(String topicname) : this()
        {
            _topicName = topicname;
        }
        public Topic(long idtopic, String topicname) : this(topicname)
        {
            _id = idtopic;
        }

        public long Id { get => _id; set => _id = value; }
        public string TopicName { get => _topicName; set => _topicName = value; }
        public List<Post> PostList { get => _postList; }

        public bool AddPost(Post postItem)
        {
            if (_postList.Contains(postItem)) return false;
            _postList.Add(postItem);
            return true;
        }

        public bool UpdatePost(Post postItem)
        {
            if (!_postList.Exists(post =>CheckByID(post,postItem))) return false;
            var i = _postList.FindIndex(post => CheckByID(post, postItem));
            _postList[i] = postItem;
            return true;
        }

        public bool DeletePost(Post postItem)
        {
            if (!_postList.Exists(post => CheckByID(post, postItem))) return false;
            postItem = _postList.First(post => CheckByID(post, postItem));
            _postList.Remove(postItem);
            return true;
        }


    }
}
