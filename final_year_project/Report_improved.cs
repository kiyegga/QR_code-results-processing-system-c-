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
using MessagingToolkit.QRCode.Codec.Data;

namespace final_year_project
{
    public partial class Report_improved : Form
    {
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
        public Report_improved()
        {
            InitializeComponent();
            fillcombo();
        }
       private void fillcombo()
        {
            try
            {

                using (MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                {


                    
                    MySqlCommand MyCommand = new MySqlCommand("select Student_name, Year, CLASS, Term, Student_no from Report_marks WHERE Student_no LIKE '%" + Student_no.Text + "%'", con);
                    con.Open();
                    MySqlDataReader MyReader2 = MyCommand.ExecuteReader();
                    if (MyReader2.Read())
                    {
                        class_cm.Text = MyReader2["CLASS"].ToString();
                        year_cm.Text = MyReader2["YEAR"].ToString();
                        term_cm.Text = MyReader2["TERM"].ToString();
                        Student_no.Text = MyReader2["student_no"].ToString();
                        student_name.Text = MyReader2["STUDENT_NAME"].ToString();
                    }
                    MyReader2.Close();
                    con.Close();
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Report_improved_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private DataTable finalTable;
        private void search_Click(object sender, EventArgs e)
        {
           
                try
                {
                if (string.IsNullOrEmpty(Student_no.Text))
                {
                    MessageBox.Show("Enter Student number");
                    Student_no.Focus();
                }
                else if (string.IsNullOrEmpty(class_cm.Text))
                {
                    MessageBox.Show("Enter class");
                    class_cm.Focus();
                }
                else if (string.IsNullOrEmpty(term_cm.Text))
                {
                    MessageBox.Show("Enter the term");
                    term_cm.Focus();
                }
                else if (string.IsNullOrEmpty(year_cm.Text))
                {
                    MessageBox.Show("Enter the year");
                    year_cm.Focus();
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
                    con.Open();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT Subject,Mid_term,End_of_term from report_marks WHERE Student_no='" + Student_no.Text + "' AND Term='" + term_cm.Text + "' AND Year='" + year_cm.Text + "'", con);

                    da.Fill(dt);

                    finalTable = new DataTable();
                    finalTable.Columns.Add("SUBJECT");
                    finalTable.Columns.Add("MID TERM");
                    finalTable.Columns.Add("END TERM");
                    finalTable.Columns.Add("AVERAGE");
                    finalTable.Columns.Add("GRADE");
                    finalTable.Columns.Add("COMMENT");
                    int total = 0;

                    foreach(DataRow row in dt.Rows)
                    {
                        var average = (Convert.ToInt32(row["Mid_term"]) + Convert.ToInt32(row["End_of_term"]))/2;
                        if (average >= 85 && average <=100)
                        {
                            finalTable.Rows.Add(row[0], row[1], row[2], average, "D1", "Excellent");
                            total += 1;
                        }else if (average <= 85 && average >= 75)
                        {
                            finalTable.Rows.Add(row[0], row[1], row[2], average, "D2", "Every Good");
                            total += 2;
                        }
                        else if (average <= 75 && average >= 65)
                        {
                            finalTable.Rows.Add(row[0], row[1], row[2], average, "C3", " Good");
                            total += 3;
                        }
                        else if (average <= 65 && average >= 60)
                        {
                            finalTable.Rows.Add(row[0], row[1], row[2], average, "C4", " Good");
                            total += 4;
                        }
                        else if (average <= 60 && average >= 55)
                        {
                            finalTable.Rows.Add(row[0], row[1], row[2], average, "C5", " Fair");
                            total += 5;
                        }
                        else if (average <= 55 && average >= 50)
                        {
                            finalTable.Rows.Add(row[0], row[1], row[2], average, "C6", " Tried");
                            total += 6;
                        }
                        else if (average <= 50 && average >= 45)
                        {
                            finalTable.Rows.Add(row[0], row[1], row[2], average, "P7", " Pull up socks");
                            total += 7;
                        }
                        else if (average <= 45 && average >= 40)
                        {
                            finalTable.Rows.Add(row[0], row[1], row[2], average, "P8", " Needs help");
                            total += 8;
                        }
                        else if (average <= 40 && average >= 0)
                        {
                            finalTable.Rows.Add(row[0], row[1], row[2], average, "F9", " Need serous help");
                            total += 9;
                        }
                        else
                        {
                            MessageBox.Show("out of range");
                        }
                    }






                    dataGridView1.DataSource = finalTable;
                    aggregates.Text = total.ToString();
                    if (total <= 32)
                    {
                        division.Text = " division 1";
                    }
                    else if (total <= 45 && total > 32)
                    {
                        division.Text = "division 2";
                    }
                    else if (total <= 52 && total > 45)
                    {
                        division.Text = "division 3";
                    }
                    else if (total <= 62 && total > 52)
                    {
                        division.Text = "division 4";
                    }
                    else if (total <= 72 && total > 62)
                    {
                        division.Text = "Ungraded";
                    }
                    else
                    {
                        MessageBox.Show("Aggregates out of range");
                    }
                    txtEncoder.Text = student_name.Text + ", " + aggregates.Text + ", " + division.Text+ ","+ dt.Rows[0]["SUBJECT"].ToString()+" "+ dt.Rows[0]["End_of_term"].ToString() + "," + dt.Rows[1]["SUBJECT"].ToString() + " " + dt.Rows[1]["End_of_term"].ToString() + "," + dt.Rows[2]["SUBJECT"].ToString() + " " + dt.Rows[2]["End_of_term"].ToString() + "," + dt.Rows[3]["SUBJECT"].ToString() + " " + dt.Rows[3]["End_of_term"].ToString() + "," + dt.Rows[4]["SUBJECT"].ToString() + " " + dt.Rows[4]["End_of_term"].ToString();
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " No record Found");

                } 
                finally
                {
                    con.Close();
                }
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG | *.jpg", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                    encoder.QRCodeScale = 8;
                    Bitmap bmp = encoder.Encode(txtEncoder.Text);
                    pictureBox.Image = bmp;
                    bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                }
            }

        }


        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Student_no.Text))
            {
                fillcombo();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
