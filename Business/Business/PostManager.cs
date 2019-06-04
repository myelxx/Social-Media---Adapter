using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Business
{
    public class PostManager 
    {
        public bool PostValidate(Post post)
        {
            ICollection<ValidationResult> validationResult;

            bool valid = GenericValidator.TryValidate(post, out validationResult);
            if (!valid)
            {
                foreach (ValidationResult res in validationResult)
                {
                    Console.WriteLine(res.ErrorMessage);
                    return false;
                }
            }

            return true;
        }
    }
}
