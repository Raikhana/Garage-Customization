using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsAndForms
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        bool isDataSaved = true;

        private void btnGarageCustomization_Click(object sender, EventArgs e)
        {
            if (lblList.Text != "")
            {
                MessageBox.Show("This form contains unsaved data.", "Entry Error");
                btnSave.Focus();
            }
            if (cmbSizeOfTheGarage.SelectedIndex == 0)
            {
                MessageBox.Show("You must select type of the garage.", "Entry Error");
                cmbSizeOfTheGarage.Focus();
            }
            else if (lblList.Text == "" && cmbSizeOfTheGarage.SelectedIndex != 0)
            {
                Form paymentForm = new frmPayment();
                DialogResult selectedButton = paymentForm.ShowDialog();
                if (selectedButton == DialogResult.OK)
                {
                    lblList.Text += "Size of the garage:\t " + cmbSizeOfTheGarage.Text +
                                   "\r\n" + "\r\n" + paymentForm.Tag.ToString();
                    cmbSizeOfTheGarage.Items.Clear();
                    btnSave.Enabled = true;
                    btnClear.Enabled = true;
                    btnSave.Focus();
                }
            }
        }
        
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Garage();
            cmbSizeOfTheGarage.SelectedIndex = 0;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void Garage()
        {
            string[] garage = {"Select:","Single","Double","Three-car-garage","Tandem garages"};
            foreach (string g in garage)
            {
                cmbSizeOfTheGarage.Items.Add(g);
            }
        }

        private void DataChanged(object sender, EventArgs e)
        {
            isDataSaved = false;
        }

        private bool IsValidData()
        {
            if (cmbSizeOfTheGarage.SelectedIndex == 0)
            {
                MessageBox.Show("You must select type of the garage.", "Entry Error");
                cmbSizeOfTheGarage.Focus();
                return false;
            }
            if (lblList.Text == "")
            {
                MessageBox.Show("You must enter a Garage customization", "Entry Error");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            lblList.Text = "";
            isDataSaved = true;
            cmbSizeOfTheGarage.Focus();
            Garage();
            cmbSizeOfTheGarage.SelectedIndex = 0;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClose(e);
        }

        private void FormClose(FormClosingEventArgs e)
        {
            if (lblList.Text == "" && cmbSizeOfTheGarage.SelectedIndex != -1)
            {
                string message1 = "Are you sure you want to close an application?";
                DialogResult button1 =
                    MessageBox.Show(message1, "Customer",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (button1 == DialogResult.Yes) { }
                if (button1 == DialogResult.No) { e.Cancel = true; }
            }
            else
            {
                if (isDataSaved == false)
                {
                    string message =
                        "This form contains unsaved data.\n\n" +
                        "Do you want to save it?";
                    DialogResult button =
                        MessageBox.Show(message, "Customer",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);
                    if (button == DialogResult.Yes)
                    {
                        if (IsValidData())
                            this.SaveData();
                        else
                            e.Cancel = true;
                    }
                    if (button == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(cmbSizeOfTheGarage.SelectedIndex != -1) { }
            else
            {
                Garage();
                cmbSizeOfTheGarage.SelectedIndex = 0;
            }
            lblList.Text = "";
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
