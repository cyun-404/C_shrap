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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_pwd_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtbox_id_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btn_newmember_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = localhost;Database=db_test;Uid=root;Pwd=1234;");
                connection.Open();

                string insertQuery = "INSERT INTO account_info (name, id, pwd) VALUES ('" + txtbox_name.Text + "', '" + txtbox_id.Text + "', '" + txtbox_pwd.Text + "');";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(txtbox_name.Text + "님 회원가입 완료, 사용할 아이디는 " + txtbox_id.Text + "입니다.");
                    connection.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("비정상 입력 정보, 재확인 요망");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtbox_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
