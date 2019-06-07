using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    public class PostRepository
    {

        List<Post> _postList = new List<Post>()
        {
            new Post () { PostDetails = "I want to post something", PostId = 1, Created_At = ""},
        };

        public void DisplayValues(Post p)
        {
            Console.WriteLine(" Post Id: {0} \n Post Details: {1} ", p.PostId, p.PostDetails);
        }

        public Post Add(Post post)
        {
            _postList.Add(post);
            return post;
        }

        public Post Delete(int id)
        {
            Post post = _postList.First(p => p.PostId == id);

            if (post != null)
            {
                _postList.Remove(post);
            }

            return post;
        }

        public Post Edit(Post post)
        {
            Post editPost = _postList.First(p => p.PostId == post.PostId);

            if (editPost != null)
            {
                post.PostDetails = editPost.PostDetails;

            }

            return post;
        }

        public List<Post> View()
        {
            Console.WriteLine("#####################################");
            foreach (var p in _postList)
            {
                Console.WriteLine(" Post Id: {0} \n Post Details: {1} ", p.PostId, p.PostDetails);
            }
            Console.WriteLine("#####################################");

            return _postList;
        }

    }
}
