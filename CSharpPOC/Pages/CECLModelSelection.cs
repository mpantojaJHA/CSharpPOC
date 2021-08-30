using Microsoft.Playwright;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CSharpPOC.Pages;

namespace CSharpPOC.Pages
{


    class CECLModelSelection {

    IPage Page;
    public CECLModelSelection(IPage page) => Page = page;

        //selectors and or scoped variables
        //candidte for glogbal or helper class file
        string txtCalendarIcon => "//p-calendar[@id='field-dateValue-desktop']//button[@type='button']/span[@class='p-button-icon pi pi-calendar']";
        string txtCalendarDatePicker => "#field-dateValue-desktop > span > div > div.p-datepicker-group-container.ng-tns-c185-1.ng-star-inserted > div > div";
        string txtCurETLMonLabel => "text=Current Month Feb 2019";
        string txtCalDatePickerYear => "text=2019";
        string txtCalDatePickerMonth => "text=Feb";

        //methods
        public async Task ClickCalendarIcon() => await Page.Frame(name: "FpsAngularAppFrame").ClickAsync(txtCalendarIcon);

        public async Task <bool> DoesCalendarExist()
        {
            var calendarControl = await Page.Frame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtCalendarDatePicker).Result.IsEnabledAsync();
            if (calendarControl)
                return calendarControl;
            else
                return false; //await Page.Frame(name: "FpsAngularAppFrame").QuerySelectorAsync(txtCalendarDatePicker).Result.IsHiddenAsync();

        }

        public async Task <string> GetCurrentMonthETL()
        {
            string curMonthETL = await Page.QuerySelectorAsync(txtCurETLMonLabel).Result.InnerTextAsync();
            return curMonthETL.Trim().Substring(14,3);
        
        }

        public async Task <string> GetCurrentYearETL()
        {

               //note that this page is not yet in a "frame" 
            string curYearETL = await Page.QuerySelectorAsync(txtCurETLMonLabel).Result.InnerTextAsync();
            return curYearETL.Trim().Substring(18).Trim();

        }
        public async Task <string> GetCalendarYear()
        {
            var year = await Page.Frame("FpsAngularAppFrame").QuerySelectorAsync(txtCalDatePickerYear).Result.InnerTextAsync();
            return year.Trim();
        }
        
        public async Task <string> GetCalendarMonth()
        {
            var month = await Page.Frame("FpsAngularAppFrame").QuerySelectorAsync(txtCalDatePickerMonth).Result.InnerTextAsync();
            return month.Trim();
        }







    }
    
}
