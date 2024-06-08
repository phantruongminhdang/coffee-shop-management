namespace WinFormsApp1.Admin
{
    partial class frmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 345);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dgvOrderList_CellDoubleClick;
            // 
            // button3
            // 
            button3.Location = new Point(679, 53);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 22;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(579, 53);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 21;
            button2.Text = "New";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(579, 17);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(365, 50);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 27);
            textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(88, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 27);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(365, 17);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 27);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 53);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 15;
            label4.Text = "Tpye";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 53);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 14;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 20);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 20);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 12;
            label1.Text = "ID";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduct";
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}