using Reportes.Reports;
using SG_Blazor_4.Shared.Models.Psico;
using System.IO;
using Telerik.Reporting.Processing;
using System.Windows.Forms;

namespace Reportes.Controllers
{
    public  class Ba7TelerikReportController
    {
       
        public static MemoryStream GetBa7Report(Ba7Model ba7) 
        {
            var deviceInfo = new System.Collections.Hashtable();
            Ba7Report report1 = new Ba7Report( ba7);
            ReportProcessor reportProcessor = new ReportProcessor();
            Telerik.Reporting.InstanceReportSource instanceReportSource = new Telerik.Reporting.InstanceReportSource();
            instanceReportSource.ReportDocument = report1;
            RenderingResult result = reportProcessor.RenderReport("PDF", instanceReportSource, deviceInfo);

            MemoryStream ms = new MemoryStream();
            var bts = result.DocumentBytes;
            ms.Write(bts, 0, bts.Length);

            return ms;
        }
    }
}
