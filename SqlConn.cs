using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using HRIMS;
public class SqlConn
{
    private string servername = "";
    private string username = "";
    private string pwd = "";
    private string dbname = "";
    public　static SqlConnection conn=null;
    public SqlConn()
	{

	}
    //配置数据库连接参数
    public void setServer(string servername)
    {
        this.servername = servername;
    }
    public void setUser(string username)
    {
        this.username = username;
    }
    public void setPwd(string pwd)
    {
        this.pwd = pwd;
    }
    public void setDatabase(string dbname)
    {
        this.dbname = dbname;
    }
    public SqlConnection getConn()
    {
        return conn;
    }
    public void setAll()
    {
        MyConfig mc = new MyConfig();
        setServer(mc.getServer());
        setUser(mc.getUser());
        setPwd(mc.getPwd());
        setDatabase(mc.getDbname());
    }
    //连接数据库
    public void Connect()
    {
        setAll();
        string ConString = "server=" + servername + ";uid=" + username + ";pwd=" + pwd + ";database=" + dbname;
        conn = new SqlConnection(ConString);
        conn.Open();
        //    if (conn.State == ConnectionState.Open)
        //    {
        //        MessageBox.Show("连接数据库成功！");
        //    }
        //    else
        //    {
        //        MessageBox.Show("连接数据库失败！");
        //    }
    }
    public void ConnectServer()
    {
        MyConfig mc = new MyConfig();
        setServer(mc.getServer());
        setUser(mc.getUser());
        setPwd(mc.getPwd());
        string ConString = "server=" + servername + ";uid=" + username + ";pwd=" + pwd;
        conn = new SqlConnection(ConString);
        conn.Open();
        //if (conn.State == ConnectionState.Open)
        //{
        //    MessageBox.Show("连接数据库成功！");
        //}
        //else
        //{
        //    MessageBox.Show("连接数据库失败！");
        //}
    }
    public void createNew()
    {
        try{
        //创建用户表
        string cmdText = "create table Users(Username char(20) primary key,Name char(20),Pwd char(20))";
        SqlCommand cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //创建宾客信息表
        cmdText = "create table Guest(gid char(20) primary key,gname char(10),tel char(20) not null,);";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //创建客房类型表
        cmdText = "create table Type(typenum int primary key,typename char(10) not null,prize int not null,);";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //创建客房信息表
        cmdText = "create table Room(rid int primary key,typenum int not null,status char(5),orders char(5),foreign key (typenum) references Type(typenum),);";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //创建预约信息表
        cmdText = "create table Orders(rid int primary key,name char(10),tel char(20),orders char(5),ordertime date,foreign key (rid) references Room(rid));";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //创建入住信息表
        cmdText = "create table Checkin(rid int primary key,gid char(20),intime date,incost int,details char(200),foreign key (rid) references Room(rid),foreign key (gid) references Guest(gid),);";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //创建入住信息备份表
        cmdText = "create table CheckinBackup(rid int,gid char(20),intime date,outtime date,incost int,outcost int,details char(200),primary key(rid,intime),foreign key (rid) references Room(rid),foreign key (gid) references Guest(gid),);";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //创建宾客信息视图
        cmdText = "create view V_Guest as select gname,tel,Room.rid,typename,intime,outtime,outcost,details from Guest,Room,Type,CheckinBackup where Guest.gid=CheckinBackup.gid and Room.rid=CheckinBackup.rid and Room.typenum=Type.typenum;";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //创建客房信息视图
        cmdText = "create view V_Room as select Room.rid,typename,gname,tel,intime,outtime,outcost,details from Guest,Room,Type,CheckinBackup where Guest.gid=CheckinBackup.gid and Room.rid=CheckinBackup.rid and Room.typenum=Type.typenum;";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //获取表操作权限
        cmdText = "grant insert,select,update,delete on Users to public";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        cmdText = "grant insert,select,update,delete on Type to public";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        cmdText = "grant insert,select,update,delete on Guest to public";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        cmdText = "grant insert,select,update,delete on Room to public";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        cmdText = "grant insert,select,update,delete on Checkin to public";
        cmd = new SqlCommand(cmdText, conn);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        }
        catch(Exception ex)
        {
            MessageBox.Show("初始化数据库失败："+ex.Message);
        }
    }
    //关闭数据库
     public void Close()
     {
         setAll();
         string ConString = "server=" + servername + ";uid=" + username + ";pwd=" + pwd+":database="+dbname;
         conn = new SqlConnection(ConString);
         conn.Close();
         //if (conn.State == ConnectionState.Closed)
         //{
         //    MessageBox.Show("已退出数据库！");
         //}
         //else
         //{
         //    MessageBox.Show("退出数据库失败！");
         //}
     }
     public void CloseServer()
     {
         MyConfig mc = new MyConfig();
         setServer(mc.getServer());
         setUser(mc.getUser());
         setPwd(mc.getPwd());
         string ConString = "server=" + servername + ";uid=" + username + ";pwd=" + pwd;
         conn = new SqlConnection(ConString);
         conn.Close();
         //if (conn.State == ConnectionState.Closed)
         //{
         //    MessageBox.Show("已退出数据库！");
         //}
         //else
         //{
         //    MessageBox.Show("退出数据库失败！");
         //}
     }
    public void ReConnect()
     {
        if(conn.State==ConnectionState.Open)
        {
            Close();
        }

         Connect();
     }
}
