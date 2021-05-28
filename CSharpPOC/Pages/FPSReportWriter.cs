using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaywrightSharp;
using System.Diagnostics;

namespace CSharpPOC.Pages
{
    class FPSReportWriter
    {
        IPage Page;
        public FPSReportWriter(IPage page) => Page = page;

        // string txtOpenRWBtn => "button:has-text(\"Open Report Writer\"";
        string txtOpenRWBtn => "//button[normalize-space()='Open Report Writer']";
        string txtInstallAndOpenRW => "Install & Open Report Writer";
        string txtRptFindInput => "input[type=\"text\"]";


        public async Task FillFindTextInput() { 
            await Page.ClickAsync(txtRptFindInput);
        // Fill input[type="text"]
        await Page.FillAsync(txtRptFindInput, txtInstallAndOpenRW);
        await Page.PressAsync("text=– Install & Open Report Writer Go >> [placeholder=\"Find...\"]", "Enter");


        }
        public async Task ClickOpenRW() => await Page.ClickAsync((txtOpenRWBtn));
        
        
        




    }




}
