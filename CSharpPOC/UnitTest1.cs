using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaywrightSharp;


namespace CSharpPOC
{


    public class filterTests
        {


    [Test]
    public async Task FilterSmokeTest()
    {
        await Playwright.InstallAsync();
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(
            headless: false
            );
        var context = await browser.NewContextAsync();

        // Open new page
        var page = await context.NewPageAsync();

        // Go to https://login.microsoftonline.com/ProfitStarsFPSDev.onmicrosoft.com/oauth2/authorize?client_id=bb2a2e3a-c5e7-4f0a-88e0-8e01fd3fc1f4&redirect_uri=https%3a%2f%2fprofitstarsfpsdev.b2clogin.com%2fprofitstarsfpsdev.onmicrosoft.com%2foauth2%2fauthresp&response_type=id_token&scope=email+openid&response_mode=query&nonce=uJjE8eurbYQq08x%2bR39LVQ%3d%3d&nux=1&nca=1&domain_hint=ProfitStarsFPSDev.onmicrosoft.com&mkt=en-US&lc=1033&state=StateProperties%3deyJTSUQiOiJ4LW1zLWNwaW0tcmM6ZjZhNWE5ZjQtNzI0My00Y2E4LTliMGEtMzJkZTI1MzZhMDNhIiwiVElEIjoiMmFmMTQ4MmEtODk0MS00OTY0LTljYTMtY2E4Yzk2NTM2NWVhIiwiVE9JRCI6IjYzYzZlZDlkLWNjNjktNGViOS05MmE3LWYwNjZkYThmZGFjOSJ9
        await page.GoToAsync("https:qasp.profitstarsfps.com");
        // Click [placeholder="Enter User Name"]
        await page.ClickAsync("[placeholder=\"Enter User Name\"]");

        // Fill [placeholder="Enter User Name"]
        await page.FillAsync("[placeholder=\"Enter User Name\"]", "dmltest12");

        // Press Tab
        await page.PressAsync("[placeholder=\"Enter User Name\"]", "Tab");

        // Fill [aria-label="Password"]
        await page.FillAsync("[aria-label=\"Password\"]", "Kiara%%%");

        // Press Enter
        await Task.WhenAll(
            page.WaitForNavigationAsync(/*"https://qasp.profitstarsfps.com/"*/),
            page.PressAsync("[aria-label=\"Password\"]", "Enter"));
       
        // Go to https://qasp.profitstarsfps.com/#/home
        await page.GoToAsync("https://qasp.profitstarsfps.com/#/home");

        // Go to https://qasp.profitstarsfps.com/#/dashboard
        await page.GoToAsync("https://qasp.profitstarsfps.com/#/dashboard");

        // Click text=PROFITABILITY
        await Task.WhenAll(
            page.WaitForNavigationAsync(/*"https://qasp.profitstarsfps.com/#/profitabilityLandingPage/relationship"*/),
            page.ClickAsync("text=PROFITABILITY"));

        // Click text=Relationships
        await page.ClickAsync("text=Relationships");

        // Click [placeholder="Select"]
        await page.ClickAsync("[placeholder=\"Select\"]");

        // Click #viewsrelationshipsPopoverButton
        await page.ClickAsync("#viewsrelationshipsPopoverButton");

        // Click text=My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> :nth-match(i, 2)
        await page.ClickAsync("text=My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> :nth-match(i, 2)");

        // Click text=Filters
        await page.ClickAsync("text=Filters");

        // Click text=× Close
        await page.ClickAsync("text=× Close");
            await page.ClickAsync("text=× Close");

            // Click text = My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> :nth - match(i, 2)
            await page.ClickAsync("text=My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> :nth-match(i, 2)");

            // Click text=Filters
            await page.ClickAsync("text=Filters");

            // Click button:has-text("Cancel")
              await page.ClickAsync("button:has-text(\"Cancel\")");

            // Click text = My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> :nth - match(i, 2)
            await page.ClickAsync("text=My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> :nth-match(i, 2)");

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
            // Assert.Equal("https://qasp.profitstarsfps.com/#/profitabilityLandingPage/relationship?viewData=%7B%22dataDictionary%22:%7B%22relationships%22:%22%7B%5C%220%5C%22:0,%5C%221%5C%22:%5C%22relationshipName%5C%22,%5C%222%5C%22:%5B%5C%22loans%5C%5Cb3%5C%5Cb1%5C%5Cb2%5C%5Cb1%5C%5CbLoans%20%3D%20$1.00%5C%22%5D,%5C%223%5C%22:%5B%5C%22profit%5C%5Cbdesc%5C%22%5D,%5C%224%5C%22:%5C%2224240%5C%5Cb24240%5C%5CbJan%202020%5C%22,%5C%225%5C%22:0,%5C%226%5C%22:1%7D%22%7D,%22viewID%22:%22relationships%22%7D", page.Url);

            // Click text=My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> i
            await page.ClickAsync("text=My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> i");
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
            await page.ClickAsync("text=My Saved Views CSV Excel Jan 2020 Custom From 2020 Jan Feb Mar Apr May Jun Jul A >> :nth-match(i, 2)");
            // Click text=Yes
            await page.ClickAsync("text=Yes");


            // Click img
            await page.ClickAsync("img");
        // Assert.Equal("https://qasp.profitstarsfps.com/#/dashboard", page.Url);

        // Click a:has-text("Ovation Bank")
        await page.ClickAsync("a:has-text(\"Ovation Bank\")");

        // Click text=Sign Out
        await page.ClickAsync("text=Sign Out");
        // Assert.Equal("https://profitstarsfpsdev.b2clogin.com/profitstarsfpsdev.onmicrosoft.com/oauth2/v2.0/logout?p=b2c_1_jha.signin&post_logout_redirect_uri=https%3A%2F%2Fqasp.profitstarsfps.com%2FLogOut", page.Url);

        // Go to https://qasp.profitstarsfps.com/LogOut
        await page.GoToAsync("https://qasp.profitstarsfps.com/LogOut");
    }

}
}
