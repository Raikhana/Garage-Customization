namespace ControlsAndForms
{
    partial class frmCustomer
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
            this.btnGarageCustomization = new System.Windows.Forms.Button();
            this.cmbSizeOfTheGarage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGarageCustomization
            // 
            this.btnGarageCustomization.Location = new System.Drawing.Point(235, 59);
            this.btnGarageCustomization.Name = "btnGarageCustomization";
            this.btnGarageCustomization.Size = new System.Drawing.Size(119, 23);
            this.btnGarageCustomization.TabIndex = 0;
            this.btnGarageCustomization.Text = "&Garage customization";
            this.btnGarageCustomization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGarageCustomization.UseVisualStyleBackColor = true;
            this.btnGarageCustomization.Click += new System.EventHandler(this.btnGarageCustomization_Click);
            // 
            // cmbSizeOfTheGarage
            // 
            this.cmbSizeOfTheGarage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeOfTheGarage.FormattingEnabled = true;
            this.cmbSizeOfTheGarage.Location = new System.Drawing.Point(124, 14);
            this.cmbSizeOfTheGarage.Name = "cmbSizeOfTheGarage";
            this.cmbSizeOfTheGarage.Size = new System.Drawing.Size(230, 21);
            this.cmbSizeOfTheGarage.TabIndex = 2;
            this.cmbSizeOfTheGarage.SelectedIndexChanged += new System.EventHandler(this.DataChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Size of the garage:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(235, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblList
            // 
            this.lblList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblList.Location = new System.Drawing.Point(12, 59);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(213, 203);
            this.lblList.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 284);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(366, 324);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSizeOfTheGarage);
            this.Controls.Add(this.btnGarageCustomization);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGarageCustomization;
        private System.Windows.Forms.ComboBox cmbSizeOfTheGarage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnClear;
    }
}