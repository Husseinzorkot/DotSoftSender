namespace DotSoftSender.Forms
{
    partial class frmSender
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
            components = new System.ComponentModel.Container();
            tblSender = new TableLayoutPanel();
            headerPanel = new Panel();
            lblSelected = new Label();
            btntest = new DotSoftSender.UI.ModernButton();
            btnSend = new DotSoftSender.UI.ModernButton();
            label1 = new Label();
            title = new Label();
            recipientsCard = new DotSoftSender.UI.CardPanel();
            dataGridView1 = new DataGridView();
            colSelect = new DataGridViewButtonColumn();
            codeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDoctorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            drNameEnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobileNumbersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            drNameArDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            riteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kazaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registerNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registrationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumbersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            specDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            printedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pcDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cleanDatumBindingSource = new BindingSource(components);
            recipientsHeader = new Panel();
            lblRecipientsHint = new Label();
            lblRecipients = new Label();
            queueCard = new DotSoftSender.UI.CardPanel();
            dataGridView2 = new DataGridView();
            tmessageBindingSource = new BindingSource(components);
            queueHeader = new Panel();
            modernButton1 = new DotSoftSender.UI.ModernButton();
            checkBox1 = new CheckBox();
            lblQueueHint = new Label();
            lblQueue = new Label();
            idDrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DoctorId = new DataGridViewTextBoxColumn();
            drNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isSentDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isErrorDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            fromDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            errorMsgDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            requestNbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filePathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            msgTypeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            msgTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tblSender.SuspendLayout();
            headerPanel.SuspendLayout();
            recipientsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cleanDatumBindingSource).BeginInit();
            recipientsHeader.SuspendLayout();
            queueCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tmessageBindingSource).BeginInit();
            queueHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tblSender
            // 
            tblSender.ColumnCount = 1;
            tblSender.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSender.Controls.Add(headerPanel, 0, 0);
            tblSender.Controls.Add(recipientsCard, 0, 1);
            tblSender.Controls.Add(queueCard, 0, 2);
            tblSender.Dock = DockStyle.Fill;
            tblSender.Location = new Point(41, 48);
            tblSender.Margin = new Padding(5, 6, 5, 6);
            tblSender.Name = "tblSender";
            tblSender.RowCount = 3;
            tblSender.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tblSender.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tblSender.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tblSender.Size = new Size(2112, 1504);
            tblSender.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(lblSelected);
            headerPanel.Controls.Add(btntest);
            headerPanel.Controls.Add(btnSend);
            headerPanel.Controls.Add(label1);
            headerPanel.Controls.Add(title);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(2112, 160);
            headerPanel.TabIndex = 0;
            // 
            // lblSelected
            // 
            lblSelected.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSelected.Font = new Font("Segoe UI", 9F);
            lblSelected.ForeColor = Color.FromArgb(100, 116, 139);
            lblSelected.Location = new Point(1303, 32);
            lblSelected.Margin = new Padding(5, 0, 5, 0);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(343, 80);
            lblSelected.TabIndex = 4;
            lblSelected.Text = "0 recipients selected";
            lblSelected.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btntest
            // 
            btntest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btntest.FlatStyle = FlatStyle.Flat;
            btntest.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btntest.Icon = "";
            btntest.Location = new Point(1673, 32);
            btntest.Margin = new Padding(5, 6, 5, 6);
            btntest.Name = "btntest";
            btntest.Size = new Size(206, 80);
            btntest.TabIndex = 3;
            btntest.Text = "Refresh";
            btntest.Variant = UI.ButtonVariant.Secondary;
            btntest.Click += btntest_Click;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSend.Icon = "";
            btnSend.Location = new Point(1899, 32);
            btnSend.Margin = new Padding(5, 6, 5, 6);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(213, 80);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.FromArgb(100, 116, 139);
            label1.Location = new Point(3, 88);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(521, 30);
            label1.TabIndex = 1;
            label1.Text = "Select recipients and queue your promotional message";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(15, 23, 42);
            title.Location = new Point(-3, 20);
            title.Margin = new Padding(5, 0, 5, 0);
            title.Name = "title";
            title.Size = new Size(154, 54);
            title.TabIndex = 0;
            title.Text = "Sender";
            // 
            // recipientsCard
            // 
            recipientsCard.BackColor = Color.White;
            recipientsCard.BorderColor = Color.FromArgb(226, 232, 240);
            recipientsCard.Controls.Add(dataGridView1);
            recipientsCard.Controls.Add(recipientsHeader);
            recipientsCard.Dock = DockStyle.Fill;
            recipientsCard.Location = new Point(0, 160);
            recipientsCard.Margin = new Padding(0, 0, 0, 32);
            recipientsCard.Name = "recipientsCard";
            recipientsCard.Padding = new Padding(27, 16, 27, 32);
            recipientsCard.Size = new Size(2112, 707);
            recipientsCard.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colSelect, codeDataGridViewTextBoxColumn, idDoctorDataGridViewTextBoxColumn, drNameEnDataGridViewTextBoxColumn, mobileNumbersDataGridViewTextBoxColumn, drNameArDataGridViewTextBoxColumn, dobDataGridViewTextBoxColumn, riteDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, kazaDataGridViewTextBoxColumn, registerNumberDataGridViewTextBoxColumn, registrationDateDataGridViewTextBoxColumn, phoneNumbersDataGridViewTextBoxColumn, specDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, printedDataGridViewTextBoxColumn, pcDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cleanDatumBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(27, 128);
            dataGridView1.Margin = new Padding(5, 6, 5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(2058, 547);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // colSelect
            // 
            colSelect.FlatStyle = FlatStyle.Flat;
            colSelect.HeaderText = "";
            colSelect.MinimumWidth = 9;
            colSelect.Name = "colSelect";
            colSelect.ReadOnly = true;
            colSelect.Text = "Select";
            colSelect.UseColumnTextForButtonValue = true;
            colSelect.Width = 96;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.MinimumWidth = 9;
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            codeDataGridViewTextBoxColumn.ReadOnly = true;
            codeDataGridViewTextBoxColumn.Width = 110;
            // 
            // idDoctorDataGridViewTextBoxColumn
            // 
            idDoctorDataGridViewTextBoxColumn.DataPropertyName = "IdDoctor";
            idDoctorDataGridViewTextBoxColumn.HeaderText = "Doctor ID";
            idDoctorDataGridViewTextBoxColumn.MinimumWidth = 9;
            idDoctorDataGridViewTextBoxColumn.Name = "idDoctorDataGridViewTextBoxColumn";
            idDoctorDataGridViewTextBoxColumn.ReadOnly = true;
            idDoctorDataGridViewTextBoxColumn.Width = 175;
            // 
            // drNameEnDataGridViewTextBoxColumn
            // 
            drNameEnDataGridViewTextBoxColumn.DataPropertyName = "DrNameEn";
            drNameEnDataGridViewTextBoxColumn.HeaderText = "Name (EN)";
            drNameEnDataGridViewTextBoxColumn.MinimumWidth = 9;
            drNameEnDataGridViewTextBoxColumn.Name = "drNameEnDataGridViewTextBoxColumn";
            drNameEnDataGridViewTextBoxColumn.ReadOnly = true;
            drNameEnDataGridViewTextBoxColumn.Width = 200;
            // 
            // mobileNumbersDataGridViewTextBoxColumn
            // 
            mobileNumbersDataGridViewTextBoxColumn.DataPropertyName = "MobileNumbers";
            mobileNumbersDataGridViewTextBoxColumn.HeaderText = "Mobile";
            mobileNumbersDataGridViewTextBoxColumn.MinimumWidth = 9;
            mobileNumbersDataGridViewTextBoxColumn.Name = "mobileNumbersDataGridViewTextBoxColumn";
            mobileNumbersDataGridViewTextBoxColumn.ReadOnly = true;
            mobileNumbersDataGridViewTextBoxColumn.Width = 140;
            // 
            // drNameArDataGridViewTextBoxColumn
            // 
            drNameArDataGridViewTextBoxColumn.DataPropertyName = "DrNameAr";
            drNameArDataGridViewTextBoxColumn.HeaderText = "Name (AR)";
            drNameArDataGridViewTextBoxColumn.MinimumWidth = 9;
            drNameArDataGridViewTextBoxColumn.Name = "drNameArDataGridViewTextBoxColumn";
            drNameArDataGridViewTextBoxColumn.ReadOnly = true;
            drNameArDataGridViewTextBoxColumn.Visible = false;
            drNameArDataGridViewTextBoxColumn.Width = 200;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            dobDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            dobDataGridViewTextBoxColumn.MinimumWidth = 9;
            dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            dobDataGridViewTextBoxColumn.ReadOnly = true;
            dobDataGridViewTextBoxColumn.Visible = false;
            dobDataGridViewTextBoxColumn.Width = 120;
            // 
            // riteDataGridViewTextBoxColumn
            // 
            riteDataGridViewTextBoxColumn.DataPropertyName = "Rite";
            riteDataGridViewTextBoxColumn.HeaderText = "Rite";
            riteDataGridViewTextBoxColumn.MinimumWidth = 9;
            riteDataGridViewTextBoxColumn.Name = "riteDataGridViewTextBoxColumn";
            riteDataGridViewTextBoxColumn.ReadOnly = true;
            riteDataGridViewTextBoxColumn.Visible = false;
            riteDataGridViewTextBoxColumn.Width = 110;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.MinimumWidth = 9;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Width = 175;
            // 
            // kazaDataGridViewTextBoxColumn
            // 
            kazaDataGridViewTextBoxColumn.DataPropertyName = "Kaza";
            kazaDataGridViewTextBoxColumn.HeaderText = "District";
            kazaDataGridViewTextBoxColumn.MinimumWidth = 9;
            kazaDataGridViewTextBoxColumn.Name = "kazaDataGridViewTextBoxColumn";
            kazaDataGridViewTextBoxColumn.ReadOnly = true;
            kazaDataGridViewTextBoxColumn.Visible = false;
            kazaDataGridViewTextBoxColumn.Width = 130;
            // 
            // registerNumberDataGridViewTextBoxColumn
            // 
            registerNumberDataGridViewTextBoxColumn.DataPropertyName = "RegisterNumber";
            registerNumberDataGridViewTextBoxColumn.HeaderText = "Register No.";
            registerNumberDataGridViewTextBoxColumn.MinimumWidth = 9;
            registerNumberDataGridViewTextBoxColumn.Name = "registerNumberDataGridViewTextBoxColumn";
            registerNumberDataGridViewTextBoxColumn.ReadOnly = true;
            registerNumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // registrationDateDataGridViewTextBoxColumn
            // 
            registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
            registrationDateDataGridViewTextBoxColumn.HeaderText = "Registered On";
            registrationDateDataGridViewTextBoxColumn.MinimumWidth = 9;
            registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
            registrationDateDataGridViewTextBoxColumn.Visible = false;
            registrationDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // phoneNumbersDataGridViewTextBoxColumn
            // 
            phoneNumbersDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumbers";
            phoneNumbersDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneNumbersDataGridViewTextBoxColumn.MinimumWidth = 9;
            phoneNumbersDataGridViewTextBoxColumn.Name = "phoneNumbersDataGridViewTextBoxColumn";
            phoneNumbersDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumbersDataGridViewTextBoxColumn.Visible = false;
            phoneNumbersDataGridViewTextBoxColumn.Width = 140;
            // 
            // specDataGridViewTextBoxColumn
            // 
            specDataGridViewTextBoxColumn.DataPropertyName = "Spec";
            specDataGridViewTextBoxColumn.HeaderText = "Specialty";
            specDataGridViewTextBoxColumn.MinimumWidth = 9;
            specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            specDataGridViewTextBoxColumn.ReadOnly = true;
            specDataGridViewTextBoxColumn.Width = 160;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 9;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Visible = false;
            emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // printedDataGridViewTextBoxColumn
            // 
            printedDataGridViewTextBoxColumn.DataPropertyName = "Printed";
            printedDataGridViewTextBoxColumn.HeaderText = "Printed";
            printedDataGridViewTextBoxColumn.MinimumWidth = 9;
            printedDataGridViewTextBoxColumn.Name = "printedDataGridViewTextBoxColumn";
            printedDataGridViewTextBoxColumn.ReadOnly = true;
            printedDataGridViewTextBoxColumn.Visible = false;
            printedDataGridViewTextBoxColumn.Width = 90;
            // 
            // pcDataGridViewTextBoxColumn
            // 
            pcDataGridViewTextBoxColumn.DataPropertyName = "Pc";
            pcDataGridViewTextBoxColumn.HeaderText = "PC";
            pcDataGridViewTextBoxColumn.MinimumWidth = 9;
            pcDataGridViewTextBoxColumn.Name = "pcDataGridViewTextBoxColumn";
            pcDataGridViewTextBoxColumn.ReadOnly = true;
            pcDataGridViewTextBoxColumn.Visible = false;
            pcDataGridViewTextBoxColumn.Width = 80;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 9;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            typeDataGridViewTextBoxColumn.Visible = false;
            typeDataGridViewTextBoxColumn.Width = 175;
            // 
            // cleanDatumBindingSource
            // 
            cleanDatumBindingSource.DataSource = typeof(Data.CleanDatum);
            // 
            // recipientsHeader
            // 
            recipientsHeader.Controls.Add(lblRecipientsHint);
            recipientsHeader.Controls.Add(lblRecipients);
            recipientsHeader.Dock = DockStyle.Top;
            recipientsHeader.Location = new Point(27, 16);
            recipientsHeader.Margin = new Padding(5, 6, 5, 6);
            recipientsHeader.Name = "recipientsHeader";
            recipientsHeader.Size = new Size(2058, 112);
            recipientsHeader.TabIndex = 0;
            // 
            // lblRecipientsHint
            // 
            lblRecipientsHint.AutoSize = true;
            lblRecipientsHint.Font = new Font("Segoe UI", 8.25F);
            lblRecipientsHint.ForeColor = Color.FromArgb(100, 116, 139);
            lblRecipientsHint.Location = new Point(7, 64);
            lblRecipientsHint.Margin = new Padding(5, 0, 5, 0);
            lblRecipientsHint.Name = "lblRecipientsHint";
            lblRecipientsHint.Size = new Size(364, 28);
            lblRecipientsHint.TabIndex = 1;
            lblRecipientsHint.Text = "Click Select to add or remove a recipient";
            // 
            // lblRecipients
            // 
            lblRecipients.AutoSize = true;
            lblRecipients.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblRecipients.ForeColor = Color.FromArgb(15, 23, 42);
            lblRecipients.Location = new Point(3, 20);
            lblRecipients.Margin = new Padding(5, 0, 5, 0);
            lblRecipients.Name = "lblRecipients";
            lblRecipients.Size = new Size(136, 35);
            lblRecipients.TabIndex = 0;
            lblRecipients.Text = "Recipients";
            // 
            // queueCard
            // 
            queueCard.BackColor = Color.White;
            queueCard.BorderColor = Color.FromArgb(226, 232, 240);
            queueCard.Controls.Add(dataGridView2);
            queueCard.Controls.Add(queueHeader);
            queueCard.Dock = DockStyle.Fill;
            queueCard.Location = new Point(0, 899);
            queueCard.Margin = new Padding(0);
            queueCard.Name = "queueCard";
            queueCard.Padding = new Padding(27, 16, 27, 32);
            queueCard.Size = new Size(2112, 605);
            queueCard.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeight = 40;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDrDataGridViewTextBoxColumn, DoctorId, drNameDataGridViewTextBoxColumn, isSentDataGridViewCheckBoxColumn, isErrorDataGridViewCheckBoxColumn, fromDataGridViewTextBoxColumn, toDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, errorMsgDataGridViewTextBoxColumn, requestNbDataGridViewTextBoxColumn, filePathDataGridViewTextBoxColumn, msgTypeIdDataGridViewTextBoxColumn, msgTypeDataGridViewTextBoxColumn });
            dataGridView2.DataSource = tmessageBindingSource;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(27, 128);
            dataGridView2.Margin = new Padding(5, 6, 5, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.Size = new Size(2058, 445);
            dataGridView2.TabIndex = 1;
            // 
            // tmessageBindingSource
            // 
            tmessageBindingSource.DataSource = typeof(Data.Tmessage);
            // 
            // queueHeader
            // 
            queueHeader.Controls.Add(modernButton1);
            queueHeader.Controls.Add(checkBox1);
            queueHeader.Controls.Add(lblQueueHint);
            queueHeader.Controls.Add(lblQueue);
            queueHeader.Dock = DockStyle.Top;
            queueHeader.Location = new Point(27, 16);
            queueHeader.Margin = new Padding(5, 6, 5, 6);
            queueHeader.Name = "queueHeader";
            queueHeader.Size = new Size(2058, 112);
            queueHeader.TabIndex = 0;
            // 
            // modernButton1
            // 
            modernButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            modernButton1.FlatStyle = FlatStyle.Flat;
            modernButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            modernButton1.Icon = "";
            modernButton1.Location = new Point(1829, 12);
            modernButton1.Margin = new Padding(5, 6, 5, 6);
            modernButton1.Name = "modernButton1";
            modernButton1.Size = new Size(213, 80);
            modernButton1.TabIndex = 3;
            modernButton1.Text = "ReSend";
            modernButton1.Click += modernButton1_Click;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.Popup;
            checkBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkBox1.Location = new Point(1701, 32);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 40);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Not Sent";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblQueueHint
            // 
            lblQueueHint.AutoSize = true;
            lblQueueHint.Font = new Font("Segoe UI", 8.25F);
            lblQueueHint.ForeColor = Color.FromArgb(100, 116, 139);
            lblQueueHint.Location = new Point(7, 64);
            lblQueueHint.Margin = new Padding(5, 0, 5, 0);
            lblQueueHint.Name = "lblQueueHint";
            lblQueueHint.Size = new Size(364, 28);
            lblQueueHint.TabIndex = 1;
            lblQueueHint.Text = "Messages saved and their delivery status";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblQueue.ForeColor = Color.FromArgb(15, 23, 42);
            lblQueue.Location = new Point(3, 20);
            lblQueue.Margin = new Padding(5, 0, 5, 0);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(201, 35);
            lblQueue.TabIndex = 0;
            lblQueue.Text = "Message Queue";
            // 
            // idDrDataGridViewTextBoxColumn
            // 
            idDrDataGridViewTextBoxColumn.DataPropertyName = "IdDr";
            idDrDataGridViewTextBoxColumn.HeaderText = "ID";
            idDrDataGridViewTextBoxColumn.MinimumWidth = 9;
            idDrDataGridViewTextBoxColumn.Name = "idDrDataGridViewTextBoxColumn";
            idDrDataGridViewTextBoxColumn.ReadOnly = true;
            idDrDataGridViewTextBoxColumn.Visible = false;
            idDrDataGridViewTextBoxColumn.Width = 80;
            // 
            // DoctorId
            // 
            DoctorId.DataPropertyName = "DoctorId";
            DoctorId.HeaderText = "DoctorId";
            DoctorId.MinimumWidth = 9;
            DoctorId.Name = "DoctorId";
            DoctorId.ReadOnly = true;
            DoctorId.Width = 175;
            // 
            // drNameDataGridViewTextBoxColumn
            // 
            drNameDataGridViewTextBoxColumn.DataPropertyName = "DrName";
            drNameDataGridViewTextBoxColumn.HeaderText = "Recipient";
            drNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            drNameDataGridViewTextBoxColumn.Name = "drNameDataGridViewTextBoxColumn";
            drNameDataGridViewTextBoxColumn.ReadOnly = true;
            drNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // isSentDataGridViewCheckBoxColumn
            // 
            isSentDataGridViewCheckBoxColumn.DataPropertyName = "IsSent";
            isSentDataGridViewCheckBoxColumn.HeaderText = "Sent";
            isSentDataGridViewCheckBoxColumn.MinimumWidth = 9;
            isSentDataGridViewCheckBoxColumn.Name = "isSentDataGridViewCheckBoxColumn";
            isSentDataGridViewCheckBoxColumn.ReadOnly = true;
            isSentDataGridViewCheckBoxColumn.Width = 80;
            // 
            // isErrorDataGridViewCheckBoxColumn
            // 
            isErrorDataGridViewCheckBoxColumn.DataPropertyName = "IsError";
            isErrorDataGridViewCheckBoxColumn.HeaderText = "Error";
            isErrorDataGridViewCheckBoxColumn.MinimumWidth = 9;
            isErrorDataGridViewCheckBoxColumn.Name = "isErrorDataGridViewCheckBoxColumn";
            isErrorDataGridViewCheckBoxColumn.ReadOnly = true;
            isErrorDataGridViewCheckBoxColumn.Width = 80;
            // 
            // fromDataGridViewTextBoxColumn
            // 
            fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            fromDataGridViewTextBoxColumn.HeaderText = "From";
            fromDataGridViewTextBoxColumn.MinimumWidth = 9;
            fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            fromDataGridViewTextBoxColumn.ReadOnly = true;
            fromDataGridViewTextBoxColumn.Width = 140;
            // 
            // toDataGridViewTextBoxColumn
            // 
            toDataGridViewTextBoxColumn.DataPropertyName = "To";
            toDataGridViewTextBoxColumn.HeaderText = "To";
            toDataGridViewTextBoxColumn.MinimumWidth = 9;
            toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            toDataGridViewTextBoxColumn.ReadOnly = true;
            toDataGridViewTextBoxColumn.Width = 140;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 9;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Width = 120;
            // 
            // errorMsgDataGridViewTextBoxColumn
            // 
            errorMsgDataGridViewTextBoxColumn.DataPropertyName = "ErrorMsg";
            errorMsgDataGridViewTextBoxColumn.HeaderText = "Error Message";
            errorMsgDataGridViewTextBoxColumn.MinimumWidth = 9;
            errorMsgDataGridViewTextBoxColumn.Name = "errorMsgDataGridViewTextBoxColumn";
            errorMsgDataGridViewTextBoxColumn.ReadOnly = true;
            errorMsgDataGridViewTextBoxColumn.Visible = false;
            errorMsgDataGridViewTextBoxColumn.Width = 220;
            // 
            // requestNbDataGridViewTextBoxColumn
            // 
            requestNbDataGridViewTextBoxColumn.DataPropertyName = "RequestNb";
            requestNbDataGridViewTextBoxColumn.HeaderText = "Request No.";
            requestNbDataGridViewTextBoxColumn.MinimumWidth = 9;
            requestNbDataGridViewTextBoxColumn.Name = "requestNbDataGridViewTextBoxColumn";
            requestNbDataGridViewTextBoxColumn.ReadOnly = true;
            requestNbDataGridViewTextBoxColumn.Visible = false;
            requestNbDataGridViewTextBoxColumn.Width = 130;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            filePathDataGridViewTextBoxColumn.HeaderText = "Attachment";
            filePathDataGridViewTextBoxColumn.MinimumWidth = 9;
            filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            filePathDataGridViewTextBoxColumn.ReadOnly = true;
            filePathDataGridViewTextBoxColumn.Visible = false;
            filePathDataGridViewTextBoxColumn.Width = 240;
            // 
            // msgTypeIdDataGridViewTextBoxColumn
            // 
            msgTypeIdDataGridViewTextBoxColumn.DataPropertyName = "MsgTypeId";
            msgTypeIdDataGridViewTextBoxColumn.HeaderText = "Type ID";
            msgTypeIdDataGridViewTextBoxColumn.MinimumWidth = 9;
            msgTypeIdDataGridViewTextBoxColumn.Name = "msgTypeIdDataGridViewTextBoxColumn";
            msgTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            msgTypeIdDataGridViewTextBoxColumn.Width = 90;
            // 
            // msgTypeDataGridViewTextBoxColumn
            // 
            msgTypeDataGridViewTextBoxColumn.DataPropertyName = "MsgType";
            msgTypeDataGridViewTextBoxColumn.HeaderText = "Message Type";
            msgTypeDataGridViewTextBoxColumn.MinimumWidth = 9;
            msgTypeDataGridViewTextBoxColumn.Name = "msgTypeDataGridViewTextBoxColumn";
            msgTypeDataGridViewTextBoxColumn.ReadOnly = true;
            msgTypeDataGridViewTextBoxColumn.Visible = false;
            msgTypeDataGridViewTextBoxColumn.Width = 130;
            // 
            // frmSender
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(2194, 1600);
            Controls.Add(tblSender);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(1629, 1216);
            Name = "frmSender";
            Padding = new Padding(41, 48, 41, 48);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sender — DotSoft";
            Load += frmSender_Load;
            tblSender.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            recipientsCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cleanDatumBindingSource).EndInit();
            recipientsHeader.ResumeLayout(false);
            recipientsHeader.PerformLayout();
            queueCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tmessageBindingSource).EndInit();
            queueHeader.ResumeLayout(false);
            queueHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tblSender;
        private Panel headerPanel;
        private Label title;
        private Label label1;
        private Label lblSelected;
        private UI.ModernButton btnSend;
        private UI.ModernButton btntest;
        private UI.CardPanel recipientsCard;
        private Panel recipientsHeader;
        private Label lblRecipients;
        private Label lblRecipientsHint;
        private DataGridView dataGridView1;
        private BindingSource cleanDatumBindingSource;
        private UI.CardPanel queueCard;
        private Panel queueHeader;
        private Label lblQueue;
        private Label lblQueueHint;
        private DataGridView dataGridView2;
        private BindingSource tmessageBindingSource;
        private CheckBox checkBox1;
        private UI.ModernButton modernButton1;
        private DataGridViewButtonColumn colSelect;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDoctorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn drNameEnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobileNumbersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn drNameArDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn riteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kazaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registerNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumbersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn printedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DoctorId;
        private DataGridViewTextBoxColumn drNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isSentDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isErrorDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn errorMsgDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn requestNbDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn msgTypeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn msgTypeDataGridViewTextBoxColumn;
    }
}
