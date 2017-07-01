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
    public partial class signup : Form
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
        public signup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main Open = new main();
            Open.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (password_txt.Text== password_comfirm.Text) {
                    if (status_txt.Text=="Active") {
                        string query = "insert into final_year_project.login(NAME, STATUS, USERNAME, PASSWORD,CONFIRM_PASSWORD) VALUES ('" + this.name_txt.Text + "', '" + this.status_txt.Text + "', '" + this.username_txt.Text + "', '" + this.password_txt.Text + "','" + this.password_comfirm.Text + "');";

                        MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                        MySqlDataReader MyReader;
                        conn.Open();
                        MyReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Saved");
                        while (MyReader.Read())
                        {

                        }
                        MyReader.Close();
                    }
                    else
                    {
                        MessageBox.Show("for you to login status must be Active");
                        status_txt.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("password does match");
                    password_txt.Focus();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from final_year_project.login where NAME='" + this.name_txt.Text + "';";
                //MySqlConnection con = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand = new MySqlCommand(Query, conn);
                MySqlDataReader MyReader2;
                conn.Open();
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
                conn.Close();
            }
        }
    }
}
