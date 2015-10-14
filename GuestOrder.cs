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
    public partial class GuestOrder : Form
    {
        SqlConn sc = new SqlConn();
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlTransaction transaction = null;
        string cmdText = "";
        public GuestOrder()
        {
            InitializeComponent();
            initList();
            initComb();
        }
        //初始化类型信息下拉列表
        public void initComb()
        {
            try
            {
                cmdText = "select typename from Type";
                cmd = new SqlCommand(cmdText, sc.getConn());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combType.Items.Add(reader.GetString(reader.GetOrdinal("typename")));
                }
                reader.Dispose();
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化类型信息错误：" + ex.Message);
            }
        }
        //初始化客房信息列表
        public void initList()
        {
            roomList.Columns.Add("客房号", 110, HorizontalAlignment.Center);
            roomList.Columns.Add("类型", 130, HorizontalAlignment.Center);
            roomList.Columns.Add("价格", 100, HorizontalAlignment.Center);
            roomList.Columns.Add("入住状态", 100, HorizontalAlignment.Center);
            roomList.Columns.Add("预约状态", 100, HorizontalAlignment.Center);
            roomList.Columns.Add("预约时间", 130, HorizontalAlignment.Center);
            string cmdText = "";
            try
            {
                roomList.Items.Clear();
                if (sc.getConn().State != ConnectionState.Open)
                {
                    sc.Connect();
                }
                cmdText = "select Room.rid,typename,prize,status,orders,ordertime from Room,Type,Orders where Room.typenum=Type.typenum and Room.rid=Orders.rid";
                SqlDataAdapter adapter = new SqlDataAdapter(cmdText, sc.getConn());
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                adapter.Dispose();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    ListViewItem item = roomList.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
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
                MessageBox.Show("初始化客房列表失败：：" + ex.Message);
            }
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            try
            {
                roomList.Items.Clear();
                if (sc.getConn().State != ConnectionState.Open)
                {
                    sc.Connect();
                }
                cmdText = "select Room.rid,typename,prize,status,orders,ordertime from Room,Type,Orders where Room.typenum=Type.typenum and Room.rid=Orders.rid and status='空' and typename='" + combType.Text.Trim() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(cmdText, sc.getConn());
                cmd = new SqlCommand(cmdText, sc.getConn());
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                adapter.Dispose();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    ListViewItem item = roomList.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
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
                MessageBox.Show("查询失败：" + ex.Message);
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            int rid;
            string ordertime = datePicker.Value.ToString("yyyy-MM-dd");
            if(sc.getConn().State!=ConnectionState.Open)
            {
                sc.Connect();
            }
            try
            {
                for (int i = 0; i < roomList.Items.Count; i++)
                {
                    if (roomList.Items[i].Checked)
                    {
                        rid = int.Parse(roomList.Items[i].SubItems[0].Text.Trim());
                        cmdText = "update Orders set name='"+textName.Text.Trim()+"',tel='"  +textTel.Text.Trim()+ "',orders='YES',ordertime='" + ordertime+ "' where rid="+rid;
                        transaction = sc.getConn().BeginTransaction();
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = cmdText;
                        cmd.Connection = sc.getConn();
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        transaction.Commit();
                    }
                }
                MessageBox.Show("录入预约信息成功！");
                sc.Close();
                initList();
                textName.Text = "";
                textTel.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("录入预约信息失败："+ex.Message);
                transaction.Rollback();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rid;
            string ordertime = datePicker.Value.ToString("yyyy-MM-dd");
            if (sc.getConn().State != ConnectionState.Open)
            {
                sc.Connect();
            }
            try
            {
                for (int i = 0; i < roomList.Items.Count; i++)
                {
                    if (roomList.Items[i].Checked)
                    {
                        rid = int.Parse(roomList.Items[i].SubItems[0].Text.Trim());
                        cmdText = "update Orders set name=null,tel=null,orders=null,ordertime=null";
                        transaction = sc.getConn().BeginTransaction();
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = cmdText;
                        cmd.Connection = sc.getConn();
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        transaction.Commit();
                    }
                }
                MessageBox.Show("取消预约信息成功！");
                sc.Close();
                initList();
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("取消预约信息失败：" + ex.Message);
                transaction.Rollback();
            }
        }
    }

}
