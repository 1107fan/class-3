using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            double ans = 0;

            for (double i = 0.5; i <= 10; i = i + 0.5)

                ans = ans + i;
            textBox1.Text = ans.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double ans = 0;
                for (int i = 1; i <= 10; i++)
                {
                    ans += i;
                }
                textBox1.Text = ans.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ans = 0;
            for (int i = 11; i >= 1; i -= 2)
            {
                ans += i;
            }
            textBox1.Text = ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox2.Text); // 从文本框获取输入的n值
                Console.WriteLine("输入的n值是：" + n); // 調適输出

                long result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                textBox1.Text = result.ToString();
            }
            catch
            {
                textBox1.Text = "輸入錯誤"; // 如果输入不正確，显示错误信息
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox2.Text);  // 获取用户输入的 n 值
                if (n == 0)
                {
                    textBox1.Text = "0";  // F(0) = 0
                    return;
                }
                else if (n == 1)
                {
                    textBox1.Text = "1";  // F(1) = 1
                    return;
                }

                // 计算斐波那契数列的第 n 项
                long a = 0, b = 1, result = 0;

                for (int i = 2; i <= n; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }

                textBox1.Text = result.ToString();
            }
            catch
            {
                textBox1.Text = "輸入錯誤";  // 如果输入不合法，显示错误信息
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // 从文本框获取开始值、结束值和步长
                double start = double.Parse(textBox4.Text);  // 起始值
                double end = double.Parse(textBox5.Text);    // 结束值
                double step = double.Parse(textBox6.Text);   // 步长

                // 初始化结果
                double ans = 0;

                // 使用步长来循环从start到end
                for (double i = start; i <= end; i += step)
                {
                    ans += i; // 每次加上当前数值
                }

                // 将结果显示在textBox1中
                textBox1.Text = ans.ToString();
            }
            catch
            {
                // 如果输入无效，显示错误信息
                textBox1.Text = "輸入錯誤";
            }
        }
    }
}
