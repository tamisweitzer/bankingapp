namespace TSS.BankingApp.UI
{
    partial class BankingAppForm
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
            this.lstbxCustomersList = new System.Windows.Forms.ListBox();
            this.DgvDeposits = new System.Windows.Forms.DataGridView();
            this.DgvWithdrawls = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDisplayID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDisplayAge = new System.Windows.Forms.Label();
            this.LblWithdrawls = new System.Windows.Forms.Label();
            this.LblDeposits = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblTempTable = new System.Windows.Forms.Label();
            this.dgvTempTable = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveToXML = new System.Windows.Forms.Button();
            this.btnLoadFromXML = new System.Windows.Forms.Button();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.btnReadFromDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvWithdrawls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbxCustomersList
            // 
            this.lstbxCustomersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxCustomersList.FormattingEnabled = true;
            this.lstbxCustomersList.ItemHeight = 17;
            this.lstbxCustomersList.Location = new System.Drawing.Point(24, 20);
            this.lstbxCustomersList.Margin = new System.Windows.Forms.Padding(2);
            this.lstbxCustomersList.Name = "lstbxCustomersList";
            this.lstbxCustomersList.Size = new System.Drawing.Size(216, 276);
            this.lstbxCustomersList.TabIndex = 0;
            this.lstbxCustomersList.SelectedIndexChanged += new System.EventHandler(this.lstbxCustomersList_SelectedIndexChanged_1);
            // 
            // DgvDeposits
            // 
            this.DgvDeposits.AllowUserToOrderColumns = true;
            this.DgvDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDeposits.Location = new System.Drawing.Point(24, 316);
            this.DgvDeposits.Margin = new System.Windows.Forms.Padding(2);
            this.DgvDeposits.Name = "DgvDeposits";
            this.DgvDeposits.RowTemplate.Height = 33;
            this.DgvDeposits.Size = new System.Drawing.Size(592, 134);
            this.DgvDeposits.TabIndex = 1;
            // 
            // DgvWithdrawls
            // 
            this.DgvWithdrawls.AllowUserToOrderColumns = true;
            this.DgvWithdrawls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvWithdrawls.Location = new System.Drawing.Point(24, 472);
            this.DgvWithdrawls.Margin = new System.Windows.Forms.Padding(2);
            this.DgvWithdrawls.Name = "DgvWithdrawls";
            this.DgvWithdrawls.RowTemplate.Height = 33;
            this.DgvWithdrawls.Size = new System.Drawing.Size(592, 133);
            this.DgvWithdrawls.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.Control;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(353, 26);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.MinimumSize = new System.Drawing.Size(75, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(80, 23);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDisplayID
            // 
            this.lblDisplayID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayID.Location = new System.Drawing.Point(464, 25);
            this.lblDisplayID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplayID.Name = "lblDisplayID";
            this.lblDisplayID.Size = new System.Drawing.Size(150, 23);
            this.lblDisplayID.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(353, 64);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.MinimumSize = new System.Drawing.Size(75, 16);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 23);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(354, 100);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.MinimumSize = new System.Drawing.Size(75, 16);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 23);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSSN
            // 
            this.lblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(356, 138);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSSN.MinimumSize = new System.Drawing.Size(75, 16);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(81, 23);
            this.lblSSN.TabIndex = 7;
            this.lblSSN.Text = "SSN";
            this.lblSSN.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(356, 175);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthDate.MinimumSize = new System.Drawing.Size(75, 16);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(81, 23);
            this.lblBirthDate.TabIndex = 8;
            this.lblBirthDate.Text = "Birth Date";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(464, 63);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(152, 24);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(464, 100);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(152, 24);
            this.txtLastName.TabIndex = 10;
            // 
            // txtSSN
            // 
            this.txtSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSN.Location = new System.Drawing.Point(464, 138);
            this.txtSSN.Margin = new System.Windows.Forms.Padding(2);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(152, 24);
            this.txtSSN.TabIndex = 11;
            // 
            // lblAge
            // 
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(356, 212);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(83, 23);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDisplayAge
            // 
            this.lblDisplayAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayAge.Location = new System.Drawing.Point(464, 212);
            this.lblDisplayAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplayAge.Name = "lblDisplayAge";
            this.lblDisplayAge.Size = new System.Drawing.Size(150, 23);
            this.lblDisplayAge.TabIndex = 13;
            // 
            // LblWithdrawls
            // 
            this.LblWithdrawls.AutoSize = true;
            this.LblWithdrawls.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWithdrawls.Location = new System.Drawing.Point(21, 452);
            this.LblWithdrawls.Name = "LblWithdrawls";
            this.LblWithdrawls.Size = new System.Drawing.Size(81, 18);
            this.LblWithdrawls.TabIndex = 15;
            this.LblWithdrawls.Text = "Withdrawls";
            // 
            // LblDeposits
            // 
            this.LblDeposits.AutoSize = true;
            this.LblDeposits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeposits.Location = new System.Drawing.Point(21, 296);
            this.LblDeposits.Name = "LblDeposits";
            this.LblDeposits.Size = new System.Drawing.Size(67, 18);
            this.LblDeposits.TabIndex = 16;
            this.LblDeposits.Text = "Deposits";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(334, 251);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(84, 45);
            this.btnAddCustomer.TabIndex = 17;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(433, 251);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(84, 45);
            this.btnUpdateCustomer.TabIndex = 18;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(532, 251);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 45);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthDate.Location = new System.Drawing.Point(464, 176);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(150, 22);
            this.dtBirthDate.TabIndex = 20;
            this.dtBirthDate.Value = new System.DateTime(2018, 12, 19, 18, 59, 52, 0);
            // 
            // lblTempTable
            // 
            this.lblTempTable.AutoSize = true;
            this.lblTempTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempTable.Location = new System.Drawing.Point(21, 621);
            this.lblTempTable.Name = "lblTempTable";
            this.lblTempTable.Size = new System.Drawing.Size(85, 18);
            this.lblTempTable.TabIndex = 22;
            this.lblTempTable.Text = "Temp_table";
            // 
            // dgvTempTable
            // 
            this.dgvTempTable.AllowUserToOrderColumns = true;
            this.dgvTempTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTempTable.Location = new System.Drawing.Point(24, 641);
            this.dgvTempTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTempTable.Name = "dgvTempTable";
            this.dgvTempTable.RowTemplate.Height = 33;
            this.dgvTempTable.Size = new System.Drawing.Size(592, 71);
            this.dgvTempTable.TabIndex = 21;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(244, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 45);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveToXML
            // 
            this.btnSaveToXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToXML.Location = new System.Drawing.Point(24, 752);
            this.btnSaveToXML.Name = "btnSaveToXML";
            this.btnSaveToXML.Size = new System.Drawing.Size(135, 52);
            this.btnSaveToXML.TabIndex = 24;
            this.btnSaveToXML.Text = "Save to XML";
            this.btnSaveToXML.UseVisualStyleBackColor = true;
            this.btnSaveToXML.Click += new System.EventHandler(this.btnSaveToXML_Click);
            // 
            // btnLoadFromXML
            // 
            this.btnLoadFromXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFromXML.Location = new System.Drawing.Point(165, 752);
            this.btnLoadFromXML.Name = "btnLoadFromXML";
            this.btnLoadFromXML.Size = new System.Drawing.Size(135, 52);
            this.btnLoadFromXML.TabIndex = 25;
            this.btnLoadFromXML.Text = "Load From XML";
            this.btnLoadFromXML.UseVisualStyleBackColor = true;
            this.btnLoadFromXML.Click += new System.EventHandler(this.btnLoadFromXML_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToDB.Location = new System.Drawing.Point(340, 752);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(135, 52);
            this.btnSaveToDB.TabIndex = 26;
            this.btnSaveToDB.Text = "Save to DB";
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // btnReadFromDB
            // 
            this.btnReadFromDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFromDB.Location = new System.Drawing.Point(481, 752);
            this.btnReadFromDB.Name = "btnReadFromDB";
            this.btnReadFromDB.Size = new System.Drawing.Size(135, 52);
            this.btnReadFromDB.TabIndex = 27;
            this.btnReadFromDB.Text = "Read From DB";
            this.btnReadFromDB.UseVisualStyleBackColor = true;
            this.btnReadFromDB.Click += new System.EventHandler(this.btnReadFromDB_Click);
            // 
            // BankingAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 851);
            this.Controls.Add(this.btnReadFromDB);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.btnLoadFromXML);
            this.Controls.Add(this.btnSaveToXML);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTempTable);
            this.Controls.Add(this.dgvTempTable);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.LblDeposits);
            this.Controls.Add(this.LblWithdrawls);
            this.Controls.Add(this.lblDisplayAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblDisplayID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.DgvWithdrawls);
            this.Controls.Add(this.DgvDeposits);
            this.Controls.Add(this.lstbxCustomersList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BankingAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSS.BankingApp";
            this.Load += new System.EventHandler(this.BankingAppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvWithdrawls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxCustomersList;
        private System.Windows.Forms.DataGridView DgvDeposits;
        private System.Windows.Forms.DataGridView DgvWithdrawls;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDisplayID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDisplayAge;
        private System.Windows.Forms.Label LblWithdrawls;
        private System.Windows.Forms.Label LblDeposits;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Label lblTempTable;
        private System.Windows.Forms.DataGridView dgvTempTable;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveToXML;
        private System.Windows.Forms.Button btnLoadFromXML;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Button btnReadFromDB;
    }
}

