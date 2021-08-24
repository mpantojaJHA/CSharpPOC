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
    class CECLModelSelectionStepDefinition
    {
        Context Context;

        CECLModelSelection page = null;
        NavigatePages navigate = null;
                
        public CECLModelSelectionStepDefinition(Context context)
        {
            Context = context;


            page = new CECLModelSelection(Context.Page);
            navigate = new NavigatePages(Context.Page);
        }

        [Given(@"I choose Model Selection")]
        public async Task GivenIChooseModelSelection()
        {
            //await navigate.ClickBreadcrumb("text=Setup CECL");
            await navigate.ClickBreadCrumbSubmenu("text=Model Selection");
        }

        [Given(@"I am on the Model Selection Page")]
        public async Task GivenIAmOnTheModelSelectionPage()
        {
            Assert.That(await navigate.DoesPageExist("Model Selection"), Contains.Substring("Model Selection"));
        }

        [When(@"I click the Calendar Control icon")]
        public void WhenIClickTheCalendarControlIcon()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the Calendar drops down")]
        public void ThenTheCalendarDropsDown()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the Current year of recent ETLs shows for Year")]
        public void ThenTheCurrentYearOfRecentETLsShowsForYear()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Only Months with Completed ETLs can be selected")]
        public void ThenOnlyMonthsWithCompletedETLsCanBeSelected()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I cannot select a month beyond or prior to the ETLd months")]
        public void ThenICannotSelectAMonthBeyondOrPriorToTheETLdMonths()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click outside of the dropped down calendar")]
        public void WhenIClickOutsideOfTheDroppedDownCalendar()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the Calendar collapses up")]
        public void ThenTheCalendarCollapsesUp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select the first drop down on the Category-Primary Model Grid")]
        public void WhenISelectTheFirstDropDownOnTheCategory_PrimaryModelGrid()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the combo box drops down and I can select Roll Rate")]
        public void WhenTheComboBoxDropsDownAndICanSelectRollRate()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"in the second grid  Include in Report and Include in Grid become checked and disabled")]
        public void ThenInTheSecondGridIncludeInReportAndIncludeInGridBecomeCheckedAndDisabled()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I change the Primary Model for the first item in the first grid back to Advanced PD")]
        public void WhenIChangeThePrimaryModelForTheFirstItemInTheFirstGridBackToAdvancedPD()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Roll Rate Include in Report check box stays checked and enabled")]
        public void ThenRollRateIncludeInReportCheckBoxStaysCheckedAndEnabled()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a Primary Model is not selected in the first grid")]
        public void WhenAPrimaryModelIsNotSelectedInTheFirstGrid()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the Include in Report check box is enabled and checked")]
        public void ThenTheIncludeInReportCheckBoxIsEnabledAndChecked()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Roll Rate Include in Report check box is unchecked")]
        public void WhenRollRateIncludeInReportCheckBoxIsUnchecked()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Roll Rate Include in Grid check box becomes enabled")]
        public void ThenRollRateIncludeInGridCheckBoxBecomesEnabled()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Roll Rate Include i Grid check box is checked")]
        public void WhenRollRateIncludeIGridCheckBoxIsChecked()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Roll Rate Include in Grid is unchecked")]
        public void WhenRollRateIncludeInGridIsUnchecked()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Roll Rate Include in Report gets checked")]
        public void WhenRollRateIncludeInReportGetsChecked()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Roll Rate Include in Grid becomes checked and disabled")]
        public void ThenRollRateIncludeInGridBecomesCheckedAndDisabled()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the Save and Cancel buttons are present and disabled")]
        public void GivenTheSaveAndCancelButtonsArePresentAndDisabled()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I uncheck Roll Rate")]
        public void WhenIUncheckRollRate()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Save and cancel become enabled")]
        public void ThenSaveAndCancelBecomeEnabled()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Roll Rate state returns to checked in the second grid")]
        public void ThenRollRateStateReturnsToCheckedInTheSecondGrid()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I change first Categroy in First grid to Primary Model of Roll Rate")]
        public void WhenIChangeFirstCategroyInFirstGridToPrimaryModelOfRollRate()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the Primary Model change perists")]
        public void ThenThePrimaryModelChangePerists()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I Change the Primary Model for the first Category back to Advanced PD")]
        public void WhenIChangeThePrimaryModelForTheFirstCategoryBackToAdvancedPD()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the Save and Cancel buttons become enabled")]
        public void ThenTheSaveAndCancelButtonsBecomeEnabled()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click the Save button")]
        public void WhenIClickTheSaveButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"all changes are saved no navigation occurs")]
        public void ThenAllChangesAreSavedNoNavigationOccurs()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
