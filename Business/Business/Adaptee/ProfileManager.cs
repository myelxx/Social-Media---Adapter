using Domain.Entity;
using Repository.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Business
{
    public class ProfileManager : UserAdapter
    {
        
        public void DisplaySpecificUser(string name)
        {
            GetUserRepo().DisplaySpecificUser(name);
        }

    }
}
