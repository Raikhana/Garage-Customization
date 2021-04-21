namespace ControlsAndForms
{
    partial class frmPayment
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
            this.cboDoorType = new System.Windows.Forms.ComboBox();
            this.cboMaterialsForSiding = new System.Windows.Forms.ComboBox();
            this.lstInsulation = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAttached = new System.Windows.Forms.RadioButton();
            this.rdoDetached = new System.Windows.Forms.RadioButton();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaterialsForTheRoof = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalAreaOfAGarage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstWindowsType = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDoorType
            // 
            this.cboDoorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoorType.FormattingEnabled = true;
            this.cboDoorType.Location = new System.Drawing.Point(163, 238);
            this.cboDoorType.Name = "cboDoorType";
            this.cboDoorType.Size = new System.Drawing.Size(266, 21);
            this.cboDoorType.TabIndex = 2;
            // 
            // cboMaterialsForSiding
            // 
            this.cboMaterialsForSiding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterialsForSiding.FormattingEnabled = true;
            this.cboMaterialsForSiding.Location = new System.Drawing.Point(163, 280);
            this.cboMaterialsForSiding.Name = "cboMaterialsForSiding";
            this.cboMaterialsForSiding.Size = new System.Drawing.Size(266, 21);
            this.cboMaterialsForSiding.TabIndex = 3;
            // 
            // lstInsulation
            // 
            this.lstInsulation.FormattingEnabled = true;
            this.lstInsulation.Location = new System.Drawing.Point(163, 134);
            this.lstInsulation.Name = "lstInsulation";
            this.lstInsulation.Size = new System.Drawing.Size(266, 82);
            this.lstInsulation.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.rdoAttached);
            this.groupBox1.Controls.Add(this.rdoDetached);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 64);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options of the garage attachment:";
            // 
            // rdoAttached
            // 
            this.rdoAttached.AutoSize = true;
            this.rdoAttached.Location = new System.Drawing.Point(142, 24);
            this.rdoAttached.Name = "rdoAttached";
            this.rdoAttached.Size = new System.Drawing.Size(68, 17);
            this.rdoAttached.TabIndex = 5;
            this.rdoAttached.Text = "Attached";
            this.rdoAttached.UseVisualStyleBackColor = true;
            this.rdoAttached.CheckedChanged += new System.EventHandler(this.rdoAttached_CheckedChanged);
            // 
            // rdoDetached
            // 
            this.rdoDetached.AutoSize = true;
            this.rdoDetached.Checked = true;
            this.rdoDetached.Location = new System.Drawing.Point(21, 24);
            this.rdoDetached.Name = "rdoDetached";
            this.rdoDetached.Size = new System.Drawing.Size(72, 17);
            this.rdoDetached.TabIndex = 5;
            this.rdoDetached.TabStop = true;
            this.rdoDetached.Text = "Detached";
            this.rdoDetached.UseVisualStyleBackColor = true;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Location = new System.Drawing.Point(19, 485);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(140, 17);
            this.chkDefault.TabIndex = 4;
            this.chkDefault.Text = "Contact for more details.";
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Garage insulation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Door type:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(264, 479);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 26);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(354, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Materials for siding:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Materials for the roof:";
            // 
            // cmbMaterialsForTheRoof
            // 
            this.cmbMaterialsForTheRoof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialsForTheRoof.FormattingEnabled = true;
            this.cmbMaterialsForTheRoof.Location = new System.Drawing.Point(163, 326);
            this.cmbMaterialsForTheRoof.Name = "cmbMaterialsForTheRoof";
            this.cmbMaterialsForTheRoof.Size = new System.Drawing.Size(266, 21);
            this.cmbMaterialsForTheRoof.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "The total area of a garage: ";
            // 
            // txtTotalAreaOfAGarage
            // 
            this.txtTotalAreaOfAGarage.Location = new System.Drawing.Point(163, 99);
            this.txtTotalAreaOfAGarage.Name = "txtTotalAreaOfAGarage";
            this.txtTotalAreaOfAGarage.Size = new System.Drawing.Size(229, 20);
            this.txtTotalAreaOfAGarage.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = " Windows types:";
            // 
            // lstWindowsType
            // 
            this.lstWindowsType.FormattingEnabled = true;
            this.lstWindowsType.Location = new System.Drawing.Point(163, 369);
            this.lstWindowsType.Name = "lstWindowsType";
            this.lstWindowsType.Size = new System.Drawing.Size(266, 82);
            this.lstWindowsType.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "sq.m.";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(219, 14);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(184, 44);
            this.textBox2.TabIndex = 6;
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(454, 527);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstWindowsType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalAreaOfAGarage);
            this.Controls.Add(this.cmbMaterialsForTheRoof);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstInsulation);
            this.Controls.Add(this.cboMaterialsForSiding);
            this.Controls.Add(this.cboDoorType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDoorType;
        private System.Windows.Forms.ComboBox cboMaterialsForSiding;
        private System.Windows.Forms.ListBox lstInsulation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoAttached;
        private System.Windows.Forms.RadioButton rdoDetached;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaterialsForTheRoof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalAreaOfAGarage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstWindowsType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

