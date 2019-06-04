using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Post : BaseClass
    {
        public Guid PostId { get; set; }

        [Required(ErrorMessage = "Post Details Required")]
        [MaxLength(240, ErrorMessage = "Post Details should not more than 240 character")]
        [MinLength(3, ErrorMessage = "Post Details should be more than 3 character")]
        public string PostDetails { get; set; }
    }
}
