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

        public bool UserValidate(User user)
        {
            if (!_userRepo.IsUserExist(user))
            {
                //use validator data annotation 
                ICollection<ValidationResult> validationResult;

                bool valid = GenericValidator.TryValidate(user, out validationResult);
                if (!valid)
                {
                    foreach (ValidationResult res in validationResult)
                    {
                        Console.WriteLine(res.ErrorMessage);
                        return false;
                    }
                }
            }

            return true;
        }

        public virtual void Display()
        {
            userList = _userRepo.View();
            foreach(var item in userList)
            Console.WriteLine("User {0} ----", item.Name);

            //return user;
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
