namespace RDA.Demo4.UI
{
    partial class Form1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cboEntrees = new System.Windows.Forms.ComboBox();
            this.cboAddOns = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddEntree = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnWorld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(180, 312);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cboEntrees
            // 
            this.cboEntrees.FormattingEnabled = true;
            this.cboEntrees.Location = new System.Drawing.Point(78, 155);
            this.cboEntrees.Name = "cboEntrees";
            this.cboEntrees.Size = new System.Drawing.Size(121, 21);
            this.cboEntrees.TabIndex = 1;
            // 
            // cboAddOns
            // 
            this.cboAddOns.FormattingEnabled = true;
            this.cboAddOns.Location = new System.Drawing.Point(380, 155);
            this.cboAddOns.Name = "cboAddOns";
            this.cboAddOns.Size = new System.Drawing.Size(121, 21);
            this.cboAddOns.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(261, 312);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddEntree
            // 
            this.btnAddEntree.Location = new System.Drawing.Point(205, 155);
            this.btnAddEntree.Name = "btnAddEntree";
            this.btnAddEntree.Size = new System.Drawing.Size(75, 23);
            this.btnAddEntree.TabIndex = 3;
            this.btnAddEntree.Text = "Add";
            this.btnAddEntree.UseVisualStyleBackColor = true;
            this.btnAddEntree.Click += new System.EventHandler(this.btnAddEntree_Click);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(525, 362);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(75, 23);
            this.btnHello.TabIndex = 4;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnWorld
            // 
            this.btnWorld.Location = new System.Drawing.Point(525, 391);
            this.btnWorld.Name = "btnWorld";
            this.btnWorld.Size = new System.Drawing.Size(75, 23);
            this.btnWorld.TabIndex = 4;
            this.btnWorld.Text = "World";
            this.btnWorld.UseVisualStyleBackColor = true;
            this.btnWorld.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWorld);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.btnAddEntree);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cboAddOns);
            this.Controls.Add(this.cboEntrees);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cboEntrees;
        private System.Windows.Forms.ComboBox cboAddOns;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddEntree;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnWorld;
    }
}

