using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Business.Business;
using Business.Factory;
using Domain.Business;
using Domain.Entity;
using Repository.Repository;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            #region display adapter

            //user adapter
            //convert behavior of display to specific user
            //string username = "Danifer";
            //UserManager _profile = new UserAdapter(username);
            //_profile.Display();

            //string username1 = "Meji";
            //UserManager _profile1 = new UserAdapter(username1);
            //_profile1.Display();

            #endregion

            #region Post Test Demo
            //post test
            PostRepository post = new PostRepository();

            Console.WriteLine("Post ID: ");
            string post_id = Console.ReadLine();

            Console.WriteLine("Post Created: ");
            string new_created_at = DateTime.Now.ToString();
            Console.WriteLine(new_created_at);

            Console.WriteLine("Enter Post Details: ");
            string post_details = Console.ReadLine();

            PostManager postManager = new PostManager();
            var insert_post = new Post()
            {
                PostId = Convert.ToInt32(post_id),
                PostDetails = post_details
            };

            var isValid = postManager.PostValidate(insert_post);

            if (isValid)
            {
                post.Add(insert_post);

            }
            #endregion

            #region User Test Demo
            //UserRepository userRepo = new UserRepository();

            //Console.WriteLine("User ID: ");
            //Guid user_id = userRepo.GetId();
            //Console.WriteLine(user_id);

            //Console.WriteLine("User Created: ");
            //string new_created_at1 = DateTime.Now.ToString();
            //Console.WriteLine(new_created_at1);

            //Console.WriteLine("Enter Username: ");
            //string insert_username = Console.ReadLine();

            //Console.WriteLine("Enter Name: ");
            //string insert_name = Console.ReadLine();

            //UserManager userManager = new UserManager();
            //var insert_user = new User()
            //{
            //    UserId = user_id,
            //    Username = insert_username,
            //    Name = insert_name
            //};

            //var isValid1 = userManager.UserValidate(insert_user);

            //if (isValid1)
            //{
            //    userRepo.Add(insert_user);

            //}

            //userRepo.View();
            #endregion

            //PROTOTYPE 
            // Perform a shallow copy of p1 and assign it to p2.
            Post p2 = insert_post.ShallowCopy();
            var insert_post2 = new Post()
            {
                PostId = p2.PostId+1,
                PostDetails = p2.PostDetails
            };
            post.Add(insert_post2);

            // Display values of p1, p2 
            Console.WriteLine("Original values of p1, p2:");
            Console.WriteLine("post 1 instance values: ");
            post.DisplayValues(insert_post);
            Console.WriteLine("cloned post instance values:");
            post.DisplayValues(insert_post2);

            //FACTORY CREATE PAGE
            PageFactory page_factory = new PageFactory();

            //Input string
            string input = "A";

            if (input != null)
            {
                Console.WriteLine("Successfully create");
                page_factory.CreatePage(input);
            }
            else
            {
                Console.WriteLine("Not valid page type");
            }
        }
    }
}
