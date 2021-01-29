using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace igeekhome_01
{
    public class PersonService
    {

        /// <summary>
        ///  根据用户姓氏查询用户集合
        /// </summary>
        /// <param name="lastname">用户姓氏</param>
        /// <returns></returns>
        public List<Person> FindListByLastName(string lastname)
        {
            //查询
            //  IDbConnection
            using (IDbConnection db = new SqlConnection(DBHelper.ConnStrings))
            {
                //1;
                //string sql = "select * from Person where LastName='wood'";
                //2\
                //string sql = "select * from Person where LastName='" + lastname + "'";

                //3;Format格式化
                //string sql =string.Format( "select * from Person where LastName='{0}'",lastname);

               // 4'；C#6语法
                string sql = $"select * from Person where LastName='{lastname}'";
                IEnumerable<Person> lst = db.Query<Person>(sql);//Query 为db对象的扩展方法；

                //string sql = "select * from Person where LastName='wood' or '1'='1';sql注入

                //5,解决sql注入问题
                //string sql = $"select * from Person where LastName=@LastName";//用@作为参数
                //IEnumerable<Person> lst =db.Query<Person>(sql, new { LastName = lastname });

                return lst.ToList();//转化为list类型

            }
        }
    }
}
