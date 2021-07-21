using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;


namespace CSharpPOC.Pages
{
    class About
    {
        IPage Page;
        public About(IPage page) => Page = page;

        string txtAbout => "text=About";
        string txtInstNameDropDn => "text=Ovation Bank";
        string txtAppName => "text=ProfitStars Financial Performance Suite";
        string appNameSelector => "//html/body/fps-app-root/jha-app/div/div/div/div[3]/fps-app-about/fps-common-function-view/jha-function-view/div/section/div/div/jha-display-block/div/div[1]/span";
        string cpyRighttxt => "text=Copyright © 2021 ProfitStars ®";
        string txtBuildNbr => "//html[1]/body[1]/fps-app-root[1]/jha-app[1]/div[1]/div[1]/div[1]/div[3]/fps-app-about[1]/fps-common-function-view[1]/jha-function-view[1]/div[1]/section[1]/div[1]/div[1]/jha-display-block[1]/div[1]/div[2]/p[2]";
        string txtTrademark => "text=Trademark Notice";
        string txtTerms => "text=Terms & Conditions";
        string txtPrivacy = "text=Privacy Policy";

        public async Task<string> DoesElementExist(string txtPage)
        {
            var txtelementPage = txtPage;


            switch (txtelementPage)
            {
                case "ProfitStars Financial Performance Suite":
                    return await Page.Frame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtAppName).Result.InnerTextAsync();
                case "Copyright":
                     return await Page.Frame(name: "FpsAngularAppFrame").QuerySelectorAsync(cpyRighttxt).Result.InnerTextAsync();
                  
                case "Build":
                    return await Page.Frame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtBuildNbr).Result.InnerTextAsync();
                case "Trademark":
                    return await Page.Frame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtTrademark).Result.InnerTextAsync();
                case "Terms":
                    return await Page.Frame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtTerms).Result.InnerTextAsync();
                case "Privacy":
                    return await Page.Frame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtPrivacy).Result.InnerTextAsync();
                
                default:
                    return await Page.QuerySelectorAsync("No Domain found").Result.InnerTextAsync();
            }

            
        }
       
        public async Task ClickInstDropDown() => await Page.ClickAsync(txtInstNameDropDn);
        public async Task ClickAbout() => await Page.ClickAsync(txtAbout);

        public async Task ClickTrademark ()
        {
           // var page1Task = Page.WaitForEventAsync(PageEvent.Popup);
           var page1Task = await Page.RunAndWaitForPopupAsync(async () =>
           {
               await Page.Frame("FpsAngularAppFrame").ClickAsync("text=Trademark Notice");
           });


            await page1Task.CloseAsync();

        }

        public async Task ClickTerms()
        {
            var page2Task = await Page.RunAndWaitForPopupAsync(async () =>
            {
                await Page.Frame("FpsAngularAppFrame").ClickAsync("text=Terms & Conditions");
            });

            await page2Task.CloseAsync();


        }

        public async Task ClickPrivacy()
        {
            var page3Task = await Page.RunAndWaitForPopupAsync(async () =>
            {
                await Page.Frame("FpsAngularAppFrame").ClickAsync("text=Privacy Policy");
            });
            // Close page
            await page3Task.CloseAsync();


        }

    }
       

  
}
