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
            //adapter
            User user = new User()
            {
                UserId = 1,
                Name = "Meji"
            };

            UserAction _profileAction = new UserAdapter();
            var specific_user = _profileAction.Display(user);

            Console.WriteLine("#####################################");
            Console.WriteLine("USER PROFILE");
            Console.WriteLine("User Id: {0} \nName: {1}", specific_user.UserId, specific_user.Name);
            Console.WriteLine("#####################################");
            Console.WriteLine();

            //
            PostRepository post = new PostRepository();

            Console.WriteLine("Post ID: ");
            Guid post_id = post.GetId();
            Console.WriteLine(post_id);

            Console.WriteLine("Post Created: ");
            string new_created_at = DateTime.Now.ToString();
            Console.WriteLine(new_created_at);

            Console.WriteLine("Enter Post Details: ");
            string post_details = Console.ReadLine();

            PostManager postManager = new PostManager();
            var insert_post = new Post() {
                PostId = post_id,
                PostDetails = post_details
            };

           var isValid  = postManager.PostValidate(insert_post);

            if (isValid)
            {
               post.Add(insert_post);

            }

            post.View();
        }
    }
}
