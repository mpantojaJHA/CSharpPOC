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
   class NavigateSimplified
    {
        Context Context;
        NavigatePages navigate = null;


        public NavigateSimplified(Context context)
        {
            Context = context;
            navigate = new NavigatePages(Context.Page);

        }

        [Given(@"I can navigate to AppPage and am on_Page")]
        public async Task GivenICanNavigateToAppPageAndAmOn_Page(Table table)
        {

            foreach (TableRow row in table.Rows)
            {
                await navigate.NavToPage(row[0]);
                string backFromPgFile = await navigate.DoesPageExist(row[1]);
                Assert.That(backFromPgFile.Trim(), Is.EqualTo(row[1].Trim()));

            }
            
        }
      
    }
}
