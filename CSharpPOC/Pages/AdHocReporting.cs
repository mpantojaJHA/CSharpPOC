using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaywrightSharp;

namespace CSharpPOC.Pages
{
    class AdHocReporting
    {
        IPage Page;
        public AdHocReporting(IPage page) => Page = page;

        string txtRefreshBtn => "span:has-text(\"Refresh All\")";


        public async Task ClickRefreshButon() => await Page.ClickAsync(txtRefreshBtn);

        public async Task<string> DoesTextExist(string txtPage)
        {
            var txtelPage = txtPage;


            switch (txtelPage)
            {
                case "Refresh":
                    return await Page.QuerySelectorAsync("text=Refresh is in progress..").Result.GetInnerTextAsync();
                default:
                    return await Page.QuerySelectorAsync("No text found").Result.GetInnerTextAsync();
            }

        }



    }
}