using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    public class PageRepository
    {
        List<Page> _pageList = new List<Page>()
        {
            new Page () { PageName = "Tutorials Point", PageId = 1, Created_At = "", PageType = ""},
        };

        public void DisplayValues(Page page)
        {
            Console.WriteLine(" Page Id: {0} \n Page Name: {1} ", page.PageId, page.PageName);
        }

        public bool Add(Page page)
        {
            _pageList.Add(page);
            return true;
        }

        public Page Delete(int id)
        {
            Page page = _pageList.First(p => p.PageId == id);

            if (page != null)
            {
                _pageList.Remove(page);
            }

            return page;
        }

        public Page Edit(Page page)
        {
            Page editPage = _pageList.First(p => p.PageId == page.PageId);

            if (editPage != null)
            {
                page.PageName = editPage.PageName;

            }

            return page;
        }

        public List<Page> View()
        {
            return _pageList;
        }
    }
}
