using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Byefiles
{
    public partial class Form1 : Form
    {
        public check childForm;
        public Form1()
        {
            InitializeComponent();
            LoadTextFromFile();
            LoadTextFromfile();
            this.IsMdiContainer = true; // 设置主窗体为 MdiContainer
            // 在窗体加载时自动执行加载文本文件的操作

            //导入txt文件
            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 读取选定的文本文件并将内容加载到 TextBox 中
                string filePath = openFileDialog.FileName;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    textBox1.Text = reader.ReadToEnd();
                    textBox4.Text = reader.ReadToEnd();
                }
            }*/

        }

        private void LoadTextFromFile()
        {
            string filePath = @"output.txt";

           /* try
            {*/
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        textBox1.Text = reader.ReadToEnd();
                    }
                }
               /* else
                {
                    MessageBox.Show("文件不存在。");
                }*/
            /*}*/
            /*catch (IOException e)
            {
                MessageBox.Show($"读取文件时出错: {e.Message}");
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show($"没有权限读取文件: {e.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($"发生了未知错误: {e.Message}");
            }*/
        }

        private void LoadTextFromfile()
        {
            string filePath = @"file.txt";

          /*  try
            {*/
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        textBox4.Text = reader.ReadToEnd();
                    }
                }
             /*   else
                {
                    MessageBox.Show("文件不存在。");
                }*/
           /* }*/
          /*  catch (IOException e)
            {
                MessageBox.Show($"读取文件时出错: {e.Message}");
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show($"没有权限读取文件: {e.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($"发生了未知错误: {e.Message}");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 将textBox1的文本添加到textBox2中
            textBox1.Text += textBox2.Text + Environment.NewLine;

            // 将textBox2的文本保存到文件中


            SaveToFile(textBox1.Text);
        }

        static void SaveToFile(string text)
        {
            // 指定保存文件的路径
            string filePath = "output.txt";

            // 将文本写入文件
            File.WriteAllText(filePath, text);
            Console.WriteLine("文本已保存到文件：" + filePath);
        }

        private void DeleteData()
        {

            /*string[] folderPaths = new string[] { textBox1.Text };*/
            // 假设您的 TextBox 名为 textBoxPaths
            //添加已选路径
            string[] folderPaths = textBox1.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            /*string[] folderPaths = { @"C:\Users\gchen\Desktop\1" , @"C:\Users\gchen\Desktop\2" };*/

            // 替换以下路径为你要删除的文件夹路径数组

            try
            {
                foreach (string folderPath in folderPaths)
                {
                    if (Directory.Exists(folderPath))
                    {
                        Directory.Delete(folderPath, true); // 第二个参数表示递归删除文件夹及其内容
                        MessageBox.Show($"Folder deleted: {folderPath}");
                    }
                    else
                    {
                        MessageBox.Show($"Folder not found: {folderPath}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            // 在这里执行删除数据的操作
            // ...
            /*MessageBox.Show("数据已删除！");*/
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            /*if (childForm == null || childForm.IsDisposed)
            {*/
                
                childForm = new check();
                // 将主窗体设置为子窗体的父窗体
                /*childForm.MdiParent = this;
                // 显示子窗体
                *//*childForm.Show();*//*
                // 设置 Visible 属性为 false
                childForm.Visible = false;
                childForm.Parent.Controls.Remove(childForm);
                // 显示 Form2 窗体为模式对话框
                childForm.ShowDialog();*/


                if (childForm.ShowDialog() == DialogResult.OK)
                {
                    // 密码验证通过，执行删除数据的操作
                    DeleteData();
                    textBox1.Clear();
                    textBox2.Clear();

                    File.WriteAllText("output.txt", string.Empty);
                    Console.WriteLine("文件内容已清空。");
                    
                }
                
           /* }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 将textBox1的文本添加到textBox2中
            textBox4.Text += textBox3.Text + Environment.NewLine;

            // 将textBox2的文本保存到文件中


            SaveTofile(textBox4.Text);
        }

        static void SaveTofile(string text)
        {
            // 指定保存文件的路径
            string filePath = "file.txt";

            // 将文本写入文件
            File.WriteAllText(filePath, text);
            Console.WriteLine("文本已保存到文件：" + filePath);
        }

        private void Deletedata()
        {

            /*string[] folderPaths = new string[] { textBox1.Text };*/
            // 假设您的 TextBox 名为 textBoxPaths
            //添加已选路径
            string[] filepaths = textBox4.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            /*string[] folderPaths = { @"C:\Users\gchen\Desktop\1" , @"C:\Users\gchen\Desktop\2" };*/

            // 替换以下路径为你要删除的文件夹路径数组

            try
            {
                foreach (string filePath in filepaths)
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath); // 第二个参数表示递归删除文件夹及其内容
                        MessageBox.Show($"File deleted: {filePath}");
                    }
                    else
                    {
                        MessageBox.Show($"File not found: {filePath}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            // 在这里执行删除数据的操作
            // ...
            /*MessageBox.Show("数据已删除！");*/
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* if (childForm == null || childForm.IsDisposed)
            {*/
                childForm = new check();
                // 将主窗体设置为子窗体的父窗体
                /*childForm.MdiParent = this;
                // 显示子窗体
                childForm.Show();*/
                if (childForm.ShowDialog() == DialogResult.OK)
                {
                    // 密码验证通过，执行删除数据的操作
                    Deletedata();
                    textBox3.Clear();
                    textBox4.Clear();
                    File.WriteAllText("file.txt", string.Empty);
                    Console.WriteLine("文件内容已清空。");
                }
            /*}*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 创建一个 FolderBrowserDialog 对象
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // 设置对话框的标题和提示信息
            folderBrowserDialog.Description = "请选择输出文件夹";
            folderBrowserDialog.ShowNewFolderButton = true; // 允许用户创建新文件夹

            // 打开对话框，并等待用户选择文件夹
            DialogResult result = folderBrowserDialog.ShowDialog();

            // 检查用户是否点击了“确定”按钮
            if (result == DialogResult.OK)
            {
                // 获取用户选择的文件夹路径
                string selectedFolderPath = folderBrowserDialog.SelectedPath;

                // 输出所选文件夹的地址
                Console.WriteLine("您选择的文件夹路径是：" + selectedFolderPath);
                textBox2.Text = selectedFolderPath;
            }
            else
            {
                Console.WriteLine("用户取消了文件夹选择。");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 创建一个 OpenFileDialog 对象
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 设置对话框的标题和提示信息
            openFileDialog.Title = "请选择文件";
            openFileDialog.Filter = "所有文件 (*.*)|*.*"; // 设置文件过滤器，这里选择所有文件

            // 打开对话框，并等待用户选择文件
            DialogResult result = openFileDialog.ShowDialog();

            // 检查用户是否点击了“确定”按钮
            if (result == DialogResult.OK)
            {
                // 获取用户选择的文件路径
                string selectedFilePath = openFileDialog.FileName;

                // 输出所选文件的地址
                Console.WriteLine("您选择的文件路径是：" + selectedFilePath);
                textBox3.Text = selectedFilePath;
            }
            else
            {
                Console.WriteLine("用户取消了文件选择。");
            }
        }
    }
}
