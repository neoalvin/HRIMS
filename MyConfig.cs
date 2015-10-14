using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
namespace HRIMS
{
    class MyConfig
    {
        public string xmlfile = "E:\\Program\\C#\\HRIMS\\HRIMS\\MyConfig.xml";
        public XmlDocument xml = new XmlDocument();
        //打开文件选择对话框
        //OpenFileDialog dialog = new OpenFileDialog();
        //if (dialog.ShowDialog() == DialogResult.OK)
        //{
        //     xmlfile= dialog.FileName;
        //}
        //获取服务器名
        public string getServer()
        {
            string tmpValue = "";
            try
            {
               xml.Load(xmlfile);
                //数据库连接字符串
                if (xml.GetElementsByTagName("servername").Count > 0)
                {
                    tmpValue = xml.DocumentElement["servername"].InnerText.Trim();
                }
                return tmpValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
                return null;
            }
        }
        //获取用户名
         public string getUser()
        {
             string tmpValue = "";
            try
            {
               xml.Load(xmlfile);
                if (xml.GetElementsByTagName("username").Count > 0)
                {
                    tmpValue = xml.DocumentElement["username"].InnerText.Trim();
                }
                return tmpValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
                return null;
            }
        }
        //获取用户密码
        public string  getPwd()
        {
            string tmpValue = "";
            try
            {
               xml.Load(xmlfile);
                if (xml.GetElementsByTagName("userpwd").Count > 0)
                {
                    tmpValue = xml.DocumentElement["userpwd"].InnerText.Trim();
                }
                return tmpValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
                return null;
            }
        }
        //获取数据库名
        public string  getDbname()
        {
            string tmpValue = "";
            try
            {
               xml.Load(xmlfile);
                if (xml.GetElementsByTagName("dbname").Count > 0)
                {
                    tmpValue = xml.DocumentElement["dbname"].InnerText.Trim();
                }
                return  tmpValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
                return null;
            }
        }
        //获取酒店名
        public string  getHotelname()
        {
            string tmpValue = "";
            try
            {
               xml.Load(xmlfile);
                if (xml.GetElementsByTagName("hotelname").Count > 0)
                {
                    tmpValue = xml.DocumentElement["hotelname"].InnerText.Trim();
                }
                return tmpValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
                return null;
            }
        }
        //获取酒店地址
        public string getHoteladdr()
        {
            string tmpValue = "";
            try
            {
               xml.Load(xmlfile);
                if (xml.GetElementsByTagName("hoteladdr").Count > 0)
                {
                    tmpValue = xml.DocumentElement["hoteladdr"].InnerText.Trim();
                }
                return  tmpValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
                return null;
            }
        }
        //获取酒店联系方式
        public string getHoteltel()
        {
            string tmpValue = "";
            try
            {
               xml.Load(xmlfile);
                if (xml.GetElementsByTagName("hoteltel").Count > 0)
                {
                    tmpValue = xml.DocumentElement["hoteltel"].InnerText.Trim();
                }
                return tmpValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
                return null;
            }
        }
        public string getStatus()
        {
            string tmpValue = "";
            try
            {
                xml.Load(xmlfile);
                if (xml.GetElementsByTagName("status").Count > 0)
                {
                    tmpValue = xml.DocumentElement["status"].InnerText.Trim();
                }
                return tmpValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
                return null;
            }
        }
        //写入配置文件--包含服务器
        public void setXmlDocument(string server,string user,string pwd,string name,string tel,string addr)
        {
           xml.Load(xmlfile);
           XmlNodeList nodes = xml.SelectSingleNode("root").ChildNodes;
           for (int i = 0; i < nodes.Count; i++)  
           {  
               if(nodes[i].Name.Equals("servername"))  
               {  
                   nodes[i].InnerText = server;  
               }
               if(nodes[i].Name.Equals("username"))  
               {  
                   nodes[i].InnerText = user;  
               }  
               if(nodes[i].Name.Equals("userpwd"))  
               {  
                   nodes[i].InnerText = pwd;  
               }  
               if(nodes[i].Name.Equals("hotelname"))  
               {  
                   nodes[i].InnerText = name;  
               }  
               if(nodes[i].Name.Equals("hoteltel"))  
               {  
                   nodes[i].InnerText = tel;  
               }  
               if(nodes[i].Name.Equals("hoteladdr"))  
               {  
                   nodes[i].InnerText = addr;  

               }  

           }  
           try  
           {  
               //保存上面的修改　　  
               xml.Save(xmlfile);  
                 
           }  
           catch (Exception e)  
           {  
               throw e;  
           }
        }
        //写入配置文件--不包含服务器
        public void setXmlDocument(string user, string pwd,  string name, string tel, string addr)
        {
            xml.Load(xmlfile);
            XmlNodeList nodes = xml.SelectSingleNode("root").ChildNodes;
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Name.Equals("username"))
                {
                    nodes[i].InnerText = user;
                }
                if (nodes[i].Name.Equals("userpwd"))
                {
                    nodes[i].InnerText = pwd;
                }
                if (nodes[i].Name.Equals("hotelname"))
                {
                    nodes[i].InnerText = name;
                }
                if (nodes[i].Name.Equals("hoteltel"))
                {
                    nodes[i].InnerText = tel;
                }
                if (nodes[i].Name.Equals("hoteladdr"))
                {
                    nodes[i].InnerText = addr;

                }

            }
            try
            {
                //保存上面的修改　　  
                xml.Save(xmlfile);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //修改用户名和密码
        public void setXmlDocument(string user, string pwd)
        {
            xml.Load(xmlfile);
            XmlNodeList nodes = xml.SelectSingleNode("root").ChildNodes;
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Name.Equals("username"))
                {
                    nodes[i].InnerText = user;
                }
                if (nodes[i].Name.Equals("userpwd"))
                {
                    nodes[i].InnerText = pwd;
                }

            }
            try
            {
                //保存上面的修改　　  
                xml.Save(xmlfile);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //管理员修改配置文件
        public void setConfigFile(string server,string pwd)
        {
            xml.Load(xmlfile);
            XmlNodeList nodes = xml.SelectSingleNode("root").ChildNodes;
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Name.Equals("servername"))
                {
                    nodes[i].InnerText = server;
                }
                if (nodes[i].Name.Equals("userpwd"))
                {
                    nodes[i].InnerText = pwd;
                }
            }
            try
            {
                //保存上面的修改　　  
                xml.Save(xmlfile);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //修改注册状态
        public void setStatus(string status)
        {
            xml.Load(xmlfile);
            XmlNodeList nodes = xml.SelectSingleNode("root").ChildNodes;
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Name.Equals("status"))
                {
                    nodes[i].InnerText = status;
                }
            }
            try
            {
                //保存上面的修改　　  
                xml.Save(xmlfile);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
