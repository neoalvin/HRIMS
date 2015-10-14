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
    public partial class RegitForm : Form
    {
        public HomePage Home;
        SqlConn sc = new SqlConn();
        FormsData fd = new FormsData();
        public RegitForm()
        {
            InitializeComponent();
            initPage2();
        }

        public void initPage2()
        {
            fd.setAdminreg();
            if (fd.getAdminreg())
            {
                labelreg.Text = "该系统中已存在一个管理员，不能再次注册";
                groupAdmin.Visible = false;
                //userName.Visible = false;
                //userPwd.Visible = false;
                //textPwd.Visible = false;
                //hotelName.Visible = false;
                //hotelAddr.Visible = false;
                //hotelTel.Visible = false;
                readCheck.Visible = false;
                buttonOK.Visible = false;
                buttonClear.Visible = false;
            }
        }

        //private void buttonOK_Click(object sender, EventArgs e)
        //{
         
        //}

        //private void readCheck_CheckedChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void buttonClear_Click(object sender, EventArgs e)
        //{

        //}

        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
            MyConfig mc = new MyConfig();
            if (!readCheck.Checked || userName.Text == "" || userPwd.Text == "" || hotelName.Text == "")
            {
                if (!readCheck.Checked)
                {
                    readCheck.ForeColor = Color.Red;
                }
                if (userName.Text == "")
                {
                    labelUsercan.Text = "";
                    labelUser.Text = "请输入用户名";
                }
                if (userName.Text != null)
                {
                    int flag = 0;
                    foreach (char c in userName.Text.Trim())
                    {
                        if ((c > 'z' || c < 'a') && (c > 'Z' || c < 'A') && (c > '9' || c < '0'))
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 1)
                    {
                        labelUser.Text = "";
                        labelUsercan.Text = "用户名中只能包含大小写字母和数字";
                    }

                }
                if (userPwd.Text == "")
                {
                    labelPwd.Text = "请输入密码";
                }
                if (textPwd.Text == "")
                {
                    labelPwd.Text = "两次输入密码不一致！";
                }
                if (hotelName.Text == "")
                {
                    labelHotel.Text = "请输入酒店名";
                }
                if (hotelAddr.Text == "")
                {
                    labelAddr.Text = "请输入地址";
                }
            }
            //将用户信息添加到数据库
            else
            {
                if (textPwd.Text != userPwd.Text)
                {
                    labelPwd.Text = "两次输入密码不一致！";
                }
                else
                {
                    if (mc.getStatus().ToLower() != "yes")
                    {
                        SqlTransaction transaction = null;
                        sc.Connect();
                        try
                        {
                            //新建用户名密码，并获取数据库访问权限
                            string cmdText = "sp_addlogin " + userName.Text + "," + userPwd.Text;
                            SqlCommand cmd = new SqlCommand(cmdText, sc.getConn());
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            //mc.setXmlDocument(userName.Text,userPwd.Text);
                            //sc.Connect();
                            cmdText = "sp_grantdbaccess N'" + userName.Text + "'";
                            transaction = sc.getConn().BeginTransaction();
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = cmdText;
                            cmd.Connection = sc.getConn();
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            cmdText = "EXEC sp_addrolemember N'db_owner',N'" + userName.Text + "'";
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = cmdText;
                            cmd.Connection = sc.getConn();
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            cmdText = "EXEC sp_addsrvrolemember '" + userName.Text.Trim() + "','sysadmin'";
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = cmdText;
                            cmd.Connection = sc.getConn();
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            mc.setXmlDocument(userName.Text, userPwd.Text, hotelName.Text, hotelTel.Text, hotelAddr.Text);
                            sc.Connect();
                            sc.createNew();
                            sc.Close();
                            mc.setStatus("yes");
                            transaction.Commit();
                            Home.panel_Log();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("注册失败：" + ex.Message);
                            transaction.Rollback();
                        }
                    }
                    else
                    {
                        MessageBox.Show("系统中已存在一个用户，不能再次注册！");
                        Home.panel_Log();
                    }
                }
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            userName.Text = "";
            userPwd.Text = "";
            hotelName.Text = "";
            hotelTel.Text = "";
            hotelAddr.Text = "";
            textPwd.Text = "";
            labelUser.Text = "*";
            labelUsercan.Text = "";
            labelPwd.Text = "*";
            labelHotel.Text = "*";
            labelAddr.Text = "*";
        }

        private void readCheck_CheckedChanged_1(object sender, EventArgs e)
        {
            if (readCheck.Checked)
            {
                readCheck.ForeColor = Color.MediumBlue;
            }
            else
            {
                readCheck.ForeColor = Color.Red;
            }
        }

        private void groupInfo_Enter(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (textName.Text == "" || textUser.Text == "" || textUserpwd.Text == "" || textPwd1.Text == "")
                {
                    if (textUser.Text == "")
                    {
                        labelUser1.Visible = true;
                    }
                    if (textUser.Text != "")
                    {
                        int flag = 0;
                        foreach (char c in textUser.Text.Trim())
                        {
                            if ((c > 'z' || c < 'a') && (c > 'Z' || c < 'A') && (c > '9' || c < '0'))
                            {
                                flag = 1;
                            }
                        }
                        if (flag == 1)
                        {
                            labelUser1.Text = "";
                            labelCan.Text = "用户名中只能包含大小写字母和数字";
                        }
                    }
                    if (textName.Text == "")
                    {
                        labelName.Visible = true;
                    }
                    if (textUserpwd.Text == "")
                    {
                        labelUserpwd.Visible = true;
                    }
                    if (textPwd1.Text == "")
                    {
                        labelUserpwd1.Visible = true;
                    }
                }
                else
                {
                    if (textUser.Text != "")
                    {
                        int flag = 0;
                        foreach (char c in textUser.Text.Trim())
                        {
                            if ((c > 'z' || c < 'a') && (c > 'Z' || c < 'A') && (c > '9' || c < '0'))
                            {
                                flag = 1;
                            }
                        }
                        if (flag == 1)
                        {
                            labelUser1.Text = "";
                            labelCan.Text = "用户名中只能包含大小写字母和数字";
                        }
                        if (sc.getConn().State != ConnectionState.Open)
                        {
                            sc.Connect();
                        }
                        string cmdText = "insert into Users values('" + textUser.Text.Trim() + "','" + textName.Text.Trim() + "','" + textUserpwd.Text.Trim() + "')";
                        SqlCommand cmd = new SqlCommand(cmdText, sc.getConn());
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("用户注册成功!");
                        Home.panel_Log();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("用户注册失败："+ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userName.Text = "";
            textName.Text = "";
            userPwd.Text = "";
            textPwd1.Text = "";
            this.Refresh();
        }

    }
}
