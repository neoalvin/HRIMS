using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace HRIMS
{
    public partial class HomePage : Form
    {
        SqlConn sc = new SqlConn();
        FormsData fd = new FormsData();
        MyConfig mc = new MyConfig();
        //public static string servername;
        //public static string username;
        //public static string userpwd;
        //public static string dbname;
        public HomePage()
        {
            InitializeComponent();
            //初始化导入对话框到Panel控件
            panel_Log();
            //初始化TreeView
            initTree();
        }
        public void focusNode(string nText)
        {
            myTree.Focus();
            for (int i = 0; i < myTree.Nodes.Count; i++)
            {
                for (int j = 0; j < myTree.Nodes[i].Nodes.Count; j++)
                {
                    if (myTree.Nodes[i].Nodes[j].Text == nText)
                    {
                        myTree.SelectedNode = myTree.Nodes[i].Nodes[j];//选中
                    }
                    for (int k = 0; k < myTree.Nodes[i].Nodes[j].Nodes.Count; k++)
                    {
                        if (myTree.Nodes[i].Nodes[j].Nodes[k].Text == nText)
                        {
                            myTree.SelectedNode = myTree.Nodes[i].Nodes[j].Nodes[k];//选中
                        }
                    }
                }
            }
            
        }
        //切换登录界面
        public void panel_Log()
        {
            focusNode("用户登录");
            if (fd.getAdminStatus())
            {
                fd.setWords("用户已登录！请根据需要进行相应操作");
                panel_Wel();
            }
            else
            {
                LoginWin log = new LoginWin();
                log.Home = this;
                log.TopLevel = false;
                this.mainPanel.Controls.Clear();
                this.mainPanel.Controls.Add(log);
                log.Show();
            }
        }
        //切换用户注册界面
        public void panel_Reg()
        {
            focusNode("用户注册");
            RegitForm reg = new RegitForm();
            reg.Home = this;
            reg.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(reg);
            reg.Show();
        }
        //切换欢迎界面
        public void panel_Wel()
        {
            WelForm wel = new WelForm();
            wel.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(wel);
            wel.Show();
        }

        //切换宾客登记
        public void panel_GLog()
        {
            focusNode("宾客登记");
            GuestLogin gl = new GuestLogin();
            gl.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(gl);
            gl.Show();
        }
        //切换宾客退房
        public void panel_GExit()
        {
            focusNode("宾客退房");
            GuestExit ge= new GuestExit();
            ge.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(ge);
            ge.Show();
        }
        public void panel_GOrder()
        {
            focusNode("宾客预约");
            GuestOrder go = new GuestOrder();
            go.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(go);
            go.Show();
        }
        //切换客房管理
        public void panel_RForm()
        {
            focusNode("客房管理");
            RoomForm rf = new RoomForm();
            rf.Home = this;
            rf.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(rf);
            rf.Show();
        }
        //切换客户管理
        public void panel_GForm()
        {
            focusNode("客户管理");
            GuestForm gf = new GuestForm();
            gf.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(gf);
            gf.Show();
        }
        //切换系统设置
        public void panel_Setting()
        {
            focusNode("系统设置");
            SettingForm sf = new SettingForm();
            sf.TopLevel = false;
            sf.Home = this;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(sf);
            sf.Show();
        }
        //切换分类统计
        public void panel_Sort()
        {
            focusNode("系统设置");
            SortForm sf = new SortForm();
            sf.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(sf);
            sf.Show();
        }
        //初始化树形菜单控件
        public void initTree()
        {
            TreeNode node = new TreeNode();
            //设置Treeview上方间距
            myTree.Top = 94;
            //添加根节点
            string[] TreeStr = new string[5] { "用户操作", "前台服务", "后台管理", "系统设置" ,"退出系统"};
            for (int i = 0; i <= 4; i++)
            {
                myTree.Nodes.Add(new TreeNode(TreeStr[i]));
                myTree.Nodes[i].ForeColor = Color.Black;
                myTree.Nodes[i].ExpandAll();
            }
            //添加子节点
            myTree.Nodes[0].Nodes.Add("用户登录");
            myTree.Nodes[0].Nodes.Add("用户注册");
            myTree.Nodes[1].Nodes.Add("宾客登记");
            myTree.Nodes[1].Nodes.Add("宾客退房");
            myTree.Nodes[1].Nodes.Add("宾客预约");
            myTree.Nodes[2].Nodes.Add("客户管理");
            myTree.Nodes[2].Nodes.Add("客房管理");
        }
        //TreeView点击函数--切换菜单
        private void myTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FormsData fd=new FormsData();
            TreeNode node = new TreeNode();
            node = myTree.SelectedNode;
            if (node.Text == "用户操作" || node.Text == "前台服务" || node.Text == "后台管理" ){}              
            else if (node.Text == "退出系统")
            {
                 sc.Close();
                Application.Exit();
            }
            else if (node.Text == "用户登录")
            {
                //用户已登录则跳转至提示界面
                if (fd.getAdminStatus())
                {
                    fd.setAdminStatus(false);
                }
                panel_Log();
            }
            else if (node.Text == "用户注册")
            {
                if (fd.getAdminStatus())
                {
                    panel_Reg();
                }
                else
                {
                    MessageBox.Show("管理员账户未登录！");
                    panel_Log();
                }
            }
            else if (node.Text == "宾客登记")
            {
                if (fd.getUserStatus()||fd.getAdminStatus())
                {
                    panel_GLog(); 
                }
                else
                {
                    MessageBox.Show("用户未登录！");
                    panel_Log();
                }
            }
            else if (node.Text == "宾客退房")
            {
                if (fd.getAdminStatus()||fd.getUserStatus())
                {
                    panel_GExit();
                }
                else
                {
                    MessageBox.Show("用户未登录！");
                    panel_Log();
                }

            }
            else if (node.Text == "宾客预约")
            {
                if (fd.getAdminStatus()||fd.getUserStatus())
                {
                    panel_GOrder();
                }
                else
                {
                    MessageBox.Show("用户未登录！");
                    panel_Log();
                }

            }
            else if (node.Text == "客户管理")
            {
                if (!fd.getAdminStatus())
                {
                    MessageBox.Show("需登录管理员账号！");
                    panel_Log();
                }
                else
                {
                    panel_GForm();
                }

            }
            else if (node.Text == "客房管理")
            {
                if (!fd.getAdminStatus())
                {
                    MessageBox.Show("需登录管理员账号！");
                    panel_Log();
                }
                else
                {
                    panel_RForm();
                }
            }
            else if (node.Text == "系统设置")
            {
                if (!fd.getAdminStatus())
                {
                    MessageBox.Show("需登录管理员账号！");
                    panel_Log();
                }
                else
                {
                    panel_Setting();
                }
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }


    }
}
