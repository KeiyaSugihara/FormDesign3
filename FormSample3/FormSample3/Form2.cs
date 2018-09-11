using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSample3
{
    public partial class Form2 : Form
    {

        public string DateText;

        public Form2()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateText = monthCalendar1.SelectionStart.ToShortDateString() + " ～ " +
                monthCalendar1.SelectionEnd.ToShortDateString();
            this.Close();
        }

    }
}
