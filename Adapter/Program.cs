using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Business.Business;
using Domain.Business;
using Domain.Entity;
using Domain.Repository;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {


            //post test
            // PostRepository post = new PostRepository();

            // Console.WriteLine("Post ID: ");
            // Guid post_id = post.GetId();
            // Console.WriteLine(post_id);

            // Console.WriteLine("Post Created: ");
            // string new_created_at = DateTime.Now.ToString();
            // Console.WriteLine(new_created_at);

            // Console.WriteLine("Enter Post Details: ");
            // string post_details = Console.ReadLine();

            // PostManager postManager = new PostManager();
            // var insert_post = new Post() {
            //     PostId = post_id,
            //     PostDetails = post_details
            // };

            //var isValid  = postManager.PostValidate(insert_post);

            // if (isValid)
            // {
            //    post.Add(insert_post);

            // }

            // post.View()

            //user adapter
            User user = new User();
            UserManager _profile = new UserAdapter("Danifer");
            _profile.Display(user);

            Console.WriteLine();

            UserManager _showUser = new UserAdapter();
            _showUser.ShowUser();

        }
    }
}
