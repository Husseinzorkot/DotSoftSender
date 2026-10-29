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
            button1 = new Button();
            title = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            colSelect = new DataGridViewButtonColumn();
            codeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            drNameEnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            drNameArDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            riteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kazaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registerNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registrationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumbersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobileNumbersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            specDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDoctorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            printedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pcDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cleanDatumBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            idDrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            drNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isSentDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isErrorDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            errorMsgDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fromDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            requestNbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filePathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            msgTypeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            msgTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tmessageBindingSource = new BindingSource(components);
            btntest = new Button();
            btnSend = new Button();
            testTableBindingSource = new BindingSource(components);
            tblSender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cleanDatumBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tmessageBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testTableBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tblSender
            // 
            tblSender.ColumnCount = 1;
            tblSender.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSender.Controls.Add(button1, 0, 6);
            tblSender.Controls.Add(title, 0, 0);
            tblSender.Controls.Add(label1, 0, 1);
            tblSender.Controls.Add(dataGridView1, 0, 2);
            tblSender.Controls.Add(dataGridView2, 0, 4);
            tblSender.Controls.Add(btntest, 0, 5);
            tblSender.Controls.Add(btnSend, 0, 3);
            tblSender.Dock = DockStyle.Top;
            tblSender.Location = new Point(0, 0);
            tblSender.Name = "tblSender";
            tblSender.RowCount = 6;
            tblSender.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblSender.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblSender.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSender.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tblSender.RowStyles.Add(new RowStyle(SizeType.Absolute, 439F));
            tblSender.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSender.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblSender.Size = new Size(2483, 1284);
            tblSender.TabIndex = 2;
            tblSender.Paint += tblSender_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(3, 1266);
            button1.Name = "button1";
            button1.Size = new Size(131, 15);
            button1.TabIndex = 10;
            button1.Text = "test";
            button1.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.FromArgb(23, 36, 59);
            title.Location = new Point(3, 0);
            title.Name = "title";
            title.Size = new Size(185, 50);
            title.TabIndex = 0;
            title.Text = "Sender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 36, 59);
            label1.Location = new Point(3, 50);
            label1.Name = "label1";
            label1.Size = new Size(214, 30);
            label1.TabIndex = 1;
            label1.Text = "Select Reciptients";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colSelect, codeDataGridViewTextBoxColumn, drNameEnDataGridViewTextBoxColumn, drNameArDataGridViewTextBoxColumn, dobDataGridViewTextBoxColumn, riteDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, kazaDataGridViewTextBoxColumn, registerNumberDataGridViewTextBoxColumn, registrationDateDataGridViewTextBoxColumn, phoneNumbersDataGridViewTextBoxColumn, mobileNumbersDataGridViewTextBoxColumn, specDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, idDoctorDataGridViewTextBoxColumn, printedDataGridViewTextBoxColumn, pcDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cleanDatumBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(2477, 337);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colSelect
            // 
            colSelect.FlatStyle = FlatStyle.Flat;
            colSelect.HeaderText = "Select";
            colSelect.MinimumWidth = 9;
            colSelect.Name = "colSelect";
            colSelect.Text = "Select";
            colSelect.UseColumnTextForButtonValue = true;
            colSelect.Width = 175;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.MinimumWidth = 9;
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            codeDataGridViewTextBoxColumn.Width = 175;
            // 
            // drNameEnDataGridViewTextBoxColumn
            // 
            drNameEnDataGridViewTextBoxColumn.DataPropertyName = "DrNameEn";
            drNameEnDataGridViewTextBoxColumn.HeaderText = "DrNameEn";
            drNameEnDataGridViewTextBoxColumn.MinimumWidth = 9;
            drNameEnDataGridViewTextBoxColumn.Name = "drNameEnDataGridViewTextBoxColumn";
            drNameEnDataGridViewTextBoxColumn.Width = 175;
            // 
            // drNameArDataGridViewTextBoxColumn
            // 
            drNameArDataGridViewTextBoxColumn.DataPropertyName = "DrNameAr";
            drNameArDataGridViewTextBoxColumn.HeaderText = "DrNameAr";
            drNameArDataGridViewTextBoxColumn.MinimumWidth = 9;
            drNameArDataGridViewTextBoxColumn.Name = "drNameArDataGridViewTextBoxColumn";
            drNameArDataGridViewTextBoxColumn.Width = 175;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            dobDataGridViewTextBoxColumn.MinimumWidth = 9;
            dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            dobDataGridViewTextBoxColumn.Width = 175;
            // 
            // riteDataGridViewTextBoxColumn
            // 
            riteDataGridViewTextBoxColumn.DataPropertyName = "Rite";
            riteDataGridViewTextBoxColumn.HeaderText = "Rite";
            riteDataGridViewTextBoxColumn.MinimumWidth = 9;
            riteDataGridViewTextBoxColumn.Name = "riteDataGridViewTextBoxColumn";
            riteDataGridViewTextBoxColumn.Width = 175;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.MinimumWidth = 9;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.Width = 175;
            // 
            // kazaDataGridViewTextBoxColumn
            // 
            kazaDataGridViewTextBoxColumn.DataPropertyName = "Kaza";
            kazaDataGridViewTextBoxColumn.HeaderText = "Kaza";
            kazaDataGridViewTextBoxColumn.MinimumWidth = 9;
            kazaDataGridViewTextBoxColumn.Name = "kazaDataGridViewTextBoxColumn";
            kazaDataGridViewTextBoxColumn.Width = 175;
            // 
            // registerNumberDataGridViewTextBoxColumn
            // 
            registerNumberDataGridViewTextBoxColumn.DataPropertyName = "RegisterNumber";
            registerNumberDataGridViewTextBoxColumn.HeaderText = "RegisterNumber";
            registerNumberDataGridViewTextBoxColumn.MinimumWidth = 9;
            registerNumberDataGridViewTextBoxColumn.Name = "registerNumberDataGridViewTextBoxColumn";
            registerNumberDataGridViewTextBoxColumn.Width = 175;
            // 
            // registrationDateDataGridViewTextBoxColumn
            // 
            registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
            registrationDateDataGridViewTextBoxColumn.HeaderText = "RegistrationDate";
            registrationDateDataGridViewTextBoxColumn.MinimumWidth = 9;
            registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            registrationDateDataGridViewTextBoxColumn.Width = 175;
            // 
            // phoneNumbersDataGridViewTextBoxColumn
            // 
            phoneNumbersDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumbers";
            phoneNumbersDataGridViewTextBoxColumn.HeaderText = "PhoneNumbers";
            phoneNumbersDataGridViewTextBoxColumn.MinimumWidth = 9;
            phoneNumbersDataGridViewTextBoxColumn.Name = "phoneNumbersDataGridViewTextBoxColumn";
            phoneNumbersDataGridViewTextBoxColumn.Width = 175;
            // 
            // mobileNumbersDataGridViewTextBoxColumn
            // 
            mobileNumbersDataGridViewTextBoxColumn.DataPropertyName = "MobileNumbers";
            mobileNumbersDataGridViewTextBoxColumn.HeaderText = "MobileNumbers";
            mobileNumbersDataGridViewTextBoxColumn.MinimumWidth = 9;
            mobileNumbersDataGridViewTextBoxColumn.Name = "mobileNumbersDataGridViewTextBoxColumn";
            mobileNumbersDataGridViewTextBoxColumn.Width = 175;
            // 
            // specDataGridViewTextBoxColumn
            // 
            specDataGridViewTextBoxColumn.DataPropertyName = "Spec";
            specDataGridViewTextBoxColumn.HeaderText = "Spec";
            specDataGridViewTextBoxColumn.MinimumWidth = 9;
            specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            specDataGridViewTextBoxColumn.Width = 175;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 9;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 175;
            // 
            // idDoctorDataGridViewTextBoxColumn
            // 
            idDoctorDataGridViewTextBoxColumn.DataPropertyName = "IdDoctor";
            idDoctorDataGridViewTextBoxColumn.HeaderText = "IdDoctor";
            idDoctorDataGridViewTextBoxColumn.MinimumWidth = 9;
            idDoctorDataGridViewTextBoxColumn.Name = "idDoctorDataGridViewTextBoxColumn";
            idDoctorDataGridViewTextBoxColumn.Width = 175;
            // 
            // printedDataGridViewTextBoxColumn
            // 
            printedDataGridViewTextBoxColumn.DataPropertyName = "Printed";
            printedDataGridViewTextBoxColumn.HeaderText = "Printed";
            printedDataGridViewTextBoxColumn.MinimumWidth = 9;
            printedDataGridViewTextBoxColumn.Name = "printedDataGridViewTextBoxColumn";
            printedDataGridViewTextBoxColumn.Width = 175;
            // 
            // pcDataGridViewTextBoxColumn
            // 
            pcDataGridViewTextBoxColumn.DataPropertyName = "Pc";
            pcDataGridViewTextBoxColumn.HeaderText = "Pc";
            pcDataGridViewTextBoxColumn.MinimumWidth = 9;
            pcDataGridViewTextBoxColumn.Name = "pcDataGridViewTextBoxColumn";
            pcDataGridViewTextBoxColumn.Width = 175;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 9;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.Width = 175;
            // 
            // cleanDatumBindingSource
            // 
            cleanDatumBindingSource.DataSource = typeof(Data.CleanDatum);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDrDataGridViewTextBoxColumn, drNameDataGridViewTextBoxColumn, isSentDataGridViewCheckBoxColumn, isErrorDataGridViewCheckBoxColumn, errorMsgDataGridViewTextBoxColumn, fromDataGridViewTextBoxColumn, toDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, requestNbDataGridViewTextBoxColumn, filePathDataGridViewTextBoxColumn, msgTypeIdDataGridViewTextBoxColumn, msgTypeDataGridViewTextBoxColumn });
            dataGridView2.DataSource = tmessageBindingSource;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 484);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 72;
            dataGridView2.Size = new Size(2477, 433);
            dataGridView2.TabIndex = 8;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // idDrDataGridViewTextBoxColumn
            // 
            idDrDataGridViewTextBoxColumn.DataPropertyName = "IdDr";
            idDrDataGridViewTextBoxColumn.HeaderText = "IdDr";
            idDrDataGridViewTextBoxColumn.MinimumWidth = 9;
            idDrDataGridViewTextBoxColumn.Name = "idDrDataGridViewTextBoxColumn";
            idDrDataGridViewTextBoxColumn.Width = 175;
            // 
            // drNameDataGridViewTextBoxColumn
            // 
            drNameDataGridViewTextBoxColumn.DataPropertyName = "DrName";
            drNameDataGridViewTextBoxColumn.HeaderText = "DrName";
            drNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            drNameDataGridViewTextBoxColumn.Name = "drNameDataGridViewTextBoxColumn";
            drNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // isSentDataGridViewCheckBoxColumn
            // 
            isSentDataGridViewCheckBoxColumn.DataPropertyName = "IsSent";
            isSentDataGridViewCheckBoxColumn.HeaderText = "IsSent";
            isSentDataGridViewCheckBoxColumn.MinimumWidth = 9;
            isSentDataGridViewCheckBoxColumn.Name = "isSentDataGridViewCheckBoxColumn";
            isSentDataGridViewCheckBoxColumn.Width = 175;
            // 
            // isErrorDataGridViewCheckBoxColumn
            // 
            isErrorDataGridViewCheckBoxColumn.DataPropertyName = "IsError";
            isErrorDataGridViewCheckBoxColumn.HeaderText = "IsError";
            isErrorDataGridViewCheckBoxColumn.MinimumWidth = 9;
            isErrorDataGridViewCheckBoxColumn.Name = "isErrorDataGridViewCheckBoxColumn";
            isErrorDataGridViewCheckBoxColumn.Width = 175;
            // 
            // errorMsgDataGridViewTextBoxColumn
            // 
            errorMsgDataGridViewTextBoxColumn.DataPropertyName = "ErrorMsg";
            errorMsgDataGridViewTextBoxColumn.HeaderText = "ErrorMsg";
            errorMsgDataGridViewTextBoxColumn.MinimumWidth = 9;
            errorMsgDataGridViewTextBoxColumn.Name = "errorMsgDataGridViewTextBoxColumn";
            errorMsgDataGridViewTextBoxColumn.Width = 175;
            // 
            // fromDataGridViewTextBoxColumn
            // 
            fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            fromDataGridViewTextBoxColumn.HeaderText = "From";
            fromDataGridViewTextBoxColumn.MinimumWidth = 9;
            fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            fromDataGridViewTextBoxColumn.Width = 175;
            // 
            // toDataGridViewTextBoxColumn
            // 
            toDataGridViewTextBoxColumn.DataPropertyName = "To";
            toDataGridViewTextBoxColumn.HeaderText = "To";
            toDataGridViewTextBoxColumn.MinimumWidth = 9;
            toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            toDataGridViewTextBoxColumn.Width = 175;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 9;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 175;
            // 
            // requestNbDataGridViewTextBoxColumn
            // 
            requestNbDataGridViewTextBoxColumn.DataPropertyName = "RequestNb";
            requestNbDataGridViewTextBoxColumn.HeaderText = "RequestNb";
            requestNbDataGridViewTextBoxColumn.MinimumWidth = 9;
            requestNbDataGridViewTextBoxColumn.Name = "requestNbDataGridViewTextBoxColumn";
            requestNbDataGridViewTextBoxColumn.Width = 175;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            filePathDataGridViewTextBoxColumn.HeaderText = "FilePath";
            filePathDataGridViewTextBoxColumn.MinimumWidth = 9;
            filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            filePathDataGridViewTextBoxColumn.Width = 175;
            // 
            // msgTypeIdDataGridViewTextBoxColumn
            // 
            msgTypeIdDataGridViewTextBoxColumn.DataPropertyName = "MsgTypeId";
            msgTypeIdDataGridViewTextBoxColumn.HeaderText = "MsgTypeId";
            msgTypeIdDataGridViewTextBoxColumn.MinimumWidth = 9;
            msgTypeIdDataGridViewTextBoxColumn.Name = "msgTypeIdDataGridViewTextBoxColumn";
            msgTypeIdDataGridViewTextBoxColumn.Width = 175;
            // 
            // msgTypeDataGridViewTextBoxColumn
            // 
            msgTypeDataGridViewTextBoxColumn.DataPropertyName = "MsgType";
            msgTypeDataGridViewTextBoxColumn.HeaderText = "MsgType";
            msgTypeDataGridViewTextBoxColumn.MinimumWidth = 9;
            msgTypeDataGridViewTextBoxColumn.Name = "msgTypeDataGridViewTextBoxColumn";
            msgTypeDataGridViewTextBoxColumn.Width = 175;
            // 
            // tmessageBindingSource
            // 
            tmessageBindingSource.DataSource = typeof(Data.Tmessage);
            // 
            // btntest
            // 
            btntest.BackColor = SystemColors.HotTrack;
            btntest.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntest.ForeColor = SystemColors.ButtonHighlight;
            btntest.Location = new Point(3, 923);
            btntest.Name = "btntest";
            btntest.Size = new Size(131, 40);
            btntest.TabIndex = 9;
            btntest.Text = "Refresh";
            btntest.UseVisualStyleBackColor = false;
            btntest.Click += btntest_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.HotTrack;
            btnSend.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.ForeColor = SystemColors.ButtonHighlight;
            btnSend.Location = new Point(3, 426);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(131, 40);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // frmSender
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2483, 1394);
            Controls.Add(tblSender);
            Name = "frmSender";
            Text = "frmSender";
            Load += frmSender_Load;
            tblSender.ResumeLayout(false);
            tblSender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cleanDatumBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tmessageBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)testTableBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tblSender;
        private Label title;
        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource cleanDatumBindingSource;
        private DataGridViewButtonColumn colSelect;
        private Button btnSend;
        private DataGridView dataGridView2;
        private BindingSource tmessageBindingSource;
        private Button btntest;
        private BindingSource testTableBindingSource;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn drNameEnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn drNameArDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn riteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kazaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registerNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumbersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobileNumbersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDoctorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn printedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn drNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isSentDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isErrorDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn errorMsgDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn requestNbDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn msgTypeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn msgTypeDataGridViewTextBoxColumn;
        private Button button1;
    }
}