using Domain.Entity;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Factory
{
    public class PageManager : Page
    {
        PageRepository _pageRepo = new PageRepository();
        public void AddNewPage(string page_name, string page_type)
        {
            Page page = new Page()
            {
                PageName = page_name,
                Created_At = DateTime.Now.ToString(),
                PageType = page_type,
                PageId = _pageRepo.View().Count
            };

            bool isAdded = _pageRepo.Add(page);
            if (isAdded)
            {
                PageFactory pageFactory = new PageFactory();
                var display_page = pageFactory.CreatePage(page_type);
                display_page.DisplayPageDetails();
            }
        }
    }
}
