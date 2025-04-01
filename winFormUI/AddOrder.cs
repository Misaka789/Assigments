using assigment5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormUI
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //保存已经输入的数据
            string ID = textBox1.Text;
            string CustmerName = textBox2.Text;
            string Phone = textBox4.Text;
            string detail = textBox3.Text;
            string[] contents = detail.Split(',');
            OrderDetail orderDetail = new(new Product(contents[0]), int.Parse(contents[1]),float.Parse(contents[2]));
            Order order = new(ID, new(CustmerName, Phone));
            order.AddDetail(orderDetail);
            Program.orderService.AddOrder(order);
            MessageBox.Show("添加成功");
        }
    }
}
