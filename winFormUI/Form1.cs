using assigment5;
using System.Runtime.InteropServices.ObjectiveC;

namespace winFormUI
{
    public partial class Form1 : Form
    {
        const int ById = 1;
        const int ByProduct = 2;
        const int ByCusomer = 3;
        private int selection = 0;

        private List<Order> result = new();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Query(object sender, EventArgs e)
        {
            String query = SearchBox.Text;
            //遍历容器中的所有控件找到radio的值
            //根据Tag值查询数据
            switch (selection)
            {
                case ById:
                    {
                        MessageBox.Show("根据ID查询");
                        String str = Program.orderService.GetById(query).ToString();
                        MessageBox.Show(str);
                        result.Clear();
                        result.Add(Program.orderService.GetById(query));
                        orderBindingSource.DataSource = result;
                        break;
                    }
                case ByCusomer:
                    {
                        MessageBox.Show("根据顾客查询");
                        orderBindingSource.DataSource = Program.orderService.QueryByCustomer(query);
                        break;
                    }
                case ByProduct:
                    {
                        MessageBox.Show("根据产品查询");
                        orderBindingSource.DataSource = Program.orderService.QueryByProduct(query);
                        break;
                    }
            }

        }

        private void RadioChange(object sender, EventArgs e)  //成功转换
        {
            RadioButton radioButton = (RadioButton)sender;
            selection = Convert.ToInt32(radioButton.Tag);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrder newForm = new AddOrder();  // 实例化新窗体
            newForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = Program.orderService.Orders;
        }
        /* private void RadioGroup_CheckedChanged(object sender, EventArgs e)
{
RadioButton selectedRadio = sender as RadioButton;
if (selectedRadio != null && selectedRadio.Checked)
{

}
}*/
    }
}
