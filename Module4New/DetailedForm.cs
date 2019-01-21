using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Module4New
{
    public partial class DetailedForm : CoreForm
    {
        private Session4Entities db = new Session4Entities();

        private List<string> genders = new List<string>
        {
            "All Genders",
            "Male",
            "Female"
        };

        private List<string> ages = new List<string>
        {
            "All Ages",
            "18-24",
            "25-39",
            "40-59",
            "60+"
        };

        public DetailedForm()
        {
            InitializeComponent();
        }

        private void DetailedForm_Load(object sender, EventArgs e)
        {
            var timePeriod = db.Surveys.ToList()
                .Select(x => x.Date).Distinct()
                .Select(x => x.Value.ToString("MMMM yyyy")).ToList();
            timePeriod.Insert(0, "All Periods");
            cbTimePeriod.DataSource = timePeriod;

            cbGender.DataSource = genders;
            cbAge.DataSource = ages;

            LoadDetailed();
        }

        private void LoadDetailed()
        {
            var detaileds = new List<DetailedData>();
            var detail = db.SurveysDetails.ToList()
                .Where(x =>
                    x.Survey.Date.Value.ToString("MMMM yyyy") == cbTimePeriod.Text ||
                    cbTimePeriod.Text == "All Periods"
                    ).ToList();

            foreach (var q in db.Questions.ToList())
            {
                foreach (var a in db.Answers.ToList())
                {
                    var detailed = detail.Where(x =>
                        x.QuestionID == q.ID &&
                        x.AnswerID == a.ID
                    ).ToList();

                    foreach (var gender in genders)
                    {
                        detaileds.Add(new DetailedData
                        {
                            Question = q.Question1,
                            Answer = a.Answer1,
                            AnswerID = a.ID,
                            Header = "Gender",
                            Detail = gender,
                            Total = detailed.Where(x =>
                                x.Survey.Gender == gender[0].ToString()
                            ).Count()
                        });
                    }

                    foreach (var age in ages)
                    {
                        detaileds.Add(new DetailedData
                        {
                            Question = q.Question1,
                            Answer = a.Answer1,
                            AnswerID = a.ID,

                            Header = "Age",
                            Detail = age,
                            Total = detailed.Where(x =>
                                x.Survey.Age.HasValue &&
                                GetAge(x.Survey.Age.Value) == age
                            ).Count()
                        });
                    }

                    foreach (var cabinType in
                        db.Surveys.Where(x => x.CabinType != null)
                        .Select(x => x.CabinType).Distinct().ToList())
                    {
                        detaileds.Add(new DetailedData
                        {
                            Question = q.Question1,
                            Answer = a.Answer1,
                            AnswerID = a.ID,

                            Header = "Cabin Type",
                            Detail = cabinType,
                            Total = detailed.Where(x => x.Survey.CabinType == cabinType).Count()
                        });
                    }

                    foreach (var arrival in db.Surveys.ToList()
                            .Where(x => x.Arrival != null)
                            .Select(x => x.Arrival).Distinct().ToList())
                    {
                        detaileds.Add(new DetailedData
                        {
                            Question = q.Question1,
                            Answer = a.Answer1,
                            AnswerID = a.ID,

                            Header = "Destination Airport",
                            Detail = arrival,
                            Total = detailed.Where(x => x.Survey.Arrival == arrival).Count()
                        });
                    }
                }
            }

            if (cbxGender.Checked)
            {
                if (cbGender.Text != "All Genders")
                {
                    detaileds.RemoveAll(x => x.Header == "Gender" && x.Detail != cbGender.Text);
                }
            }
            else
            {
                detaileds.RemoveAll(x => x.Header == "Gender");
            }

            if (cbxAge.Checked)
            {
                if (cbAge.Text != "All Ages")
                {
                    detaileds.RemoveAll(x => x.Header == "Age" && x.Detail != cbAge.Text);
                }
            }
            else
            {
                detaileds.RemoveAll(x => x.Header == "Age");
            }

            rv.LocalReport.DataSources.Clear();
            rv.LocalReport.DataSources.Add(new ReportDataSource("DetailedDataSet", detaileds));
            rv.RefreshReport();
        }
    }

    public class DetailedData
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int AnswerID { get; set; }
        public string Header { get; set; }
        public string Detail { get; set; }
        public int Total { get; set; }
    }
}