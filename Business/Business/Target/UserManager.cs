using Domain.Entity;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Business
{
    public class UserManager : User
    {
        List<User> userList;
        private UserRepository _userRepo = new UserRepository(); //SINGLETON
        public UserRepository GetUserRepo()
        {
            if (_userRepo == null)
            {
                this._userRepo = new UserRepository();
            }

            return this._userRepo;
        }

        public virtual void Display()
        {
            userList = GetUserRepo().View();
            foreach (var item in userList)
                Console.WriteLine("User {0} ----", item.Name);
            //return user;
        }

        public bool UserValidate(User user)
        {
            if (!_userRepo.IsUserExist(user))
            {
                Console.WriteLine("Already existed");
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

        public void isUserExist(User user)
        {
            var user_exist = GetUserRepo().IsUserExist(user);
            if (user_exist)
            {
                //
            }
        }

    }
}
