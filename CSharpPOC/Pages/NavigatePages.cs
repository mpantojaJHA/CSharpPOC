using PlaywrightSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPOC.Pages
{
    class NavigatePages
    {
        IPage Page;
        public NavigatePages(IPage page) => Page = page;

        //here, add locators for the navigation pages with variables
        // a lot like page object in Protractor, just formated differently
        string txtProfitability => "text=PROFITABILITY";
        string txtRelationships => "txt=RELATIONSHIPS";
        string txtPricingMenu => "text=PRICING";
        string txtPricingSubmenu => "text=Pricing Rate Sheets >> a";
        string imgDashboard => "img";
        string txtDashboard => "text=Dashboard";
        string txtForecasting => "text=FORECASTING";
        string txtForecastingDetail => "text=Detail";
        string txtALM => "text=ALM";
        string txtEVE => "text=EVE";
        string txtCECL => "text=CECL";
        string txtScorecard => "text=SCORECARD";
        string txtReporting => "text=REPORTING";
        string txtCreateReports => "text=Create Reports";
        string txtUpdateETL => "text=UPDATE";
        string txtMonthlyUpdate => "text=Monthly Update Process";
        string txtSetup => "text=SETUP";
        string txtManageUsers => "text=Manage Users";
        string txtCECLSetup => ":nth-match(:text(\'CECL\'), 2)";
        string txtInstNameDropDn => "text=Ovation Bank";
        string txtAbout => "text=About";


        //Methods

        public async Task<string> DoesDashbardExist()
        {
            
                   
            return await Page.QuerySelectorAsync(txtDashboard).Result.GetInnerTextAsync();
         
        }
        public async Task<string> DoesPageExist(string txtPage)
        {
           var txtDomainPage = txtPage;

            
            switch (txtDomainPage)
            {
                case "Profitability":
                    return await Page.QuerySelectorAsync("span:has-text('Profitability')").Result.GetInnerTextAsync();
                case "Pricing":
                    return await Page.QuerySelectorAsync("span:has-text('Pricing')").Result.GetInnerTextAsync();
                case "Forecasting":
                    return await Page.QuerySelectorAsync("text=Forecasting Detail").Result.GetInnerTextAsync();
                case "ALM":
                    return await Page.QuerySelectorAsync(txtEVE).Result.GetInnerTextAsync();
                case "CECL":
                    return await Page.QuerySelectorAsync("text=CECL Summary").Result.GetInnerTextAsync();
                case "Scorecard":
                    return await Page.QuerySelectorAsync("span:has-text('Scorecard')").Result.GetInnerTextAsync();
                case "Reporting":
                    return await Page.QuerySelectorAsync(txtCreateReports).Result.GetInnerTextAsync();
                case "Update":
                    return await Page.QuerySelectorAsync(txtMonthlyUpdate).Result.GetInnerTextAsync();

                case "Setup":
                    return await Page.QuerySelectorAsync(txtManageUsers).Result.GetInnerTextAsync();
                default:
                    return await Page.QuerySelectorAsync("No Domain found").Result.GetInnerTextAsync();
            }



        }
        public async Task NavToDashboard() => await Page.ClickAsync(imgDashboard);

        public async Task ClickProfitability() => await Page.ClickAsync(txtProfitability);
        public async Task ClickPricing() => await Page.ClickAsync(txtPricingMenu);
        public async Task ClickPricingSubmenu() => await Page.ClickAsync(txtPricingSubmenu);

        public async Task ClickForecasting() => await Page.ClickAsync(txtForecasting);
        public async Task ClickForecatingDetail() => await Page.ClickAsync(txtForecastingDetail);
        public async Task ClickALM() => await Page.ClickAsync(txtALM);
        public async Task ClickEVE() => await Page.ClickAsync(txtEVE);
        public async Task ClickCECL() => await Page.ClickAsync(txtCECL);
        public async Task ClickScorecard() => await Page.ClickAsync(txtScorecard);
        public async Task ClickReporting() => await Page.ClickAsync(txtReporting);
        public async Task ClickCreateReports() => await Page.ClickAsync(txtCreateReports);
        public async Task ClickUpdate() => await Page.ClickAsync(txtUpdateETL);
        public async Task ClickMonthyUpdate() => await Page.ClickAsync(txtMonthlyUpdate);
        public async Task ClickSetup() => await Page.ClickAsync(txtSetup);
        public async Task ClickManageUsers() => await Page.ClickAsync(txtManageUsers);
        public async Task ClickSetupCECL() => await Page.ClickAsync(txtCECLSetup);
        public async Task ClickInstDropDown() => await Page.ClickAsync(txtInstNameDropDn);
        public async Task ClickAbout() => await Page.ClickAsync(txtAbout);

    }
}
