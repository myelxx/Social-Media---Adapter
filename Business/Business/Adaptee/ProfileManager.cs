using Domain.Entity;
using Domain.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Business
{
    public class ProfileManager
    {
        private UserRepository _userRepo = new UserRepository();

        public void DisplaySpecificUser(string name)
        {
            _userRepo.DisplaySpecificUser(name);
        }

        public string UserListJSON()
        {
           string json_userlist = JsonConvert.SerializeObject(_userRepo.View());
           Console.WriteLine(json_userlist);
           return json_userlist;
        }
    }
}
