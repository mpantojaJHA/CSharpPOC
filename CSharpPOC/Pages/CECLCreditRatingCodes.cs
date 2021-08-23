using Microsoft.Playwright;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CSharpPOC.Pages;

namespace CSharpPOC.Pages
{
    class CECLCreditRatingCodes
    {

        IPage Page;
        public CECLCreditRatingCodes(IPage page) => Page = page;
     


        // variables

        //Risk Rating Low
        string idRiskRatingLow => "#riskRatingLow";
        //Risk Rating High
        string idRiskRatingHigh => "#riskRatingHigh";
        string txtSaveButton => "button:has-text(\'Save\')";
        string txtCancelButton => "button:has-text(\'Cancel\')";
        //  string txtLowErrorMsg1 => "text=The value must be between 1 and 100.";
        string txtLowErrorMsg1 => "//div[@id='jha-main-scroll-container']//fps-app-setup-cecl-rating-codes[@class='ng-star-inserted']/fps-common-function-view/jha-function-view//section[@class='jha-function-view-main']//form/jha-display-block//div[@class='jha-display-block-content']/div[1]/div[@class='col-sm-6']/fps-common-input-number/div[2]";
        //  string txtHigherrorMsg1 => ":nth-match(:text(\"The value must be between 1 and 100.\"), 2)";
        string txtHigherrorMsg1 => "//div[@id='jha-main-scroll-container']//fps-app-setup-cecl-rating-codes[@class='ng-star-inserted']/fps-common-function-view/jha-function-view//section[@class='jha-function-view-main']//form/jha-display-block//div[@class='jha-display-block-content']/div[2]/div[@class='col-sm-6']/fps-common-input-number/div[2]";
        string txtSaveDialog => "#myModalLabel";
        string txtDialogSaveButton => "button:has-text(\'Save\')";

        //methods
        public async Task FillRiskRatingLow(string lowValue) => await Page.Frame(name: "FpsAngularAppFrame").FillAsync(idRiskRatingLow, lowValue);

        public async Task FillRiskRatingHigh(string highValue)
        { 
         await Page.Frame(name: "FpsAngularAppFrame").FillAsync(idRiskRatingHigh, highValue);
            await Page.Frame("FpsAngularAppFrame").PressAsync(idRiskRatingHigh, "Enter");
        }
      

        public async Task ClickCredCodeSave() => await Page.Frame("FpsAngularAppFrame").ClickAsync(txtSaveButton);
        public async Task ClickCredCodeCancel() => await Page.Frame("FpsAngularAppFrame").ClickAsync(txtCancelButton);
       
        public async Task dialogSave() => await Page.ClickAsync(txtDialogSaveButton);
        public async Task dialogCancel() => await Page.ClickAsync(txtCancelButton);
        public async Task <string>GetTextValuesLow()
        {
            string lowVal = await Page.Frame("FpsAngularAppFrame").InputValueAsync(idRiskRatingLow);

            return lowVal;
           // StringAssert.Contains(low, value);

        }
        public async Task <string> GetTextValuesHigh()
        {
            string highVal = await Page.Frame("FpsAngularAppFrame").InputValueAsync(idRiskRatingHigh);

            return highVal;
        }

        public async Task <string> LowRiskErrorMessage()
        {
            // string lowMsg = await Page.Frame("FpsAngularAppFrame").QuerySelectorAsync(txtLowErrorMsg1).Result.InnerTextAsync();
            string lowMsg = await Page.Frame("FpsAngularAppFrame").TextContentAsync(txtLowErrorMsg1);
            return lowMsg;
        }

        public async Task<string> HighRiskErrorMessage()
        {
            string highMsg = await Page.Frame("FpsAngularAppFrame").TextContentAsync(txtHigherrorMsg1);
            return highMsg;
        }

        public async Task  <String> VerifySaveDialog()
        {
            return await Page.TextContentAsync(txtSaveDialog);

        }


    }

}
