using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_year_project
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login_form Open = new login_form();
            Open.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
                signup Open = new signup();
                Open.ShowDialog();
            button7.Enabled = false;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Grade Open = new Grade();
            Open.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bio_data Open = new bio_data();
            Open.ShowDialog();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Graph open = new Graph();
            open.ShowDialog();
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            Report_improved _open = new Report_improved();
            _open.ShowDialog();
        }
    }
}
