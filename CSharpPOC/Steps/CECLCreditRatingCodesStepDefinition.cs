using NUnit.Framework;
using CSharpPOC.Base;
using CSharpPOC.Hooks;
using CSharpPOC.Pages;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CSharpPOC.Steps
{
    [Binding]
    class CECLCreditRatingCodesStepDefinition
    {
        Context Context;

        CECLCreditRatingCodes page = null;
        NavigatePages navigate = null;

        string defaultLow = "1";
        string defaultHigh = "20";

        public CECLCreditRatingCodesStepDefinition(Context context)
        {
            Context = context;


            page = new CECLCreditRatingCodes(Context.Page);
            navigate = new NavigatePages(Context.Page);
        }
        [Given(@"I have have at least one completed ETL and have navigated to Setup CECL")]
        public async Task GivenIHaveHaveAtLeastOneCompletedETLAndHaveNavigatedToSetupCECL()
        {
            await navigate.ClickSetup();
            await navigate.ClickSetupCECL();
             
        }

        [Given(@"I select the Setup CECL breadcrumb")]
        public async Task GivenISelectTheSetupCECLBreadcrumb()
        {
            await navigate.ClickBreadcrumb("text=Setup CECL");
        }

        [Given(@"I choose Credit Rating Codes")]
        public async Task GivenIChooseCreditRatingCodes()
        {
            await navigate.ClickBreadCrumbSubmenu("text=Credit Rating Codes");
        }

        [Given(@"I am on the Credit Rating Page")]
        public async Task GivenIAmOnTheCreditRatingPage()
        {

            Assert.That(await navigate.DoesPageExist("Credit Rating Codes"), Contains.Substring("Credit Rating Codes"));
            

        }

        [When(@"(.*) is entered for Risk Rating Low")]
        public async Task WhenIsEnteredForRiskRatingLow(int p0)
        {
            string lowVal = p0.ToString();
            await page.FillRiskRatingLow(lowVal);
        }

        [When(@"(.*) is entered for Risk Rating High")]
        public async Task WhenIsEnteredForRiskRatingHigh(int p0)
        {
            string highVal = p0.ToString();
            await page.FillRiskRatingHigh(highVal);
        }

        [When(@"I click Save")]
        public async Task WhenIClickSave()
        {
            await page.ClickCredCodeSave();
        }

        [Then(@"the the ratings are Saved")]
        public async Task ThenTheTheRatingsAreSaved()
        {

            //here we will check that the values are there and then set back
            

            //set back to default
            await page.FillRiskRatingLow(defaultLow);
            await page.FillRiskRatingHigh(defaultHigh);
        }

        [When(@"I click Cancel")]
        public void WhenIClickCancel()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the the ratings are not Saved")]
        public void ThenTheTheRatingsAreNotSaved()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"a Validation appears below Risk Rating Low input box that says ""(.*)""")]
        public void ThenAValidationAppearsBelowRiskRatingLowInputBoxThatSays(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"a Validation appears below Risk Rating High input box that says ""(.*)""")]
        public void ThenAValidationAppearsBelowRiskRatingHighInputBoxThatSays(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I click away")]
        public void ThenIClickAway()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"a Save Change Dialog appears")]
        public void ThenASaveChangeDialogAppears()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click Save in the dialog")]
        public void WhenIClickSaveInTheDialog()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am on the Credit Rating Page")]
        public void ThenIAmOnTheCreditRatingPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click Cancel in the dialog")]
        public void WhenIClickCancelInTheDialog()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the the ratings are Not Saved")]
        public void ThenTheTheRatingsAreNotFinallySaved()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

