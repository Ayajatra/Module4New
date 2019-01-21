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
    public partial class MainForm : CoreForm
    {
        public MainForm()
        {
            InitializeComponent();
            viewResultsSummaryToolStripMenuItem_Click(this, new EventArgs());
        }

        private void viewResultsSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            var summary = new SummaryForm();
            summary.Dock = DockStyle.Fill;
            summary.TopLevel = false;
            panel.Controls.Add(summary);
            summary.Show();
        }

        private void viewDetailedResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            var detailed = new DetailedForm();
            detailed.Dock = DockStyle.Fill;
            detailed.TopLevel = false;
            panel.Controls.Add(detailed);
            detailed.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}