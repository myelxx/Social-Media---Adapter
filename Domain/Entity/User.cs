using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entity
{
    public class User : BaseClass
    {
        public string Name { get; set; }
        public string Username { get; set; }
    }
}
