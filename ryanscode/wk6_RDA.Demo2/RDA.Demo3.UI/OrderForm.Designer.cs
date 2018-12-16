namespace RDA.Demo3.UI
{
    partial class OrderForm
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
            this.grpEntrees = new System.Windows.Forms.GroupBox();
            this.rdoEntree3 = new System.Windows.Forms.RadioButton();
            this.rdoEntree2 = new System.Windows.Forms.RadioButton();
            this.rdoEntree1 = new System.Windows.Forms.RadioButton();
            this.grpAddOns = new System.Windows.Forms.GroupBox();
            this.chkAddOn3 = new System.Windows.Forms.CheckBox();
            this.chkAddOn2 = new System.Windows.Forms.CheckBox();
            this.chkAddOn1 = new System.Windows.Forms.CheckBox();
            this.cboEntrees = new System.Windows.Forms.ComboBox();
            this.grpEntrees.SuspendLayout();
            this.grpAddOns.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEntrees
            // 
            this.grpEntrees.Controls.Add(this.cboEntrees);
            this.grpEntrees.Controls.Add(this.rdoEntree3);
            this.grpEntrees.Controls.Add(this.rdoEntree2);
            this.grpEntrees.Controls.Add(this.rdoEntree1);
            this.grpEntrees.Location = new System.Drawing.Point(28, 39);
            this.grpEntrees.Name = "grpEntrees";
            this.grpEntrees.Size = new System.Drawing.Size(200, 192);
            this.grpEntrees.TabIndex = 0;
            this.grpEntrees.TabStop = false;
            this.grpEntrees.Text = "groupBox1";
            // 
            // rdoEntree3
            // 
            this.rdoEntree3.AutoSize = true;
            this.rdoEntree3.Location = new System.Drawing.Point(18, 102);
            this.rdoEntree3.Name = "rdoEntree3";
            this.rdoEntree3.Size = new System.Drawing.Size(52, 17);
            this.rdoEntree3.TabIndex = 0;
            this.rdoEntree3.TabStop = true;
            this.rdoEntree3.Text = "Salad";
            this.rdoEntree3.UseVisualStyleBackColor = true;
            this.rdoEntree3.CheckedChanged += new System.EventHandler(this.rdoEntree3_CheckedChanged);
            // 
            // rdoEntree2
            // 
            this.rdoEntree2.AutoSize = true;
            this.rdoEntree2.Location = new System.Drawing.Point(18, 66);
            this.rdoEntree2.Name = "rdoEntree2";
            this.rdoEntree2.Size = new System.Drawing.Size(56, 17);
            this.rdoEntree2.TabIndex = 0;
            this.rdoEntree2.TabStop = true;
            this.rdoEntree2.Text = "Burger";
            this.rdoEntree2.UseVisualStyleBackColor = true;
            this.rdoEntree2.CheckedChanged += new System.EventHandler(this.rdoEntree2_CheckedChanged);
            // 
            // rdoEntree1
            // 
            this.rdoEntree1.AutoSize = true;
            this.rdoEntree1.Location = new System.Drawing.Point(18, 30);
            this.rdoEntree1.Name = "rdoEntree1";
            this.rdoEntree1.Size = new System.Drawing.Size(50, 17);
            this.rdoEntree1.TabIndex = 0;
            this.rdoEntree1.TabStop = true;
            this.rdoEntree1.Text = "Pizza";
            this.rdoEntree1.UseVisualStyleBackColor = true;
            this.rdoEntree1.CheckedChanged += new System.EventHandler(this.rdoEntree1_CheckedChanged);
            // 
            // grpAddOns
            // 
            this.grpAddOns.Controls.Add(this.chkAddOn3);
            this.grpAddOns.Controls.Add(this.chkAddOn2);
            this.grpAddOns.Controls.Add(this.chkAddOn1);
            this.grpAddOns.Location = new System.Drawing.Point(252, 39);
            this.grpAddOns.Name = "grpAddOns";
            this.grpAddOns.Size = new System.Drawing.Size(200, 159);
            this.grpAddOns.TabIndex = 0;
            this.grpAddOns.TabStop = false;
            this.grpAddOns.Text = "groupBox1";
            // 
            // chkAddOn3
            // 
            this.chkAddOn3.AutoSize = true;
            this.chkAddOn3.Location = new System.Drawing.Point(36, 102);
            this.chkAddOn3.Name = "chkAddOn3";
            this.chkAddOn3.Size = new System.Drawing.Size(80, 17);
            this.chkAddOn3.TabIndex = 0;
            this.chkAddOn3.Text = "checkBox1";
            this.chkAddOn3.UseVisualStyleBackColor = true;
            // 
            // chkAddOn2
            // 
            this.chkAddOn2.AutoSize = true;
            this.chkAddOn2.Location = new System.Drawing.Point(36, 66);
            this.chkAddOn2.Name = "chkAddOn2";
            this.chkAddOn2.Size = new System.Drawing.Size(80, 17);
            this.chkAddOn2.TabIndex = 0;
            this.chkAddOn2.Text = "checkBox1";
            this.chkAddOn2.UseVisualStyleBackColor = true;
            // 
            // chkAddOn1
            // 
            this.chkAddOn1.AutoSize = true;
            this.chkAddOn1.Location = new System.Drawing.Point(36, 30);
            this.chkAddOn1.Name = "chkAddOn1";
            this.chkAddOn1.Size = new System.Drawing.Size(80, 17);
            this.chkAddOn1.TabIndex = 0;
            this.chkAddOn1.Text = "checkBox1";
            this.chkAddOn1.UseVisualStyleBackColor = true;
            // 
            // cboEntrees
            // 
            this.cboEntrees.FormattingEnabled = true;
            this.cboEntrees.Location = new System.Drawing.Point(18, 148);
            this.cboEntrees.Name = "cboEntrees";
            this.cboEntrees.Size = new System.Drawing.Size(121, 21);
            this.cboEntrees.TabIndex = 1;
            this.cboEntrees.SelectedIndexChanged += new System.EventHandler(this.cboEntrees_SelectedIndexChanged);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 268);
            this.Controls.Add(this.grpAddOns);
            this.Controls.Add(this.grpEntrees);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.grpEntrees.ResumeLayout(false);
            this.grpEntrees.PerformLayout();
            this.grpAddOns.ResumeLayout(false);
            this.grpAddOns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEntrees;
        private System.Windows.Forms.RadioButton rdoEntree3;
        private System.Windows.Forms.RadioButton rdoEntree2;
        private System.Windows.Forms.RadioButton rdoEntree1;
        private System.Windows.Forms.GroupBox grpAddOns;
        private System.Windows.Forms.CheckBox chkAddOn3;
        private System.Windows.Forms.CheckBox chkAddOn2;
        private System.Windows.Forms.CheckBox chkAddOn1;
        private System.Windows.Forms.ComboBox cboEntrees;
    }
}