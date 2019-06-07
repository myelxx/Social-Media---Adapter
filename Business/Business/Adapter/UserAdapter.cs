using Business.Business;
using Domain.Entity;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Business
{
    public class UserAdapter : UserManager, IUser
    {
        private ProfileManager  _profile = new ProfileManager();
        public UserAdapter(string name = "")
        {
            Name = name;
        }

       
        public override void Display()
        {
            _profile.DisplaySpecificUser(Name);
            //return user;
        }


    }
}
