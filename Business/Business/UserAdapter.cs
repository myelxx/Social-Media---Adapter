using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Business
{
    public class UserAdapter : UserAction
    {
        private ProfileAction _profileDetails = new ProfileAction();

        public override User Display(User user)
        {
            _profileDetails.DisplaySpecificUser(user);
            return user;
        }

    }
}
