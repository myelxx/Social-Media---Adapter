using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Business
{
    public class UserAction : User
    {
        List<User> _userList;
        public virtual User Display(User user)
        {
            //Console.WriteLine("User: {0} {1}", UserId, Name);
            return user;
        }

    }
}
