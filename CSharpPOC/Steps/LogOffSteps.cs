using NUnit.Framework;
using PlaywrightSharp;
using CSharpPOC.Base;
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

//        [Given(@"I am logged in to FPS")]
//        public async Task GivenIAmLoggedInToFPS()
//        {

//            Assert.That(await logOff.IsLogOffExist(), Is.EqualTo("Ovation Bank"));
//        }

//        [Then(@"I will Log Out")]
//            public async Task ThenIWillLogOut()
//            {
//                await logOff.ClickInstitutionName();
//                await logOff.ClickSignOut();
//            }

//        }

//}
