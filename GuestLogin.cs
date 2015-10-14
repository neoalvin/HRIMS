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
    public partial class GuestLogin : Form
    {
        SqlConn sc = new SqlConn();
        SqlDataReader reader = null;
        SqlCommand cmd = new SqlCommand ();
        SqlTransaction transaction = null;
        string cmdText = "";
        public GuestLogin()
        {
            InitializeComponent();
            initListView();
            initCombType();
        }
        //初始化客房信息列表
        public void initListView()
        {
            roomList.Columns.Add("客房号", 110, HorizontalAlignment.Center);
            roomList.Columns.Add("类型", 130, HorizontalAlignment.Center);
            roomList.Columns.Add("价格", 100, HorizontalAlignment.Center);
            roomList.Columns.Add("入住状态", 100, HorizontalAlignment.Center);
            roomList.Columns.Add("预约状态", 100, HorizontalAlignment.Center);
            roomList.Columns.Add("预约时间", 110, HorizontalAlignment.Center);
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
        //初始化类型下拉列表
        public void initCombType()
        {
            
            try
            {
                //cmdText = "select typenum,typename from Type";
                cmdText = "select typename from Type";
                cmd = new SqlCommand(cmdText, sc.getConn());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //combType2.Items.Add(reader.GetInt32(reader.GetOrdinal("typenum")).ToString() + reader.GetString(reader.GetOrdinal("typename")));
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
        //查询
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            try
            {
                roomList.Items.Clear();
                if (sc.getConn().State != ConnectionState.Open)
                {
                    sc.Connect();
                }
                cmdText = "select Room.rid,typename,prize,status,orders,ordertime from Room,Type,Orders where Room.typenum=Type.typenum and Room.rid=Orders.rid and status='空' and typename='" +combType.Text.Trim()+"'";
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
        //客房账目结算
        private void buttonCalcu_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i=0;i<roomList.Items.Count;i++)
            {
                if(roomList.Items[i].Checked)
                {
                    sum+=int.Parse(roomList.Items[i].SubItems[2].Text.Trim());
                }
            }
            sum=sum*(int.Parse(textDay.Text.Trim()));
            textCostsum.Text = sum.ToString()+" RMB";
            this.Refresh();
        }
        //宾客信息登记
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textTel.Text == "" || textId.Text == "" || textDay.Text == "" || textDetails.Text == "")
            {
                MessageBox.Show("信息不完善！");
            }
            else
            {
                int rid, cost, flag = 0, check = 0;
                string gid = textId.Text.Trim();
                string details = textDetails.Text.Trim();
                if (sc.getConn().State != ConnectionState.Open)
                {
                    sc.Connect();
                }
                for (int i = 0; i < roomList.Items.Count; i++)
                {
                    if (roomList.Items[i].Checked)
                    {
                        check = 1;
                    }
                }
                if (check == 0)
                {
                    MessageBox.Show("未选中登记房间！");
                }
                else
                {
                    try
                    {
                        cmdText = "select gid from Guest";
                        cmd = new SqlCommand(cmdText, sc.getConn());
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader["gid"].ToString().Trim() == gid)
                            {
                                flag = 1;
                            }
                        }
                        cmd.Dispose();
                        reader.Dispose();
                        transaction = sc.getConn().BeginTransaction();
                        cmd.Transaction = transaction;
                        if (flag == 0)
                        {
                            cmdText = "insert into Guest values('" + gid + "','" + textName.Text.Trim() + "','" + textTel.Text.Trim() + "')";
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = cmdText;
                            cmd.Connection = sc.getConn();
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                        for (int i = 0; i < roomList.Items.Count; i++)
                        {
                            if (roomList.Items[i].Checked)
                            {
                                   cost = (int.Parse(roomList.Items[i].SubItems[2].Text.Trim())) * (int.Parse(textDay.Text.Trim()));
                                   rid = int.Parse(roomList.Items[i].SubItems[0].Text.Trim());
                                    cmdText = "insert into Checkin values(" + rid + ",'" + gid + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + cost + ",'" + details + "')";
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = cmdText;
                                    cmd.Connection = sc.getConn();
                                    cmd.ExecuteNonQuery();
                                    cmd.Dispose();

                                    cmdText = "insert into CheckinBackup values(" + rid + ",'" + gid + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "',null," + cost + ",0,'" + details + "')";
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = cmdText;
                                    cmd.Connection = sc.getConn();
                                    cmd.ExecuteNonQuery();
                                    cmd.Dispose();
                          
                                    cmdText = "update Room set status='非空' where rid=" + rid;
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = cmdText;
                                    cmd.Connection = sc.getConn();
                                    cmd.ExecuteNonQuery();
                                    cmd.Dispose();
                                    transaction.Commit();
                            }
                        
                        }
                        MessageBox.Show("录入登记信息成功！");
                        initListView();
                        textName.Text = "";
                        textId.Text = "";
                        textTel.Text = "";
                        textDay.Text = "";
                        textDetails.Text = "";
                        textCostsum.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("录入登记信息失败：" + ex.Message);
                        transaction.Rollback();
                    }
                }
            }
        }




    }
}
