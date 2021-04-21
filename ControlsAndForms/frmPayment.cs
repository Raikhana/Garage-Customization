using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControlsAndForms
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }
        
        private void frmPayment_Load(object sender, EventArgs e)
        {
            string[] doors = { "Select a door...", "Roll-up door", "Swing-out door" };
            foreach (string door in doors)
            {
                cboDoorType.Items.Add(door);
            }
            cboDoorType.SelectedIndex = 0;
            
            string[] siding = { "Select a siding...", "Wood", "Stainless steel", "Vinyl plastic resin" };
            foreach (string wall in siding)
            {
                cboMaterialsForSiding.Items.Add(wall);
            }
            cboMaterialsForSiding.SelectedIndex = 0;

            string[] roof = { "Select materials for the roof..", "Metal", "Shingle" };
            foreach (string r in roof)
            {
                cmbMaterialsForTheRoof.Items.Add(r);
            }
            cmbMaterialsForTheRoof.SelectedIndex = 0;

            lstInsulation.Items.Add("Select an insulation");
            lstInsulation.Items.Add("wall insulation");
            lstInsulation.Items.Add("attic insulation");
            lstInsulation.Items.Add("door insulation");
            lstInsulation.Items.Add("Garage insulation( wall + door + attic)");
            lstInsulation.Items.Add("Garage insulation( wall + door)");
            lstInsulation.Items.Add("Garage insulation( wall + attic)");
            lstInsulation.SelectedIndex = 0;

            lstWindowsType.Items.Add("Select a window");
            lstWindowsType.Items.Add("Casement Windows");
            lstWindowsType.Items.Add("Awning Windows");
            lstWindowsType.Items.Add("The Verdict");
            lstWindowsType.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.SaveData();
            }
        }

        private bool IsValidData()
        {
            if (rdoDetached.Checked)
            {
                if (txtTotalAreaOfAGarage.Text == "")
                {
                    MessageBox.Show("You must enter a total area of a garage .", "Entry Error");
                    txtTotalAreaOfAGarage.Focus();
                    return false;
                }
                if (lstInsulation.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select an insulation type.", "Entry Error");
                    lstInsulation.Focus();
                    return false;
                }
                if (cboDoorType.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a door type.", "Entry Error");
                    cboDoorType.Focus();
                    return false;
                }
                if (cboMaterialsForSiding.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select materials for siding.", "Entry Error");
                    cboMaterialsForSiding.Focus();
                    return false;
                }
                if(cmbMaterialsForTheRoof.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select materials for roof.", "Entry Error");
                    cmbMaterialsForTheRoof.Focus();
                    return false;
                }
                if (lstWindowsType.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select type of windows.", "Entry Error");
                    lstWindowsType.Focus();
                    return false;
                }
                if(!Int32(txtTotalAreaOfAGarage, "a total area "))
                    return false;

                if (!WithinRange(txtTotalAreaOfAGarage, "a total area", 1, 700))
                    return false;
            }

            if (rdoAttached.Checked)
            {
                if (txtTotalAreaOfAGarage.Text == "")
                {
                    MessageBox.Show("You must enter a total area of a garage .", "Entry Error");
                    txtTotalAreaOfAGarage.Focus();
                    return false;
                }
                if (lstInsulation.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select an insulation type.", "Entry Error");
                    lstInsulation.Focus();
                    return false;
                }
                if (cboDoorType.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a door type.", "Entry Error");
                    cboDoorType.Focus();
                    return false;
                }
                if (!Int32(txtTotalAreaOfAGarage, "a total area "))
                    return false;

                if (!WithinRange(txtTotalAreaOfAGarage, "a total area", 1, 700))
                    return false;
            }
            return true;
        }

        public bool Int32(TextBox textBox, string name)
        {
            int number = 0;
            if (int.TryParse(textBox.Text, NumberStyles.None, CultureInfo.CurrentCulture, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }
        public bool WithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = decimal.Parse(textBox.Text, NumberStyles.Currency);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void SaveData()
        {
            string msg = null;
            if (rdoDetached.Checked == true)
            {
                msg += "Types of garages: Detached\t " + "\n\n";
                msg += "The total area of a garage:\t " + txtTotalAreaOfAGarage.Text + "  sq.m." +"\n";
                msg += "Garage insulation:\t " + lstInsulation.Text + "\n";
                msg += "Door type: \t " + cboDoorType.Text + "\n";
                msg += "Materials for siding:\t " + cboMaterialsForSiding.Text + "\n";
                msg += "Materials for the roof:\t " + cmbMaterialsForTheRoof.Text + "\n";
                msg += "Windows types:\t " + lstWindowsType.Text + "\n";
            }
            else
            {
                msg += "Types of garages: Attached \t  " + "\n\n";
                msg += "The total area of a garage:\t  " + txtTotalAreaOfAGarage.Text + "  sq.m." + "\r\n";
                msg += "Garage insulation: \t  " + lstInsulation.Text + "\r\n";
                msg += "Door type: \t  " + cboDoorType.Text + "\r\n";
            }
            bool isDefaultBilling = chkDefault.Checked;
            msg += "\n\n" + "Contact for more details ";
            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }

        private void rdoAttached_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDetached.Checked)
                EnableControls();
            else DisableControls();
        }
        private void DisableControls()
        {
            textBox2.Text = "Materials for siding/roof/windows must be identica to the main building." + "\r\n"+
                            "Please contact us for more details.";
            cboMaterialsForSiding.Enabled = false;
            cmbMaterialsForTheRoof.Enabled = false;
            lstWindowsType.Enabled = false;
        }

        private void EnableControls()
        {
            textBox2.Clear();
            lstInsulation.Enabled = true;
            txtTotalAreaOfAGarage.Enabled = true;
            cboDoorType.Enabled = true;
            cboMaterialsForSiding.Enabled = true;
            cmbMaterialsForTheRoof.Enabled = true;
            lstWindowsType.Enabled = true;
        }
    }
}
