using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Organizer
{
    public partial class MainForm : Form
    {

        EventManager eventManager;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            cmbCoountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbCoountry.SelectedIndex = (int)Countries.Sverige;

            EmptyTextBoxesParticipant();
            EmptyTextBoxesEvent();
            lblNr.Text = "0.00";
            lblCost.Text = "0.00";
            lblFees.Text = "0.00";
            lblSurDef.Text = "0.00";

            lstParticipant.Items.Clear();

            grpAddParticipant.Enabled = false;

        }

        private void EmptyTextBoxesEvent()
        {
            txtTitle.Text = "";
            txtFeePerP.Text = "";
            txtCostPerP.Text = "";
        }

        private void EmptyTextBoxesParticipant()
        {
            txtCity.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStreet.Text = "";
            txtZip.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            lstParticipant.Items.Clear();
            CreateEvent();
            EmptyTextBoxesParticipant();
        }

        private void UpdateGUI()
        {
            EmptyTextBoxesParticipant();
            grpInfo.Text = eventManager.Title;
            string[] strInfo = eventManager.Participants.GetParticipantsInfo();

            if(strInfo != null)
            {
                lstParticipant.Items.Clear();
                lstParticipant.Items.AddRange(strInfo);
                lblNr.Text = lstParticipant.Items.Count.ToString();
            }
            double totalCost = eventManager.CalcTotalCost();
            lblCost.Text = totalCost.ToString("0.00");
            lblNr.Text = eventManager.Participants.Count.ToString();

            double totalFees = eventManager.CalcTotalFee();
            lblFees.Text = totalFees.ToString("0.00");
            lblSurDef.Text = (totalCost - totalFees).ToString("0.00");
        }

        private void CreateEvent()
        {
            eventManager = new EventManager();

            if (string.IsNullOrEmpty(txtTitle.Text))
                txtTitle.Text = "Untitle event";

            eventManager.Title = txtTitle.Text + " - By Amina Amin";

            this.Text = eventManager.Title;

            bool costAmountOk = ReadCostPerPerson();
            bool feeAmountOk = ReadFeePerPerson();

            if ((costAmountOk) && (feeAmountOk))
            {
                grpAddParticipant.Enabled = true;
                MessageBox.Show($"Event created!");
                UpdateGUI();
            }

        }


        private bool ReadFeePerPerson()
        {
            double amount = 0.0;
            bool ok = true;

            if (double.TryParse(txtFeePerP.Text, out amount) && (amount >= 0.00))
            {
                eventManager.FeePerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid fee amount. Please try again");
                ok = false;
             }
            return ok;
        }

        private bool ReadCostPerPerson()
        {
            double amount = 0.0;
            bool ok = true;

            if (double.TryParse(txtCostPerP.Text, out amount) && (amount >= 0.00))
            {
                eventManager.CostPerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid cost amount. Please try again");
                ok = false;
            }
            return ok;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant();
            if (ReadInput(ref participant))
            {
                UpdateGUI();
            }
        }


        private bool ReadInput(ref Participant participant)
        {
            bool ok = ReadParticipantData(ref participant);
            if (ok)
            {
                eventManager.Participants.AddParticipant(participant);
            }
            else
            {
                string strMessage = "First name, last name and city are required";
                MessageBox.Show(strMessage);
            }
            return ok;
        }

        private bool ReadParticipantData(ref Participant participant)
        {
            participant.FirstName = txtFirstName.Text;
            participant.LastName = txtLastName.Text;

            Address address = ReadAddress();

            participant.Address = address;
            bool ok = address.Validate();

            return ok;
        }


        private Address ReadAddress()
        {
            Address address = new Address();

            address.Street = txtStreet.Text;
            address.City = txtCity.Text;
            address.ZipCode = txtZip.Text;

            address.Country = (Countries)cmbCoountry.SelectedIndex;

            return address;
        }

        private bool ReadName(ref Participant participant)
        {
            //if (TrimNames())
            return true;
        }

        private void lstParticipant_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstParticipant.SelectedIndex;

            if(index >= 0)
            {
                Participant participant = eventManager.Participants.GetParticipantAt(index);

                txtFirstName.Text = participant.FirstName;
                txtLastName.Text = participant.LastName;
                txtStreet.Text = participant.Address.Street;
                txtCity.Text = participant.Address.City;
                txtZip.Text = participant.Address.ZipCode;

                cmbCoountry.SelectedIndex = (int)participant.Address.Country;
            }
            else
            {
                MessageBox.Show("Select an participant");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = lstParticipant.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Select a participant");
                return;
            }
            Participant participant = eventManager.Participants.GetParticipantAt(index);
            if (ReadParticipantData(ref participant))
            {
                eventManager.Participants.ChangeParticipantAt(participant, index);
                UpdateGUI();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstParticipant.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Select a participant");
                return;
            }
            Participant participant = eventManager.Participants.GetParticipantAt(index);
            if (ReadParticipantData(ref participant))
            {
                eventManager.Participants.DeleteParticipantAt(index);
                UpdateGUI();
            }
        }
    }
}
