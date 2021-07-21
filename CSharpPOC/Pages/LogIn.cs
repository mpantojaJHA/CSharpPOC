using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace CSharpPOC.Pages
{
    public class LogIn
    {
        IPage Page;
        public LogIn(IPage page) => Page = page;

        string txtUserName => "[placeholder=\"Enter User Name\"]";
        string txtPassword => "[aria-label=\"Password\"]";
        string btnSubmit => "button:has-text(\"Sign in\")";
        string lnkInstName => "text=Ovation Bank";
        string lnkLogOff => "text=Sign Out";
        string txtDashboard => "text=Dashboard";
        //string dashboardSelector => "#content > div.shuffle-animation.ng-scope > div.px-relative-position.ng-scope > div > div";

        public async Task LoginFPS(string userName, string password)
        {
           // await Page.TypeAsync(txtUserName, userName);
           // await Page.TypeAsync(txtPassword, password);

            await Page.FillAsync(txtUserName, userName);
            await Page.FillAsync(txtPassword, password);
        }

        public async Task ClickLogin()
        {
            
            await Page.ClickAsync(btnSubmit);
              

        }

        public async Task<string> IsLogOffExist()
        {
            
            return await Page.TextContentAsync(lnkInstName);

        }


        public async Task ClickInstitutionName() => await Page.ClickAsync(lnkInstName);
        public async Task ClickSignOut() => await Page.ClickAsync(lnkLogOff);

    }



}
