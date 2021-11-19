using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventMamangement
{
    public partial class Form1 : Form
         
       
    {
        EventManager eventManager;
        public Form1()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void btncreateevent_Click(object sender, EventArgs e)
        {
            /// The Event should have been created successfully before
            /// reading the cost per capital or doing any other work
           EmptyTextBoxes(groupBox2);
            lstparticipants.Items.Clear();
            CreateEvent();
        }

        private void CreateEvent()
        {
            eventManager = new EventManager();
            if (string.IsNullOrEmpty(txttitle.Text))
                txttitle.Text = "Untitled Event";

            eventManager.Title = txttitle.Text;
            // title of the mainform
            this.Text =eventManager.Title;
            bool costAmountoK = ReadCostPerPerson();
            bool feeAmountoK = ReadFeePerPerson();
            
            if ((costAmountoK) && (feeAmountoK))
            {
                groupBox2.Enabled = true;
                MessageBox.Show($"Event createt!");
                UpdateGUI();
            }


        }
        private void InitializeGUI()
        {
            cmbcountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbcountry.SelectedIndex = (int)cmbcountry.SelectedIndex;

            EmptyTextBoxes(groupBox1);
            EmptyTextBoxes(groupBox2);

            // clear output controls
           txtnumofparticipant.Text = "0";
            txttotalcost.Text = "0.00";
            txttotalfees.Text = "0.00";
            txtprofit.Text = "0.00";
            lstparticipants.Items.Clear();

            /// Disable the add participant groupbox
            groupBox2.Enabled = false;
        }

        private bool ReadCostPerPerson()
        {
            double amount = 0.0;
            bool ok = true;

            if (double.TryParse(txtfeeperparticiapant.Text, out amount) && (amount >= 0.0))
            {
                eventManager.CostPerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid cost amount. please try again");
                ok = false;
            }
            return ok;

        }
        private bool ReadFeePerPerson()
        {
            double amount = 0.0;
            bool ok = true;
            if (double.TryParse(txtfeeperparticiapant.Text, out amount) && (amount >= 0.0))
            {
                eventManager.FeePerperson = amount;
            }
            else
            {
                MessageBox.Show("Invalid cost amount. please try again");
                ok = false;
            }
            return ok;
        }
        private void UpdateGUI()
        {
            string[] strInfo = eventManager.participants.GetParticipantsInfo();
            if (strInfo != null)
            {
                lstparticipants.Items.Clear();
                lstparticipants.Items.AddRange(strInfo);
                txtnumofparticipant.Text = lstparticipants.Items.Count.ToString();

            }
            double totalCost = eventManager.CalcTotalCost();
            txttotalcost.Text = totalCost.ToString("0.00");
            txtnumofparticipant.Text = eventManager.participants.Count.ToString();

            double totalFees = eventManager.CalculateTotalFees();
            txttotalfees.Text = totalFees.ToString("0.00");
            txtprofit.Text = (totalFees - totalCost).ToString("0.00");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant();
            if (ReadInput(ref participant))
            {
                UpdateGUI();
            }
        }

        private bool ReadInput(ref Participant partcipant)
        {
            bool ok = ReadParticipantData(ref partcipant);
            if (ok)
            {
                eventManager.participants.AddPartcipant(partcipant);
            }
            else
            {
                string strMessage = "First name, Last name and are required input";
                MessageBox.Show(strMessage);
            }
            return ok;
        }

        private bool ReadParticipantData(ref Participant partcipant)
        {
            ///Names and  address are validated in the participant class
            Participant participant = new Participant(); 
            partcipant.FirstName = txtfirstname.Text;
            partcipant. LastName  = txtlastname.Text;

            Address address = ReadAddress();

            //connect address to a participant  object
            partcipant.Address = address;
            bool ok = partcipant.Validate();
            return ok;
                 


        }
        private Address ReadAddress()
        {
            Address address = new Address();
            address.Street = txtstreet.Text;
            address.city = txtcity.Text;
            address.Zipcode = txtzipcode.Text;
            address.Country = (Countries)cmbcountry.SelectedIndex;
            return address;

        }

        private void lstparticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstparticipants.SelectedIndex;
            if (index >= 0)
            {
                Participant partcipant = eventManager.participants.GetParticipantAt(index);
                txtfirstname.Text = partcipant.FirstName;
                txtlastname.Text = partcipant.LastName;
                txtstreet.Text = partcipant.Address.Street;
                txtcity.Text = partcipant.Address.city;
                txtzipcode.Text = partcipant.Address.Zipcode;

                cmbcountry.SelectedIndex = (int)partcipant.Address.Country;
            }
            else
                MessageBox.Show("select an item");
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            int index = lstListBoxItemSelected();
            if (index < 0)
                return;
            Participant participant = eventManager.participants.GetParticipantAt(index);

            if(ReadParticipantData(ref participant))
            {
                eventManager.participants.ChangeParticipantAt(participant, index);
                UpdateGUI();

            }
        }
        private bool TrimName()
        {
            if ((!ValidateText(txtfirstname.Text)) || (!ValidateText(txtlastname.Text)))
                return false;

            txtfirstname.Text = txtfirstname.Text.Trim();
            txtlastname.Text=txtlastname.Text.Trim();
            return true;
        }

        private int lstListBoxItemSelected()
        {
            int index = lstparticipants.SelectedIndex;
            if (lstparticipants.SelectedIndex < 0)
            {
                MessageBox.Show("Select an Item in the list");
                return -1;
            }
            return lstparticipants.SelectedIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstListBoxItemSelected();
            if (index < 0)
                return ;
            eventManager.participants.DeleteParticipantAt(index);
            UpdateGUI();
        }
        public bool ValidateText(string text)
        {
            text = text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("please Provide both  first and lastname");
                return false;

              
            }
            return true;
        }
        private void EmptyTextBoxes(GroupBox groupBox)
        {
          groupBox.Text = String.Empty;
          
        }
        
    }
}
