using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;


namespace CSharpPOC
{


    public class FilterTests
        {


    [Test]
    public async Task FilterSmokeTest()
    {
        
        using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 500,
            });
            var context = await browser.NewContextAsync();

        // Open new page
        var page = await context.NewPageAsync();

        
        await page.GotoAsync("https:qafour.profitstarsfps.com");
        // Click [placeholder="Enter User Name"]
        await page.ClickAsync("[placeholder=\"Enter User Name\"]");

        // Fill [placeholder="Enter User Name"]
        await page.FillAsync("[placeholder=\"Enter User Name\"]", "mpantoja");

        // Press Tab
        await page.PressAsync("[placeholder=\"Enter User Name\"]", "Tab");

        // Fill [aria-label="Password"]
        await page.FillAsync("[aria-label=\"Password\"]", "Kiara$$$");

        // Press Enter
        await Task.WhenAll(
            page.WaitForNavigationAsync(/*"https://qafour.profitstarsfps.com/"*/),
            page.PressAsync("[aria-label=\"Password\"]", "Enter"));

            // Go to https://qafour.profitstarsfps.com/#/home
            await page.GotoAsync("https://qafour.profitstarsfps.com/#/home");

            // Go to https://qafour.profitstarsfps.com/#/dashboard
            await page.GotoAsync("https://qafour.profitstarsfps.com/#/dashboard");

        // Click text=PROFITABILITY
        await Task.WhenAll(
            page.WaitForNavigationAsync(/*"https://qafour.profitstarsfps.com/#/profitabilityLandingPage/relationship"*/),
            page.ClickAsync("text=PROFITABILITY"));

        // Click text=Relationships
        await page.ClickAsync("text=Relationships");

        // Click [placeholder="Select"]
        await page.ClickAsync("[placeholder=\"Select\"]");

        // Click #viewsrelationshipsPopoverButton
        await page.ClickAsync("#viewsrelationshipsPopoverButton");

        // Click text=My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> :nth-match(i, 2)
        await page.ClickAsync("span:nth-child(2) .px-vertical-middle");

        // Click text=Filters
        await page.ClickAsync("text=Filters");

        // Click text=× Close
        await page.ClickAsync("text=× Close");
            await page.ClickAsync("text=× Close");

            // Click text = My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> :nth - match(i, 2)
            await page.ClickAsync("span:nth-child(2) .px-vertical-middle");

            // Click text=Filters
            await page.ClickAsync("text=Filters");

            // Click button:has-text("Cancel")
              await page.ClickAsync("button:has-text(\"Cancel\")");

            // Click text = My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> :nth - match(i, 2)
            await page.ClickAsync("span:nth-child(2) .px-vertical-middle");

            // Press ArrowDown
            await page.PressAsync("[placeholder='Select Column']", "ArrowDown");

            // Press ArrowDown
            await page.PressAsync("[placeholder=\"Select Column\"]", "ArrowDown");
            // Press Tab
            await page.PressAsync("[placeholder=\"Select Column\"]", "Tab");
            // Press ArrowDown
            await page.PressAsync("[placeholder=\"Select Filter\"]", "ArrowDown");
            await page.PressAsync("[placeholder=\"Select Filter\"]", "ArrowDown");
            await page.PressAsync("[placeholder=\"Select Filter\"]", "ArrowDown");

            // Press Tab
            await page.PressAsync("[placeholder=\"Select Filter\"]", "Tab");
            // Fill input[name="numericInputFilterDetailInputField"]
            await page.FillAsync("input[name=\"numericInputFilterDetailInputField\"]", "1");
            // Click button:has-text("Apply")
            await page.ClickAsync("button:has-text(\"Apply\")");
            // Assert.Equal("https://qafour.profitstarsfps.com/#/profitabilityLandingPage/relationship?viewData=%7B%22dataDictionary%22:%7B%22relationships%22:%22%7B%5C%220%5C%22:0,%5C%221%5C%22:%5C%22relationshipName%5C%22,%5C%222%5C%22:%5B%5C%22loans%5C%5Cb3%5C%5Cb1%5C%5Cb2%5C%5Cb1%5C%5CbLoans%20%3D%20$1.00%5C%22%5D,%5C%223%5C%22:%5B%5C%22profit%5C%5Cbdesc%5C%22%5D,%5C%224%5C%22:%5C%2224240%5C%5Cb24240%5C%5CbJan%202020%5C%22,%5C%225%5C%22:0,%5C%226%5C%22:1%7D%22%7D,%22viewID%22:%22relationships%22%7D", page.Url);

            // Click text=My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> i
            await page.ClickAsync("#actionsrelationships span span span");
            // Click input[name="saveAsDialogInputInputField"]
            await page.ClickAsync("input[name=\"saveAsDialogInputInputField\"]");
            // Fill input[name="saveAsDialogInputInputField"]
            await page.FillAsync("input[name=\"saveAsDialogInputInputField\"]", "TestMatt");
            // Click text=OK
            await page.ClickAsync("text=OK");
            // Click #viewsrelationshipsPopoverButton
            await page.ClickAsync("#viewsrelationshipsPopoverButton");
            // Click #viewsrelationshipsPopoverButton
            await page.ClickAsync("#viewsrelationshipsPopoverButton");
            // Click text=My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> :nth-match(i, 2)
            await page.ClickAsync("span:nth-child(2) .px-vertical-middle");
            // Click text=Yes
            await page.ClickAsync("text=Yes");


            // Click img
            await page.ClickAsync("img");
            // Assert.Equal("https://qafour.profitstarsfps.com/#/dashboard", page.Url);

            // Click a:has-text("Ovation Bank")
            await page.ClickAsync("a:has-text(\"Ovation Bank\")");

        // Click text=Sign Out
        await page.ClickAsync("text=Sign Out");

            // Go to https://qafour.profitstarsfps.com/Account/SignedOut
            await page.GotoAsync("https://qafour.profitstarsfps.com/Account/SignedOut");
    }

}
}
