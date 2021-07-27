
using NUnit.Framework;
using Microsoft.Playwright;
using System;
using CSharpPOC.Pages;
using CSharpPOC.Hooks;
using System.Threading.Tasks;

namespace CSharpPOC
{


    class CECLSetupRecord
    {
        
        [Test]
        public async Task NavigateToCECLRecorveryRates()
        {
            

            using var playwright = await Playwright.CreateAsync();
           
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();
            // Open new page
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://qafour.profitstarsfps.com");
         //   await page.GoToAsync("https://qafour.profitstarsfps.com");
            // Click [placeholder="Enter User Name"]
            await page.ClickAsync("[placeholder=\"Enter User Name\"]");
            // Fill [placeholder="Enter User Name"]
            await page.FillAsync("[placeholder=\"Enter User Name\"]", "mpantoja");
                       // Press Tab
            await page.PressAsync("[placeholder=\"Enter User Name\"]", "Tab");
            // Fill [aria-label="Password"]
            await page.FillAsync("[aria-label=\"Password\"]", "Kiara$$$");
            // Click button:has-text("Sign in")
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.ClickAsync("button:has-text(\"Sign in\")");
            }/*, new PageWaitForNavigationOptions
        {
            UrlString = "https://qafour.profitstarsfps.com/#/dashboard"
        }*/);
            // Assert.Equal("https://profitstarsfpsdev.b2clogin.com/profitstarsfpsdev.onmicrosoft.com/oauth2/authresp?id_token=eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Im5PbzNaRHJPRFhFSzFqS1doWHNsSFJfS1hFZyIsImtpZCI6Im5PbzNaRHJPRFhFSzFqS1doWHNsSFJfS1hFZyJ9.eyJhdWQiOiJiYjJhMmUzYS1jNWU3LTRmMGEtODhlMC04ZTAxZmQzZmMxZjQiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC82M2M2ZWQ5ZC1jYzY5LTRlYjktOTJhNy1mMDY2ZGE4ZmRhYzkvIiwiaWF0IjoxNjI2Nzg4MDkzLCJuYmYiOjE2MjY3ODgwOTMsImV4cCI6MTYyNjc5MTk5MywiYW1yIjpbInB3ZCJdLCJmYW1pbHlfbmFtZSI6IlBhbnRvamEiLCJnaXZlbl9uYW1lIjoiTWF0dCIsImlwYWRkciI6IjIwLjk3LjIuNzEiLCJuYW1lIjoiTWF0dCBQYW50b2phIiwibm9uY2UiOiJhWjI3Q05WcU9ndllsMnpwdkxXM1h3PT0iLCJvaWQiOiI4YWZjMjI3Yy05NmVkLTQ5MTEtYTk2Ni02NDM5MTEwOTVmYzAiLCJwdWlkIjoiMTAwM0JGRkQ5N0U3RDVGRSIsInJoIjoiMC5BWFlBbmUzR1kybk11VTZTcF9CbTJvX2F5VG91S3J2bnhRcFBpT0NPQWYwX3dmUjJBSncuIiwic3ViIjoiay12T1MyNUFZQVdqVDdJZWdPOE8tQURLZlRCNUxWVUJoNWVTd3ZxRXEtTSIsInRpZCI6IjYzYzZlZDlkLWNjNjktNGViOS05MmE3LWYwNjZkYThmZGFjOSIsInVuaXF1ZV9uYW1lIjoibXBhbnRvamEjRVhUI0BQcm9maXRTdGFyc0ZQU0Rldi5vbm1pY3Jvc29mdC5jb20iLCJ1cG4iOiJtcGFudG9qYSNFWFQjQFByb2ZpdFN0YXJzRlBTRGV2Lm9ubWljcm9zb2Z0LmNvbSIsInV0aSI6IjlpWWlDVF9GUVVLbE1nMXZNT3RSQXciLCJ2ZXIiOiIxLjAifQ.GL7QkfdiBakTvOBYgvOil6mRmfQycpZTHe5_0AnOiVd5iOU9LtG1TBU3KU4r22x9jicxc16AYe8Vp46kmvPcWIONhfRJdSrVRhmlnVGkFY_j1tbSCUnBJ-2vcAnUSckpFizZa_Kpl0RQnTc2EeVgFjMgcQsN54g4tWcjFk9YchGZD0Hw66VXNd_lJZHdix7zVO6pbBWtXPpMvdtuEeyff_q33B-3UNI5gRGj5B03Jd8jQdCFuWCxGX-Mp0-7Q0RMuLpt6j5jT4FvnGICIxtteQ38tg7AN6cmM_dn2l4pUQB6t99JVRBGw43GM7gl7XcC27hFAULA0EA5RdUc-mAYpw&state=StateProperties%3deyJTSUQiOiJ4LW1zLWNwaW0tcmM6NzcyMjJhMjktZGM4MC00ZTBhLTg0YmUtYzk3ODViNzc3ZTdhIiwiVElEIjoiMmNiYmIxOGYtOGU0ZS00NjE4LTk3MTgtYjViODk4NDZmOGNiIiwiVE9JRCI6IjYzYzZlZDlkLWNjNjktNGViOS05MmE3LWYwNjZkYThmZGFjOSJ9&session_state=e4e07811-1572-44ef-9238-fc60d0919257#", page.Url);
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
            // Click text=Setup CECL
            await page.Frame("FpsAngularAppFrame").ClickAsync("text=Setup CECL");
            // Click h1[role="heading"]:has-text("Recovery Rates")
            await page.Frame("FpsAngularAppFrame").ClickAsync("h1[role=\"heading\"]:has-text(\"Recovery Rates\")");
            // Click text=Setup CECL Recovery Rates Credit Rating Codes Model Selection Recovery Rates
            await page.Frame("FpsAngularAppFrame").ClickAsync("text=Setup CECL Recovery Rates Credit Rating Codes Model Selection Recovery Rates");
            // Click text=Setup CECL Recovery Rates Credit Rating Codes Model Selection Recovery Rates
            await page.Frame("FpsAngularAppFrame").ClickAsync("text=Setup CECL Recovery Rates Credit Rating Codes Model Selection Recovery Rates");
            // Click text=Setup CECL
            await page.Frame("FpsAngularAppFrame").ClickAsync("text=Setup CECL", new FrameClickOptions
            {
                Button = MouseButton.Right,
            });
            // Go to https://qafour.profitstarsfps.com/#/logout
            await page.GotoAsync("https://qafour.profitstarsfps.com/#/logout");

            // Go to https://qafour.profitstarsfps.com/Account/SignedOut
            await page.GotoAsync("https://qafour.profitstarsfps.com/Account/SignedOut");
        }
    }
}