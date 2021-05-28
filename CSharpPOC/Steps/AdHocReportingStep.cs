using NUnit.Framework;
using PlaywrightSharp;
using CSharpPOC.Base;
using CSharpPOC.Hooks;
using CSharpPOC.Pages;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CSharpPOC.Steps
{
    [Binding]
    class AdHocReportingStep
    {
        Context Context;
        LogIn login = null;
        LogOff logOff = null;
        NavigatePages navigate = null;
        AdHocReporting adHoc = null;

        public AdHocReportingStep (Context context)
        {
            Context = context;
            login = new LogIn(Context.Page);
            logOff = new LogOff(Context.Page);
            navigate = new NavigatePages(Context.Page);
            adHoc = new AdHocReporting(Context.Page);
        }
        [Given(@"I click Reporting")]
        public async Task GivenIClickReporting()
        {
            await navigate.ClickReporting();
        }

        [Given(@"I Click the Ad Hoc Reporting menu item")]
        public async Task GivenIClickTheAdHocReportingMenuItem()
        {
            await navigate.ClickAdHoc();
        }
                

        [When(@"I click on the Refresh Button")]
        public async Task  WhenIClickOnTheRefreshButton()
        {
            await adHoc.ClickRefreshButon();
        }

        [Then(@"The page will begin a Refresh")]
        public async Task ThenThePageWillBeginARefresh()
        {
            Assert.That(await adHoc.DoesTextExist("Refresh"), Is.EqualTo("Refresh is in progress.."));
        }

    }
}
