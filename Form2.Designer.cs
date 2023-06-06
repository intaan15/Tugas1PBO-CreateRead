namespace TugasAsdos
{
    partial class Form2
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
            groupBox2 = new GroupBox();
            AllDetailTransaksi = new Label();
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnNext = new Button();
            textStokLepi = new TextBox();
            textHargaLepi = new TextBox();
            textNamaLepi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AllDetailTransaksi);
            groupBox2.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(27, 273);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(586, 178);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detail Laptop";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // AllDetailTransaksi
            // 
            AllDetailTransaksi.AutoSize = true;
            AllDetailTransaksi.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AllDetailTransaksi.Location = new Point(27, 42);
            AllDetailTransaksi.Name = "AllDetailTransaksi";
            AllDetailTransaksi.Size = new Size(108, 22);
            AllDetailTransaksi.TabIndex = 0;
            AllDetailTransaksi.Text = "kesimpulan";
            AllDetailTransaksi.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(textStokLepi);
            groupBox1.Controls.Add(textHargaLepi);
            groupBox1.Controls.Add(textNamaLepi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 236);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Laptop";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(328, 179);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(456, 179);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 34);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnSave_Click;
            // 
            // textStokLepi
            // 
            textStokLepi.Location = new Point(210, 125);
            textStokLepi.Name = "textStokLepi";
            textStokLepi.Size = new Size(321, 29);
            textStokLepi.TabIndex = 5;
            // 
            // textHargaLepi
            // 
            textHargaLepi.Location = new Point(210, 84);
            textHargaLepi.Name = "textHargaLepi";
            textHargaLepi.Size = new Size(321, 29);
            textHargaLepi.TabIndex = 4;
            // 
            // textNamaLepi
            // 
            textNamaLepi.Location = new Point(210, 42);
            textNamaLepi.Name = "textNamaLepi";
            textNamaLepi.Size = new Size(321, 29);
            textNamaLepi.TabIndex = 1;
            textNamaLepi.TextChanged += textNamaLepi_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 126);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 3;
            label3.Text = "Stok Laptop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 84);
            label2.Name = "label2";
            label2.Size = new Size(126, 22);
            label2.TabIndex = 2;
            label2.Text = "Harga Laptop";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(124, 22);
            label1.TabIndex = 1;
            label1.Text = "Nama Laptop";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(483, 471);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(355, 471);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(637, 528);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Create Data";
            Load += Transaksi_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label AllDetailTransaksi;
        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnNext;
        private TextBox textStokLepi;
        private TextBox textHargaLepi;
        private TextBox textNamaLepi;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnClear;
    }
}