using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPOC.Pages
{
    public class LogOff
    {
        IPage Page;
        public LogOff(IPage page) => Page = page;

        string lnkInstName => "text=Ovation Bank";
        string lnkLogOff => "text=Sign Out";
        
        
        
        public async Task ClickInstitutionName() => await Page.ClickAsync(lnkInstName);
        public async Task ClickSignOut() => await Page.ClickAsync(lnkLogOff);

       


    }
}
