using System.Data;
using System.Data.SqlClient;
using ZJY1;

namespace PWMS.DataClass
{

    
    public class MainSql
    {
        public static void mapxy(int n,int x,int y)
        {
            MyMeans.sqlstr = "select id from tb_map where classid = '" + n + "' and classx = '" + x + "'and classy = '" + y + "' ";
            MyMeans.get_cmd();
        }

        public static void mapxytable(int n,string tableName)
        {
            MyMeans.sqlstr = "select classx,classy from tb_map where classid = '" + n + "'";
            MyMeans.GetFindDataSet(tableName);
        }
        public static void classtable(int n, string tableName)
        {
            MyMeans.sqlstr = "select life,attack,defense,experience,gold,keyyellow,keyblue,keyred,keyqing from tb_class";
            MyMeans.GetFindDataSet(tableName);
        }
    }

}