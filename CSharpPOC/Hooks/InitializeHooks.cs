using NUnit.Framework;
using PlaywrightSharp;
using CSharpPOC.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace CSharpPOC.Hooks
{

    [Binding]
    class InitializeHooks
    {
        Context Context;
        public InitializeHooks(Context context) => Context = context;


        [BeforeScenario]
        public async Task BeforeScenario()
        {

            PlaywrightDriver playwrightDriver = new PlaywrightDriver();

            LaunchOptions launchOptions = new LaunchOptions()
            {
                Headless = false,
                SlowMo = 500
            };
            Context.Page = await playwrightDriver.InitalizePlaywright(Base.Browser.Chromium, launchOptions);
          //  Context.Page = await playwrightDriver.InitalizePlaywright(Base.Browser.WebKit, launchOptions);

        }
    }
}