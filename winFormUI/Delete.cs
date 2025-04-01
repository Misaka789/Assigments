using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormUI
{
    public partial class Delete : Form
    {
        int select = 0;
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //执行删除逻辑
            string To_Delete = textBox1.Text;
            switch (select)
            {
                case 1:
                    {
                        Program.orderService.RemoveOrder(To_Delete);
                        MessageBox.Show("删除成功");
                        break;
                    }
                case 2:
                    {
                        Program.orderService.RemoveByCustomer(To_Delete);
                        MessageBox.Show("删除成功");
                        break;
                    }
                case 3:
                    {
                        Program.orderService.RemoveByProduct(To_Delete);
                        MessageBox.Show("删除成功");
                        break;
                    }
            }
        }

        private void Change(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                switch (radioButton.Text)
                {
                    case "DeleteById":
                        select = 1;
                        break;
                    case "DeleteByCustomer":
                        select = 2;
                        break;
                    case "DeleteByProduct":
                        select = 3;
                        break;
                }
            }
        }
    }
}
