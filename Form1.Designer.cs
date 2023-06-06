namespace TugasAsdos
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
            button1 = new Button();
            button2 = new Button();
            UpdateData = new Button();
            DeleteData = new Button();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Location = new Point(53, 125);
            button1.Name = "button1";
            button1.Size = new Size(167, 50);
            button1.TabIndex = 1;
            button1.Text = "Tampilkan Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.Location = new Point(51, 196);
            button2.Name = "button2";
            button2.Size = new Size(169, 50);
            button2.TabIndex = 2;
            button2.Text = "Tambah Data";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // UpdateData
            // 
            UpdateData.BackColor = Color.PaleVioletRed;
            UpdateData.Location = new Point(280, 125);
            UpdateData.Name = "UpdateData";
            UpdateData.Size = new Size(166, 50);
            UpdateData.TabIndex = 3;
            UpdateData.Text = "Update Data";
            UpdateData.UseVisualStyleBackColor = false;
            UpdateData.Click += UpdateData_Click;
            // 
            // DeleteData
            // 
            DeleteData.BackColor = Color.PaleVioletRed;
            DeleteData.Location = new Point(280, 196);
            DeleteData.Name = "DeleteData";
            DeleteData.Size = new Size(166, 50);
            DeleteData.TabIndex = 4;
            DeleteData.Text = "Delete Data";
            DeleteData.UseVisualStyleBackColor = false;
            DeleteData.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumVioletRed;
            label1.Location = new Point(-1, 35);
            label1.Name = "label1";
            label1.Size = new Size(506, 58);
            label1.TabIndex = 5;
            label1.Text = "<<  LEPI STORE  >>";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleVioletRed;
            button3.Location = new Point(167, 276);
            button3.Name = "button3";
            button3.Size = new Size(166, 50);
            button3.TabIndex = 6;
            button3.Text = "Transaksi";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumVioletRed;
            label2.Location = new Point(183, 15);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 7;
            label2.Text = "WELCOME TO";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(496, 357);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(DeleteData);
            Controls.Add(UpdateData);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "LEPI STORE";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button UpdateData;
        private Button DeleteData;
        private Label label1;
        private Button button3;
        private Label label2;
    }
}