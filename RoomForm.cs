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
    public partial class RoomForm : Form
    {
        SqlConn sc = new SqlConn();
        SqlCommand cmd = new SqlCommand();
        string cmdText = "";
        SqlDataReader reader = null;
        SqlDataAdapter adapter = null;
        SqlTransaction transaction = null;
        public HomePage Home;
        public RoomForm()
        {
            InitializeComponent();
            if(sc.getConn().State!=ConnectionState.Open)
            {
                sc.Connect();
            }
            initCombType();
            initCombRoom();
            initRoomList();
        }
        //初始化类型下拉列表
        public void initCombType()
        {
           //combType1
            combType1.Items.Add("普通间");
            combType1.Items.Add("标准间");
            combType1.Items.Add("商务间");
            combType1.Items.Add("双套间");
            combType1.Items.Add("高级套间");
            //combType2,3,4,5,6
            try
            {
                combType2.Items.Clear();
                combType3.Items.Clear();
                combType4.Items.Clear();
                combType5.Items.Clear();
                combType6.Items.Clear();
                //cmdText = "select typenum,typename from Type";
                cmdText = "select typename from Type";
                adapter = new SqlDataAdapter(cmdText,sc.getConn());
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                //cmd = new SqlCommand(cmdText, sc.getConn());
                //reader = cmd.ExecuteReader();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count;i++ )
                {
                    //combType2.Items.Add(reader.GetInt32(reader.GetOrdinal("typenum")).ToString() + reader.GetString(reader.GetOrdinal("typename")));
                    combType2.Items.Add(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                    combType3.Items.Add(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                    combType4.Items.Add(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                    combType5.Items.Add(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                    combType6.Items.Add(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                }
                adapter.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("初始化类型信息错误："+ex.Message);
            }

        }

        //初始化客房下拉列表
        public void initCombRoom()
        {
            combRoom1.Items.Clear();
            combRoom2.Items.Clear();
            combRoom3.Items.Clear();
            try
            {
                sc.Connect();
                cmdText = "select rid from Room";
                adapter = new SqlDataAdapter(cmdText,sc.getConn());
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    combRoom1.Items.Add(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                    combRoom2.Items.Add(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                    combRoom3.Items.Add(dataSet.Tables[0].Rows[i][0].ToString().Trim());
                }
                adapter.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("初始化房间信息失败："+ex.Message);
            }
        }
        //初始化客房列表控件
        public void initRoomList()
        {
            roomList.Columns.Add("房间号", 90, HorizontalAlignment.Center);
            roomList.Columns.Add("类型", 90, HorizontalAlignment.Center);
            roomList.Columns.Add("价格", 90, HorizontalAlignment.Center);
            roomList.Columns.Add("状态", 90, HorizontalAlignment.Center);
            roomList.Columns.Add("预约", 90, HorizontalAlignment.Center);
            roomList.Columns.Add("备注", 150, HorizontalAlignment.Center);
            try
            {
                roomList.Items.Clear();
                sc.Connect();
                cmdText = "select Room.rid,typename,prize,status,orders from Room,Type,Orders where Room.typenum=Type.typenum and Room.rid=Orders.rid";
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
                MessageBox.Show("查询失败：" + ex.Message);
            }
        }
        //完成类型录入
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Connect();
                cmdText = "insert into Type values(" + int.Parse(typeNum.Text) + "," + "'" + combType1.Text.Trim() + "'," + int.Parse(textPrize.Text) + ")";
                cmd = new SqlCommand(cmdText, sc.getConn());
                cmd.ExecuteNonQuery();
                MessageBox.Show("录入成功！");
                cmd.Dispose();
                sc.Close();
                initCombType();
            }
            catch(Exception ex)
            {
                MessageBox.Show("录入失败："+ex.Message);
            }

        }

        //完成客房录入
        private void buttonAgain_Click(object sender, EventArgs e)
        {

            try
            {
                int typenum = 0;
                sc.Connect();
                cmdText = "select typenum from Type where typename='" + combType2.Text.Trim() + "'";
                cmd = new SqlCommand(cmdText, sc.getConn());
                reader = cmd.ExecuteReader();
                cmd.Dispose();
                reader.Read();
                typenum = reader.GetInt32(reader.GetOrdinal("typenum"));
                reader.Close();
                reader.Dispose();
                cmdText = "insert into Room values(" + int.Parse(roomNum.Text.Trim()) + "," + typenum + ",'空'" + ");";
                transaction = sc.getConn().BeginTransaction();
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmdText;
                cmd.Connection = sc.getConn();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmdText = "insert into Orders values(" + int.Parse(roomNum.Text.Trim()) + ",'','','','')";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmdText;
                cmd.Connection = sc.getConn();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                transaction.Commit();
                sc.Close();
                initRoomList();
                MessageBox.Show("录入成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("信息录入错误：" + ex.Message);
                transaction.Rollback();
            }
        }


        //修改类型信息
        private void button3_Click(object sender, EventArgs e)
        {
            if(!checkNew.Checked)
            {
                try {
                    sc.Connect();
                    cmdText = "update Type set prize=" + int.Parse(newPrize.Text.Trim()) + " where typename='"+combType3.Text.Trim() + "'";
                    cmd = new SqlCommand(cmdText, sc.getConn());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("类型修改成功！ ");
                    sc.Close();
                    initRoomList();
                    initCombType();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("修改类型信息出错："+ex.Message);
                }  
            }
            else
            {
                try
                {
                    sc.Connect();
                    cmdText = "update Type set typename='" + newType.Text.Trim() + "' where typename='" + combType3.Text.Trim() + "'";
                    transaction = sc.getConn().BeginTransaction();
                    cmd.Transaction = transaction;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = cmdText;
                    cmd.Connection = sc.getConn();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmdText = "update Type set prize=" + int.Parse(newPrize.Text.Trim()) + " where typename='" + newType.Text.Trim() + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = cmdText;
                    cmd.Connection = sc.getConn();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    transaction.Commit();
                    sc.Close();
                    initRoomList();
                    initCombType();
                    MessageBox.Show("类型及价格修改成功！ ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("修改类型信息出错：" + ex.Message);
                    transaction.Rollback();
                }
            }
        }
        //修改客房信息
        private void button5_Click(object sender, EventArgs e)
        {
            int typenum = 0;
            try
            {
                sc.Connect();
                cmdText = "select typenum from Type where typename='" + combType4.Text.Trim() + "'";
                cmd = new SqlCommand(cmdText, sc.getConn());
                reader = cmd.ExecuteReader();
                cmd.Dispose();
                reader.Read();
                typenum = reader.GetInt32(reader.GetOrdinal("typenum"));
                cmdText = "update Room set typenum="+typenum+" where rid="+int.Parse(combRoom1.Text.Trim());
                reader.Close();
                cmd = new SqlCommand(cmdText, sc.getConn());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                reader.Dispose();
                reader.Close();
                sc.Close();
                initRoomList();
                MessageBox.Show("客房信息修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改房间信息出错：" + ex.Message);
            }
            initRoomList();
        }
        //删除类型信息
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(sc.getConn().State!=ConnectionState.Open)
                {
                    sc.Connect();
                }
                //cmdText = "select typenum from Type where typename='" + combType5.Text.Trim() + "'";
                //cmd = new SqlCommand(cmdText, sc.getConn());
                //SqlDataReader reader = cmd.ExecuteReader();
                //cmd.Dispose();
                //reader.Read();
                //typenum = int.Parse(reader["typenum"].ToString().Trim());
                //reader.Close();
                //reader.Dispose();
                //cmdText = "update Room set typenum=null where typenum=" + typenum;
                //cmd = new SqlCommand(cmdText, sc.getConn());
                //cmd.ExecuteNonQuery();
                //cmd.Dispose();
                cmdText = "delete from Type where typename='"+combType5.Text.Trim()+"'";
                cmd = new SqlCommand(cmdText,sc.getConn());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                sc.Close();
                initCombType();
                MessageBox.Show("删除该条信息成功！");
                initCombType();
            }
            catch(Exception ex)
            {
                MessageBox.Show("删除类型失败："+ex.Message);
            }
        }
        //删除客房信息
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Connect();
                transaction = sc.getConn().BeginTransaction();
                cmd.Transaction = transaction;
                cmdText = "delete from Orders where rid=" + int.Parse(combRoom2.Text.Trim());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmdText;
                cmd.Connection = sc.getConn();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmdText = "delete from CheckinBackup where rid=" + int.Parse(combRoom2.Text.Trim());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmdText;
                cmd.Connection = sc.getConn();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmdText = "delete from Room where rid=" +int.Parse(combRoom2.Text.Trim());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmdText;
                cmd.Connection = sc.getConn();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                sc.Close();
                initRoomList();
                MessageBox.Show("删除该条信息成功！");
                initCombRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除客房信息失败：" + ex.Message);
                transaction.Rollback();
            }
        }
        //查询客房信息
        private void buttonOk_Click(object sender, EventArgs e)
        {
            //按客房类型查询
            if(radioType.Checked)
            {
                try
                {
                    roomList.Items.Clear();
                    sc.Connect();
                    cmdText = "select Room.rid,typename,prize,status,orders from Room,Type,Orders where Room.typenum=Type.typenum and Room.rid=Orders.rid and  typename='"+combType6.Text.Trim()+"'";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdText,sc.getConn());
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    adapter.Dispose();
                    for(int i=0;i<dataSet.Tables[0].Rows.Count;i++)
                    {
                        ListViewItem item = roomList.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
                        for(int j=1;j<dataSet.Tables[0].Columns.Count;j++)
                        {
                            item.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString());
                        }
                    }
                    dataSet.Dispose();
                    adapter.Dispose();
                    this.Refresh();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("查询失败："+ex.Message);
                }
            }
            //按客房号查询
            else if(radioRoom.Checked)
            {
                try
                {
                    roomList.Items.Clear();
                    sc.Connect();
                    cmdText = "select Room.rid,typename,prize,status,orders from Room,Type,Orders where Room.typenum=Type.typenum and Room.rid=Orders.rid and Room.rid=" + int.Parse(combRoom3.Text.Trim());
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
                    this.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询失败：" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("未选择查询方式！");
            }
        }
    }
}
