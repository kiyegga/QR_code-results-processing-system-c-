using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace final_year_project
{
    public partial class excel : Form
    {
        public excel()
        {
            InitializeComponent();
        }

        private void choose_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK) {
                this.choose_txtbox.Text = openFileDialog1.FileName;
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
                string pathconn = "Provider=Mirosoft.Jet.OLEDB.4.0;Data Source " + choose_txtbox.Text + ";Extended Properties=\"Excel 8.0; HDR=Yes;\";";
                OleDbConnection conn = new OleDbConnection(pathconn);
            if (load_textBox.Text!="") {
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("SELECT * from[" + load_textBox.Text + "$]", conn);
                DataTable dt = new DataTable();
                myDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {

            }
            
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
