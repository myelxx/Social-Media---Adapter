using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    public class UserRepository
    {
        Guid new_user_id = Guid.NewGuid();
        
        List <User> _userList = new List <User> ()
        {
            new User () { UserId = Guid.NewGuid(), Username = "Meji", Name = "Meji" },
            new User () { UserId = Guid.NewGuid(), Username = "Je-an", Name = "Danifer" }
        };

        public Guid GetId()
        {
            return new_user_id;
        }

        public User DisplaySpecificUser(string name)
        {
            User specific_user = _userList.First(u => u.Name == name);

            if (specific_user != null)
            {
                Console.WriteLine("#####################################");
                Console.WriteLine("USER PROFILE");
                Console.WriteLine("User Name: {0} \nName: {1}", specific_user.Username, specific_user.Name);
                Console.WriteLine("#####################################");
                Console.WriteLine();
                return specific_user;
            }

            return null;
        }

        public User Add(User user)
        {
            _userList.Add(user);
            return user;
        }

        public bool IsUserExist(User user)
        {
            User user_exist = _userList.FirstOrDefault(u => u.Username.ToLower() == user.Username.ToLower());

            if (user_exist != null)
            {
                return false;

            }
            return true;
        }
        public User Delete(Guid id)
        {
            User user = _userList.First(u => u.UserId == id);

            if (user != null)
            {
                _userList.Remove(user);
            }

            return user;
        }

        public User Edit(User user)
        {
            User edituser = _userList.First(u => u.UserId == user.UserId );

            if (edituser != null)
            {
                user.Username = edituser.Username;

            }
            return user;

        }

        public List<User> View()
        {
            //Console.WriteLine("#####################################");
            //foreach (var p in _userList)
            //{
            //    Console.WriteLine(" User: {0} ", p.Name);
            //}
            //Console.WriteLine("#####################################");
            return _userList;
        }

    }
}
