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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string affirmpassword = textBoxAffirmPassword.Text.Trim();
            string phone = textBoxPhone.Text.Trim();

            MyMeans.sqlstr = "select name from tb_user where name ='" + name + "'";
            MyMeans.get_cmd();
           
            if (name != "")
            {
                MyMeans.reader.Read();
                if (MyMeans.reader.HasRows)             //查到有值，则已经注册。
                {
                    MessageBox.Show("用户名已存在");
                }
                else
                {
                    MyMeans.cmd_close();     //关闭连接
                     if (password != "")
                     {
                         if (affirmpassword != "")
                         {
                             if (password.Equals(affirmpassword))
                             {
                                 if (phone != "")
                                 {
                                     MyMeans.sqlstr = "insert into tb_user(name,password,phone) values('" + name + "','" + password + "','" + phone + "')";   //添加用户
                                     MyMeans.get_cmdsql();
                                     if (MyMeans.b)   //判断是否执行成功
                                     {
                                         MyMeans.con_close();
                                         MyMeans.sqlstr = "select id from tb_user where name ='" + name + "'";  //找用户id
                                         MyMeans.get_cmd();
                                         MyMeans.reader.Read();
                                         if (MyMeans.reader.HasRows)
                                         {
                                             int id = MyMeans.reader.GetInt32(0);
                                             MyMeans.cmd_close();
                                             MyMeans.sqlstr = "insert into tb_game(uid,number,lv,life,attack,defense,experience,gold,keyyellow,keyblue,keyred,keyqing) values('" + id + "','" + 1 + "','" + 1 + "','" + 100 + "','" + 5 + "','" + 5 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 1 + "','" + 1 + "')";
                                             MyMeans.get_cmdsql();
                                                 if (MyMeans.b)
                                                 {
                                                     MyMeans.con_close();
                                                     MessageBox.Show("注册成功");
                                                     textBoxName.Text = "";
                                                     textBoxPassword.Text = "";
                                                     textBoxAffirmPassword.Text = "";
                                                     textBoxPhone.Text = "";
                                                 }
                                                 
                                         }
                                       
                                     }
                                     else
                                     {
                                         MessageBox.Show("注册失败");
                                     }
                                 }
                                 else
                                 {
                                     MessageBox.Show("请输入手机号");
                                 }
                             }
                             else
                             {
                                 MessageBox.Show("两次输入密码不一致");
                             }
                         }
                         else
                         {
                             MessageBox.Show("请输入确认密码");
                         }
                     }
                     else
                     {
                         MessageBox.Show("请输入密码");
                     }
                }
            }
            else
            {
                MessageBox.Show("请输入用户名");
            }
        }   //注册

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormLogin formLogin =new FormLogin();
            formLogin.Show();
            this.Close();
        }       //返回

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)    //按Enter键鼠标到密码框
        {
            if (e.KeyChar == '\r')
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)  //按Enter键鼠标到确认密码框
        {
            if (e.KeyChar == '\r')
            {
                textBoxAffirmPassword.Focus();
            }
        }

        private void textBoxAffirmPassword_KeyPress(object sender, KeyPressEventArgs e)  //按Enter键鼠标到手机框
        {
            if (e.KeyChar == '\r')
            {
                textBoxPhone.Focus();
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)  //按Enter键鼠标到注册按钮
        {
            if (e.KeyChar == '\r')
            {
                buttonRegister.Focus();
            }
        }     

    }
}
