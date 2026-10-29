namespace DotSoftSender.Forms
{
    partial class frmSetting
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txtFile = new TextBox();
            btnsave = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Location = new Point(-1, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1352, 826);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 137);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 36, 59);
            label2.Location = new Point(0, 105);
            label2.Name = "label2";
            label2.Size = new Size(211, 32);
            label2.TabIndex = 1;
            label2.Text = "Message Content";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 36, 59);
            label1.Location = new Point(-3, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 57);
            label1.TabIndex = 0;
            label1.Text = "Message Settings";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtFile);
            panel2.Controls.Add(btnsave);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(3, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(1324, 670);
            panel2.TabIndex = 1;
            // 
            // txtFile
            // 
            txtFile.Enabled = false;
            txtFile.Location = new Point(3, 334);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(1311, 35);
            txtFile.TabIndex = 5;
            txtFile.TextChanged += txtFile_TextChanged;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(255, 100, 0);
            btnsave.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(147, 452);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(131, 40);
            btnsave.TabIndex = 4;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 100, 0);
            button2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(10, 452);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 3;
            button2.Text = "Upload";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1321, 290);
            textBox1.TabIndex = 1;
            textBox1.Text = "Write here...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(23, 36, 59);
            label3.Location = new Point(10, 301);
            label3.Name = "label3";
            label3.Size = new Size(211, 30);
            label3.TabIndex = 6;
            label3.Text = "Upload Photos/Files";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 408);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1314, 35);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 36, 59);
            label4.Location = new Point(10, 372);
            label4.Name = "label4";
            label4.Size = new Size(163, 30);
            label4.TabIndex = 8;
            label4.Text = "Phone Number";
            label4.Click += label4_Click;
            // 
            // frmSetting
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1637, 1028);
            Controls.Add(tableLayoutPanel1);
            Name = "frmSetting";
            Text = "frmSetting";
            Load += frmSetting_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private TextBox textBox1;
        private Button btnsave;
        private TextBox txtFile;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
    }
}