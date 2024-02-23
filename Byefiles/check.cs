using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Byefiles
{
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredPassword = textBox1.Text; // 获取输入的密码

            // 在这里添加密码验证逻辑，例如与预设密码比较

            if (enteredPassword == "Siri")
            {
                // 密码验证通过
                MessageBox.Show("密码验证通过！");
                this.DialogResult = DialogResult.OK; // 设置为 OK 表示验证通过
                this.Close(); // 关闭窗体
            }
            else
            {
                // 密码验证失败
                MessageBox.Show("密码验证失败，请重试！");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
