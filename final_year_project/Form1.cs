using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace final_year_project
{
   
    public partial class login_form : Form
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
        public login_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(usernameTxt.Text))
                {
                    MessageBox.Show("Enter username");
                    usernameTxt.Focus();
                }
                else if (string.IsNullOrEmpty(passwordTxt.Text))
                {
                    MessageBox.Show("Enter password");
                    usernameTxt.Focus();
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM login WHERE username=@1 AND password=@2 AND status='Active' AND PERMISSION=@3", conn);
                    cmd.Parameters.AddWithValue("@1", usernameTxt.Text);
                    cmd.Parameters.AddWithValue("@2", passwordTxt.Text);
                    cmd.Parameters.AddWithValue("@3", permission_cm.Text);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        main OpenForm = new main();
                        OpenForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username and password!");
                        username.Focus();
                    }

                }   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
             
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordTxt.UseSystemPasswordChar = false;
            }
            else
            {
               
                passwordTxt.UseSystemPasswordChar = true;
            }
        }
    }
}
