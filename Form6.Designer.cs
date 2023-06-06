namespace TugasAsdos
{
    partial class Form6
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
            button2 = new Button();
            label4 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(227, 327);
            button2.Name = "button2";
            button2.Size = new Size(90, 24);
            button2.TabIndex = 9;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 331);
            label4.Name = "label4";
            label4.Size = new Size(135, 16);
            label4.TabIndex = 8;
            label4.Text = "Don't have account yet?";
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(60, 137);
            button1.Name = "button1";
            button1.Size = new Size(156, 34);
            button1.TabIndex = 7;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleVioletRed;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(44, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 195);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 86);
            label3.Name = "label3";
            label3.Size = new Size(89, 22);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 33);
            label2.Name = "label2";
            label2.Size = new Size(96, 22);
            label2.TabIndex = 0;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleVioletRed;
            label1.Location = new Point(65, 49);
            label1.Name = "label1";
            label1.Size = new Size(246, 41);
            label1.TabIndex = 5;
            label1.Text = "<<  LOGIN  >>";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(375, 450);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form6";
            Text = "LOGIN";
            Load += Form6_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label4;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}