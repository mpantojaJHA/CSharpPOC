using Microsoft.Playwright;
using System;
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

        //methods
        public async Task FillRiskRatingLow(string lowValue) => await Page.Frame(name: "FpsAngularAppFrame").FillAsync(idRiskRatingLow, lowValue);

        public async Task FillRiskRatingHigh(string highValue) => await Page.Frame(name: "FpsAngularAppFrame").FillAsync(idRiskRatingHigh, highValue);
        public async Task ClickCredCodeSave() => await Page.Frame("FpsAngularAppFrame").ClickAsync(txtSaveButton);

        //public async Task <String>GetTextValuesLow()
        //{
        //    return string LowContent = await Page.Frame("FpsAngularAppFrame").TextContentAsync(idRiskRatingLow);
  
        //}
        //public async Task GetTextValuesHigh()
        //{
        //  return string HighContent = await Page.Frame("FpsAngularAppFrame").TextContentAsync(idRiskRatingHigh);
        //}


    }

}
