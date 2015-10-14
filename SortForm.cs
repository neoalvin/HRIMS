using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;//用于文件存取 
using System.Drawing;//提供画GDI+图形的基本功能
using System.Drawing.Text;//提供画GDI+图形的高级功能  
using System.Drawing.Drawing2D;//提供画高级二维，矢量图形功能
using System.Drawing.Imaging;//提供画GDI+图形的高级功能 
namespace HRIMS
{
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
            showChart();
        }
        public void showChart()
        {
            SqlConn sc = new SqlConn();
            int roomnum = 0;
            string typename;
            string cmdText = "select * from V_Typenum";
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText,sc.getConn());
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            for(int i=0;i<dataSet.Tables[0].Rows.Count;i++)
            {
                typename = dataSet.Tables[0].Rows[i][0].ToString().Trim();
                roomnum = int.Parse(dataSet.Tables[0].Rows[i][1].ToString().Trim());
                chart.Series[0].Points.AddXY(typename , roomnum);
                chart.Series[0].Color = Color.SkyBlue;
                chart.Series[0].Label = "#VAL";
            }
            adapter.Dispose();
        }
    }

}
