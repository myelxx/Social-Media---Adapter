using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Factory
{
    //Creator
    public abstract class Factory
    {
        public abstract Page CreatePage(string choice);
    }
}
