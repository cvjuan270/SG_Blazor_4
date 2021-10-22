using SG_Blazor_4.Shared.Models.Psico;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Reporting;
using Telerik.Reporting.Drawing;

namespace Reportes.Reports
{
    /// <summary>
    /// Summary description for Ba7Report.
    /// </summary>
    public partial class Ba7Report : Telerik.Reporting.Report
    {
        public Ba7Report(Ba7Model ba7)
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            textBoxNomApe.Value = ba7.NomApe;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
    }
}