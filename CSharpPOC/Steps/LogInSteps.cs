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
    class LogInSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        Context Context;
        
        LogIn login = null;
        NavigatePages navigate = null;

       
        
        public LogInSteps(Context context)
        {
            Context = context;
           
            login = new LogIn(Context.Page);
            navigate = new NavigatePages(Context.Page);
            
                    }

        [Given(@"I navigate to the environment FPS application")]
        public async Task GivenINavigateToTheEnvironmentFPSApplication()
        {
            await Context.Page.GotoAsync("https://qafour.profitstarsfps.com");
        }

        
        [Given(@"And I enter Username and Password")]
        public async Task GivenAndIEnterUsernameAndPassword(Table table)
        {
            //dynamic data = table.CreateDynamicInstance();
            //await login.LoginFPS(data.Username, data.Password);
            foreach(TableRow row in table.Rows)
            {
                await login.LoginFPS(row[0], row[1]);

            }

        }


        [When(@"I click Login")]
        public async Task WhenIClickLogin()
        {
            await login.ClickLogin();
           await Context.Page.WaitForSelectorAsync("#content > div.shuffle-animation.ng-scope > div.px-relative-position.ng-scope > div > div");

        }
        [Then(@"I am logged in to FPS")]
        public async Task GivenIAmLoggedInToFPS() {

            Assert.That(await navigate.DoesDashbardExist(), Is.EqualTo(" Dashboard"));
        }
        [When(@"I log out")]
        public async Task GivenIWillLogOut()
        {
            await login.ClickInstitutionName();
            await login.ClickSignOut();
        }

        [Then(@"I will be logged out")]
        public async Task ThenIWillBeLoggedOut()
        {
            await Context.Page.GotoAsync("https://qafour.profitstarsfps.com/Account/SignedOut");
        }


    }


}
       

   

