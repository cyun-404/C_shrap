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

namespace MySqlConnect
{
    public partial class Form1 : Form
    {
        MySqlConnection connection =
        new MySqlConnection("Server=localhost;Database=member1;Uid=root;Pwd=1234;");
        //서버     //DB이름      // 유저이름  //비밀번호
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            //칼럼에 추가하는 커리문 insertQuery
            string insertQuery = "INSERT INTO member_tb(name,age) VALUES('" + NameBox.Text + "'," + AgeBox.Text + ")";
            /* 추가한다    테이블 member_tb 테이블에  name 과 age 라는 항목의 값을 그값은 NameBox.Text 와  AgeBox.Text 에입력
             된 값이다*/

            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("정상적으로 갔다");
                }
                else
                {
                    MessageBox.Show("비정상 이당");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();
        }
    }
}