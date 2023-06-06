namespace TugasAsdos
{
    partial class Form3
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
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleVioletRed;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(709, 298);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(22, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 213);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Laptop";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 158);
            label4.Name = "label4";
            label4.Size = new Size(122, 22);
            label4.TabIndex = 7;
            label4.Text = "Stok Laptop";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 121);
            label3.Name = "label3";
            label3.Size = new Size(138, 22);
            label3.TabIndex = 6;
            label3.Text = "Harga Laptop";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(194, 158);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(309, 29);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(194, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(309, 29);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 29);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 84);
            label2.Name = "label2";
            label2.Size = new Size(135, 22);
            label2.TabIndex = 2;
            label2.Text = "Nama Laptop";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 29);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 45);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 0;
            label1.Text = "ID Laptop";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(606, 557);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(606, 506);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(760, 603);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Update Data";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private Button btnUpdate;
        private Button btnClear;
    }
}