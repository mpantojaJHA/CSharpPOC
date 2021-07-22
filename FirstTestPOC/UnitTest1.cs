using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Playwright;
using System.Threading.Tasks;
using System.Configuration;


namespace FPSTestPOC
{
    [TestClass]
    public class SmokeTests
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }



        [TestInitialize]
        public void TestInit()
        {
            var appSettings = ConfigurationManager.AppSettings;

            string result = appSettings["TestUrl"];
            testContextInstance.Properties.Add("TestUrl", result);
            string user = appSettings["TestUser"];
            testContextInstance.Properties.Add("TestUser", user);
            string pwd = appSettings["TestUserPwd"];
            testContextInstance.Properties.Add("TestUserPwd", pwd);
        }

        [TestCleanup]
        public void TestClean()
        {
        }



        //[DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0;Data Source=c:\test.sdf", "TestData")]
        //int input1 = Convert.ToInt32(TestContext.DataRow["Test Input 1"]);
        [TestMethod]
        public async Task SmokeTest1()
        {

            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            var context = await browser.NewContextAsync();

            var page = await browser.NewPageAsync();
            string url = testContextInstance.Properties["TestUrl"].ToString();

            FpsLoginPage login = new(page);
            await login.Load(url);
            await login.Submit(url, testContextInstance.Properties["TestUser"].ToString(), testContextInstance.Properties["TestUserPwd"].ToString());

            ForecastingDetailPage details = new(page);

            await details.Load(url);
            await details.ChangeViews();

            ScoreCardMainPage scorecard = new(page);
            await scorecard.Load();

            await browser.CloseAsync();

        }



    }
    public class FpsLoginPage
    {
        private IPage page;

        public FpsLoginPage(IPage page)
        {
            this.page = page;
        }

        public async Task Load(string testUrl)
        {
            await page.GotoAsync(testUrl);
        }

        public async Task Submit(string testUrl, string user, string pwd)
        {
            await page.FillAsync("[placeholder=\"Enter User Name\"]", user);
            // Press Tab
            await page.PressAsync("[placeholder=\"Enter User Name\"]", "Tab");
            // Fill [aria-label="Password"]
            await page.FillAsync("[aria-label=\"Password\"]", pwd);
            // Click button:has-text("Sign in")
            await Task.WhenAll(
                page.WaitForNavigationAsync(/*"https://qafour.profitstarsfps.com/"*/),
                page.ClickAsync("button:has-text(\"Sign in\")"));
        }
    }

    public class ForecastingDetailPage
    {
        private IPage page;



        public ForecastingDetailPage(IPage page)
        {
            this.page = page;
        }

        public async Task Load(string testUrl)
        {
            await page.GotoAsync(testUrl);
            await page.ClickAsync("text=FORECASTING");
            await Task.WhenAll(
                page.WaitForNavigationAsync(/*"https://qafour.profitstarsfps.com/#/forecastingDetail?userSelection=%7B%7D&path=%5B2%5D"*/),
                page.ClickAsync("text=Detail"));
        }

        public async Task ChangeViews()
        {
            await page.GotoAsync("https://qafour.profitstarsfps.com/#/forecastingDetail?userSelection=%7B%225%22:%221%5Cb%22%7D&path=%5B2%5D");
            await page.GotoAsync("https://qafour.profitstarsfps.com/#/forecastingDetail?userSelection=%7B%221%22:%224%5Cb%22,%225%22:%221%5Cb%22,%2223%22:1%7D&path=%5B2%5D");
            await page.GotoAsync("https://qafour.profitstarsfps.com/#/forecastingDetail?userSelection=%7B%221%22:%224%5Cb%22,%225%22:%221%5Cb%22,%2219%22:1,%2223%22:1%7D&path=%5B2%5D");
            await page.GotoAsync("https://qafour.profitstarsfps.com/#/forecastingDetail?userSelection=%7B%221%22:%224%5Cb%22,%225%22:%221%5Cb%22,%2213%22:%221%5CbmonthEndBalance%22,%2219%22:1,%2223%22:1%7D&path=%5B2%5D");
        }
    }

    public class ScoreCardMainPage
    {
        private IPage page;

        public ScoreCardMainPage(IPage page)
        {
            this.page = page;
        }

        public async Task Load()
        {

            await Task.WhenAll(
                page.WaitForNavigationAsync(/*"https://qafour.profitstarsfps.com/#/scorecard?path=%5B2%5D&userSelection=%7B%2213%22:%220%5Cb%22,%2219%22:0,%2223%22:3%7D"*/),
                page.ClickAsync("text=SCORECARD"));
            Assert.Equals("https://qafour.profitstarsfps.com/#/scorecard?path=%5B2%5D&userSelection=%7B%7D", page.Url);
            await page.ClickAsync("text=Public");
            Assert.Equals("https://qafour.profitstarsfps.com/#/scorecard?path=%5B2%5D&userSelection=%7B%2213%22:%220%5Cb%22,%2219%22:1,%2223%22:3%7D", page.Url);
        }

        public async Task Submit()
        {

        }
    }
}