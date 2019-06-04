using Domain.Entity;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Business
{
    public class ProfileAction 
    {
        private UserRepository _userRepo = new UserRepository();
        public void DisplaySpecificUser(User user)
        {
            _userRepo.DisplaySpecificUser(user);
        }
    }
}
