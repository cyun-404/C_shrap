using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WinForms_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_newmember_Click(object sender, EventArgs e)
        {
            Form2 showform2 = new Form2();
            showform2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_pwd_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = localhost;Database=db_test;Uid=root;Pwd=1234;");
                connection.Open();

                int login_status = 0;

                string loginid = txtbox_id.Text;
                string loginpwd = txtbox_pwd.Text;

                string selectQuery = "SELECT * FROM account_info WHERE id = \'" + loginid + "\' ";
                MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);

                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["id"] && loginpwd == (string)userAccount["pwd"])
                    {
                        login_status = 1;
                    }
                }
                connection.Close();

                if (login_status == 1)
                {
                    MessageBox.Show("로그인 완료");
                }
                else
                {
                    MessageBox.Show("회원 정보를 확인해 주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}