using Domain.Entity;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Business
{
    public class UserManager : User
    {
        UserRepository _userRepo = new UserRepository();
        List<User> userList;
        public virtual User Display(User user)
        {
            return user;
        }

        public virtual List<User> ShowUser()
        {
            userList = _userRepo.View();

            Console.WriteLine("#####################################");
            foreach (var item in userList)
            {
                Console.WriteLine(" user Id: {0} \n username: {1} ", item.UserId, item.Username);
            }
            Console.WriteLine("#####################################");

            return userList;
        }
    }
}
