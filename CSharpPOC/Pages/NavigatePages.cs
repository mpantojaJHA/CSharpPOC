using Microsoft.Playwright;
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
        string txtPricingSubmenu => "text=Pricing Rate Sheets >> a";  //depending on DOM load speed, may need to do new selector
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
        string txtAdHocReporting => "text=Ad-Hoc Reporting";
        string txtUpdateETL => "text=UPDATE";
        string txtMonthlyUpdate => "text=Monthly Update Process";
        string txtSetup => "text=SETUP";
        string txtManageUsers => "text=Manage Users";
        string txtCECLSetup => ":nth-match(:text(\"CECL\"), 2)";
        string txtBrdCrmbSetupCECL => "text=Setup CECL";
        string txtInstNameDropDn => "text=Ovation Bank";
       string txtAbout => "text=About";
       string txtCreditRatingCodes => "text=Credit Rating Codes";
        string txtCECLModelSelection => "text=Model Selection";

        //Methods

        public async Task<string> DoesDashbardExist()
        {


            return await Page.QuerySelectorAsync(txtDashboard).Result.InnerTextAsync();

        }
        public async Task<string> DoesPageExist(string txtPage)
        {
           var txtDomainPage = txtPage;

            
            switch (txtDomainPage)
            {
                case "Profitability":
                    return await Page.QuerySelectorAsync(txtProfitability).Result.InnerTextAsync();
                  ;
                case "Pricing":
                    return await Page.TextContentAsync("span:has-text('Pricing')");
                case "Forecasting":
                    return await Page.TextContentAsync("text=Forecasting Detail");
                case "ALM":
                    return await Page.TextContentAsync(txtEVE);
                case "CECL":
                    return await Page.TextContentAsync("text=CECL Summary");
                case "Scorecard":
                    return await Page.TextContentAsync("span:has-text('Scorecard')");
                case "Reporting":
                    return await Page.TextContentAsync(txtCreateReports);
                case "Update":
                    return await Page.TextContentAsync(txtMonthlyUpdate);

                case "MgUsers":
                    return await Page.TextContentAsync(txtManageUsers);
                case "SetupCECL":
                    return await Page.Frame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtBrdCrmbSetupCECL).Result.InnerTextAsync();

                case "About":
                    return await Page.TextContentAsync(txtAbout);
                case "Credit Rating Codes":
                    return await Page.Frame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtCreditRatingCodes).Result.InnerTextAsync();
                case "Model Selection":
                    return await Page.Frame("FpsAngularAppFrame").QuerySelectorAsync(txtCECLModelSelection).Result.InnerTextAsync();
                default:
                    return await Page.TextContentAsync("No Domain found");
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
        public async Task ClickAdHoc() => await Page.ClickAsync(txtAdHocReporting);
        public async Task ClickUpdate() => await Page.ClickAsync(txtUpdateETL);
        public async Task ClickMonthyUpdate() => await Page.ClickAsync(txtMonthlyUpdate);
        public async Task ClickSetup() => await Page.ClickAsync(txtSetup);
        public async Task ClickManageUsers() => await Page.ClickAsync(txtManageUsers);
        public async Task ClickSetupCECL() => await Page.ClickAsync(txtCECLSetup);
        public async Task ClickInstDropDown() => await Page.ClickAsync(txtInstNameDropDn);
       public async Task ClickAbout() => await Page.ClickAsync(txtAbout);

        public async Task ClickBreadcrumb(string breadcrumbselector) => await Page.Frame(name: "FpsAngularAppFrame").ClickAsync(breadcrumbselector);
        public async Task ClickBreadCrumbSubmenu(string brdCrmbselector) => await Page.Frame(name: "FpsAngularAppFrame").ClickAsync(brdCrmbselector);

        
    }
}
