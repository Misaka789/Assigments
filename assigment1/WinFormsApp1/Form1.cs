namespace WinFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            result = Calculate();
            label1.Text = result + "";
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            TextBox sender1 = (TextBox)sender;
            sender1.Text = result + "";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox sender1 = (TextBox)sender;
            if (sender1.Text != null)
                double1 = double.Parse(sender1.Text);
        }
        private double Calculate()
        {
            if (double2 == 0 && operation == '/') throw new Exception("0不能作为除数");
            switch (operation)
            {
                case '+':
                    return (double1 + double2);

                case '-':
                    return (double1 - double2);

                case '*':
                    return (double1 * double2);

                case '/':
                    return (double1 / double2);
                case '%':
                    return double1 % double2;
                default: return 0;
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox sender1 = (TextBox)sender;
            if (sender1.Text != null)
                double2 = double.Parse(sender1.Text);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton sender1 = (RadioButton)sender;
            operation = '+';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton sender1 = (RadioButton)sender;
            operation = '-';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton sender1 = (RadioButton)sender;
            operation = '*';
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton sender1 = (RadioButton)sender;
            operation = '/';
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton sender1 = (RadioButton)sender;
            operation = '%';
        }
    }
}
