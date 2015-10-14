using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIMS
{
    class FormsData
    {
        public static bool IsAdmin=false;
        public static bool IsUser = false;
        public static string welWords = "欢迎使用酒店客房管理系统！";
        public static bool adminreg = false;
        MyConfig mc = new MyConfig();
        //set,get管理员状态

        public void setAdminStatus(bool flag)
        {
            IsAdmin = flag;
        }

        public bool getAdminStatus()
        {
            return IsAdmin;
        }
        //set,get普通用户状态
        public void setUserStatus(bool flag)
        {
            IsUser = flag;
        }

        public bool getUserStatus()
        {
            return IsUser;
        }
        //set,get中间界面显示内容
        public void setWords(string wel)
        {
            welWords = wel;
        }
        public string getWords()
        {
            return welWords;
        }
        public void setAdminreg()
        {
            if (mc.getStatus().ToLower() == "yes")
            {
                adminreg = true;
            }
        }
        public bool getAdminreg()
        {
            return adminreg;
        }
    }

}
