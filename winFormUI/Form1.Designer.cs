namespace winFormUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Query_Button = new Button();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            SearchBox = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dataGridView1 = new DataGridView();
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            button4 = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Query_Button);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(102, 436);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Query_Button
            // 
            Query_Button.Location = new Point(3, 3);
            Query_Button.Name = "Query_Button";
            Query_Button.Size = new Size(94, 29);
            Query_Button.TabIndex = 1;
            Query_Button.Text = "查询订单";
            Query_Button.UseVisualStyleBackColor = true;
            Query_Button.Click += Query;
            // 
            // button2
            // 
            button2.Location = new Point(3, 38);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "删除订单";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 73);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 1;
            button3.Text = "更新订单";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 108);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "新增订单";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(SearchBox);
            flowLayoutPanel2.Controls.Add(groupBox1);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(102, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1024, 78);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.Location = new Point(3, 3);
            SearchBox.Name = "SearchBox";
            SearchBox.RightToLeft = RightToLeft.No;
            SearchBox.Size = new Size(196, 27);
            SearchBox.TabIndex = 0;
            SearchBox.Text = "请输入查询信息";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(205, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(646, 64);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "查询选项";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(344, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(90, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Tag = "3";
            radioButton3.Text = "客户名称";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += RadioChange;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Tag = "1";
            radioButton2.Text = "订单ID";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += RadioChange;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(172, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Tag = "2";
            radioButton1.Text = "商品名称";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += RadioChange;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderIdDataGridViewTextBoxColumn, customerDataGridViewTextBoxColumn, PhoneNumber, Product, Amount, TotalAmount });
            dataGridView1.DataSource = orderBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(102, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1024, 358);
            dataGridView1.TabIndex = 2;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            orderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            customerDataGridViewTextBoxColumn.ReadOnly = true;
            customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "TotalAmount";
            PhoneNumber.HeaderText = "PhoneNumber";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 125;
            // 
            // Product
            // 
            Product.DataPropertyName = "OrderId";
            Product.HeaderText = "Product";
            Product.MinimumWidth = 6;
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Width = 125;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "OrderId";
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 125;
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "TotalAmount";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            TotalAmount.Width = 125;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(assigment5.Order);
            // 
            // button4
            // 
            button4.Location = new Point(3, 143);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "所有订单";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1126, 436);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "订单管理系统";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button Query_Button;
        private Button button2;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox SearchBox;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn TotalAmount;
        private Button button4;
    }
}
