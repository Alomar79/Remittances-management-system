using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remittances.Forms
{
    public partial class DateTimeTesting : Form
    {
        public DateTimeTesting()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
            textBox2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBox3.Text = DateTime.Now.ToString("h:mm tt");
            textBox4.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            textBox5.Text = DateTime.Now.ToString("MMMM yyyy");
            textBox6.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            textBox7.Text = DateTime.Now.ToString("dd MMMM");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("h:mm tt");
        }
    }
}
