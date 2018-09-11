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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            textBox20.Text = f.DateText;
            f.Dispose();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            textBox30.Text = f.DateText;
            f.Dispose();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            textBox31.Text = f.DateText;
            f.Dispose();
        }
    }
}
