using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Business
{
    public interface IUser
    {
        User Display(User user);
        List<User> ShowUser();
    }
}
