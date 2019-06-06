using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entity
{
    public class User : BaseClass
    {
        [Required(ErrorMessage = "Name Required")]
        [MaxLength(30, ErrorMessage = "Name should not more than 30 character")]
        [MinLength(1, ErrorMessage = "Name should be more than 1 character")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Username Required")]
        [MaxLength(30, ErrorMessage = "Username should not more than 30 character")]
        [MinLength(1, ErrorMessage = "Username should be more than 1 character")]
        public string Username { get; set; }
    }
}
