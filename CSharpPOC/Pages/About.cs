using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PlaywrightSharp;


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
                    return await Page.GetFrame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtAppName).Result.GetInnerTextAsync();
                case "Copyright":
                     return await Page.GetFrame(name: "FpsAngularAppFrame").QuerySelectorAsync(cpyRighttxt).Result.GetInnerTextAsync();
                  
                case "Build":
                    return await Page.GetFrame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtBuildNbr).Result.GetInnerTextAsync();
                case "Trademark":
                    return await Page.GetFrame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtTrademark).Result.GetInnerTextAsync();
                case "Terms":
                    return await Page.GetFrame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtTerms).Result.GetInnerTextAsync();
                case "Privacy":
                    return await Page.GetFrame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtPrivacy).Result.GetInnerTextAsync();
                
                default:
                    return await Page.QuerySelectorAsync("No Domain found").Result.GetInnerTextAsync();
            }

            
        }
       
        public async Task ClickInstDropDown() => await Page.ClickAsync(txtInstNameDropDn);
        public async Task ClickAbout() => await Page.ClickAsync(txtAbout);

        public async Task ClickTrademark ()
        {
            var page1Task = Page.WaitForEventAsync(PageEvent.Popup);
            await Task.WhenAll(
            page1Task,
           Page.GetFrame(name: "FpsAngularAppFrame").ClickAsync("text=Trademark Notice"));

            page1Task.Dispose();

        }

        public async Task ClickTerms()
        {
            var page2Task = Page.WaitForEventAsync(PageEvent.Popup);
            await Task.WhenAll(
                 page2Task,
                Page.GetFrame(name: "FpsAngularAppFrame").ClickAsync("text=Terms & Conditions"));
            // Close page
             page2Task.Dispose();


        }

        public async Task ClickPrivacy()
        {
            var page3Task = Page.WaitForEventAsync(PageEvent.Popup);
            await Task.WhenAll(
             page3Task,
            Page.GetFrame(name: "FpsAngularAppFrame").ClickAsync("text=Privacy Policy"));
            // Close page
            page3Task.Dispose();


        }

    }
       

  
}
