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
    public partial class LoginWin : Form
    {
        public HomePage Home;
        SqlConn sc= new SqlConn();
        FormsData fd = new FormsData();
        public LoginWin()
        {
            InitializeComponent();
        }
        //登录按钮功能
        private void Login_Click(object sender, EventArgs e)
        {
            Home.Refresh();
            if (userName.Text == "" || userPwd.Text == "")
            {
                if (userName.Text == "")
                {
                    labelUser.Visible = true;
                }
                if (userPwd.Text == "")
                {
                    labelPwd.Visible = true;
                }
            }
            else if(radioSu.Checked)
            {
                MyConfig mc=new MyConfig();
                if (userName.Text == mc.getUser() && userPwd.Text == mc.getPwd())
                {
                    //连接数据库
                    sc.Connect();
                    //设置登录状态
                    fd.setAdminStatus(true);
                    fd.setWords("用户登录成功！相应操作已解锁,\n\n  新用户请先进行客房信息录入");
                    Home.panel_Wel();
                }
                else
                {
                    labelLogin.Text = "用户名或密码不正确！";
                }
            }
            else if(radioUser.Checked)
            {
                sc.Connect();
                string cmdText = "select Username,Pwd from Users";
                SqlDataAdapter adapter = new SqlDataAdapter(cmdText, sc.getConn());
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                adapter.Dispose();
                int flag = 0;
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    if (dataSet.Tables[0].Rows[i][0].ToString().Trim() == userName.Text.Trim() && dataSet.Tables[0].Rows[i][1].ToString().Trim() == userPwd.Text.Trim())
                    {
                        flag = 1;
                        fd.setUserStatus(true);
                        fd.setWords("用户登录成功！相应操作已解锁,\n\n ");
                        Home.panel_Wel();
                    }
                }
                if (flag == 0)
                {
                    labelLogin.Text = "用户名或密码不正确！";
                }
            }
            else
            {
                MessageBox.Show("未选中登录方式！");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            userName.Text = "";
            userPwd.Text = "";
            labelLogin.Text = "";
            labelUser.Text = "";
            labelPwd.Text = "";
        }
    }
}
