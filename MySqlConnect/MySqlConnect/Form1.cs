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
        //����     //DB�̸�      // �����̸�  //��й�ȣ
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
            //Į���� �߰��ϴ� Ŀ���� insertQuery
            string insertQuery = "INSERT INTO member_tb(name,age) VALUES('" + NameBox.Text + "'," + AgeBox.Text + ")";
            /* �߰��Ѵ�    ���̺� member_tb ���̺�  name �� age ��� �׸��� ���� �װ��� NameBox.Text ��  AgeBox.Text ���Է�
             �� ���̴�*/

            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try//���� ó��
            {
                // ���࿡ ����ó���� Mysql�� ���������� ���ٸ� �޼����� �����ֶ�� ���̴�
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("���������� ����");
                }
                else
                {
                    MessageBox.Show("������ �̴�");
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