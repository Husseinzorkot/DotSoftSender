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
            lblSubtitle = new Label();
            label1 = new Label();
            panel2 = new DotSoftSender.UI.CardPanel();
            phoneBox = new DotSoftSender.UI.CardPanel();
            textBox2 = new TextBox();
            label4 = new Label();
            lblFileHint = new Label();
            button2 = new DotSoftSender.UI.ModernButton();
            fileBox = new DotSoftSender.UI.CardPanel();
            txtFile = new TextBox();
            label3 = new Label();
            messageBox = new DotSoftSender.UI.CardPanel();
            textBox1 = new TextBox();
            label2 = new Label();
            footerPanel = new Panel();
            btnCancel = new DotSoftSender.UI.ModernButton();
            btnsave = new DotSoftSender.UI.ModernButton();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            phoneBox.SuspendLayout();
            fileBox.SuspendLayout();
            messageBox.SuspendLayout();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(footerPanel, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(41, 48);
            tableLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 152F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            tableLayoutPanel1.Size = new Size(1221, 1224);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSubtitle);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1221, 152);
            panel1.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(3, 72);
            lblSubtitle.Margin = new Padding(5, 0, 5, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(596, 30);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Configure the message, attachment and sender phone number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(-3, 8);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(308, 47);
            label1.TabIndex = 0;
            label1.Text = "Message Settings";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderColor = Color.FromArgb(226, 232, 240);
            panel2.Controls.Add(phoneBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblFileHint);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(fileBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(messageBox);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 152);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1221, 944);
            panel2.TabIndex = 1;
            // 
            // phoneBox
            // 
            phoneBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneBox.BackColor = Color.White;
            phoneBox.BorderColor = Color.FromArgb(226, 232, 240);
            phoneBox.BorderRadius = 6;
            phoneBox.Controls.Add(textBox2);
            phoneBox.Location = new Point(41, 796);
            phoneBox.Margin = new Padding(5, 6, 5, 6);
            phoneBox.Name = "phoneBox";
            phoneBox.Padding = new Padding(21, 22, 21, 16);
            phoneBox.Size = new Size(1138, 80);
            phoneBox.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 9.75F);
            textBox2.ForeColor = Color.FromArgb(15, 23, 42);
            textBox2.Location = new Point(21, 22);
            textBox2.Margin = new Padding(5, 6, 5, 6);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "e.g. +961 70 123 456";
            textBox2.Size = new Size(1096, 31);
            textBox2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(15, 23, 42);
            label4.Location = new Point(38, 744);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(233, 30);
            label4.TabIndex = 6;
            label4.Text = "Sender phone number";
            // 
            // lblFileHint
            // 
            lblFileHint.AutoSize = true;
            lblFileHint.Font = new Font("Segoe UI", 8.25F);
            lblFileHint.ForeColor = Color.FromArgb(100, 116, 139);
            lblFileHint.Location = new Point(38, 668);
            lblFileHint.Margin = new Padding(5, 0, 5, 0);
            lblFileHint.Name = "lblFileHint";
            lblFileHint.Size = new Size(447, 28);
            lblFileHint.TabIndex = 5;
            lblFileHint.Text = "Image or document sent along with each message";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Icon = "";
            button2.Location = new Point(974, 576);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(206, 80);
            button2.TabIndex = 4;
            button2.Text = "Browse";
            button2.Variant = UI.ButtonVariant.Secondary;
            button2.Click += button2_Click;
            // 
            // fileBox
            // 
            fileBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileBox.BackColor = Color.White;
            fileBox.BorderColor = Color.FromArgb(226, 232, 240);
            fileBox.BorderRadius = 6;
            fileBox.Controls.Add(txtFile);
            fileBox.Location = new Point(41, 576);
            fileBox.Margin = new Padding(5, 6, 5, 6);
            fileBox.Name = "fileBox";
            fileBox.Padding = new Padding(21, 22, 21, 16);
            fileBox.Size = new Size(912, 80);
            fileBox.TabIndex = 3;
            // 
            // txtFile
            // 
            txtFile.BackColor = Color.White;
            txtFile.BorderStyle = BorderStyle.None;
            txtFile.Dock = DockStyle.Fill;
            txtFile.Font = new Font("Segoe UI", 9.75F);
            txtFile.ForeColor = Color.FromArgb(100, 116, 139);
            txtFile.Location = new Point(21, 22);
            txtFile.Margin = new Padding(5, 6, 5, 6);
            txtFile.Name = "txtFile";
            txtFile.PlaceholderText = "No file selected";
            txtFile.ReadOnly = true;
            txtFile.Size = new Size(870, 31);
            txtFile.TabIndex = 0;
            txtFile.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(38, 524);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 30);
            label3.TabIndex = 2;
            label3.Text = "Attachment";
            // 
            // messageBox
            // 
            messageBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            messageBox.BackColor = Color.White;
            messageBox.BorderColor = Color.FromArgb(226, 232, 240);
            messageBox.BorderRadius = 6;
            messageBox.Controls.Add(textBox1);
            messageBox.Location = new Point(41, 100);
            messageBox.Margin = new Padding(5, 6, 5, 6);
            messageBox.Name = "messageBox";
            messageBox.Padding = new Padding(21, 20, 10, 20);
            messageBox.Size = new Size(1138, 384);
            messageBox.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 9.75F);
            textBox1.ForeColor = Color.FromArgb(15, 23, 42);
            textBox1.Location = new Point(21, 20);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Write your message here...";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(1107, 344);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(15, 23, 42);
            label2.Location = new Point(38, 48);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 30);
            label2.TabIndex = 0;
            label2.Text = "Message content";
            // 
            // footerPanel
            // 
            footerPanel.Controls.Add(btnCancel);
            footerPanel.Controls.Add(btnsave);
            footerPanel.Dock = DockStyle.Fill;
            footerPanel.Location = new Point(0, 1096);
            footerPanel.Margin = new Padding(0);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(1221, 128);
            footerPanel.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(789, 48);
            btnCancel.Margin = new Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(206, 80);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.Variant = UI.ButtonVariant.Secondary;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsave.Icon = "";
            btnsave.Location = new Point(1015, 48);
            btnsave.Margin = new Padding(5, 6, 5, 6);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(206, 80);
            btnsave.TabIndex = 0;
            btnsave.Text = "Save";
            btnsave.Click += btnsave_Click;
            // 
            // frmSetting
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            CancelButton = btnCancel;
            ClientSize = new Size(1303, 1320);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSetting";
            Padding = new Padding(41, 48, 41, 48);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings — DotSoft";
            Load += frmSetting_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            phoneBox.ResumeLayout(false);
            phoneBox.PerformLayout();
            fileBox.ResumeLayout(false);
            fileBox.PerformLayout();
            messageBox.ResumeLayout(false);
            messageBox.PerformLayout();
            footerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label lblSubtitle;
        private UI.CardPanel panel2;
        private Label label2;
        private UI.CardPanel messageBox;
        private TextBox textBox1;
        private Label label3;
        private UI.CardPanel fileBox;
        private TextBox txtFile;
        private UI.ModernButton button2;
        private Label lblFileHint;
        private Label label4;
        private UI.CardPanel phoneBox;
        private TextBox textBox2;
        private Panel footerPanel;
        private UI.ModernButton btnsave;
        private UI.ModernButton btnCancel;
        private ComboBox cmbType;
    }
}
