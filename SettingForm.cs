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
//生成报表
using GemBox.ExcelLite;
using System.Data.OleDb;
using System.Collections;
using System.IO;
namespace HRIMS
{
    public partial class SettingForm : Form
    {
        public HomePage Home;
        MyConfig mc = new MyConfig();
        SqlConn sc = new SqlConn();
        private BackgroundWorker bkWorker = new BackgroundWorker();
        private ProgressForm notifyForm = new ProgressForm();
        SqlCommand cmd = new SqlCommand();
        public SettingForm()
        {
            InitializeComponent();
            initPage1();
            initList();
 //           initBkworker();
        }
        ////进度条使用
        //public void initBkworker()
        //{ 
        //    CheckForIllegalCrossThreadCalls = false;   
        //    bkWorker.WorkerReportsProgress = true;  
        //    bkWorker.WorkerSupportsCancellation = true;  
        //    bkWorker.DoWork += new DoWorkEventHandler(DoWork);  
        //    bkWorker.ProgressChanged += new ProgressChangedEventHandler(ProgessChanged);  
        //    bkWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompleteWork);
        //}
        //private void ProgressMaker()
        //{
        //    notifyForm.StartPosition = FormStartPosition.CenterParent;
        //    bkWorker.RunWorkerAsync();
        //    notifyForm.ShowDialog();
        //}

        //public void DoWork(object sender, DoWorkEventArgs e)
        //{
        //    // 事件处理，指定处理函数  
        //    e.Result = ProcessProgress(bkWorker, e);
        //}

        //public void ProgessChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    // bkWorker.ReportProgress 会调用到这里，此处可以进行自定义报告方式  
        //    notifyForm.SetNotifyInfo(e.ProgressPercentage, Convert.ToString(e.ProgressPercentage) + "%");
        //}

        //public void CompleteWork(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    notifyForm.Close();
        //}

        //private int ProcessProgress(object sender, DoWorkEventArgs e)
        //{
        //    for (int i = 0; i <= 1000; i++)
        //    {
        //        if (bkWorker.CancellationPending)
        //        {
        //            e.Cancel = true;
        //            return -1;
        //        }
        //        else
        //        {
        //            // 状态报告  
        //            bkWorker.ReportProgress(i / 10);

        //            // 等待，用于UI刷新界面，很重要  
        //            System.Threading.Thread.Sleep(1);
        //        }
        //    }

        //    return -1;
        //}  
        //初始化页面1
        public void initPage1()
        {
            textIp.Text=mc.getServer();
            textDbname.Text = mc.getDbname();
            textName.Text = mc.getUser();
            textPwd.Text = mc.getPwd();
        }
        //初始化用户表
        public void initList()
        {
            listUser.Clear();
            listUser.Columns.Add("用户名", 150, HorizontalAlignment.Center);
            listUser.Columns.Add("真实姓名", 130, HorizontalAlignment.Center);
            listUser.Columns.Add("密码", 150, HorizontalAlignment.Center);
            try
            {
                if(sc.getConn().State!=ConnectionState.Open)
                {
                    sc.Connect();
                }
                string cmdText = "select * from Users";
                SqlDataAdapter adapter = new SqlDataAdapter(cmdText, sc.getConn());
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    ListViewItem item = listUser.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
                    for (int j = 1; j < dataSet.Tables[0].Columns.Count; j++)
                    {
                        item.SubItems.Add(dataSet.Tables[0].Rows[i][j].ToString());
                    }
                }
                dataSet.Dispose();
                adapter.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("初始化用户信息失败："+ex.Message);
            }
        }
        //修改系统配置
        private void buttonSu_Click(object sender, EventArgs e)
        {
            if(textPwd.Text!=textPwd1.Text)
            {
                label8.Text = "两次输入密码不一样";
            }
            else
            {
                try
                {
                    if (sc.getConn().State != ConnectionState.Open)
                    {
                        sc.Connect();
                    }
                    string cmdText = "exec sp_password '" + mc.getPwd().Trim() + "','" + textPwd.Text.Trim() + "','" + textName.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(cmdText,sc.getConn());
                    cmd.ExecuteNonQuery();
                    mc.setConfigFile(textIp.Text, textPwd.Text);
                    label8.Text = "";
                    initPage1();
                    cmd.Dispose();
                    MessageBox.Show("修改信息成功！");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("修改内容失败："+ex.Message);
                }
            }
        }
        //用户注销
        private void button1_Click(object sender, EventArgs e)
        {
            string username = "";
            try
            {
                if(sc.getConn().State!=ConnectionState.Open)
                {
                    sc.Connect();
                }
                for (int i = 0; i < listUser.Items.Count; i++)
                {
                    if (listUser.Items[i].Checked)
                    {
                        username = listUser.Items[i].SubItems[0].Text.Trim();
                        string cmdText = "delete from Users where Username='"+username+"'";
                        SqlCommand cmd = new SqlCommand(cmdText,sc.getConn());
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("用户注销成功！");
                        initList();
                    }
                }
            }
            catch(Exception  ex)
            {
                MessageBox.Show("注销信息失败："+ex.Message);
            }
        }
        //用户密码修改
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textUserpwd.Text != textUserpwd1.Text)
            {
                labelErr.Text = "两次输入密码不一样";
            }
            else
            {
                string username = "";
                try
                {
                    if (sc.getConn().State != ConnectionState.Open)
                    {
                        sc.Connect();
                    }
                    for (int i = 0; i < listUser.Items.Count; i++)
                    {
                        if (listUser.Items[i].Checked)
                        {
                            username = listUser.Items[i].SubItems[0].Text.Trim();
                            string cmdText = "update Users set Pwd='"+textUserpwd.Text.Trim()+"' where Username='" + username + "'";
                            SqlCommand cmd = new SqlCommand(cmdText,sc.getConn());
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            MessageBox.Show("用户修改成功！");
                            initList();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("修改信息失败：" + ex.Message);
                }
            }
        }
        //打印报表
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(radioGuest.Checked) && !(radioRoom.Checked))
                {
                    MessageBox.Show("未选择导出方式！");
                }
                else if (radioGuest.Checked)
                {
                    string cmdText = "select * from V_Guest";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdText, sc.getConn());
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    ExcelFile excelFile = new ExcelFile();
                    ExcelWorksheet sheet = excelFile.Worksheets.Add("Guest");
                    int columns = dataSet.Tables[0].Columns.Count;
                    int rows = dataSet.Tables[0].Rows.Count;
                    string[] guestInfo = new string[8] { "宾客姓名", "联系方式", "客房号", "客房类型", "入住时间", "退房时间", "实付款", "备注" };
                    for (int j = 0; j < guestInfo.Length; j++)
                    {
                        //sheet.Cells[0, j].Value = dataSet.Tables[0].Columns[j].ToString().Trim();
                        sheet.Cells[0, j].Value = guestInfo[j];
                    }

                    for (int i = 1; i <= rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            sheet.Cells[i, j].Value = dataSet.Tables[0].Rows[i - 1][j].ToString().Trim();
                        }
                    }
                    string strTitle = "Guest";
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xls)|*.xls";
                    saveFileDialog.FilterIndex = 0;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.CreatePrompt = false;
                    saveFileDialog.FileName = strTitle + ".xls";
                    if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }
                    excelFile.SaveXls(saveFileDialog.FileName);
                    MessageBox.Show("导出成功");
                }
                else if (radioRoom.Checked)
                {
                    string cmdText = "select * from V_Room";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdText, sc.getConn());
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    ExcelFile excelFile = new ExcelFile();
                    ExcelWorksheet sheet = excelFile.Worksheets.Add("Guest");
                    int columns = dataSet.Tables[0].Columns.Count;
                    int rows = dataSet.Tables[0].Rows.Count;
                    string[] roomInfo = new string[8] { "客房号", "客房类型", "宾客姓名", "联系方式", "入住时间", "退房时间", "实付款", "备注" }; ;
                    for (int j = 0; j < roomInfo.Length; j++)
                    {
                        //sheet.Cells[0, j].Value = dataSet.Tables[0].Columns[j].ToString().Trim();
                        sheet.Cells[0, j].Value = roomInfo[j];
                    }

                    for (int i = 1; i <= rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            sheet.Cells[i, j].Value = dataSet.Tables[0].Rows[i - 1][j].ToString().Trim();
                        }
                    }
                    string strTitle = "Room";
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xls)|*.xls";
                    saveFileDialog.FilterIndex = 0;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.CreatePrompt = false;
                    saveFileDialog.FileName = strTitle + ".xls";
                    if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }
                    excelFile.SaveXls(saveFileDialog.FileName);
                    MessageBox.Show("导出成功");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("导出失败："+ex.Message);
            }
        }
        //数据备份
        private void buttonBackup_Click(object sender, EventArgs e)
        {
            if (sc.getConn().State == ConnectionState.Open)
            {
                sc.Close();
            }
            sc.ConnectServer();     //断开当前数据库直接连接到服务器
            try
            {
                string strTitle = "HRIMS_backup" + DateTime.Now.ToString("yyyy-MM-dd").Trim();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Backup files (*.bak)|*.bak";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.CreatePrompt = false;
                saveFileDialog.FileName = strTitle + ".bak";
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                string cmdText = "backup database HRIMS to disk='" + saveFileDialog.FileName.Trim() + "'";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmdText;
                cmd.Connection = sc.getConn();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
//                ProgressMaker();
                sc.CloseServer();
                labelWait.Text = "";
                MessageBox.Show("备份数据成功！");
            }
            catch(Exception ex)
            {
                MessageBox.Show("备份失败："+ex.Message);
            }
        }

        private void buttonRecover_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "";
                if (sc.getConn().State == ConnectionState.Open)
                {
                    sc.Close();
                }
                sc.ConnectServer();     //断开当前数据库直接连接到服务器
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Backup files (*.bak)|*.bak";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    string cmdText = "alter database HRIMS set SINGLE_USER With ROLLBACK IMMEDIATE";//设置单用户模式，断开当前连接
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = cmdText;
                    cmd.Connection = sc.getConn();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmdText = "restore database HRIMS from disk='" + filePath + "' with replace";       //恢复数据
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = cmdText;
                    cmd.Connection = sc.getConn();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmdText = "alter database HRIMS set MULTI_USER";        //还原到多用户模式
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = cmdText;
                    cmd.Connection = sc.getConn();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    labelWait.Text = "";
                    sc.CloseServer();
                    MessageBox.Show("恢复数据完成！");
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("恢复失败："+ex.Message);
            }
        }
        //分类统计
        private void button2_Click(object sender, EventArgs e)
        {
            Home.panel_Sort();
        }
    }
}
