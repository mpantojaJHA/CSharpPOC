using NUnit.Framework;
using PlaywrightSharp;
using CSharpPOC.Base;
using CSharpPOC.Hooks;
using CSharpPOC.Pages;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System;
using System.Diagnostics;

namespace CSharpPOC.Steps
{
    [Binding]
   class ReportWriterSteps
    {
        
        Context Context;
       // LogIn login = null;
       // LogOff logOff = null;
       // NavigatePages navigate = null;
        FPSReportWriter reportWriter = null;
        

        public ReportWriterSteps(Context context)
        {
            Context = context;
          //  login = new LogIn(Context.Page);
          //  logOff = new LogOff(Context.Page);
         //   navigate = new NavigatePages(Context.Page);
            reportWriter = new FPSReportWriter(Context.Page);
        }

        [Then(@"I enter Install & Open Report writer in the Report Search Box")]
        public async Task ThenIEnterInstallOpenReportWriterInTheReportSearchBox()
        {
            await reportWriter.FillFindTextInput();
        }

        [Then(@"Report Writer is successfully launched")]
        public async Task ThenReportWriterIsSuccessfullyLaunched()
        {
            await reportWriter.ClickOpenRW();
            //Process currentProcess = Process.GetCurrentProcess();
            Process[] localAll = Process.GetProcesses();
           // Process[] localByName = Process.GetProcessesByName("FPSReportWriter");
            Process[] localByName = Process.GetProcessesByName("FPSReportWriter");


            int i = 0;
            const int maxCounter = 50;

            do
            {

                try
                {


                    if (localAll[i] == localByName[0])
                    {
                        Console.WriteLine(localAll[i]);
                        localByName[0].CloseMainWindow();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }


                i++;


            } while (i < maxCounter);

           localByName[0].CloseMainWindow();

            //(i < maxCounter && localByName[0] != null);

            // Console.WriteLine(localByName[0].ToString());






        }



    }
}
