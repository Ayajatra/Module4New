using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module4New
{
    public partial class SummaryForm : CoreForm
    {
        private Session4Entities db = new Session4Entities();

        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            var fieldWork = $"{db.Surveys.Min(x => x.Date).Value.ToString("MMMM yyyy")}-{db.Surveys.Max(x => x.Date).Value.ToString("MMMM yyyy")}";
            var sampleSize = $"{db.Surveys.Count()} Adults";

            var q = db.Surveys.ToList().Select(x => new SummaryData
            {
                Gender = x.Gender ?? "",
                Age = x.Age.HasValue ? GetAge(x.Age.Value) : "",
                CabinType = x.CabinType ?? "",
                DestinationAirport = x.Arrival ?? ""
            }).ToList();

            rv.LocalReport.SetParameters(new ReportParameter("Fieldwork", fieldWork));
            rv.LocalReport.SetParameters(new ReportParameter("SampleSize", sampleSize));
            rv.LocalReport.DataSources.Add(new ReportDataSource("DataSetSummary", q));
            rv.RefreshReport();
        }
    }

    public class SummaryData
    {
        public string Gender { get; set; }
        public string Age { get; set; }
        public string CabinType { get; set; }
        public string DestinationAirport { get; set; }
    }
}