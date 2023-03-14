namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // 폼 생성 메소드
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

        private void button17_Click(object sender, EventArgs e) // = 버튼
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
                // strSplit[i]가 double 타입인지 확인
                if (!splitIsNum) // false 인 경우 == 기호가 포함됨, 한번 더 분해
                {
                    if (delimiterCountTmp < delimiterLength) delimiterCountTmp++;
                    strSubSplit = EquationSpliter(strSplit[i],delimiter, delimiterCountTmp); // 재귀함수
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
                if(i==0) // 첫번째 입력 숫자를 그대로 받아옴
                {
                    result = Convert.ToDouble(strArr[i]);
                }
                else
                {
                    switch(delimiter) // switch 문 활용하여 계산 기호 구분
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