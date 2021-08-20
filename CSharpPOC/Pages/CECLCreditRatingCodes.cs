using Microsoft.Playwright;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
        string txtLowErrorMsg1 => "text=The value must be between 1 and 100.";
        string txtHigherrorMsg1 => ":nth-match(:text(\"The value must be between 1 and 100.\"), 2)";
        
        
        //methods
        public async Task FillRiskRatingLow(string lowValue) => await Page.Frame(name: "FpsAngularAppFrame").FillAsync(idRiskRatingLow, lowValue);

        public async Task FillRiskRatingHigh(string highValue) => await Page.Frame(name: "FpsAngularAppFrame").FillAsync(idRiskRatingHigh, highValue);
        public async Task ClickCredCodeSave() => await Page.Frame("FpsAngularAppFrame").ClickAsync(txtSaveButton);
        public async Task ClickCredCodeCancel() => await Page.Frame("FpsAngularAppFrame").ClickAsync(txtCancelButton);
        
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
            string lowMsg = await Page.Frame("FpsAngularAppFrame").QuerySelectorAsync(txtLowErrorMsg1).Result.InnerTextAsync();
            return lowMsg;
        }

        public async Task<string> HighRiskErrorMessage()
        {
            string highMsg = await Page.Frame("FpsAngularAppFrame").QuerySelectorAsync(txtHigherrorMsg1).Result.InnerTextAsync();
            return highMsg;
        }


    }

}
