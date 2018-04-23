using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace final_year_project
{
    public partial class bio_data : Form
    {
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
        
        public bio_data()
        {
            InitializeComponent();
             fillcombo();
        }
        void fillcombo()
        {
             try
            {
                string Query = "select * from Results_table WHERE STUDENT_NO LIKE '%"+ student_no_txt.Text + "%'";
                MySqlCommand MyCommand = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = MyCommand.ExecuteReader();
                if (MyReader2.Read())
                {
                    class_cm.Text = MyReader2["CLASS"].ToString();
                    year_cm.Text = MyReader2["YEAR"].ToString();
                    term_cm.Text = MyReader2["TERM"].ToString();
                    exam_type.Text = MyReader2["Exam_Type"].ToString();
                    name_txt.Text = MyReader2["STUDENT_NAME"].ToString();
                    subject_txt.Text = MyReader2["SUBJECT"].ToString();
                    marks_txt.Text = MyReader2["MARKS"].ToString();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void bio_data_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main Open = new main();
            Open.Show();
            Visible = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {


           
            try
            {


                if (string.IsNullOrEmpty(student_no_txt.Text))
                {
                    MessageBox.Show("Enter student number");
                    student_no_txt.Focus();
                } else if (string.IsNullOrEmpty(name_txt.Text)) {
                    MessageBox.Show("Enter student name");
                    name_txt.Focus();
                }
                else if(string.IsNullOrEmpty(subject_txt.Text)){
                    MessageBox.Show("Enter subject");
                    subject_txt.Focus();
                }else if (string.IsNullOrEmpty(marks_txt.Text))
                {
                    MessageBox.Show("Enter marks");
                    subject_txt.Focus();
                }else if (string.IsNullOrWhiteSpace(year_cm.Text))
                {
                    MessageBox.Show("Enter year");
                    year_cm.Focus();
                }else if (string.IsNullOrWhiteSpace(term_cm.Text))
                {
                    MessageBox.Show("Enter term");
                    term_cm.Focus();
                }
                else if(string.IsNullOrWhiteSpace(class_cm.Text)){
                    MessageBox.Show("Enter class");
                    class_cm.Focus();
                }else if (string.IsNullOrWhiteSpace(exam_type.Text))
                {
                    MessageBox.Show("Enter exam type");
                    exam_type.Focus();
                } else {
                    string query = "insert into final_year_project.Results_table(STUDENT_NO, STUDENT_NAME, SUBJECT, MARKS,YEAR,TERM,CLASS,Exam_Type) VALUES ('" + this.student_no_txt.Text + "', '" + this.name_txt.Text + "', '" + this.subject_txt.Text + "', '" + this.marks_txt.Text + "','" + this.year_cm.Text + "','" + this.term_cm.Text + "','" + this.class_cm.Text + "',  '" + this.exam_type.Text + "');";

                    MySqlCommand commandDatabase = new MySqlCommand(query, con);
                    MySqlDataReader MyReader;
                    con.Open();
                    MyReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Saved");
                    while (MyReader.Read())
                    {

                    }
                    MyReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
               DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Results_table", con);
                
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message+" No record Found");

            }
            finally
            {
                con.Close();
            }
        }

        private void term_cm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from final_year_project.Results_table where STUDENT_NO='" + this.student_no_txt.Text + "';";
                MySqlCommand MyCommand = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = MyCommand.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Results_table where STUDENT_NO='" + this.student_no_txt.Text + "'", con);

                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void update_text_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "update Results_table set STUDENT_NO='"+ student_no_txt.Text + "',STUDENT_NAME='"+ name_txt.Text + "',SUBJECT='"+ subject_txt.Text + "',MARKS='"+ marks_txt.Text + "',TERM='"+ term_cm.Text + "',YEAR='"+ year_cm.Text + "',CLASS='"+ class_cm.Text + "',Exam_Type='"+ exam_type.Text + "' where STUDENT_NO='" + this.student_no_txt.Text + "';";
                MySqlCommand MyCommand = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = MyCommand.ExecuteReader();
                MessageBox.Show("Table is updated");
                while (MyReader2.Read())
                {
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void student_no_txt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(student_no_txt.Text))
            {
                fillcombo();
            }
        }

        private void year_cm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
