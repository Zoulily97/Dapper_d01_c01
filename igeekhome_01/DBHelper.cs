using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;//导入
namespace igeekhome_01
{
   public  class DBHelper
    {
        /// <summary>
        /// 从配置文件中读取连接字符串
        /// </summary>
        public static string ConnStrings
        {
            get
            { 
                return ConfigurationManager.ConnectionStrings["connString"].ConnectionString; 
            }
        }
    }
}
