using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Playwright;
using System.Threading.Tasks;
using NUnit.Framework;


namespace FPSPagAndUserJourney
{
    [TestFixture]
    public class TryAssumptionsServices
    {

        [Test]
        public async Task Main()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 500
            });
            var context = await browser.NewContextAsync();
            // Open new page
            var page = await context.NewPageAsync();
            // Go to https://login.microsoftonline.com/ProfitStarsFPSDev.onmicrosoft.com/oauth2/authorize?client_id=bb2a2e3a-c5e7-4f0a-88e0-8e01fd3fc1f4&redirect_uri=https%3a%2f%2fprofitstarsfpsdev.b2clogin.com%2fprofitstarsfpsdev.onmicrosoft.com%2foauth2%2fauthresp&response_type=id_token&scope=email+openid&response_mode=query&nonce=EcVqTsZFH7J43q37mFfhUQ%3d%3d&nux=1&nca=1&domain_hint=ProfitStarsFPSDev.onmicrosoft.com&mkt=en-US&lc=1033&state=StateProperties%3deyJTSUQiOiJ4LW1zLWNwaW0tcmM6NWU1ZGFjNDItY2NjMy00ODNkLTg3ZTktZDRjMzFhNjkxNmMyIiwiVElEIjoiZTJhM2IxZjEtOGMxOC00ZGU1LWFkMjQtNTY2Yjk1ZmM1YzhlIiwiVE9JRCI6IjYzYzZlZDlkLWNjNjktNGViOS05MmE3LWYwNjZkYThmZGFjOSJ9
            await page.GotoAsync("https://qafour.profitstarsfps.com");
            // Click [placeholder="Enter User Name"]
            await page.ClickAsync("[placeholder=\"Enter User Name\"]");
            // Fill [placeholder="Enter User Name"]
            await page.FillAsync("[placeholder=\"Enter User Name\"]", "mpantoja");
            // Press Tab
            await page.PressAsync("[placeholder=\"Enter User Name\"]", "Tab");
            // Fill [aria-label="Password"]
            await page.FillAsync("[aria-label=\"Password\"]", "Kiara$$$");
            // Press Enter
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.PressAsync("[aria-label=\"Password\"]", "Enter");
            }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://qafour.profitstarsfps.com/#/dashboard"
        }*/);
            // Click text=SETUP
            await page.ClickAsync("text=SETUP");
            // Click text=Assumptions
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.ClickAsync("text=Assumptions");
            }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://qafour.profitstarsfps.com/#/assumptionsLoanApplications?path=%5B2%5D&userSelection=%7B%7D"
        }*/);
            // Click text=Setup Assumptions
            await page.Frame("FpsAngularAppFrame").ClickAsync("text=Setup Assumptions");
            // Click text=Service Applications
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.Frame("FpsAngularAppFrame").ClickAsync("text=Service Applications");
            }/*, new FrameWaitForNavigationOptions
        {
            UrlString = "https://qafour.profitstarsfps.com/#/assumptionsServiceApplications?path=%5B2%5D&userSelection=%7B%7D"
        }*/);
            // Click .ag-row.ag-row-no-focus.ag-row-even.ag-row-level-0.ag-row-position-absolute.ag-row-first .ag-cell fps-common-ag-grid-string-renderer .ag-grid-default-cell-height .form-control
            await page.Frame("FpsAngularAppFrame").ClickAsync(".ag-row.ag-row-no-focus.ag-row-even.ag-row-level-0.ag-row-position-absolute.ag-row-first .ag-cell fps-common-ag-grid-string-renderer .ag-grid-default-cell-height .form-control");
            // Press Tab
            await page.Frame("FpsAngularAppFrame").PressAsync(".ag-cell.ag-cell-not-inline-editing.ag-cell-auto-height.ag-cell-last-left-pinned.ag-cell-value.ag-column-hover.ag-cell-focus fps-common-ag-grid-string-renderer .ag-grid-default-cell-height .form-control", "Tab");
            // Press Tab with modifiers
            await page.Frame("FpsAngularAppFrame").PressAsync(".p-inputwrapper-filled.ng-untouched.ng-pristine.ng-valid.p-inputwrapper-focus .p-inputnumber .form-control", "Shift+Tab");
            // Fill .form-control.jha-text-input.ng-pristine.ng-valid.ng-touched
            await page.Frame("FpsAngularAppFrame").FillAsync(".form-control.jha-text-input.ng-pristine.ng-valid.ng-touched", "BTest");
            

            await page.Frame("FpsAngularAppFrame").FillAsync("div:nth-of-type(1) > fps-common-ag-grid-numeric-renderer  .ng-pristine.ng-touched.ng-valid.p-inputwrapper-filled  .form-control.jha-text-input-right.p-component.p-filled.p-inputnumber-input.p-inputtext", "5.00");
            await page.Frame("FpsAngularAppFrame").FillAsync("div:nth-of-type(1) > fps-common-ag-grid-numeric-renderer  .ng-pristine.ng-touched.ng-valid.p-inputwrapper-filled  .form-control.jha-text-input-right.p-component.p-filled.p-inputnumber-input.p-inputtext", "5.00");

             await page.Keyboard.PressAsync("Enter");

            await page.Frame("FpsAngularAppFrame").PressAsync(".ng-dirty.ng-touched.ng-valid.p-inputwrapper-filled  .form-control.jha-text-input-right.p-component.p-filled.p-inputnumber-input.p-inputtext", "Tab");

          // await page.Frame("FpsAngularAppFrame").FillAsync("div:nth-of-type(1) > div:nth-of-type(2) > fps-common-ag-grid-numeric-renderer  .ng-pristine.ng-untouched.ng-valid.p-inputwrapper-filled  .form-control.jha-text-input-right.p-component.p-filled.p-inputnumber-input.p-inputtext", "8.45");
           
          await page.Frame("FpsAngularAppFrame").FillAsync("#agGrid_ServiceApplications > div > div.ag-root-wrapper-body.ag-layout-normal.ag-focus-managed > div.ag-root.ag-unselectable.ag-layout-normal > div.ag-body-viewport.ag-layout-normal.ag-row-no-animation > div.ag-center-cols-clipper > div > div > div.ag-row.ag-row-even.ag-row-level-0.ag-row-position-absolute.ag-row-first.ag-row-focus > div.ag-cell.ag-cell-not-inline-editing.ag-cell-auto-height.ag-cell-value.ag-cell-focus > fps-common-ag-grid-numeric-renderer > div > p-inputnumber > span > input ", "8.45");
            //---------------------------------------------------------------------
            //save
            await page.Frame("FpsAngularAppFrame").ClickAsync("button:has-text(\"Save\")");
            //change back
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.ClickAsync("img");
            }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://qafour.profitstarsfps.com/#/dashboard"
        }*/);
            // Click text=SETUP
            await page.ClickAsync("text=SETUP");
            // Click text=Assumptions
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.ClickAsync("text=Assumptions");
            }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://qafour.profitstarsfps.com/#/assumptionsLoanApplications?path=%5B2%5D&userSelection=%7B%7D"
        }*/);
            // Click text=Setup Assumptions
            await page.Frame("FpsAngularAppFrame").ClickAsync("text=Setup Assumptions");
            // Click text=Service Applications
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.Frame("FpsAngularAppFrame").ClickAsync("text=Service Applications");
            }/*, new FrameWaitForNavigationOptions
        {
            UrlString = "https://qafour.profitstarsfps.com/#/assumptionsServiceApplications?path=%5B2%5D&userSelection=%7B%7D"
        }*/);

            // Click .ag-row.ag-row-no-focus.ag-row-even.ag-row-level-0.ag-row-position-absolute.ag-row-first .ag-cell fps-common-ag-grid-string-renderer .ag-grid-default-cell-height .form-control
            // await page.Frame("FpsAngularAppFrame").ClickAsync(".ag-row.ag-row-no-focus.ag-row-even.ag-row-level-0.ag-row-position-absolute.ag-row-first .ag-cell fps-common-ag-grid-string-renderer .ag-grid-default-cell-height .form-control");
            await page.Frame("FpsAngularAppFrame").ClickAsync(".ag-row.ag-row-no-focus.ag-row-even.ag-row-level-0.ag-row-position-absolute.ag-row-first .ag-cell fps-common-ag-grid-string-renderer .ag-grid-default-cell-height .form-control");
            // Press Tab
            await page.Frame("FpsAngularAppFrame").PressAsync(".ag-cell.ag-cell-not-inline-editing.ag-cell-auto-height.ag-cell-last-left-pinned.ag-cell-value.ag-column-hover.ag-cell-focus fps-common-ag-grid-string-renderer .ag-grid-default-cell-height .form-control", "Tab");
            // Press Tab with modifiers
            await page.Frame("FpsAngularAppFrame").PressAsync(".p-inputwrapper-filled.ng-untouched.ng-pristine.ng-valid.p-inputwrapper-focus .p-inputnumber .form-control", "Shift+Tab");
            // Fill .form-control.jha-text-input.ng-pristine.ng-valid.ng-touched
            await page.Frame("FpsAngularAppFrame").FillAsync(".form-control.jha-text-input.ng-pristine.ng-valid.ng-touched", "Business Credit Card");


            await page.Frame("FpsAngularAppFrame").FillAsync("div:nth-of-type(1) > fps-common-ag-grid-numeric-renderer  .ng-pristine.ng-touched.ng-valid.p-inputwrapper-filled  .form-control.jha-text-input-right.p-component.p-filled.p-inputnumber-input.p-inputtext", "0.00");
            await page.Frame("FpsAngularAppFrame").FillAsync("div:nth-of-type(1) > fps-common-ag-grid-numeric-renderer  .ng-pristine.ng-touched.ng-valid.p-inputwrapper-filled  .form-control.jha-text-input-right.p-component.p-filled.p-inputnumber-input.p-inputtext", "0.00");

            await page.Keyboard.PressAsync("Enter");

            await page.Frame("FpsAngularAppFrame").PressAsync(".ng-dirty.ng-touched.ng-valid.p-inputwrapper-filled  .form-control.jha-text-input-right.p-component.p-filled.p-inputnumber-input.p-inputtext", "Tab");

           // await page.Frame("FpsAngularAppFrame").FillAsync("div:nth-of-type(1) > div:nth-of-type(2) > fps-common-ag-grid-numeric-renderer  .ng-pristine.ng-untouched.ng-valid.p-inputwrapper-filled  .form-control.jha-text-input-right.p-component.p-filled.p-inputnumber-input.p-inputtext", "0.00");

            await page.Frame("FpsAngularAppFrame").FillAsync("#agGrid_ServiceApplications > div > div.ag-root-wrapper-body.ag-layout-normal.ag-focus-managed > div.ag-root.ag-unselectable.ag-layout-normal > div.ag-body-viewport.ag-layout-normal.ag-row-no-animation > div.ag-center-cols-clipper > div > div > div.ag-row.ag-row-even.ag-row-level-0.ag-row-position-absolute.ag-row-first.ag-row-focus > div.ag-cell.ag-cell-not-inline-editing.ag-cell-auto-height.ag-cell-value.ag-cell-focus > fps-common-ag-grid-numeric-renderer > div > p-inputnumber > span > input ", "0.00");

            await page.Frame("FpsAngularAppFrame").ClickAsync("button:has-text(\"Save\")");


            //--------------------------------------------------------------------------
            // Press Tab
            //await page.Frame("FpsAngularAppFrame").PressAsync(".p-inputwrapper-filled.ng-untouched.ng-pristine.ng-valid.p-inputwrapper-focus .p-inputnumber .form-control", "Tab");
            // Click button:has-text("Cancel")
     //       await page.Frame("FpsAngularAppFrame").ClickAsync("button:has-text(\"Cancel\")");

     //       await page.Keyboard.PressAsync("Enter");
            // Click img
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.ClickAsync("img");
            }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://qafour.profitstarsfps.com/#/dashboard"
        }*/);
            // Click a:has-text("Ovation Bank")
            await page.ClickAsync("a:has-text(\"Ovation Bank\")");
            // Click text=Sign Out
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.ClickAsync("text=Sign Out");
            }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://qafour.profitstarsfps.com/Account/SignedOut"
        }*/);
            // Assert.Equal("https://profitstarsfpsdev.b2clogin.com/profitstarsfpsdev.onmicrosoft.com/b2c_1_jha.signin/oauth2/v2.0/logout?post_logout_redirect_uri=https%3A%2F%2Fqafour.profitstarsfps.com%2Fsignout-callback-oidc&state=CfDJ8P_MIwzQA-RAicp2Y--OjnsckHnHEwvNIt7Pl0UZPsXQYFlyPxP9jNcqXaeEOreAc1MXgtg0gPPeAUYdUoOZmcTqphgTW0IO-Pmu60Z9vBas7AfCFN6jbLY2OFVQtU_ItAHH0cCk_GAEhLhN7l7ctMbEOZXjaSEIxNQ-DIHQp9aw&x-client-SKU=ID_NETSTANDARD2_0&x-client-ver=6.8.0.0", page.Url);
        }

    }
}