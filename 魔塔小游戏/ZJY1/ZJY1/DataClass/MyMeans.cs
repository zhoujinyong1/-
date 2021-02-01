using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PWMS.DataClass
{
    public class MyMeans
    {

        
        #region 全局变量
        //定义静态全局变量，记录“基础信息”各窗体的表名、SQL语句以及要添加和修改的字段名
        public static string Mean_SQL = "", Mean_Table = "", Mean_Field = "";

        //定义一个SqlConnection类型的静态公共变量conn，用于判断数据库是否连接成功
        public static SqlConnection conn;
        //定义SQL Server 2008 连接字符串，用户在使用时，将Date Source 改为自己的SQL Server 2008服务器名 
        public static string sqlconn = "Data Source=DESKTOP-QGLTQVV;uid=sa;pwd=root;database=db_ZJY1;";
        //存储SQL语句
        public static string sqlstr = "";
        public static SqlDataReader reader;
        public static Boolean b;
        public static string tableName = "";
        public static DataTable dt;

        #endregion 自定义方法

        public static SqlConnection get_con()    //建立连接
        {
            conn = new SqlConnection(sqlconn);    //用SqlConnection对象与指定的数据相连接
            conn.Open();                               //打开数据库连接
            return conn;                               //返回SqlConnection对象的信息
        }

        public static void con_close()   //关闭连接
        {
            if (conn.State==ConnectionState.Open)       //判断是否打开与数据库的连接
            {
                conn.Close();                           //关闭数据库的连接
                conn.Dispose();                         //释放My_con变量的所有空间
            }
        }

        public static SqlDataReader get_cmd()     //执行SQL语句，生成一个SqlDataReader对象，读取数据
        {
            get_con();                                     //打开与数据库的连接
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            reader = cmd.ExecuteReader(); //执行SQL语句，生成一个SqlDataReader对象
            return reader;
        }      //SqlDataReader执行sql

        public static Boolean get_cmdsql()  //执行SQL语句（增加，删除，修改）
        {
            
            get_con();                                     //打开与数据库的连接
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            //判断是否添加成功cmd.ExecuteNonQuery()
            if (cmd.ExecuteNonQuery() > 0)
            {
                return b=true;
            }
            else
            {
                return b=false;
            }

        }

        public static void cmd_close()
        {
            sqlstr = "";
            reader.Dispose();
            con_close();
        }    //关闭SqlDataReader,并重置sqlstr：sql语句

        public static DataTable GetFindDataSet(string tableName)
        {

            get_con();
            SqlDataAdapter sda = new SqlDataAdapter(sqlstr,conn);
            DataSet ds = new DataSet(); //创建DataSet对象
            sda.Fill(ds,tableName);
            tableName = "";
            sqlstr = "";
            con_close();
            return dt=ds.Tables[0];                                 //返回DataSet对象的信息 
        }
    }
}