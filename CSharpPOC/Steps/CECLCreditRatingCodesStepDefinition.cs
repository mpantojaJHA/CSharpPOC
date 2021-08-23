using NUnit.Framework;
using CSharpPOC.Base;
using CSharpPOC.Hooks;
using CSharpPOC.Pages;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Microsoft.Playwright;
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
            
            var lowValue = await page.GetTextValuesLow();
            StringAssert.Contains("2", lowValue);
            
            var highValue = await page.GetTextValuesHigh();
            StringAssert.Contains("25", highValue);

            //set back to default
            await page.FillRiskRatingLow(defaultLow);
            await page.FillRiskRatingHigh(defaultHigh);
            await page.ClickCredCodeSave();
        }

        [When(@"I click Cancel")]
        public async Task WhenIClickCancel()
        {
            //need to make some changes so this occurs so we will pass in a couple values to cause a change
            //
            string lowValue = "5";
            string highValue = "99";
            await page.FillRiskRatingLow(lowValue);
            await page.FillRiskRatingHigh(highValue);
            ////click cancel
            await page.ClickCredCodeCancel();
        }

        [Then(@"the the ratings are not Saved")]
        public async Task ThenTheTheRatingsAreNotSaved()
        {
            var lowValue = await page.GetTextValuesLow();
            StringAssert.Contains("1", lowValue);

            var highValue = await page.GetTextValuesHigh();
            StringAssert.Contains("20", highValue);
        }

        [Then(@"a Validation appears below Risk Rating Low input box that says ""(.*)""")]
        public async Task ThenAValidationAppearsBelowRiskRatingLowInputBoxThatSays(string p0)
        {
           
            string lowMsg = await page.LowRiskErrorMessage();
            //StringAssert.Contains(p0, lowMsg);
            Assert.That(p0, Is.EqualTo(lowMsg.Trim()));
        }

        [Then(@"a Validation appears below Risk Rating High input box that says ""(.*)""")]
        public async Task ThenAValidationAppearsBelowRiskRatingHighInputBoxThatSays(string p0)
        {
            string highMsg = await page.HighRiskErrorMessage();
            //StringAssert.Contains(p0, highMsg.Trim());
           Assert.That(p0, Is.EqualTo(highMsg.Trim()));

            await page.ClickCredCodeCancel();
        }

      
        [Then(@"a Save Change Dialog appears")]
        public async Task ThenASaveChangeDialogAppears()
        {
            string saveDialog = await page.VerifySaveDialog();
            Assert.That(saveDialog.Trim(), Is.EqualTo("Save Changes"));
        }

        [When(@"I click Save in the dialog")]
        public async Task WhenIClickSaveInTheDialog()
        {

            
        await page.dialogSave();
         
        }
        [Then(@"the the dialog ratings are Saved")]
        public async Task ThenTheTheDialogRatingsAreSaved()
        {
            var lowValue = await page.GetTextValuesLow();
            StringAssert.Contains("3", lowValue);

            var highValue = await page.GetTextValuesHigh();
            StringAssert.Contains("16", highValue);
        }



        [Then(@"I stay on the Credit Rating Page")]
        public async Task ThenIAmOnTheCreditRatingPage()
        {
            Assert.That(await navigate.DoesPageExist("Credit Rating Codes"), Contains.Substring("Credit Rating Codes"));

            //set back to 1 low 20 high
            await page.FillRiskRatingLow(defaultLow);
            await page.FillRiskRatingHigh(defaultHigh);
            await page.ClickCredCodeSave();

        }

        [When(@"I click Cancel in the dialog")]
        public async Task WhenIClickCancelInTheDialog()
        {
            await page.dialogCancel();
        }

        [When(@"I have navigated to Setup CECL")]
        public async Task WhenIHaveNavigatedToSetupCECL()
        {
            await navigate.ClickSetup();
            await navigate.ClickSetupCECL();
            await navigate.ClickBreadcrumb("text=Setup CECL");
            await navigate.ClickBreadCrumbSubmenu("text=Credit Rating Codes");

        }



        [Then(@"the the ratings are Not Saved")]
        public async Task ThenTheTheRatingsAreNotFinallySaved()
        {
            var lowValue = await page.GetTextValuesLow();
            StringAssert.Contains("1", lowValue);

            var highValue = await page.GetTextValuesHigh();
            StringAssert.Contains("20", highValue);
        }
    }
}

