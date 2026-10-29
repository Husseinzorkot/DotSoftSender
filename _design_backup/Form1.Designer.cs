namespace DotSoftSender
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
            panelSidebar = new Panel();
            Main = new Panel();
            PageDescription = new Label();
            pageTitle = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            AppSubtitle = new Label();
            CompanyName = new Label();
            panelmain = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            totalReciptients = new Panel();
            label5 = new Label();
            label2 = new Label();
            MessageSent = new Panel();
            label3 = new Label();
            label6 = new Label();
            PendingMessage = new Panel();
            label7 = new Label();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            description = new Label();
            panelSidebar.SuspendLayout();
            Main.SuspendLayout();
            panelmain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            totalReciptients.SuspendLayout();
            MessageSent.SuspendLayout();
            PendingMessage.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Black;
            panelSidebar.Controls.Add(Main);
            panelSidebar.Controls.Add(button5);
            panelSidebar.Controls.Add(button4);
            panelSidebar.Controls.Add(button3);
            panelSidebar.Controls.Add(button2);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(AppSubtitle);
            panelSidebar.Controls.Add(CompanyName);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(240, 1093);
            panelSidebar.TabIndex = 0;
            panelSidebar.Paint += panelSidebar_Paint;
            // 
            // Main
            // 
            Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Main.BackColor = Color.FromArgb(244, 246, 250);
            Main.Controls.Add(PageDescription);
            Main.Controls.Add(pageTitle);
            Main.Location = new Point(25, 590);
            Main.Name = "Main";
            Main.Size = new Size(0, 454);
            Main.TabIndex = 2;
            // 
            // PageDescription
            // 
            PageDescription.AutoSize = true;
            PageDescription.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageDescription.ForeColor = Color.FromArgb(100, 116, 139);
            PageDescription.Location = new Point(233, 75);
            PageDescription.Name = "PageDescription";
            PageDescription.Size = new Size(514, 32);
            PageDescription.TabIndex = 1;
            PageDescription.Text = "Manage reciptients and promotional messages";
            // 
            // pageTitle
            // 
            pageTitle.AutoSize = true;
            pageTitle.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageTitle.ForeColor = Color.FromArgb(23, 36, 59);
            pageTitle.Location = new Point(340, 10);
            pageTitle.Name = "pageTitle";
            pageTitle.Size = new Size(273, 65);
            pageTitle.TabIndex = 0;
            pageTitle.Text = "Dashboard";
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Font = new Font("Segoe UI", 9.857143F);
            button5.ForeColor = Color.DimGray;
            button5.Location = new Point(10, 335);
            button5.Name = "button5";
            button5.Size = new Size(220, 42);
            button5.TabIndex = 6;
            button5.Text = "Settings";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Segoe UI", 9.857143F);
            button4.ForeColor = Color.DimGray;
            button4.Location = new Point(10, 280);
            button4.Name = "button4";
            button4.Size = new Size(220, 42);
            button4.TabIndex = 5;
            button4.Text = "Messages History";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Segoe UI", 9.857143F);
            button3.ForeColor = Color.DimGray;
            button3.Location = new Point(10, 225);
            button3.Name = "button3";
            button3.Size = new Size(220, 42);
            button3.TabIndex = 4;
            button3.Text = "Recipients";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 9.857143F);
            button2.ForeColor = Color.DimGray;
            button2.Location = new Point(10, 170);
            button2.Name = "button2";
            button2.Size = new Size(220, 42);
            button2.TabIndex = 3;
            button2.Text = "Sender";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 9.857143F);
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(10, 115);
            button1.Name = "button1";
            button1.Size = new Size(220, 42);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // AppSubtitle
            // 
            AppSubtitle.AutoSize = true;
            AppSubtitle.BackColor = Color.Transparent;
            AppSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppSubtitle.ForeColor = Color.LightGray;
            AppSubtitle.Location = new Point(71, 77);
            AppSubtitle.Name = "AppSubtitle";
            AppSubtitle.Size = new Size(77, 30);
            AppSubtitle.TabIndex = 1;
            AppSubtitle.Text = "Sender";
            AppSubtitle.Click += AppSubtitle_Click;
            // 
            // CompanyName
            // 
            CompanyName.AutoSize = true;
            CompanyName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompanyName.ForeColor = Color.White;
            CompanyName.Location = new Point(25, 20);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(180, 57);
            CompanyName.TabIndex = 0;
            CompanyName.Text = "DotSoft";
            CompanyName.Click += CompanyName_Click;
            // 
            // panelmain
            // 
            panelmain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelmain.BackColor = Color.FromArgb(250, 246, 244);
            panelmain.Controls.Add(tableLayoutPanel1);
            panelmain.Location = new Point(240, 0);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(1913, 1118);
            panelmain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Black;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 184F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.374733F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.62527F));
            tableLayoutPanel1.Size = new Size(1913, 1118);
            tableLayoutPanel1.TabIndex = 6;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 414F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 479F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(totalReciptients, 0, 0);
            tableLayoutPanel2.Controls.Add(MessageSent, 1, 0);
            tableLayoutPanel2.Controls.Add(PendingMessage, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 187);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1907, 231);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // totalReciptients
            // 
            totalReciptients.BorderStyle = BorderStyle.FixedSingle;
            totalReciptients.Controls.Add(label5);
            totalReciptients.Controls.Add(label2);
            totalReciptients.Dock = DockStyle.Fill;
            totalReciptients.Location = new Point(3, 3);
            totalReciptients.Name = "totalReciptients";
            totalReciptients.Size = new Size(408, 225);
            totalReciptients.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.NavajoWhite;
            label5.Location = new Point(15, 45);
            label5.Name = "label5";
            label5.Size = new Size(58, 68);
            label5.TabIndex = 1;
            label5.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(203, 32);
            label2.TabIndex = 0;
            label2.Text = "Total Reciptients";
            label2.Click += label2_Click;
            // 
            // MessageSent
            // 
            MessageSent.BackgroundImageLayout = ImageLayout.None;
            MessageSent.BorderStyle = BorderStyle.FixedSingle;
            MessageSent.Controls.Add(label3);
            MessageSent.Controls.Add(label6);
            MessageSent.Dock = DockStyle.Fill;
            MessageSent.Location = new Point(417, 3);
            MessageSent.Name = "MessageSent";
            MessageSent.Size = new Size(473, 225);
            MessageSent.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(15, 15);
            label3.Name = "label3";
            label3.Size = new Size(181, 32);
            label3.TabIndex = 0;
            label3.Text = "Messages Sent";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.NavajoWhite;
            label6.Location = new Point(15, 45);
            label6.Name = "label6";
            label6.Size = new Size(58, 68);
            label6.TabIndex = 1;
            label6.Text = "0";
            // 
            // PendingMessage
            // 
            PendingMessage.BorderStyle = BorderStyle.FixedSingle;
            PendingMessage.Controls.Add(label7);
            PendingMessage.Controls.Add(label4);
            PendingMessage.Dock = DockStyle.Fill;
            PendingMessage.Location = new Point(896, 3);
            PendingMessage.Name = "PendingMessage";
            PendingMessage.Size = new Size(1008, 225);
            PendingMessage.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.NavajoWhite;
            label7.Location = new Point(15, 45);
            label7.Name = "label7";
            label7.Size = new Size(58, 68);
            label7.TabIndex = 1;
            label7.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 15);
            label4.Name = "label4";
            label4.Size = new Size(225, 32);
            label4.TabIndex = 0;
            label4.Text = "Pending Messages";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 564F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(description, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1907, 178);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(558, 100);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Dock = DockStyle.Fill;
            description.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.ForeColor = Color.White;
            description.Location = new Point(3, 100);
            description.Name = "description";
            description.Size = new Size(558, 78);
            description.TabIndex = 1;
            description.Text = "Manage reciptients and promotional message";
            description.TextAlign = ContentAlignment.MiddleCenter;
            description.Click += description_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(2145, 1093);
            Controls.Add(panelmain);
            Controls.Add(panelSidebar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            Main.ResumeLayout(false);
            Main.PerformLayout();
            panelmain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            totalReciptients.ResumeLayout(false);
            totalReciptients.PerformLayout();
            MessageSent.ResumeLayout(false);
            MessageSent.PerformLayout();
            PendingMessage.ResumeLayout(false);
            PendingMessage.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label CompanyName;
        private Label AppSubtitle;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel Main;
        private Label pageTitle;
        private Label PageDescription;
        private Panel panelmain;
        private Label description;
        private Label label1;
        private Panel totalReciptients;
        private Panel PendingMessage;
        private Label label4;
        private Panel MessageSent;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
