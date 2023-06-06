namespace TugasAsdos
{
    partial class Form7
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleVioletRed;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(35, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 213);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 34);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Pink;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(197, 144);
            button2.Name = "button2";
            button2.Size = new Size(119, 34);
            button2.TabIndex = 9;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 83);
            label2.Name = "label2";
            label2.Size = new Size(89, 22);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(21, 144);
            button1.Name = "button1";
            button1.Size = new Size(115, 34);
            button1.TabIndex = 8;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 31);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.PaleVioletRed;
            label3.Location = new Point(56, 49);
            label3.Name = "label3";
            label3.Size = new Size(283, 41);
            label3.TabIndex = 10;
            label3.Text = "<<  Register  >>";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(408, 402);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "Form7";
            Text = "REGISTER";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button2;
        private Button button1;
    }
}