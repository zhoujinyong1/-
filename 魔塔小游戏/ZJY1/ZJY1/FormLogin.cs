using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PWMS.DataClass;

namespace ZJY1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //获取窗体数据
            string name = textName.Text.Trim();
            string password = textPassword.Text.Trim();

            //执行语句
            MyMeans.sqlstr = "select password,id from tb_user where name = '" + name + "'";
            MyMeans.get_cmd();

            if (name != "" & password != "")
            {
                MyMeans .reader.Read();
                if (MyMeans.reader.HasRows)       //判断是否有值，没有的话用户名错误
                {
                    string pwd = MyMeans.reader.GetString(MyMeans.reader.GetOrdinal("password"));
                    if (password.Equals(pwd))
                    {
                       User.Id = MyMeans.reader.GetInt32(1);               //将用户ID传到静态变量里      
                       MyMeans .cmd_close();    //关闭连接
                       FormMain formMain=new FormMain();
                       formMain.Show();
                       this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("用户名错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
            }
            else
            {
                MessageBox.Show("用户名或密码为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }        //登录

        private void textName_KeyPress(object sender, KeyPressEventArgs e)   //按Enter键鼠标到密码框
        {
            if (e.KeyChar == '\r')
            {
                textPassword.Focus();
            }
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)  //按Enter键鼠标到登录按钮
        {
            if (e.KeyChar == '\r')
            {
                buttonLogin.Focus();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)    //注册
        {
            FormRegister formRegister=new FormRegister();
            formRegister.Show();
            this.Hide();
        }

    }
}
