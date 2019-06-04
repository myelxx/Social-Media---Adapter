using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Repository
{
    public class PostRepository
    {
        Guid new_post_id = Guid.NewGuid();

        List<Post> _postList = new List<Post>()
        {
            new Post () { PostDetails = "HAHAHAHAHA", PostId = Guid.NewGuid(), Created_At = ""},
        };

        public Guid GetId()
        {
            //int post_id = _postList.Max(p => p.PostId) + 1;
            return new_post_id;
        }

        public Post Add(Post post)
        {
            //post.PostId = _postList.Max(p => p.PostId) + 1;
            _postList.Add(post);
            return post;
        }

        public Post Delete(Guid id)
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

        public void View()
        {
            Console.WriteLine("#####################################");
            foreach (var p in _postList)
            {
                Console.WriteLine(" Post Id: {0} \n Post Details: {1} ", p.PostId, p.PostDetails);
            }
            Console.WriteLine("#####################################");
        }

    }
}
