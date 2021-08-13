using NUnit.Framework;
using System;
using System.Threading.Tasks;
using Microsoft.Playwright;



namespace FPSPagAndUserJourney
{
    class SmokeReporting
    {

        


    [Test]
        public async Task DecileSummaryCPP()
        {
            
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 500,
            });
            var context = await browser.NewContextAsync();
            //// Open new page
            var page = await context.NewPageAsync();
            
            await page.GotoAsync("https://qafour.profitstarsfps.com");
           // await login.LoginFPS("DMLTest12", "Kiara%%%");

            //// Click [placeholder="Enter User Name"]
          await page.ClickAsync("[placeholder=\"Enter User Name\"]");
           //Fill [placeholder="Enter User Name"]
           await page.FillAsync("[placeholder=\"Enter User Name\"]", "mpantoja");
          //  Press Tab
          await page.PressAsync("[placeholder=\"Enter User Name\"]", "Tab");
            //// Fill [aria-label="Password"]
            await page.FillAsync("[aria-label=\"Password\"]", "Kiara$$$");
            //Press Enter
            await Task.WhenAll(
               page.WaitForNavigationAsync(/*"https://qafour.profitstarsfps.com/"*/),
               page.PressAsync("[aria-label=\"Password\"]", "Enter"));
            
            await page.GotoAsync("https://qasp.profitstarsfps.com/#/home");



            // Go to https://qafour.profitstarsfps.com/#/dashboard
            await page.GotoAsync("https://qafour.profitstarsfps.com/#/dashboard");
            // Click text=REPORTING
            await page.ClickAsync("text=REPORTING");
            // Click text=Create Reports
            await Task.WhenAll(
                page.WaitForNavigationAsync(/*"https://qafour.profitstarsfps.com/#/createReports?userSelection=%7B%229%22:29,%2223%22:0%7D"*/),
                page.ClickAsync("text=Create Reports"));
            // Click input[type="text"]
            await page.ClickAsync("input[type=\"text\"]");
            // Fill input[type="text"]
            await page.FillAsync("input[type=\"text\"]", "Decile Summary");
            // Click text=Decile Summary
            // Press Enter
            await page.PressAsync("input[type=\"text\"]", "Enter");
            // Assert.Equal("https://qafour.profitstarsfps.com/#/createReports?userSelection=%7B%229%22:49,%2223%22:0%7D", page.Url);
            // Fill input[name="_Option1"]
            // await page.FillAsync("input[name=\"_Option1\"]", "1");
            // Click input[name="_Option1"]
            await page.ClickAsync("input[name=\"_Option1\"]");
            // Click text=PDF
            await page.ClickAsync("text=PDF");
            // Click text=Generate
            await page.ClickAsync("text=Generate");
            // Click text=View Reports
            await page.ClickAsync("text=View Reports");
            // Assert.Equal("https://qafour.profitstarsfps.com/#/viewReports", page.Url);
            // Click text=Decile Summary PDF04/20/2021 8:16 PM 1 Selected >> span
            await page.WaitForSelectorAsync("// html / body / div[2] / div[1] / div / section / div[2] / div[2] / div / div / div[3] / form / div / div / div[3] / table / tbody / tr / td[1] / div / div / span");
           
           // await page.ClickAsync("text=Decile Summary PDF04/20/2021 8:16 PM 1 Selected >> span");
           // Click td[role="gridcell"] span
            await page.ClickAsync("td[role=\"gridcell\"] span");
            // Click text=Delete
            await page.ClickAsync("text=Delete");
            // Click text=Yes
            await page.ClickAsync("text=Yes");
            // Click text=Create Reports
            await Task.WhenAll(
                page.WaitForNavigationAsync(/*"https://qafour.profitstarsfps.com/#/createReports?userSelection=%7B%229%22:29,%2223%22:0%7D"*/),
                page.ClickAsync("text=Create Reports"));
            // Assert.Equal("https://qafour.profitstarsfps.com/#/createReports?userSelection=%7B%7D", page.Url);
            // ---------------------

        }
        [Test]
        public async Task CustRankingFavorite()
        {
            //Context Context;
            //LogIn login = null;
            //LogOff logOff = null;

            //public LogInSteps(Context context)
            //{
            //    Context = context;
            //    login = new LogIn(Context.Page);
            //    logOff = new LogOff(Context.Page);
            //}
            //await login.LoginFPS("DMLTest12", "Kiara%%%");



            string baseNameFavRep = "AAA BB Fav ";

            string dateappend = DateTime.Now.ToString();
            string dateappend1 = dateappend.Replace("/", "");
            string dateappend2 = dateappend1.Replace(":", "");
            string faveAppendName = baseNameFavRep + dateappend2;


            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 500,

            });
        
            var context = await browser.NewContextAsync();
            //// Open new page
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://qafour.profitstarsfps.com");
            

            //// Click [placeholder="Enter User Name"]
            await page.ClickAsync("[placeholder=\"Enter User Name\"]");
            //Fill [placeholder="Enter User Name"]
            await page.FillAsync("[placeholder=\"Enter User Name\"]", "mpantoja");
            //  Press Tab
            await page.PressAsync("[placeholder=\"Enter User Name\"]", "Tab");
            //// Fill [aria-label="Password"]
            await page.FillAsync("[aria-label=\"Password\"]", "Kiara$$$" +
                "");
            //Press Enter
            await Task.WhenAll(
               page.WaitForNavigationAsync(/*"https://qafour.profitstarsfps.com/"*/),
               page.PressAsync("[aria-label=\"Password\"]", "Enter"));
            
            await page.GotoAsync("https://qafour.profitstarsfps.com/#/home");

            await page.GotoAsync("https://qafour.profitstarsfps.com/#/dashboard");
            // Click text=REPORTING
            await page.ClickAsync("text=REPORTING");
            // Click text=Create Reports
            await Task.WhenAll(
                page.WaitForNavigationAsync(/*"https://qafour.profitstarsfps.com/#/createReports?userSelection=%7B%229%22:29,%2223%22:0%7D"*/),
                page.ClickAsync("text=Create Reports"));
            // Click input[type="text"]
            await page.ClickAsync("input[type=\"text\"]");
            // Fill input[type="text"]
            await page.FillAsync("input[type=\"text\"]", "Customer Ranking");
            // Press Enter
            await page.PressAsync("input[type=\"text\"]", "Enter");
            // Assert.Equal("https://qafour.profitstarsfps.com/#/createReports?userSelection=%7B%229%22:46,%2223%22:0%7D", page.Url);
            // Check input[name="Save as Favorite"]
            await page.CheckAsync("input[name=\"Save as Favorite\"]");
            // Click input[name="favoriteNameInputField"]
            await page.ClickAsync("input[name=\"favoriteNameInputField\"]");
            // Fill input[name="favoriteNameInputField"]
            await page.FillAsync("input[name=\"favoriteNameInputField\"]", faveAppendName);
            // Click text=Excel
            await page.ClickAsync("text=Excel");
            // Click text=Save
            await page.ClickAsync("text=Save");
            // Click text=Favorites
            await page.ClickAsync("text=Favorites");
            // Assert.Equal("https://qafour.profitstarsfps.com/#/createReports?userSelection=%7B%229%22:1,%2223%22:1%7D", page.Url);
            // Click #scrollCanvas

            await page.ClickAsync("text=View Reports");
            // Assert.Equal("https://qafour.profitstarsfps.com/#/viewReports", page.Url);
            // Click text=Create Reports
            await Task.WhenAll(
                page.WaitForNavigationAsync(/*"https://qafour.profitstarsfps.com/#/createReports?userSelection=%7B%229%22:29,%2223%22:0%7D"*/),
                page.ClickAsync("text=Create Reports"));
            // Assert.Equal("https://qafour.profitstarsfps.com/#/createReports?userSelection=%7B%7D", page.Url);
            // Click text=Favorites
            await page.ClickAsync("text=Favorites");
            // Assert.Equal("https://qafour.profitstarsfps.com/#/createReports?userSelection=%7B%229%22:1,%2223%22:1%7D", page.Url);
            // Click input[type="text"]
            await page.ClickAsync("input[type=\"text\"]");
            // Fill input[type="text"]
            await page.FillAsync("input[type=\"text\"]", faveAppendName);
            // Click text=AAA BB Fav 4212021 93938 PM
            await page.ClickAsync("text=" + faveAppendName);

            // below is just a sort of stub area until we can figure out the scroll canvas issue
            
            //  await page.FocusAsync("#delete4");

            // await page.QuerySelectorAllAsync("#delete3");
            // await page.GetAttributeAsync("delete3",);

            // await page.ClickAsync(clickX);
            // await page.GetAttributeAsync("#delete3",faveAppendName);
            
             //await page.ClickAsync("//*[@id='delete4']");

         // await page.ClickAsync("//div[@id='viewport']//div[@id='treeviewNode5']//span[@id='delete5']");

            //  < span id = "delete4" class="treeview-node-button fa fa-times" ng-style="{left: node.deleteButtonLeft, position: 'absolute'}" ng-click="vm.deleteNode($index)" ng-class="node.deleteButtonClass" style="left: 584px; position: absolute;">
            //          </span>

            //await page.ClickAsync("#delete3", force: true);

            // ---------------------





        }




    }
}
