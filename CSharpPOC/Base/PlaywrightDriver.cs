using PlaywrightSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPOC.Base
{
    public enum Browser
    {
        Chromium,
        Firefox,
        WebKit
    }



    public class PlaywrightDriver
    {
        public IPage Page { get; set; }
        public async Task<IPage> InitalizePlaywright(Browser browser, LaunchOptions launchOptions)
        {
            await Playwright.InstallAsync();
            var playwright = await Playwright.CreateAsync();

            IBrowser pBrowser = null;
            if (browser == Browser.Chromium)
                pBrowser = await playwright.Chromium.LaunchAsync(launchOptions);
            if (browser == Browser.Firefox)
                pBrowser = await playwright.Firefox.LaunchAsync(launchOptions);
            if (browser == Browser.WebKit)
                pBrowser = await playwright.Webkit.LaunchAsync(launchOptions);
            Page = await pBrowser.NewPageAsync();

            return Page;
        }

    }
}
