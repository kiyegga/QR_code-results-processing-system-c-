using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace final_year_project
{
    public partial class Graph : Form
    {
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
        public Graph()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(class_cm.Text))
            {
                MessageBox.Show("Please select class to consider");
                class_cm.Focus();
            }
            else if (string.IsNullOrEmpty(subject_cm.Text))
            {
                MessageBox.Show("Please select subject to consider");
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT `Year`, ((`Mid_term`+`End_of_term`)/2)AVG FROM `report_marks` WHERE Class='" + class_cm.Text + "' AND Subject='" + subject_cm.Text + "' GROUP BY Year", con);
                    con.Open();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    chart1.DataSource = dt;
                    chart1.Series["marks"].XValueMember = "Year";
                    chart1.Series["marks"].YValueMembers = "avg";
                    chart1.DataBind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No records found");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Graph_Load(object sender, EventArgs e)
        {

        }

        private void btngraph_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No results found");
            }
            finally
            {
                con.Close();
            }

        }
    }
}
