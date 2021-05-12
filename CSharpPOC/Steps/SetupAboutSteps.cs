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
    class SetupAboutSteps
    {
        Context Context;
        
        About aboutPg = null;
        NavigatePages navigate = null;

        public SetupAboutSteps(Context context)
        {
            Context = context;
            
            
            aboutPg = new About(Context.Page);
            navigate = new NavigatePages(Context.Page);
        }


        [Given(@"I click the Institution Name Drop Down")]
        public async Task GivenIClickTheInstitutionNameDropDown()
        {
            await navigate.ClickInstDropDown();
           
        }

        [When(@"I click the About link")]
        public async Task WhenIClickTheAboutLink()
        {
          
            await navigate.ClickAbout();
        }

        [Then(@"I am navigated to the About page")]
        public async Task ThenIAmNavigatedToTheAboutPage()
        {
           Assert.That(await navigate.DoesPageExist("About"), Is.EqualTo("About"));
                 
        }

        [Then(@"I verify the Application Name")]
        public async Task  ThenIVeifyTheApplicationName()
        {
            Assert.That(await aboutPg.DoesElementExist("ProfitStars Financial Performance Suite"), Is.EqualTo("ProfitStars Financial Performance Suite"));

        }

        [Then(@"I verify a copyright Date exists")]
        public async Task  ThenIVerifyACopyrightDateExists()
        {
            Assert.That(await aboutPg.DoesElementExist("Copyright"), Is.EqualTo("Copyright © 2021 ProfitStars ®"));
        }

        [Then(@"I verify a build number exists")]
        public async Task  ThenIVerifyABuildNumberExists()
        {
            Assert.That(await aboutPg.DoesElementExist("Build"), Is.AtLeast("Version FPS-DevNightlyAngular-PL_"));
        }

        [Then(@"I verify a Tradmark Notice link exists")]
        public async Task ThenIVerifyATradmarkNoticeLinkExists()
        {
            Assert.That(await aboutPg.DoesElementExist("Trademark"), Is.EqualTo("Trademark Notice"));

            await aboutPg.ClickTrademark();
        
        }

        [Then(@"I verify a Terms and Conditions link exists")]
        public  async Task ThenIVerifyATermsAndConditionsLinkExists()
        {
            Assert.That(await aboutPg.DoesElementExist("Terms"), Is.EqualTo("Terms & Conditions"));

            await aboutPg.ClickTerms();
        }

        [Then(@"I verify a Privacy Policy link exists")]
        public async Task ThenIVerifyAPrivacyPolicyLinkExists()
        {
            Assert.That(await aboutPg.DoesElementExist("Privacy"), Is.EqualTo("Privacy Policy"));

            await aboutPg.ClickPrivacy();

        }


    }
}
