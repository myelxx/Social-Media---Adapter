using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Page
    {
        public string PageName { get; set; }

        public int PageId { get; set; }

        public string Created_At { get; set; }

        public virtual void DisplayPageDetails()
        {
            Console.WriteLine("Welcome to my page!");
        }

    }
}
