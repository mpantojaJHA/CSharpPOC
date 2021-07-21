//using NUnit.Framework;
//using PlaywrightSharp;
//using CSharpPOC.Base;
//using CSharpPOC.Hooks;
//using CSharpPOC.Pages;
//using System.Threading.Tasks;
//using TechTalk.SpecFlow;
//using TechTalk.SpecFlow.Assist;

//namespace CSharpPOC.Steps
//{
//    [Binding]
//    class LogOffSteps
//    {
//        Context Context;
//        LogOff logOff = null;

//        public LogOffSteps(Context context)
//        {
//            Context = context;
//            logOff = new LogOff(Context.Page);
//        }

        
       
//        [Given(@"I will log out")]
//        public async Task GivenIWillLogOut()
//        {
//            await logOff.ClickInstitutionName();
//                 await logOff.ClickSignOut();
//        }

//        [Then(@"I will be logged out")]
//        public async Task ThenIWillBeLoggedOut()
//        {
//            await Context.Page.GotoAsync("https://qafour.profitstarsfps.com/Account/SignedOut");
//        }


//    }

//}
