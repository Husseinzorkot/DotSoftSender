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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSidebar = new Panel();
            pictureBox1 = new PictureBox();
            lblFooter = new Label();
            button5 = new DotSoftSender.UI.NavButton();
            lblPrefs = new Label();
            button2 = new DotSoftSender.UI.NavButton();
            button1 = new DotSoftSender.UI.NavButton();
            lblMenu = new Label();
            AppSubtitle = new Label();
            CompanyName = new Label();
            panelmain = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblOverview = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            totalReciptients = new DotSoftSender.UI.CardPanel();
            iconRecipients = new DotSoftSender.UI.IconBadge();
            lblCaptionRecipients = new Label();
            label5 = new Label();
            label2 = new Label();
            MessageSent = new DotSoftSender.UI.CardPanel();
            iconSent = new DotSoftSender.UI.IconBadge();
            lblCaptionSent = new Label();
            label6 = new Label();
            label3 = new Label();
            PendingMessage = new DotSoftSender.UI.CardPanel();
            iconPending = new DotSoftSender.UI.IconBadge();
            lblCaptionPending = new Label();
            label7 = new Label();
            label4 = new Label();
            lblQuickActions = new Label();
            quickActionsCard = new DotSoftSender.UI.CardPanel();
            btnOpenSettings = new DotSoftSender.UI.ModernButton();
            btnNewCampaign = new DotSoftSender.UI.ModernButton();
            lblQuickText = new Label();
            lblQuickTitle = new Label();
            headerBar = new Panel();
            lblDate = new Label();
            description = new Label();
            label1 = new Label();
            headerDivider = new Panel();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelmain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            totalReciptients.SuspendLayout();
            MessageSent.SuspendLayout();
            PendingMessage.SuspendLayout();
            quickActionsCard.SuspendLayout();
            headerBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(15, 23, 42);
            panelSidebar.Controls.Add(pictureBox1);
            panelSidebar.Controls.Add(lblFooter);
            panelSidebar.Controls.Add(button5);
            panelSidebar.Controls.Add(lblPrefs);
            panelSidebar.Controls.Add(button2);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(lblMenu);
            panelSidebar.Controls.Add(AppSubtitle);
            panelSidebar.Controls.Add(CompanyName);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(5, 6, 5, 6);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(425, 1600);
            panelSidebar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 88);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblFooter
            // 
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Font = new Font("Segoe UI", 8.25F);
            lblFooter.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooter.Location = new Point(0, 1504);
            lblFooter.Margin = new Padding(5, 0, 5, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Padding = new Padding(41, 0, 0, 0);
            lblFooter.Size = new Size(425, 96);
            lblFooter.TabIndex = 10;
            lblFooter.Text = "© DotSoft  ·  v1.0";
            lblFooter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9.75F);
            button5.Icon = "";
            button5.Location = new Point(21, 553);
            button5.Margin = new Padding(5, 6, 5, 6);
            button5.Name = "button5";
            button5.Size = new Size(384, 88);
            button5.TabIndex = 6;
            button5.Text = "Settings";
            button5.Click += button5_Click;
            // 
            // lblPrefs
            // 
            lblPrefs.AutoSize = true;
            lblPrefs.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPrefs.ForeColor = Color.FromArgb(100, 116, 139);
            lblPrefs.Location = new Point(21, 499);
            lblPrefs.Margin = new Padding(5, 0, 5, 0);
            lblPrefs.Name = "lblPrefs";
            lblPrefs.Size = new Size(136, 25);
            lblPrefs.TabIndex = 9;
            lblPrefs.Text = "PREFERENCES";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F);
            button2.Icon = "";
            button2.Location = new Point(21, 376);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(384, 88);
            button2.TabIndex = 3;
            button2.Text = "Sender";
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Active = true;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.Icon = "";
            button1.Location = new Point(21, 280);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(384, 88);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMenu.ForeColor = Color.FromArgb(100, 116, 139);
            lblMenu.Location = new Point(41, 232);
            lblMenu.Margin = new Padding(5, 0, 5, 0);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(126, 25);
            lblMenu.TabIndex = 8;
            lblMenu.Text = "MAIN MENU";
            // 
            // AppSubtitle
            // 
            AppSubtitle.AutoSize = true;
            AppSubtitle.Font = new Font("Segoe UI", 8.25F);
            AppSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            AppSubtitle.Location = new Point(132, 108);
            AppSubtitle.Margin = new Padding(5, 0, 5, 0);
            AppSubtitle.Name = "AppSubtitle";
            AppSubtitle.Size = new Size(186, 28);
            AppSubtitle.TabIndex = 1;
            AppSubtitle.Text = "Messaging Platform";
            // 
            // CompanyName
            // 
            CompanyName.AutoSize = true;
            CompanyName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            CompanyName.ForeColor = Color.White;
            CompanyName.Location = new Point(127, 52);
            CompanyName.Margin = new Padding(5, 0, 5, 0);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(143, 45);
            CompanyName.TabIndex = 0;
            CompanyName.Text = "DotSoft";
            // 
            // panelmain
            // 
            panelmain.BackColor = Color.FromArgb(248, 250, 252);
            panelmain.Controls.Add(tableLayoutPanel1);
            panelmain.Controls.Add(headerBar);
            panelmain.Dock = DockStyle.Fill;
            panelmain.Location = new Point(425, 0);
            panelmain.Margin = new Padding(5, 6, 5, 6);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(1769, 1600);
            panelmain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblOverview, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblQuickActions, 0, 2);
            tableLayoutPanel1.Controls.Add(quickActionsCard, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 178);
            tableLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(55, 48, 55, 64);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 296F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 280F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1769, 1422);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblOverview
            // 
            lblOverview.Dock = DockStyle.Fill;
            lblOverview.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblOverview.ForeColor = Color.FromArgb(15, 23, 42);
            lblOverview.Location = new Point(55, 48);
            lblOverview.Margin = new Padding(0);
            lblOverview.Name = "lblOverview";
            lblOverview.Size = new Size(1659, 72);
            lblOverview.TabIndex = 0;
            lblOverview.Text = "Overview";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tableLayoutPanel2.Controls.Add(totalReciptients, 0, 0);
            tableLayoutPanel2.Controls.Add(MessageSent, 1, 0);
            tableLayoutPanel2.Controls.Add(PendingMessage, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(55, 120);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1659, 296);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // totalReciptients
            // 
            totalReciptients.BackColor = Color.White;
            totalReciptients.BorderColor = Color.FromArgb(226, 232, 240);
            totalReciptients.Controls.Add(iconRecipients);
            totalReciptients.Controls.Add(lblCaptionRecipients);
            totalReciptients.Controls.Add(label5);
            totalReciptients.Controls.Add(label2);
            totalReciptients.Dock = DockStyle.Fill;
            totalReciptients.Location = new Point(0, 0);
            totalReciptients.Margin = new Padding(0, 0, 21, 0);
            totalReciptients.Name = "totalReciptients";
            totalReciptients.Size = new Size(531, 296);
            totalReciptients.TabIndex = 0;
            totalReciptients.Paint += totalReciptients_Paint;
            // 
            // iconRecipients
            // 
            iconRecipients.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconRecipients.BadgeColor = Color.FromArgb(219, 234, 254);
            iconRecipients.Font = new Font("Segoe MDL2 Assets", 13F);
            iconRecipients.ForeColor = Color.FromArgb(37, 99, 235);
            iconRecipients.Location = new Point(429, 40);
            iconRecipients.Margin = new Padding(5, 6, 5, 6);
            iconRecipients.Name = "iconRecipients";
            iconRecipients.Size = new Size(69, 80);
            iconRecipients.TabIndex = 3;
            iconRecipients.Text = "";
            // 
            // lblCaptionRecipients
            // 
            lblCaptionRecipients.AutoSize = true;
            lblCaptionRecipients.Font = new Font("Segoe UI", 8.25F);
            lblCaptionRecipients.ForeColor = Color.FromArgb(100, 116, 139);
            lblCaptionRecipients.Location = new Point(38, 216);
            lblCaptionRecipients.Margin = new Padding(5, 0, 5, 0);
            lblCaptionRecipients.Name = "lblCaptionRecipients";
            lblCaptionRecipients.Size = new Size(247, 28);
            lblCaptionRecipients.TabIndex = 2;
            lblCaptionRecipients.Text = "Doctors in your contact list";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(15, 23, 42);
            label5.Location = new Point(27, 108);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 74);
            label5.TabIndex = 1;
            label5.Text = "0";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(100, 116, 139);
            label2.Location = new Point(38, 48);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(167, 30);
            label2.TabIndex = 0;
            label2.Text = "Total Recipients";
            // 
            // MessageSent
            // 
            MessageSent.BackColor = Color.White;
            MessageSent.BorderColor = Color.FromArgb(226, 232, 240);
            MessageSent.Controls.Add(iconSent);
            MessageSent.Controls.Add(lblCaptionSent);
            MessageSent.Controls.Add(label6);
            MessageSent.Controls.Add(label3);
            MessageSent.Dock = DockStyle.Fill;
            MessageSent.Location = new Point(562, 0);
            MessageSent.Margin = new Padding(10, 0, 10, 0);
            MessageSent.Name = "MessageSent";
            MessageSent.Size = new Size(532, 296);
            MessageSent.TabIndex = 1;
            // 
            // iconSent
            // 
            iconSent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconSent.BadgeColor = Color.FromArgb(220, 252, 231);
            iconSent.Font = new Font("Segoe MDL2 Assets", 13F);
            iconSent.ForeColor = Color.FromArgb(22, 163, 74);
            iconSent.Location = new Point(430, 40);
            iconSent.Margin = new Padding(5, 6, 5, 6);
            iconSent.Name = "iconSent";
            iconSent.Size = new Size(69, 80);
            iconSent.TabIndex = 3;
            iconSent.Text = "";
            // 
            // lblCaptionSent
            // 
            lblCaptionSent.AutoSize = true;
            lblCaptionSent.Font = new Font("Segoe UI", 8.25F);
            lblCaptionSent.ForeColor = Color.FromArgb(100, 116, 139);
            lblCaptionSent.Location = new Point(38, 216);
            lblCaptionSent.Margin = new Padding(5, 0, 5, 0);
            lblCaptionSent.Name = "lblCaptionSent";
            lblCaptionSent.Size = new Size(200, 28);
            lblCaptionSent.TabIndex = 2;
            lblCaptionSent.Text = "Delivered successfully";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(15, 23, 42);
            label6.Location = new Point(27, 108);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 74);
            label6.TabIndex = 1;
            label6.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(100, 116, 139);
            label3.Location = new Point(38, 48);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 30);
            label3.TabIndex = 0;
            label3.Text = "Messages Sent";
            // 
            // PendingMessage
            // 
            PendingMessage.BackColor = Color.White;
            PendingMessage.BorderColor = Color.FromArgb(226, 232, 240);
            PendingMessage.Controls.Add(iconPending);
            PendingMessage.Controls.Add(lblCaptionPending);
            PendingMessage.Controls.Add(label7);
            PendingMessage.Controls.Add(label4);
            PendingMessage.Dock = DockStyle.Fill;
            PendingMessage.Location = new Point(1125, 0);
            PendingMessage.Margin = new Padding(21, 0, 0, 0);
            PendingMessage.Name = "PendingMessage";
            PendingMessage.Size = new Size(534, 296);
            PendingMessage.TabIndex = 2;
            // 
            // iconPending
            // 
            iconPending.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPending.BadgeColor = Color.FromArgb(254, 243, 199);
            iconPending.Font = new Font("Segoe MDL2 Assets", 13F);
            iconPending.ForeColor = Color.FromArgb(217, 119, 6);
            iconPending.Location = new Point(431, 40);
            iconPending.Margin = new Padding(5, 6, 5, 6);
            iconPending.Name = "iconPending";
            iconPending.Size = new Size(69, 80);
            iconPending.TabIndex = 3;
            iconPending.Text = "";
            // 
            // lblCaptionPending
            // 
            lblCaptionPending.AutoSize = true;
            lblCaptionPending.Font = new Font("Segoe UI", 8.25F);
            lblCaptionPending.ForeColor = Color.FromArgb(100, 116, 139);
            lblCaptionPending.Location = new Point(38, 216);
            lblCaptionPending.Margin = new Padding(5, 0, 5, 0);
            lblCaptionPending.Name = "lblCaptionPending";
            lblCaptionPending.Size = new Size(193, 28);
            lblCaptionPending.TabIndex = 2;
            lblCaptionPending.Text = "Waiting in the queue";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(15, 23, 42);
            label7.Location = new Point(27, 108);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 74);
            label7.TabIndex = 1;
            label7.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(100, 116, 139);
            label4.Location = new Point(38, 48);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(193, 30);
            label4.TabIndex = 0;
            label4.Text = "Pending Messages";
            // 
            // lblQuickActions
            // 
            lblQuickActions.Dock = DockStyle.Fill;
            lblQuickActions.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblQuickActions.ForeColor = Color.FromArgb(15, 23, 42);
            lblQuickActions.Location = new Point(55, 416);
            lblQuickActions.Margin = new Padding(0);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Padding = new Padding(0, 0, 0, 20);
            lblQuickActions.Size = new Size(1659, 104);
            lblQuickActions.TabIndex = 2;
            lblQuickActions.Text = "Quick actions";
            lblQuickActions.TextAlign = ContentAlignment.BottomLeft;
            // 
            // quickActionsCard
            // 
            quickActionsCard.BackColor = Color.White;
            quickActionsCard.BorderColor = Color.FromArgb(226, 232, 240);
            quickActionsCard.Controls.Add(btnOpenSettings);
            quickActionsCard.Controls.Add(btnNewCampaign);
            quickActionsCard.Controls.Add(lblQuickText);
            quickActionsCard.Controls.Add(lblQuickTitle);
            quickActionsCard.Dock = DockStyle.Fill;
            quickActionsCard.Location = new Point(55, 520);
            quickActionsCard.Margin = new Padding(0);
            quickActionsCard.Name = "quickActionsCard";
            quickActionsCard.Size = new Size(1659, 280);
            quickActionsCard.TabIndex = 3;
            // 
            // btnOpenSettings
            // 
            btnOpenSettings.FlatStyle = FlatStyle.Flat;
            btnOpenSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOpenSettings.Icon = "";
            btnOpenSettings.Location = new Point(350, 160);
            btnOpenSettings.Margin = new Padding(5, 6, 5, 6);
            btnOpenSettings.Name = "btnOpenSettings";
            btnOpenSettings.Size = new Size(295, 80);
            btnOpenSettings.TabIndex = 3;
            btnOpenSettings.Text = "Message settings";
            btnOpenSettings.Variant = UI.ButtonVariant.Secondary;
            btnOpenSettings.Click += button5_Click;
            // 
            // btnNewCampaign
            // 
            btnNewCampaign.FlatStyle = FlatStyle.Flat;
            btnNewCampaign.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNewCampaign.Icon = "";
            btnNewCampaign.Location = new Point(41, 160);
            btnNewCampaign.Margin = new Padding(5, 6, 5, 6);
            btnNewCampaign.Name = "btnNewCampaign";
            btnNewCampaign.Size = new Size(288, 80);
            btnNewCampaign.TabIndex = 2;
            btnNewCampaign.Text = "New campaign";
            btnNewCampaign.Click += button2_Click;
            // 
            // lblQuickText
            // 
            lblQuickText.AutoSize = true;
            lblQuickText.Font = new Font("Segoe UI", 9F);
            lblQuickText.ForeColor = Color.FromArgb(100, 116, 139);
            lblQuickText.Location = new Point(43, 96);
            lblQuickText.Margin = new Padding(5, 0, 5, 0);
            lblQuickText.Name = "lblQuickText";
            lblQuickText.Size = new Size(711, 30);
            lblQuickText.TabIndex = 1;
            lblQuickText.Text = "Pick your recipients, review the queue and send your promotional message.";
            // 
            // lblQuickTitle
            // 
            lblQuickTitle.AutoSize = true;
            lblQuickTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblQuickTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblQuickTitle.Location = new Point(41, 44);
            lblQuickTitle.Margin = new Padding(5, 0, 5, 0);
            lblQuickTitle.Name = "lblQuickTitle";
            lblQuickTitle.Size = new Size(213, 35);
            lblQuickTitle.TabIndex = 0;
            lblQuickTitle.Text = "Start a campaign";
            // 
            // headerBar
            // 
            headerBar.BackColor = Color.White;
            headerBar.Controls.Add(lblDate);
            headerBar.Controls.Add(description);
            headerBar.Controls.Add(label1);
            headerBar.Controls.Add(headerDivider);
            headerBar.Dock = DockStyle.Top;
            headerBar.Location = new Point(0, 0);
            headerBar.Margin = new Padding(5, 6, 5, 6);
            headerBar.Name = "headerBar";
            headerBar.Size = new Size(1769, 178);
            headerBar.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.Font = new Font("Segoe UI", 9F);
            lblDate.ForeColor = Color.FromArgb(100, 116, 139);
            lblDate.Location = new Point(1200, 64);
            lblDate.Margin = new Padding(5, 0, 5, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(514, 48);
            lblDate.TabIndex = 2;
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Font = new Font("Segoe UI", 9F);
            description.ForeColor = Color.FromArgb(100, 116, 139);
            description.Location = new Point(58, 108);
            description.Margin = new Padding(5, 0, 5, 0);
            description.Name = "description";
            description.Size = new Size(440, 30);
            description.TabIndex = 1;
            description.Text = "Manage recipients and promotional messages";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(51, 36);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 54);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // headerDivider
            // 
            headerDivider.BackColor = Color.FromArgb(226, 232, 240);
            headerDivider.Dock = DockStyle.Bottom;
            headerDivider.Location = new Point(0, 176);
            headerDivider.Margin = new Padding(5, 6, 5, 6);
            headerDivider.Name = "headerDivider";
            headerDivider.Size = new Size(1769, 2);
            headerDivider.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_10_19_at_1_43_50_PM;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(2194, 1600);
            Controls.Add(panelmain);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(1869, 1336);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DotSoft Sender";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelmain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            totalReciptients.ResumeLayout(false);
            totalReciptients.PerformLayout();
            MessageSent.ResumeLayout(false);
            MessageSent.PerformLayout();
            PendingMessage.ResumeLayout(false);
            PendingMessage.PerformLayout();
            quickActionsCard.ResumeLayout(false);
            quickActionsCard.PerformLayout();
            headerBar.ResumeLayout(false);
            headerBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label CompanyName;
        private Label AppSubtitle;
        private Label lblMenu;
        private Label lblPrefs;
        private Label lblFooter;
        private UI.NavButton button5;
        private UI.NavButton button1;
        private Panel panelmain;
        private Panel headerBar;
        private Panel headerDivider;
        private Label label1;
        private Label description;
        private Label lblDate;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblOverview;
        private UI.CardPanel totalReciptients;
        private UI.IconBadge iconRecipients;
        private Label lblCaptionRecipients;
        private Label label5;
        private Label label2;
        private UI.CardPanel MessageSent;
        private UI.IconBadge iconSent;
        private Label lblCaptionSent;
        private Label label6;
        private Label label3;
        private UI.CardPanel PendingMessage;
        private UI.IconBadge iconPending;
        private Label lblCaptionPending;
        private Label label7;
        private Label label4;
        private Label lblQuickActions;
        private UI.CardPanel quickActionsCard;
        private Label lblQuickTitle;
        private Label lblQuickText;
        private UI.ModernButton btnNewCampaign;
        private UI.ModernButton btnOpenSettings;
        private PictureBox pictureBox1;
        private UI.NavButton button2;
    }
}
