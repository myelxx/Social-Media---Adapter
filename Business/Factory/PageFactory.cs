using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;

namespace Business.Factory
{
    //concrete creator
    public class PageFactory : Factory
    {
        public override Page CreatePage(string choice)
        {
            switch (choice)
            {
                case "A":
                    return new BusinessPage();
                case "B":
                    return new AcademicPage();
                default:
                    return null;
            }
        }



    }

    public class AcademicPage : Page
    {
        public override void DisplayPageDetails()
        {
            Console.WriteLine("This page shares academic stuff");
        }

    }

    public class BusinessPage : Page
    {
        public override void DisplayPageDetails()
        {
            Console.WriteLine("This page shares business stuff");
        }
    }
}
