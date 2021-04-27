using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaywrightSharp;

namespace CSharpPOC.Pages
{
    public class LogIn
    {
        IPage Page;
        public LogIn(IPage page) => Page = page;

        string txtUserName => "[placeholder=\"Enter User Name\"]";
        string txtPassword => "[aria-label=\"Password\"]";
        string btnSubmit => "button:has-text(\"Sign in\")";

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
    }



}
