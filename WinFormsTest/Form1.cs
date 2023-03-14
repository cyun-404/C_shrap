namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // �� ���� �޼ҵ�
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnTmp = (Button)sender;
            textBox1.Text += btnTmp.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(button2.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e) // = ��ư
        {
            char[] delimiter = { '+', '-', '*', '/' };
            string[] strSplit =EquationSpliter(textBox1.Text, delimiter, 0);
            double result = 0;
            result = ArrayCalc(strSplit, '+');
            label1.Text= Convert.ToString(result);

        }

        string[] EquationSpliter(string equation, char[] delimiter, int delimiterCount)
        {
            int delimiterCountTmp = delimiterCount;
            int delimiterLength = delimiter.Length;
            string[] strSplit = equation.Split(delimiter[delimiterCount]);
            string[] strSubSplit;
            bool splitIsNum = false;

            for(int i =0; i<strSplit.Length;i++) 
            {
                double splitNum = 0;
                splitIsNum = double.TryParse(strSplit[i], out splitNum);
                // strSplit[i]�� double Ÿ������ Ȯ��
                if (!splitIsNum) // false �� ��� == ��ȣ�� ���Ե�, �ѹ� �� ����
                {
                    if (delimiterCountTmp < delimiterLength) delimiterCountTmp++;
                    strSubSplit = EquationSpliter(strSplit[i],delimiter, delimiterCountTmp); // ����Լ�
                    splitNum = ArrayCalc(strSubSplit, delimiter[delimiterCountTmp]);
                }
                delimiterCountTmp = delimiterCount;
                strSplit[i] = Convert.ToString(splitNum);
            }
            return strSplit;
            
            
        }

        private double ArrayCalc(string[] strArr, char delimiter)
        {
            double result = 0;
            for(int i = 0;i<strArr.Length; i++)
            {
                if(i==0) // ù��° �Է� ���ڸ� �״�� �޾ƿ�
                {
                    result = Convert.ToDouble(strArr[i]);
                }
                else
                {
                    switch(delimiter) // switch �� Ȱ���Ͽ� ��� ��ȣ ����
                    {
                        case '+':
                            result += Convert.ToDouble(strArr[i]);
                            break;
                        case '-':
                            result -= Convert.ToDouble(strArr[i]);
                            break;
                        case '*':
                            result *= Convert.ToDouble(strArr[i]);
                            break;
                        case '/':
                            result /= Convert.ToDouble(strArr[i]);
                            break;

                    }
                }
            }
            return result;
        }
    }
}