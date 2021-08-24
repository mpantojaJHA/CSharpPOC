
using Microsoft.Playwright;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CSharpPOC.Pages;

namespace CSharpPOC.Pages
{
    class helperShared
    {

        IPage Page;
        public helperShared(IPage page) => Page = page;




    }
}
