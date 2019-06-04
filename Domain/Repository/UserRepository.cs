using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Repository
{
    public class UserRepository
    {
        List <User> _userList = new List <User> ()
        {
            new User () { UserId = 1, Name = "Meji" },
            new User () { UserId = 2, Name = "Teya"},
            new User () { UserId = 3, Name = "Je-an"}
        };


        public User DisplaySpecificUser(User user)
        {
            User specific_user = _userList.FirstOrDefault(e => e.UserId == user.UserId);

            if (specific_user != null)
            {
                return user;
            }

            return null;
        }



    }
}
