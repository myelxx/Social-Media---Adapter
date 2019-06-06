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
            //user adapter
            User user = new User();
            string username = "Danifer";

            //UserManager _profile = new UserAdapter(username);
            //_profile.Display();

            #region Json
            //Non-adapted
            //UserManager userlist = new UserManager();
            //userlist.Display(user);

            //UserManager _showUser = new UserAdapter();
            //_showUser.ShowUser(); 
            #endregion

            #region Post Test Demo
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
            #endregion

            #region User Test Demo
            UserRepository userRepo = new UserRepository();

            Console.WriteLine("User ID: ");
            Guid user_id = userRepo.GetId();
            Console.WriteLine(user_id);

            Console.WriteLine("User Created: ");
            string new_created_at = DateTime.Now.ToString();
            Console.WriteLine(new_created_at);

            Console.WriteLine("Enter Username: ");
            string insert_username = Console.ReadLine();

            Console.WriteLine("Enter Name: ");
            string insert_name = Console.ReadLine();

            UserManager userManager = new UserManager();
            var insert_post = new User()
            {
                UserId = user_id,
                Username = insert_username,
                Name = insert_name
            };

            var isValid = userManager.UserValidate(insert_post);

            if (isValid)
            {
                userRepo.Add(insert_post);

            }

            userRepo.View();
            #endregion
        }
    }
}
