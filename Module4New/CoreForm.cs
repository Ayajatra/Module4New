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
    public partial class CoreForm : Form
    {
        public CoreForm()
        {
            InitializeComponent();
        }

        public string GetAge(int age)
        {
            if (age >= 18 && age <= 24)
                return "18-24";
            else if (age >= 25 && age <= 39)
                return "25-39";
            else if (age >= 40 && age <= 59)
                return "40-59";
            else if (age >= 60)
                return "60+";
            else
                return "";
        }
    }
}