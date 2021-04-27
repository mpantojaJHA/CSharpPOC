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
    class LogInSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        Context Context;
        LogIn login = null;
        LogOff logOff = null;
        
        public LogInSteps(Context context)
        {
            Context = context;
            login = new LogIn(Context.Page);
            logOff = new LogOff(Context.Page);
                    }

        [Given(@"I navigate to the environment FPS application")]
        public async Task GivenINavigateToTheEnvironmentFPSApplication()
        {
            await Context.Page.GoToAsync("https://qafour.profitstarsfps.com");
        }

        [Given(@"And I enter username and password")]
        public async Task GivenAndIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            await login.LoginFPS(data.Username, data.Password);
        }

        [When(@"I click Login")]
        public async Task WhenIClickLogin()
        {
            await login.ClickLogin();
        }
        [Then(@"I am logged in to FPS")]
        public async Task GivenIAmLoggedInToFPS()
        {

            Assert.That(await logOff.IsLogOffExist(), Is.EqualTo("Ovation Bank"));
        }

        [Then(@"I will Log Out")]
        public async Task ThenIWillLogOut()
        {
            await logOff.ClickInstitutionName();
            await logOff.ClickSignOut();
        }

    }


}
       

   

