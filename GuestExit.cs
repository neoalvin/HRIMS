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
    public partial class GuestExit : Form
    {
        SqlConn sc = new SqlConn();
        SqlCommand cmd = new SqlCommand();
        SqlTransaction transaction=null;
        string cmdText = "";
        public GuestExit()
        {
            InitializeComponent();
            initList();
        }
        public void initList()
        {
            roomList.Columns.Add("客房号", 110, HorizontalAlignment.Center);
            roomList.Columns.Add("类型", 130, HorizontalAlignment.Center);
            roomList.Columns.Add("价格", 100, HorizontalAlignment.Center);
            roomList.Columns.Add("入住状态", 100, HorizontalAlignment.Center);
            roomList.Columns.Add("入住时间", 110, HorizontalAlignment.Center);
            roomList.Columns.Add("已付金额", 110, HorizontalAlignment.Center);
            string cmdText = "";
            try
            {
                roomList.Items.Clear();
                if (sc.getConn().State != ConnectionState.Open)
                {
                    sc.Connect();
                }
                cmdText = "select Room.rid,typename,prize,status,intime,incost from Room,Type,Checkin where Room.typenum=Type.typenum and Room.rid=Checkin.rid and status='非空'";
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

        private void buttonCalcu_Click(object sender, EventArgs e)
        {
            int cost,result;
            for (int i = 0; i < roomList.Items.Count; i++)
            {
                if(roomList.Items[i].Checked)
                {
                    cost = int.Parse(roomList.Items[i].SubItems[5].Text.Trim());
                    result = cost - int.Parse(textCost.Text.Trim());
                    textReturn.Text = result.ToString()+" RMB";
                    this.Refresh();
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (sc.getConn().State != ConnectionState.Open)
                {
                    sc.Connect();
                }
                for (int i = 0; i < roomList.Items.Count; i++)
                {
                if(roomList.Items[i].Checked)
                {
                    int rid= int.Parse(roomList.Items[i].SubItems[0].Text.Trim());
                    string intime = roomList.Items[i].SubItems[4].Text.Trim();
                        cmdText = "update Room set status='空' where rid=" + rid;
                        transaction = sc.getConn().BeginTransaction();
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = cmdText;
                        cmd.Connection = sc.getConn();
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        cmdText = "update CheckinBackup set outtime='" + DateTime.Now.ToString("yyyy-MM-dd") + "',outcost=" + int.Parse(textCost.Text.Trim()) + "where rid=" + rid + " and intime='" + intime + "'";
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = cmdText;
                        cmd.Connection = sc.getConn();
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        cmdText = "delete from Checkin where rid=" + rid;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = cmdText;
                        cmd.Connection = sc.getConn();
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        transaction.Commit();
                }
                }
                MessageBox.Show("录入退房信息成功！");
                initList();
                }
            catch (Exception ex)
            {
                MessageBox.Show("录入退房信息失败：" + ex.Message);
                transaction.Rollback();
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
                cmdText = "select Room.rid,typename,prize,status,intime,incost from Room,Type,Checkin where Room.typenum=Type.typenum and Room.rid=Checkin.rid and status='非空' and Room.rid='"+textRoom.Text+"'";
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
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询客房信息失败：：" + ex.Message);
            }
        }
    }
}
