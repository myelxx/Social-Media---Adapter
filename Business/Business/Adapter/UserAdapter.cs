using Business.Business;
using Domain.Entity;
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
        public override User Display(User user)
        {
            _profile.DisplaySpecificUser(Name);
            return user;
        }

        public override List<User> ShowUser()
        {
            var userList = base.ShowUser();
            _profile.UserListJSON();
            return userList;
        }

    }
}
