using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace igeekhome_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 搜索按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //实例化PersonService
            PersonService ps = new PersonService();
            List<Person> list = ps.FindListByLastName(this.txtSearch.Text.Trim());//根据姓氏查找的用户列表方法
            //绑定数据源
            listContent.DataSource = list;
            //显示成员
            listContent.DisplayMember = "EmailAddress";

        }

        private void listContent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
