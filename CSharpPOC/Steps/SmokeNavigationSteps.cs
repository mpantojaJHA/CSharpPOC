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
    class SmokeNavigationSteps
    {
        Context Context;
        LogIn login = null;
        LogOff logOff = null;
        NavigatePages navigate = null;

        public SmokeNavigationSteps(Context context)
        {
            Context = context;
            login = new LogIn(Context.Page);
            logOff = new LogOff(Context.Page);
            navigate = new NavigatePages(Context.Page);
        }

        [Given(@"I am on the Dashboard")]
        public async Task GivenIAmOnTheDashboard()
        {
            
            Assert.That(await navigate.DoesDashbardExist(), Is.EqualTo(" Dashboard"));
        }



        [Given(@"I click Profitability")]
        public async Task GivenIClickProfitability()
        {
            await navigate.ClickProfitability();
        }

        [Then(@"I am navigated to the Profitability page")]
        public async Task ThenIAmNavigatedToTheProfitabilityPage()
        {
            Assert.That(await navigate.DoesPageExist("Profitability"), Is.EqualTo("Profitability"));
            
        }

        [Then(@"I click the FPS Image")]
        public async Task ThenIClickTheFPSImage()
        {
            await navigate.NavToDashboard();
        }

        [Then(@"am navigated to the Dashboard")]
        public async Task ThenAmNavigatedToTheDashboard()
        {
            Assert.That(await navigate.DoesDashbardExist(), Is.EqualTo(" Dashboard"));
            
        }

        [Then(@"I click Pricing")]
        public async Task ThenIClickPricing()
        {
            await navigate.ClickPricing();
        }

        [When(@"I click submenu Pricing")]
        public async Task WhenIClickSubmenuPricing()
        {
            await navigate.ClickPricingSubmenu();
        }

        [Then(@"I am navigated to the Pricing Loans Page")]
        public async Task ThenIAmNavigatedToThePricingLoansPage()
        {
            Assert.That(await navigate.DoesPageExist("Pricing"), Is.EqualTo("Pricing"));
        }

        [Then(@"I click Forecasting")]
        public async Task ThenIClickForecasting()
        {
            await navigate.ClickForecasting();
        }

        [When(@"I click submenu Forecasting Detail")]
        public async Task WhenIClickSubmenuForecastingDetail()
        {
            await navigate.ClickForecatingDetail();
        }

        [Then(@"I am navigated to the Forecasting Detail Page")]
        public async Task ThenIAmNavigatedToTheForecastingDetailPage()
        {
            Assert.That(await navigate.DoesPageExist("Forecasting"), Is.EqualTo("Forecasting Detail"));
        }

        [Then(@"I click ALM")]
        public async Task ThenIClickALM()
        {
            await navigate.ClickALM();

        }

        [When(@"I click submenu EVE")]
        public async Task WhenIClickSubmenuEVE()
        {
            await navigate.ClickEVE();
        }

        [Then(@"I am navigated to the EVE Page")]
        public async Task ThenIAmNavigatedToTheEVEPage()
        {
            Assert.That(await navigate.DoesPageExist("ALM"), Is.EqualTo("EVE"));
        }

        [Then(@"I click CECL")]
        public async Task ThenIClickCECL()
        {
            await navigate.ClickCECL();
        }

        [Then(@"I am navigated to the CECL Summary Page")]
        public async Task ThenIAmNavigatedToTheCECLSummaryPage()
        {
            Assert.That(await navigate.DoesPageExist("CECL"), Is.EqualTo("CECL Summary"));
        }

        [Then(@"I click Scorecard")]
        public async Task ThenIClickScorecard()
        {
            await navigate.ClickScorecard();
        }

        [Then(@"I am navigated to the Scorecard Page")]
        public async Task ThenIAmNavigatedToTheScorecardPage()
        {
            Assert.That(await navigate.DoesPageExist("Scorecard"), Is.EqualTo("Scorecard"));
        }

        [Then(@"I click Reporting")]
        public async Task ThenIClickReporting()
        {
            await navigate.ClickReporting();
        }

        [When(@"I click submenu Create Reports")]
        public async Task WhenIClickSubmenuCreateReports()
        {
            await navigate.ClickCreateReports();
        }

        [Then(@"I am navigated to the Create Reports Page")]
        public async Task ThenIAmNavigatedToTheCreateReportsPage()
        {
            Assert.That(await navigate.DoesPageExist("Reporting"), Is.EqualTo("Create Reports"));
        }
            [Then(@"I click Update")]
        public async Task ThenIClickUpdate()
        {
                await navigate.ClickUpdate();
        }

        [When(@"I click submenu Monthly Update Process")]
        public async Task WhenIClickSubmenuMonthlyUpdateProcess()
        {
                await navigate.ClickMonthyUpdate();
        }

        [Then(@"I am navigated to the Monthly Update Page")]
        public async Task ThenIAmNavigatedToTheMonthlyUpdatePage()
        {
            Assert.That(await navigate.DoesPageExist("Update"), Is.EqualTo("Monthly Update Process"));
        }

                [Then(@"I click Setup")]
        public async Task ThenIClickSetup()
        {
            await navigate.ClickSetup();
        }

        [When(@"I click submenu Manage Users")]
        public async Task WhenIClickSubmenuManageUsers()
        {
            await navigate.ClickManageUsers();
        }

        [Then(@"I am navigated to the Manage Users Page")]
        public async Task ThenIAmNavigatedToTheManageUsersPage()
        {
            Assert.That(await navigate.DoesPageExist("Setup"), Is.EqualTo("Manage Users"));
        }

        

    }
}
