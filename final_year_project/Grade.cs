using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace final_year_project
{
    public partial class Grade : Form
    {
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
        public Grade()
        {
            InitializeComponent();
        }
        void fillCombo() {

        }

        private void Grade_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main Open = new main();
            Open.Show();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void excel_Click(object sender, EventArgs e)
        {
            excel Open = new excel();
            Open.ShowDialog();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void exam_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(class_cm.Text))
                {
                    MessageBox.Show("Fill in class");
                    class_cm.Focus();
                }
                else if (string.IsNullOrEmpty(year_cm.Text))
                {
                    MessageBox.Show("Fill in year");
                    year_cm.Focus();
                }
                else if (string.IsNullOrEmpty(term_cm.Text))
                {
                    MessageBox.Show("Fill in term");
                    term_cm.Focus();
                }
                else if (string.IsNullOrEmpty(subject_cm.Text))
                {
                    MessageBox.Show("Fill in subject");
                    subject_cm.Focus();
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from report_marks WHERE CLASS='"+this.class_cm.Text+ "' AND YEAR='"+this.year_cm.Text+ "' AND TERM='"+this.term_cm.Text+ "' AND SUBJECT='"+this.subject_cm.Text+ "'", con);

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " No record Found");

            }
            finally
            {
                con.Close();
            }
        }
    }
}
