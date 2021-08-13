using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using NUnit.Framework;

namespace FPSPagAndUserJourney
{

    [TestFixture]
    public class CECLModelSelection
    {
        [Test]
        public async Task CECLModelSel()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();
            // Open new page
            var page = await context.NewPageAsync();
            // Go to https://qafour.profitstarsfps.com/
            await page.GotoAsync("https://qafour.profitstarsfps.com/");
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
            // Assert.Equal("https://qafour.profitstarsfps.com/#/dashboard", UrlString);
            // Click text=SETUP
            await page.ClickAsync("text=SETUP");
            // Click :nth-match(:text("CECL"), 2)
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.ClickAsync(":nth-match(:text(\"CECL\"), 2)");
            }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://qafour.profitstarsfps.com/#/ceclSetup?userSelection=%7B%7D"
        }*/);
            // Click jha-function-breadcrumbs div:has-text("Setup CECL Recovery Rates Credit Rating Codes Model Selection")
            await page.Frame("FpsAngularAppFrame").ClickAsync("jha-function-breadcrumbs div:has-text(\"Setup CECL Recovery Rates Credit Rating Codes Model Selection\")");
            // Click jha-function-breadcrumbs div:has-text("Setup CECL Recovery Rates Credit Rating Codes Model Selection")
            await page.Frame("FpsAngularAppFrame").ClickAsync("jha-function-breadcrumbs div:has-text(\"Setup CECL Recovery Rates Credit Rating Codes Model Selection\")");
            // Click h1[role="heading"]:has-text("Recovery Rates")
            await page.Frame("FpsAngularAppFrame").ClickAsync("h1[role=\"heading\"]:has-text(\"Recovery Rates\")");
            // Click jha-function-breadcrumbs div:has-text("Setup CECL Recovery Rates Credit Rating Codes Model Selection")
            await page.Frame("FpsAngularAppFrame").ClickAsync("jha-function-breadcrumbs div:has-text(\"Setup CECL Recovery Rates Credit Rating Codes Model Selection\")");
            // Click jha-function-breadcrumbs div:has-text("Setup CECL Recovery Rates Credit Rating Codes Model Selection")
            await page.Frame("FpsAngularAppFrame").ClickAsync("jha-function-breadcrumbs div:has-text(\"Setup CECL Recovery Rates Credit Rating Codes Model Selection\")");
            // Double click jha-function-breadcrumbs div:has-text("Setup CECL Recovery Rates Credit Rating Codes Model Selection")
            await page.Frame("FpsAngularAppFrame").DblClickAsync("jha-function-breadcrumbs div:has-text(\"Setup CECL Recovery Rates Credit Rating Codes Model Selection\")");
            // Click jha-function-breadcrumbs div:has-text("Setup CECL Recovery Rates Credit Rating Codes Model Selection")
            //await page.Frame("FpsAngularAppFrame").ClickAsync("jha-function-breadcrumbs div:has-text(\"Setup CECL Recovery Rates Credit Rating Codes Model Selection\")", new FrameClickOptions
            //{
            //    Button = MouseButton.Right,
            //});

           
            // Click text=Setup CECL
            await page.Frame("FpsAngularAppFrame").ClickAsync("text=Setup CECL");
            // Click text=Model Selection
            await page.Frame("FpsAngularAppFrame").ClickAsync("text=Model Selection");
            // Assert.Equal("https://qafour.profitstarsfps.com/#/ceclSetupModelSelection?userSelection=%7B%7D", page.Url);
            // Click input[type="text"]
            await page.Frame("FpsAngularAppFrame").ClickAsync("input[type=\"text\"]");
            // Click button
            await page.Frame("FpsAngularAppFrame").ClickAsync("button");
            // Click text=Jan
            await page.Frame("FpsAngularAppFrame").ClickAsync("text=Jan");
            // Click button
            await page.Frame("FpsAngularAppFrame").ClickAsync("button");
            // Click text=2019 Jan Feb Mar Apr May Jun Jul Aug Sep Oct Nov Dec >> button
            await page.Frame("FpsAngularAppFrame").ClickAsync("[class='p-monthpicker ng-tns-c174-1 ng-star-inserted'] > [ng-reflect-ng-class='[object Object]']:nth-child(1)");
            // Click :nth-match(button, 3)
            await page.Frame("FpsAngularAppFrame").ClickAsync(":nth-match(button, 3)");
            // Click text=Feb
            await page.Frame("FpsAngularAppFrame").ClickAsync("text=Feb");
            // Click text=Comm & Industrial LoanAdvanced PD >> div[role="button"]
            await page.Frame("FpsAngularAppFrame").ClickAsync("text=Comm & Industrial LoanAdvanced PD >> div[role=\"button\"]");
            // Click [aria-label="Roll Rate"]
            await page.Frame("FpsAngularAppFrame").ClickAsync("[aria-label=\"Roll Rate\"]");
            // Click .ag-row.ag-row-no-focus.ag-row-even.ag-row-level-0.ag-row-position-absolute.ag-row-hover .ag-cell.ag-cell-not-inline-editing.ag-cell-auto-height.ag-cell-value.ag-column-hover fps-common-ag-grid-boolean-renderer .ag-grid-default-cell-height .ng-untouched
            await page.Frame("FpsAngularAppFrame").ClickAsync(".ag-row.ag-row-no-focus.ag-row-even.ag-row-level-0.ag-row-position-absolute.ag-row-hover .ag-cell.ag-cell-not-inline-editing.ag-cell-auto-height.ag-cell-value.ag-column-hover fps-common-ag-grid-boolean-renderer .ag-grid-default-cell-height .ng-untouched");
            // Click .ag-row.ag-row-even.ag-row-level-0.ag-row-position-absolute.ag-row-hover .ag-cell.ag-cell-not-inline-editing.ag-cell-auto-height.ag-cell-value.ag-column-hover fps-common-ag-grid-boolean-renderer .ag-grid-default-cell-height .ng-untouched
            await page.Frame("FpsAngularAppFrame").ClickAsync(".ag-row.ag-row-even.ag-row-level-0.ag-row-position-absolute.ag-row-hover .ag-cell.ag-cell-not-inline-editing.ag-cell-auto-height.ag-cell-value.ag-column-hover fps-common-ag-grid-boolean-renderer .ag-grid-default-cell-height .ng-untouched");
            // Click text=Comm & Industrial LoanRoll Rate >> div[role="button"]
            await page.Frame("FpsAngularAppFrame").ClickAsync("text=Comm & Industrial LoanRoll Rate >> div[role=\"button\"]");
            // Click [aria-label="Advanced PD"] >> text=Advanced PD
            await page.Frame("FpsAngularAppFrame").ClickAsync("[aria-label=\"Advanced PD\"] >> text=Advanced PD");
            // Click button:has-text("Save")
            await page.Frame("FpsAngularAppFrame").ClickAsync("button:has-text(\"Save\")");
            // Click text=Ovation Bank
            await page.ClickAsync("text=Ovation Bank");
            // Click text=Sign Out
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.ClickAsync("text=Sign Out");
            }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://qafour.profitstarsfps.com/Account/SignedOut"
        }*/);
        }
    }
}

