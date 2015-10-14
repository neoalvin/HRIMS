using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HRIMS
{    

    public partial class GuestForm : Form
    {
        SqlConn sc = new SqlConn();
        string cmdText = "";
        public GuestForm()
        {
            InitializeComponent();
            initGuestList();
        }
        public void initGuestList()
        {
            guestList.Columns.Add("姓名", 80, HorizontalAlignment.Center);
            guestList.Columns.Add("联系方式", 120, HorizontalAlignment.Center);
            guestList.Columns.Add("房间号", 70, HorizontalAlignment.Center);
            guestList.Columns.Add("房间类型", 80, HorizontalAlignment.Center);
            guestList.Columns.Add("入住时间", 110, HorizontalAlignment.Center);
            guestList.Columns.Add("退房时间", 110, HorizontalAlignment.Center);
            guestList.Columns.Add("实付款", 90, HorizontalAlignment.Center);
            guestList.Columns.Add("备注", 140, HorizontalAlignment.Center);
            try
            {
                guestList.Items.Clear();
                if (sc.getConn().State != ConnectionState.Open)
                {
                    sc.Connect();
                }
                cmdText = "select * from V_Guest";
                SqlDataAdapter adapter = new SqlDataAdapter(cmdText, sc.getConn());
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                adapter.Dispose();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    ListViewItem item = guestList.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
                    for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                    {
                        item.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString());
                    }
                }
                dataSet.Dispose();
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化宾客信息失败：：" + ex.Message);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(radioRoom.Checked)
            {
                try
                {
                    guestList.Items.Clear();
                    if (sc.getConn().State != ConnectionState.Open)
                    {
                        sc.Connect();
                    }
                    cmdText = "select * from V_Guest where rid="+int.Parse(textQuery.Text.Trim());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdText, sc.getConn());
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    adapter.Dispose();
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem item = guestList.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
                        for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                        {
                            item.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString());
                        }
                    }
                    dataSet.Dispose();
                    adapter.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询宾客信息失败：：" + ex.Message);
                }
            }
            else if(radioName.Checked)
            {
                try
                {
                    guestList.Items.Clear();
                    if (sc.getConn().State != ConnectionState.Open)
                    {
                        sc.Connect();
                    }
                    cmdText = "select * from V_Guest where gname='"+textQuery.Text+"'";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdText, sc.getConn());
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    adapter.Dispose();
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem item = guestList.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
                        for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                        {
                            item.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString());
                        }
                    }
                    dataSet.Dispose();
                    adapter.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询宾客信息失败：：" + ex.Message);
                }
            }
            else if(radioTime.Checked)
            {
                try
                {
                    guestList.Items.Clear();
                    if (sc.getConn().State != ConnectionState.Open)
                    {
                        sc.Connect();
                    }
                    cmdText = "select * from V_Guest where intime='"+datePicker.Value.ToString("yyyy-MM-dd")+"'";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdText, sc.getConn());
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    adapter.Dispose();
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem item = guestList.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
                        for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                        {
                            item.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString());
                        }
                    }
                    dataSet.Dispose();
                    adapter.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询宾客信息失败：：" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("未选择查询方式！");
            }
        }





    }
}
