using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PWMS.DataClass;

namespace ZJY1
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonUp_Click(object sender, EventArgs e) //上
        {
            PictureBox[,] pb = new PictureBox[11, 11]
            {
                {pictureBox1_1,pictureBox1_2,pictureBox1_3,pictureBox1_4,pictureBox1_5,pictureBox1_6,pictureBox1_7,pictureBox1_8,pictureBox1_9,pictureBox1_10,pictureBox1_11},
                {pictureBox2_1,pictureBox2_2,pictureBox2_3,pictureBox2_4,pictureBox2_5,pictureBox2_6,pictureBox2_7,pictureBox2_8,pictureBox2_9,pictureBox2_10,pictureBox2_11},
                {pictureBox3_1,pictureBox3_2,pictureBox3_3,pictureBox3_4,pictureBox3_5,pictureBox3_6,pictureBox3_7,pictureBox3_8,pictureBox3_9,pictureBox3_10,pictureBox3_11},
                {pictureBox4_1,pictureBox4_2,pictureBox4_3,pictureBox4_4,pictureBox4_5,pictureBox4_6,pictureBox4_7,pictureBox4_8,pictureBox4_9,pictureBox4_10,pictureBox4_11},
                {pictureBox5_1,pictureBox5_2,pictureBox5_3,pictureBox5_4,pictureBox5_5,pictureBox5_6,pictureBox5_7,pictureBox5_8,pictureBox5_9,pictureBox5_10,pictureBox5_11},
                {pictureBox6_1,pictureBox6_2,pictureBox6_3,pictureBox6_4,pictureBox6_5,pictureBox6_6,pictureBox6_7,pictureBox6_8,pictureBox6_9,pictureBox6_10,pictureBox6_11},
                {pictureBox7_1,pictureBox7_2,pictureBox7_3,pictureBox7_4,pictureBox7_5,pictureBox7_6,pictureBox7_7,pictureBox7_8,pictureBox7_9,pictureBox7_10,pictureBox7_11},
                {pictureBox8_1,pictureBox8_2,pictureBox8_3,pictureBox8_4,pictureBox8_5,pictureBox8_6,pictureBox8_7,pictureBox8_8,pictureBox8_9,pictureBox8_10,pictureBox8_11},
                {pictureBox9_1,pictureBox9_2,pictureBox9_3,pictureBox9_4,pictureBox9_5,pictureBox9_6,pictureBox9_7,pictureBox9_8,pictureBox9_9,pictureBox9_10,pictureBox9_11},
                {pictureBox10_1,pictureBox10_2,pictureBox10_3,pictureBox10_4,pictureBox10_5,pictureBox10_6,pictureBox10_7,pictureBox10_8,pictureBox10_9,pictureBox10_10,pictureBox10_11},
                {pictureBox11_1,pictureBox11_2,pictureBox11_3,pictureBox11_4,pictureBox11_5,pictureBox11_6,pictureBox11_7,pictureBox11_8,pictureBox11_9,pictureBox11_10,pictureBox11_11}
            };
            Label[] lb = new Label[4] { labelKeyYellow, labelKeyBlue, labelKeyRed, labelKeyQin };
            int y = People.Y + 1;
            MainSql.mapxy(18, People.X, y);
            MyMeans.reader.Read();
            if (Int32.Parse(labelShenming.Text) > 0)    //生命大于0
            {
                pb[People.Y - 1, People.X - 1].Image = imageList1.Images[15];
                for (int j = 0; j < 15; j++)
                {
                    string map = "map" + j;
                    MainSql.mapxytable(j, map);
                    for (int i = 0; i < Int32.Parse(MyMeans.dt.Rows.Count.ToString()); i++)
                    {
                        if (People.X == Int32.Parse(MyMeans.dt.Rows[i][0].ToString()) & People.Y + 1 == Int32.Parse(MyMeans.dt.Rows[i][1].ToString()))
                        {
                            if (Count.Cs[People.Y - 1, People.X - 1] == 0)
                            {
                                if (j < 11)
                                {
                                    labelShenming.Text = (Int32.Parse(labelShenming.Text) + ClassShuXing.Sx[j, 0]).ToString();
                                    labelGongji.Text = (Int32.Parse(labelGongji.Text) + ClassShuXing.Sx[j, 1]).ToString();
                                    labelFangyu.Text = (Int32.Parse(labelFangyu.Text) + ClassShuXing.Sx[j, 2]).ToString();
                                    labelJingyan.Text = (Int32.Parse(labelJingyan.Text) + ClassShuXing.Sx[j, 3]).ToString();
                                    labelJingbi.Text = (Int32.Parse(labelJingbi.Text) + ClassShuXing.Sx[j, 4]).ToString();
                                    labelKeyYellow.Text = (Int32.Parse(labelKeyYellow.Text) + ClassShuXing.Sx[j, 5]).ToString();
                                    labelKeyBlue.Text = (Int32.Parse(labelKeyBlue.Text) + ClassShuXing.Sx[j, 6]).ToString();
                                    labelKeyRed.Text = (Int32.Parse(labelKeyRed.Text) + ClassShuXing.Sx[j, 7]).ToString();
                                    labelKeyQin.Text = (Int32.Parse(labelKeyQin.Text) + ClassShuXing.Sx[j, 8]).ToString();
                                    Count.Cs[People.Y - 1, People.X - 1] = 1;
                                }
                                else
                                {
                                    if (Int32.Parse(lb[j - 11].Text) > 0)
                                    {
                                        labelShenming.Text = (Int32.Parse(labelShenming.Text) + ClassShuXing.Sx[j, 0]).ToString();
                                        labelGongji.Text = (Int32.Parse(labelGongji.Text) + ClassShuXing.Sx[j, 1]).ToString();
                                        labelFangyu.Text = (Int32.Parse(labelFangyu.Text) + ClassShuXing.Sx[j, 2]).ToString();
                                        labelJingyan.Text = (Int32.Parse(labelJingyan.Text) + ClassShuXing.Sx[j, 3]).ToString();
                                        labelJingbi.Text = (Int32.Parse(labelJingbi.Text) + ClassShuXing.Sx[j, 4]).ToString();
                                        labelKeyYellow.Text = (Int32.Parse(labelKeyYellow.Text) + ClassShuXing.Sx[j, 5]).ToString();
                                        labelKeyBlue.Text = (Int32.Parse(labelKeyBlue.Text) + ClassShuXing.Sx[j, 6]).ToString();
                                        labelKeyRed.Text = (Int32.Parse(labelKeyRed.Text) + ClassShuXing.Sx[j, 7]).ToString();
                                        labelKeyQin.Text = (Int32.Parse(labelKeyQin.Text) + ClassShuXing.Sx[j, 8]).ToString();
                                        Count.Cs[People.Y - 1, People.X - 1] = 1;
                                    }
                                    else
                                    {
                                        MessageBox.Show("没有钥匙");
                                        People.Y = People.Y - 1;
                                        pictureBoxPeople.Top = pictureBoxPeople.Top + 45;
                                        Count.Cs[People.Y - 1, People.X - 1] = 0;
                                    }
                                }

                            }

                        }
                    }
                }
                if (People.Y+1>=12)   //不能超过上边界
                {
                }
                else
                {
                    if (MyMeans.reader.HasRows)
                    {
                        MyMeans.cmd_close();
                    }
                    else
                    {
                            People.Y = People.Y + 1;
                            pictureBoxPeople.Top = pictureBoxPeople.Top - 45;        
                    }
                }
            }
            else
            {
                MessageBox.Show("game over");
            }
            label3.Text = People.X.ToString();
            label11.Text = People.Y.ToString();
        } //上

        private void buttonDown_Click(object sender, EventArgs e)   //下
        {
           PictureBox[,] pb = new PictureBox[11, 11]
            {
                {pictureBox1_1,pictureBox1_2,pictureBox1_3,pictureBox1_4,pictureBox1_5,pictureBox1_6,pictureBox1_7,pictureBox1_8,pictureBox1_9,pictureBox1_10,pictureBox1_11},
                {pictureBox2_1,pictureBox2_2,pictureBox2_3,pictureBox2_4,pictureBox2_5,pictureBox2_6,pictureBox2_7,pictureBox2_8,pictureBox2_9,pictureBox2_10,pictureBox2_11},
                {pictureBox3_1,pictureBox3_2,pictureBox3_3,pictureBox3_4,pictureBox3_5,pictureBox3_6,pictureBox3_7,pictureBox3_8,pictureBox3_9,pictureBox3_10,pictureBox3_11},
                {pictureBox4_1,pictureBox4_2,pictureBox4_3,pictureBox4_4,pictureBox4_5,pictureBox4_6,pictureBox4_7,pictureBox4_8,pictureBox4_9,pictureBox4_10,pictureBox4_11},
                {pictureBox5_1,pictureBox5_2,pictureBox5_3,pictureBox5_4,pictureBox5_5,pictureBox5_6,pictureBox5_7,pictureBox5_8,pictureBox5_9,pictureBox5_10,pictureBox5_11},
                {pictureBox6_1,pictureBox6_2,pictureBox6_3,pictureBox6_4,pictureBox6_5,pictureBox6_6,pictureBox6_7,pictureBox6_8,pictureBox6_9,pictureBox6_10,pictureBox6_11},
                {pictureBox7_1,pictureBox7_2,pictureBox7_3,pictureBox7_4,pictureBox7_5,pictureBox7_6,pictureBox7_7,pictureBox7_8,pictureBox7_9,pictureBox7_10,pictureBox7_11},
                {pictureBox8_1,pictureBox8_2,pictureBox8_3,pictureBox8_4,pictureBox8_5,pictureBox8_6,pictureBox8_7,pictureBox8_8,pictureBox8_9,pictureBox8_10,pictureBox8_11},
                {pictureBox9_1,pictureBox9_2,pictureBox9_3,pictureBox9_4,pictureBox9_5,pictureBox9_6,pictureBox9_7,pictureBox9_8,pictureBox9_9,pictureBox9_10,pictureBox9_11},
                {pictureBox10_1,pictureBox10_2,pictureBox10_3,pictureBox10_4,pictureBox10_5,pictureBox10_6,pictureBox10_7,pictureBox10_8,pictureBox10_9,pictureBox10_10,pictureBox10_11},
                {pictureBox11_1,pictureBox11_2,pictureBox11_3,pictureBox11_4,pictureBox11_5,pictureBox11_6,pictureBox11_7,pictureBox11_8,pictureBox11_9,pictureBox11_10,pictureBox11_11}
            };
            Label[] lb = new Label[4] { labelKeyYellow, labelKeyBlue, labelKeyRed, labelKeyQin };
            int y = People.Y - 1;
            MainSql.mapxy(18, People.X, y);
            MyMeans.reader.Read();
            if (Int32.Parse(labelShenming.Text) > 0)    //生命大于0
            {
                pb[People.Y - 1, People.X - 1].Image = imageList1.Images[15];
                for (int j = 0; j < 15; j++)
                {
                    string map = "map" + j;
                    MainSql.mapxytable(j, map);
                    for (int i = 0; i < Int32.Parse(MyMeans.dt.Rows.Count.ToString()); i++)
                    {
                        if (People.X == Int32.Parse(MyMeans.dt.Rows[i][0].ToString()) & People.Y - 1 == Int32.Parse(MyMeans.dt.Rows[i][1].ToString()))
                        {
                            if (Count.Cs[People.Y - 1, People.X - 1] == 0)
                            {
                                if (j < 11)
                                {
                                    labelShenming.Text = (Int32.Parse(labelShenming.Text) + ClassShuXing.Sx[j, 0]).ToString();
                                    labelGongji.Text = (Int32.Parse(labelGongji.Text) + ClassShuXing.Sx[j, 1]).ToString();
                                    labelFangyu.Text = (Int32.Parse(labelFangyu.Text) + ClassShuXing.Sx[j, 2]).ToString();
                                    labelJingyan.Text = (Int32.Parse(labelJingyan.Text) + ClassShuXing.Sx[j, 3]).ToString();
                                    labelJingbi.Text = (Int32.Parse(labelJingbi.Text) + ClassShuXing.Sx[j, 4]).ToString();
                                    labelKeyYellow.Text = (Int32.Parse(labelKeyYellow.Text) + ClassShuXing.Sx[j, 5]).ToString();
                                    labelKeyBlue.Text = (Int32.Parse(labelKeyBlue.Text) + ClassShuXing.Sx[j, 6]).ToString();
                                    labelKeyRed.Text = (Int32.Parse(labelKeyRed.Text) + ClassShuXing.Sx[j, 7]).ToString();
                                    labelKeyQin.Text = (Int32.Parse(labelKeyQin.Text) + ClassShuXing.Sx[j, 8]).ToString();
                                    Count.Cs[People.Y - 1, People.X - 1] = 1;
                                }
                                else
                                {
                                    if (Int32.Parse(lb[j - 11].Text) > 0)
                                    {
                                        labelShenming.Text = (Int32.Parse(labelShenming.Text) + ClassShuXing.Sx[j, 0]).ToString();
                                        labelGongji.Text = (Int32.Parse(labelGongji.Text) + ClassShuXing.Sx[j, 1]).ToString();
                                        labelFangyu.Text = (Int32.Parse(labelFangyu.Text) + ClassShuXing.Sx[j, 2]).ToString();
                                        labelJingyan.Text = (Int32.Parse(labelJingyan.Text) + ClassShuXing.Sx[j, 3]).ToString();
                                        labelJingbi.Text = (Int32.Parse(labelJingbi.Text) + ClassShuXing.Sx[j, 4]).ToString();
                                        labelKeyYellow.Text = (Int32.Parse(labelKeyYellow.Text) + ClassShuXing.Sx[j, 5]).ToString();
                                        labelKeyBlue.Text = (Int32.Parse(labelKeyBlue.Text) + ClassShuXing.Sx[j, 6]).ToString();
                                        labelKeyRed.Text = (Int32.Parse(labelKeyRed.Text) + ClassShuXing.Sx[j, 7]).ToString();
                                        labelKeyQin.Text = (Int32.Parse(labelKeyQin.Text) + ClassShuXing.Sx[j, 8]).ToString();
                                        Count.Cs[People.Y - 1, People.X - 1] = 1;
                                    }
                                    else
                                    {
                                        MessageBox.Show("没有钥匙");
                                        People.Y = People.Y + 1;
                                        pictureBoxPeople.Top = pictureBoxPeople.Top - 45;
                                        Count.Cs[People.Y - 1, People.X - 1] = 0;
                                    }
                                }
                            }

                        }
                    }
                }
                if (People.Y-1<=0)   //不能超过下边界
                {
                }
                else
                {
                    if (MyMeans.reader.HasRows)
                    {
                        MyMeans.cmd_close();
                    }
                    else
                    {
                            People.Y = People.Y - 1;
                            pictureBoxPeople.Top = pictureBoxPeople.Top + 45;                         
                    }
                }
            }
            else
            {
                MessageBox.Show("game over");
            }
            label3.Text = People.X.ToString();
            label11.Text = People.Y.ToString();         
        } //下

        private void buttonLeft_Click(object sender, EventArgs e)//左
        {
             PictureBox[,] pb = new PictureBox[11, 11]
            {
                {pictureBox1_1,pictureBox1_2,pictureBox1_3,pictureBox1_4,pictureBox1_5,pictureBox1_6,pictureBox1_7,pictureBox1_8,pictureBox1_9,pictureBox1_10,pictureBox1_11},
                {pictureBox2_1,pictureBox2_2,pictureBox2_3,pictureBox2_4,pictureBox2_5,pictureBox2_6,pictureBox2_7,pictureBox2_8,pictureBox2_9,pictureBox2_10,pictureBox2_11},
                {pictureBox3_1,pictureBox3_2,pictureBox3_3,pictureBox3_4,pictureBox3_5,pictureBox3_6,pictureBox3_7,pictureBox3_8,pictureBox3_9,pictureBox3_10,pictureBox3_11},
                {pictureBox4_1,pictureBox4_2,pictureBox4_3,pictureBox4_4,pictureBox4_5,pictureBox4_6,pictureBox4_7,pictureBox4_8,pictureBox4_9,pictureBox4_10,pictureBox4_11},
                {pictureBox5_1,pictureBox5_2,pictureBox5_3,pictureBox5_4,pictureBox5_5,pictureBox5_6,pictureBox5_7,pictureBox5_8,pictureBox5_9,pictureBox5_10,pictureBox5_11},
                {pictureBox6_1,pictureBox6_2,pictureBox6_3,pictureBox6_4,pictureBox6_5,pictureBox6_6,pictureBox6_7,pictureBox6_8,pictureBox6_9,pictureBox6_10,pictureBox6_11},
                {pictureBox7_1,pictureBox7_2,pictureBox7_3,pictureBox7_4,pictureBox7_5,pictureBox7_6,pictureBox7_7,pictureBox7_8,pictureBox7_9,pictureBox7_10,pictureBox7_11},
                {pictureBox8_1,pictureBox8_2,pictureBox8_3,pictureBox8_4,pictureBox8_5,pictureBox8_6,pictureBox8_7,pictureBox8_8,pictureBox8_9,pictureBox8_10,pictureBox8_11},
                {pictureBox9_1,pictureBox9_2,pictureBox9_3,pictureBox9_4,pictureBox9_5,pictureBox9_6,pictureBox9_7,pictureBox9_8,pictureBox9_9,pictureBox9_10,pictureBox9_11},
                {pictureBox10_1,pictureBox10_2,pictureBox10_3,pictureBox10_4,pictureBox10_5,pictureBox10_6,pictureBox10_7,pictureBox10_8,pictureBox10_9,pictureBox10_10,pictureBox10_11},
                {pictureBox11_1,pictureBox11_2,pictureBox11_3,pictureBox11_4,pictureBox11_5,pictureBox11_6,pictureBox11_7,pictureBox11_8,pictureBox11_9,pictureBox11_10,pictureBox11_11}
            };
             Label[] lb = new Label[4] { labelKeyYellow, labelKeyBlue, labelKeyRed, labelKeyQin };
            int x = People.X - 1;
            MainSql.mapxy(18,x,People.Y);  //查找墙
            MyMeans.reader.Read();
            if (Int32.Parse(labelShenming.Text) > 0)    //生命大于0
            {
                pb[People.Y - 1, People.X - 1].Image = imageList1.Images[15];
                for (int j = 0; j < 15; j++)
                {
                    string map = "map" + j;
                    MainSql.mapxytable(j, map);
                    for (int i = 0; i < Int32.Parse(MyMeans.dt.Rows.Count.ToString()); i++)
                    {
                        if (People.X - 1 == Int32.Parse(MyMeans.dt.Rows[i][0].ToString()) & People.Y == Int32.Parse(MyMeans.dt.Rows[i][1].ToString()))
                        {
                            if (Count.Cs[People.Y - 1, People.X - 1] == 0)
                            {
                                if (j < 11)
                                {
                                    labelShenming.Text = (Int32.Parse(labelShenming.Text) + ClassShuXing.Sx[j, 0]).ToString();
                                    labelGongji.Text = (Int32.Parse(labelGongji.Text) + ClassShuXing.Sx[j, 1]).ToString();
                                    labelFangyu.Text = (Int32.Parse(labelFangyu.Text) + ClassShuXing.Sx[j, 2]).ToString();
                                    labelJingyan.Text = (Int32.Parse(labelJingyan.Text) + ClassShuXing.Sx[j, 3]).ToString();
                                    labelJingbi.Text = (Int32.Parse(labelJingbi.Text) + ClassShuXing.Sx[j, 4]).ToString();
                                    labelKeyYellow.Text = (Int32.Parse(labelKeyYellow.Text) + ClassShuXing.Sx[j, 5]).ToString();
                                    labelKeyBlue.Text = (Int32.Parse(labelKeyBlue.Text) + ClassShuXing.Sx[j, 6]).ToString();
                                    labelKeyRed.Text = (Int32.Parse(labelKeyRed.Text) + ClassShuXing.Sx[j, 7]).ToString();
                                    labelKeyQin.Text = (Int32.Parse(labelKeyQin.Text) + ClassShuXing.Sx[j, 8]).ToString();
                                    Count.Cs[People.Y - 1, People.X - 1] = 1;
                                }
                                else
                                {
                                    if (Int32.Parse(lb[j - 11].Text) > 0)
                                    {
                                        labelShenming.Text = (Int32.Parse(labelShenming.Text) + ClassShuXing.Sx[j, 0]).ToString();
                                        labelGongji.Text = (Int32.Parse(labelGongji.Text) + ClassShuXing.Sx[j, 1]).ToString();
                                        labelFangyu.Text = (Int32.Parse(labelFangyu.Text) + ClassShuXing.Sx[j, 2]).ToString();
                                        labelJingyan.Text = (Int32.Parse(labelJingyan.Text) + ClassShuXing.Sx[j, 3]).ToString();
                                        labelJingbi.Text = (Int32.Parse(labelJingbi.Text) + ClassShuXing.Sx[j, 4]).ToString();
                                        labelKeyYellow.Text = (Int32.Parse(labelKeyYellow.Text) + ClassShuXing.Sx[j, 5]).ToString();
                                        labelKeyBlue.Text = (Int32.Parse(labelKeyBlue.Text) + ClassShuXing.Sx[j, 6]).ToString();
                                        labelKeyRed.Text = (Int32.Parse(labelKeyRed.Text) + ClassShuXing.Sx[j, 7]).ToString();
                                        labelKeyQin.Text = (Int32.Parse(labelKeyQin.Text) + ClassShuXing.Sx[j, 8]).ToString();
                                        Count.Cs[People.Y - 1, People.X - 1] = 1;
                                    }
                                    else
                                    {
                                        MessageBox.Show("没有钥匙");
                                        People.X = People.X + 1;
                                        pictureBoxPeople.Left = pictureBoxPeople.Left + 45;
                                        Count.Cs[People.Y - 1, People.X - 1] = 0;
                                    }
                                }
                            }
                        }
                    }
                }
                if (People.X -1<=0)  //不能超过左边界
                {
                }
                else
                {
                    if (MyMeans.reader.HasRows)
                    {
                        MyMeans.cmd_close();
                    }
                    else
                    { 
                            People.X = People.X - 1;
                            pictureBoxPeople.Left = pictureBoxPeople.Left - 45;
                    }
                }
            }
            else
            {
                MessageBox.Show("game over");
            }
            label3.Text = People.X.ToString();
            label11.Text = People.Y.ToString();
                   
        }//左

        private void buttonRight_Click(object sender, EventArgs e) //右
        {
            PictureBox[,] pb = new PictureBox[11, 11]
            {
                {pictureBox1_1,pictureBox1_2,pictureBox1_3,pictureBox1_4,pictureBox1_5,pictureBox1_6,pictureBox1_7,pictureBox1_8,pictureBox1_9,pictureBox1_10,pictureBox1_11},
                {pictureBox2_1,pictureBox2_2,pictureBox2_3,pictureBox2_4,pictureBox2_5,pictureBox2_6,pictureBox2_7,pictureBox2_8,pictureBox2_9,pictureBox2_10,pictureBox2_11},
                {pictureBox3_1,pictureBox3_2,pictureBox3_3,pictureBox3_4,pictureBox3_5,pictureBox3_6,pictureBox3_7,pictureBox3_8,pictureBox3_9,pictureBox3_10,pictureBox3_11},
                {pictureBox4_1,pictureBox4_2,pictureBox4_3,pictureBox4_4,pictureBox4_5,pictureBox4_6,pictureBox4_7,pictureBox4_8,pictureBox4_9,pictureBox4_10,pictureBox4_11},
                {pictureBox5_1,pictureBox5_2,pictureBox5_3,pictureBox5_4,pictureBox5_5,pictureBox5_6,pictureBox5_7,pictureBox5_8,pictureBox5_9,pictureBox5_10,pictureBox5_11},
                {pictureBox6_1,pictureBox6_2,pictureBox6_3,pictureBox6_4,pictureBox6_5,pictureBox6_6,pictureBox6_7,pictureBox6_8,pictureBox6_9,pictureBox6_10,pictureBox6_11},
                {pictureBox7_1,pictureBox7_2,pictureBox7_3,pictureBox7_4,pictureBox7_5,pictureBox7_6,pictureBox7_7,pictureBox7_8,pictureBox7_9,pictureBox7_10,pictureBox7_11},
                {pictureBox8_1,pictureBox8_2,pictureBox8_3,pictureBox8_4,pictureBox8_5,pictureBox8_6,pictureBox8_7,pictureBox8_8,pictureBox8_9,pictureBox8_10,pictureBox8_11},
                {pictureBox9_1,pictureBox9_2,pictureBox9_3,pictureBox9_4,pictureBox9_5,pictureBox9_6,pictureBox9_7,pictureBox9_8,pictureBox9_9,pictureBox9_10,pictureBox9_11},
                {pictureBox10_1,pictureBox10_2,pictureBox10_3,pictureBox10_4,pictureBox10_5,pictureBox10_6,pictureBox10_7,pictureBox10_8,pictureBox10_9,pictureBox10_10,pictureBox10_11},
                {pictureBox11_1,pictureBox11_2,pictureBox11_3,pictureBox11_4,pictureBox11_5,pictureBox11_6,pictureBox11_7,pictureBox11_8,pictureBox11_9,pictureBox11_10,pictureBox11_11}
            };
            Label[] lb =new Label[4]{labelKeyYellow,labelKeyBlue,labelKeyRed,labelKeyQin};
            int x = People.X + 1;
            MainSql.mapxy(18, x, People.Y);
            MyMeans.reader.Read();
            if (Int32.Parse(labelShenming.Text) > 0)    //生命大于0
            {
                pb[People.Y - 1, People.X - 1].Image = imageList1.Images[15];
                for (int j = 0; j < 15; j++)
                {
                    string map = "map" + j;
                    MainSql.mapxytable(j, map);
                    for (int i = 0; i < Int32.Parse(MyMeans.dt.Rows.Count.ToString()); i++)
                    {
                        if (People.X + 1 == Int32.Parse(MyMeans.dt.Rows[i][0].ToString()) & People.Y == Int32.Parse(MyMeans.dt.Rows[i][1].ToString()))
                        {
                            
                            if (Count.Cs[People.Y - 1, People.X - 1] == 0)
                            {
                                if (j < 11)
                                {
                                    labelShenming.Text = (Int32.Parse(labelShenming.Text) + ClassShuXing.Sx[j, 0]).ToString();
                                    labelGongji.Text = (Int32.Parse(labelGongji.Text) + ClassShuXing.Sx[j, 1]).ToString();
                                    labelFangyu.Text = (Int32.Parse(labelFangyu.Text) + ClassShuXing.Sx[j, 2]).ToString();
                                    labelJingyan.Text = (Int32.Parse(labelJingyan.Text) + ClassShuXing.Sx[j, 3]).ToString();
                                    labelJingbi.Text = (Int32.Parse(labelJingbi.Text) + ClassShuXing.Sx[j, 4]).ToString();
                                    labelKeyYellow.Text = (Int32.Parse(labelKeyYellow.Text) + ClassShuXing.Sx[j, 5]).ToString();
                                    labelKeyBlue.Text = (Int32.Parse(labelKeyBlue.Text) + ClassShuXing.Sx[j, 6]).ToString();
                                    labelKeyRed.Text = (Int32.Parse(labelKeyRed.Text) + ClassShuXing.Sx[j, 7]).ToString();
                                    labelKeyQin.Text = (Int32.Parse(labelKeyQin.Text) + ClassShuXing.Sx[j, 8]).ToString();
                                    Count.Cs[People.Y - 1, People.X - 1] = 1;   
                                }else
                               {
                                   if (Int32.Parse(lb[j - 11].Text) > 0)
                                   {
                                       labelShenming.Text = (Int32.Parse(labelShenming.Text) + ClassShuXing.Sx[j, 0]).ToString();
                                       labelGongji.Text = (Int32.Parse(labelGongji.Text) + ClassShuXing.Sx[j, 1]).ToString();
                                       labelFangyu.Text = (Int32.Parse(labelFangyu.Text) + ClassShuXing.Sx[j, 2]).ToString();
                                       labelJingyan.Text = (Int32.Parse(labelJingyan.Text) + ClassShuXing.Sx[j, 3]).ToString();
                                       labelJingbi.Text = (Int32.Parse(labelJingbi.Text) + ClassShuXing.Sx[j, 4]).ToString();
                                       labelKeyYellow.Text = (Int32.Parse(labelKeyYellow.Text) + ClassShuXing.Sx[j, 5]).ToString();
                                       labelKeyBlue.Text = (Int32.Parse(labelKeyBlue.Text) + ClassShuXing.Sx[j, 6]).ToString();
                                       labelKeyRed.Text = (Int32.Parse(labelKeyRed.Text) + ClassShuXing.Sx[j, 7]).ToString();
                                       labelKeyQin.Text = (Int32.Parse(labelKeyQin.Text) + ClassShuXing.Sx[j, 8]).ToString();
                                       Count.Cs[People.Y - 1, People.X - 1] = 1;
                                   }
                                   else
                                   {
                                       MessageBox.Show("没有钥匙");
                                       People.X = People.X - 1;
                                       pictureBoxPeople.Left = pictureBoxPeople.Left - 45;
                                   }

                               }
                            }
                        }
                    }
                }
                if (People.X +1>=12)  //不能超过右边界
                {
                }
                else
                {
                    if (MyMeans.reader.HasRows)   //不能通过墙
                    {
                        MyMeans.cmd_close();
                    }
                    else
                    {                
                            People.X = People.X + 1;
                            pictureBoxPeople.Left = pictureBoxPeople.Left + 45;                                                                   
                    }
                }
            }
            else
            {
                MessageBox.Show("game over");
            }
            label3.Text = People.X.ToString();
            label11.Text = People.Y.ToString();
        }//右

        private void FormMain_Load(object sender, EventArgs e)
        {
          PictureBox[,] pb = new PictureBox[11, 11]
            {
                {pictureBox1_1,pictureBox1_2,pictureBox1_3,pictureBox1_4,pictureBox1_5,pictureBox1_6,pictureBox1_7,pictureBox1_8,pictureBox1_9,pictureBox1_10,pictureBox1_11},
                {pictureBox2_1,pictureBox2_2,pictureBox2_3,pictureBox2_4,pictureBox2_5,pictureBox2_6,pictureBox2_7,pictureBox2_8,pictureBox2_9,pictureBox2_10,pictureBox2_11},
                {pictureBox3_1,pictureBox3_2,pictureBox3_3,pictureBox3_4,pictureBox3_5,pictureBox3_6,pictureBox3_7,pictureBox3_8,pictureBox3_9,pictureBox3_10,pictureBox3_11},
                {pictureBox4_1,pictureBox4_2,pictureBox4_3,pictureBox4_4,pictureBox4_5,pictureBox4_6,pictureBox4_7,pictureBox4_8,pictureBox4_9,pictureBox4_10,pictureBox4_11},
                {pictureBox5_1,pictureBox5_2,pictureBox5_3,pictureBox5_4,pictureBox5_5,pictureBox5_6,pictureBox5_7,pictureBox5_8,pictureBox5_9,pictureBox5_10,pictureBox5_11},
                {pictureBox6_1,pictureBox6_2,pictureBox6_3,pictureBox6_4,pictureBox6_5,pictureBox6_6,pictureBox6_7,pictureBox6_8,pictureBox6_9,pictureBox6_10,pictureBox6_11},
                {pictureBox7_1,pictureBox7_2,pictureBox7_3,pictureBox7_4,pictureBox7_5,pictureBox7_6,pictureBox7_7,pictureBox7_8,pictureBox7_9,pictureBox7_10,pictureBox7_11},
                {pictureBox8_1,pictureBox8_2,pictureBox8_3,pictureBox8_4,pictureBox8_5,pictureBox8_6,pictureBox8_7,pictureBox8_8,pictureBox8_9,pictureBox8_10,pictureBox8_11},
                {pictureBox9_1,pictureBox9_2,pictureBox9_3,pictureBox9_4,pictureBox9_5,pictureBox9_6,pictureBox9_7,pictureBox9_8,pictureBox9_9,pictureBox9_10,pictureBox9_11},
                {pictureBox10_1,pictureBox10_2,pictureBox10_3,pictureBox10_4,pictureBox10_5,pictureBox10_6,pictureBox10_7,pictureBox10_8,pictureBox10_9,pictureBox10_10,pictureBox10_11},
                {pictureBox11_1,pictureBox11_2,pictureBox11_3,pictureBox11_4,pictureBox11_5,pictureBox11_6,pictureBox11_7,pictureBox11_8,pictureBox11_9,pictureBox11_10,pictureBox11_11}
            };
          Label[] label = new Label[]{ labelChenshu, labelLV, labelShenming, labelGongji, labelFangyu, labelJingyan, labelJingbi, labelKeyYellow, labelKeyBlue, labelKeyRed, labelKeyQin, label3, label11 };
      
            for (int j=0;j<=18;j++)
            {
                string map="map"  + j;
                MainSql.mapxytable(j,map);   
            for (int i = 0; i < Int32.Parse(MyMeans.dt.Rows.Count.ToString()); i++)
            {
                pb[Int32.Parse(MyMeans.dt.Rows[i][1].ToString()) - 1, Int32.Parse(MyMeans.dt.Rows[i][0].ToString()) - 1].Image = imageList1.Images[j];
            }
            }
            int uid = User.Id;
            MyMeans.sqlstr = "select number,lv,life,attack,defense,experience,gold,keyyellow,keyblue,keyred,keyqing,x,y from tb_game where uid ='" + uid + "'";
            MyMeans.get_cmd();
            if (MyMeans.reader.HasRows)
            {
                if (MyMeans.reader.Read())
                {
                    for (int m = 0; m < 13; m++)
                    {
                        label[m].Text = MyMeans.reader.GetInt32(m).ToString();
                    }                    
                    pictureBoxPeople.Left = pictureBoxPeople.Left + ((People.X-1)*45);
                    pictureBoxPeople.Top = pictureBoxPeople.Top - ((People.Y-1)*45);
                    MyMeans.cmd_close();
                }
            }
            else
            {
                MessageBox.Show("找不到数据");
                MyMeans.cmd_close();
            }


        }

        private void buttonExit_Click(object sender, EventArgs e)   //退出
        {
            int number = Int32.Parse(labelChenshu.Text);
            int lv = Int32.Parse(labelLV.Text);
            int life = Int32.Parse(labelShenming.Text);
            int attack = Int32.Parse(labelGongji.Text);
            int defense = Int32.Parse(labelFangyu.Text);
            int experience = Int32.Parse(labelJingyan.Text);
            int gold = Int32.Parse(labelJingbi.Text);
            int keyyellow = Int32.Parse(labelKeyYellow.Text);
            int keyblue = Int32.Parse(labelKeyBlue.Text);
            int keyred = Int32.Parse(labelKeyRed.Text);
            int keyqing = Int32.Parse(labelKeyQin.Text);
            int id = User.Id;
            int x = People.X;
            int y = People.Y;

            
            string sql = "update tb_game set number = '" + number + "',lv ='" + lv + "',life='" + life +
                         "',attack='" + attack + "',defense='" + defense + "',experience='" + experience + "',gold='" +
                         gold + "',keyyellow='" + keyyellow + "',keyblue='" + keyblue + "',keyred='" + keyred +
                         "',keyqing='" + keyqing + "',x='" + x + "',y='" + y + "' where uid='" + id + "'";
            MyMeans.get_cmdsql();
            if (MyMeans.b)
            {
                MyMeans.con_close();
                MessageBox.Show("退出成功");
                FormMain formMain=new FormMain();
                formMain.Close();
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)  //用SWAD控制人物移动
        {
            if (e.KeyCode == Keys.S || e.KeyValue==40)
            {
                this.buttonDown_Click(sender, e);
            }
            if (e.KeyCode == Keys.W || e.KeyValue==38)
            {
                this.buttonUp_Click(sender, e);
            }
            if (e.KeyCode == Keys.A || e.KeyValue==37)
            {
                this.buttonLeft_Click(sender, e);
            }
            if (e.KeyCode == Keys.D || e.KeyValue==39)
            {
                this.buttonRight_Click(sender, e);
            }

        }
    }
}
