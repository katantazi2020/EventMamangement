namespace EventMamangement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfeeperparticiapant = new System.Windows.Forms.TextBox();
            this.txtcostperparticipant = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.btncreateevent = new System.Windows.Forms.Button();
            this.lblfeeperparticpant = new System.Windows.Forms.Label();
            this.lblcostperparticipant = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbcountry = new System.Windows.Forms.ComboBox();
            this.txtzipcode = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblcountry = new System.Windows.Forms.Label();
            this.lblzipcode = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblstreet = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lstparticipants = new System.Windows.Forms.ListBox();
            this.lblparticipantlst = new System.Windows.Forms.Label();
            this.lbladdresslst = new System.Windows.Forms.Label();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpeventeconomy = new System.Windows.Forms.GroupBox();
            this.txtprofit = new System.Windows.Forms.TextBox();
            this.txttotalfees = new System.Windows.Forms.TextBox();
            this.txttotalcost = new System.Windows.Forms.TextBox();
            this.txtnumofparticipant = new System.Windows.Forms.TextBox();
            this.lblprofit = new System.Windows.Forms.Label();
            this.lbltotalfees = new System.Windows.Forms.Label();
            this.lbltotalcost = new System.Windows.Forms.Label();
            this.lblnumofParticipants = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpeventeconomy.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfeeperparticiapant);
            this.groupBox1.Controls.Add(this.txtcostperparticipant);
            this.groupBox1.Controls.Add(this.txttitle);
            this.groupBox1.Controls.Add(this.btncreateevent);
            this.groupBox1.Controls.Add(this.lblfeeperparticpant);
            this.groupBox1.Controls.Add(this.lblcostperparticipant);
            this.groupBox1.Controls.Add(this.lbltitle);
            this.groupBox1.Location = new System.Drawing.Point(33, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Event";
            // 
            // txtfeeperparticiapant
            // 
            this.txtfeeperparticiapant.Location = new System.Drawing.Point(209, 93);
            this.txtfeeperparticiapant.Name = "txtfeeperparticiapant";
            this.txtfeeperparticiapant.Size = new System.Drawing.Size(115, 26);
            this.txtfeeperparticiapant.TabIndex = 6;
            // 
            // txtcostperparticipant
            // 
            this.txtcostperparticipant.Location = new System.Drawing.Point(209, 61);
            this.txtcostperparticipant.Name = "txtcostperparticipant";
            this.txtcostperparticipant.Size = new System.Drawing.Size(115, 26);
            this.txtcostperparticipant.TabIndex = 5;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(173, 29);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(151, 26);
            this.txttitle.TabIndex = 4;
            // 
            // btncreateevent
            // 
            this.btncreateevent.Location = new System.Drawing.Point(88, 128);
            this.btncreateevent.Name = "btncreateevent";
            this.btncreateevent.Size = new System.Drawing.Size(116, 33);
            this.btncreateevent.TabIndex = 3;
            this.btncreateevent.Text = "Create Event";
            this.btncreateevent.UseVisualStyleBackColor = true;
            this.btncreateevent.Click += new System.EventHandler(this.btncreateevent_Click);
            // 
            // lblfeeperparticpant
            // 
            this.lblfeeperparticpant.AutoSize = true;
            this.lblfeeperparticpant.Location = new System.Drawing.Point(7, 94);
            this.lblfeeperparticpant.Name = "lblfeeperparticpant";
            this.lblfeeperparticpant.Size = new System.Drawing.Size(144, 20);
            this.lblfeeperparticpant.TabIndex = 2;
            this.lblfeeperparticpant.Text = "Fee Per Participant";
            // 
            // lblcostperparticipant
            // 
            this.lblcostperparticipant.AutoSize = true;
            this.lblcostperparticipant.Location = new System.Drawing.Point(6, 61);
            this.lblcostperparticipant.Name = "lblcostperparticipant";
            this.lblcostperparticipant.Size = new System.Drawing.Size(149, 20);
            this.lblcostperparticipant.TabIndex = 1;
            this.lblcostperparticipant.Text = "Cost Per Participant";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(7, 26);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(88, 20);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Event Tittle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbcountry);
            this.groupBox2.Controls.Add(this.txtzipcode);
            this.groupBox2.Controls.Add(this.txtcity);
            this.groupBox2.Controls.Add(this.txtstreet);
            this.groupBox2.Controls.Add(this.txtlastname);
            this.groupBox2.Controls.Add(this.txtfirstname);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.lblcountry);
            this.groupBox2.Controls.Add(this.lblzipcode);
            this.groupBox2.Controls.Add(this.lblcity);
            this.groupBox2.Controls.Add(this.lblstreet);
            this.groupBox2.Controls.Add(this.lbllastname);
            this.groupBox2.Controls.Add(this.lblfirstname);
            this.groupBox2.Location = new System.Drawing.Point(33, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Participant";
            // 
            // cmbcountry
            // 
            this.cmbcountry.FormattingEnabled = true;
            this.cmbcountry.Location = new System.Drawing.Point(100, 192);
            this.cmbcountry.Name = "cmbcountry";
            this.cmbcountry.Size = new System.Drawing.Size(224, 28);
            this.cmbcountry.TabIndex = 12;
            // 
            // txtzipcode
            // 
            this.txtzipcode.Location = new System.Drawing.Point(100, 159);
            this.txtzipcode.Name = "txtzipcode";
            this.txtzipcode.Size = new System.Drawing.Size(224, 26);
            this.txtzipcode.TabIndex = 11;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(100, 126);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(224, 26);
            this.txtcity.TabIndex = 10;
            // 
            // txtstreet
            // 
            this.txtstreet.Location = new System.Drawing.Point(100, 94);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(224, 26);
            this.txtstreet.TabIndex = 9;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(100, 62);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(224, 26);
            this.txtlastname.TabIndex = 8;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(100, 30);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(224, 26);
            this.txtfirstname.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(116, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Location = new System.Drawing.Point(7, 190);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(64, 20);
            this.lblcountry.TabIndex = 5;
            this.lblcountry.Text = "Country";
            // 
            // lblzipcode
            // 
            this.lblzipcode.AutoSize = true;
            this.lblzipcode.Location = new System.Drawing.Point(6, 159);
            this.lblzipcode.Name = "lblzipcode";
            this.lblzipcode.Size = new System.Drawing.Size(69, 20);
            this.lblzipcode.TabIndex = 4;
            this.lblzipcode.Text = "ZipCode";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(7, 126);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(35, 20);
            this.lblcity.TabIndex = 3;
            this.lblcity.Text = "City";
            // 
            // lblstreet
            // 
            this.lblstreet.AutoSize = true;
            this.lblstreet.Location = new System.Drawing.Point(7, 94);
            this.lblstreet.Name = "lblstreet";
            this.lblstreet.Size = new System.Drawing.Size(53, 20);
            this.lblstreet.TabIndex = 2;
            this.lblstreet.Text = "Street";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(6, 62);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(86, 20);
            this.lbllastname.TabIndex = 1;
            this.lbllastname.Text = "Last Name";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(7, 30);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(86, 20);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "First Name";
            // 
            // lstparticipants
            // 
            this.lstparticipants.FormattingEnabled = true;
            this.lstparticipants.ItemHeight = 20;
            this.lstparticipants.Location = new System.Drawing.Point(369, 43);
            this.lstparticipants.Name = "lstparticipants";
            this.lstparticipants.Size = new System.Drawing.Size(419, 164);
            this.lstparticipants.TabIndex = 2;
            this.lstparticipants.SelectedIndexChanged += new System.EventHandler(this.lstparticipants_SelectedIndexChanged);
            // 
            // lblparticipantlst
            // 
            this.lblparticipantlst.AutoSize = true;
            this.lblparticipantlst.Location = new System.Drawing.Point(384, 21);
            this.lblparticipantlst.Name = "lblparticipantlst";
            this.lblparticipantlst.Size = new System.Drawing.Size(84, 20);
            this.lblparticipantlst.TabIndex = 3;
            this.lblparticipantlst.Text = "Participant";
            // 
            // lbladdresslst
            // 
            this.lbladdresslst.AutoSize = true;
            this.lbladdresslst.Location = new System.Drawing.Point(673, 21);
            this.lbladdresslst.Name = "lbladdresslst";
            this.lbladdresslst.Size = new System.Drawing.Size(68, 20);
            this.lbladdresslst.TabIndex = 4;
            this.lbladdresslst.Text = "Address";
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(423, 213);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(75, 34);
            this.btnchange.TabIndex = 5;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(645, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpeventeconomy
            // 
            this.grpeventeconomy.Controls.Add(this.txtprofit);
            this.grpeventeconomy.Controls.Add(this.txttotalfees);
            this.grpeventeconomy.Controls.Add(this.txttotalcost);
            this.grpeventeconomy.Controls.Add(this.txtnumofparticipant);
            this.grpeventeconomy.Controls.Add(this.lblprofit);
            this.grpeventeconomy.Controls.Add(this.lbltotalfees);
            this.grpeventeconomy.Controls.Add(this.lbltotalcost);
            this.grpeventeconomy.Controls.Add(this.lblnumofParticipants);
            this.grpeventeconomy.Location = new System.Drawing.Point(369, 268);
            this.grpeventeconomy.Name = "grpeventeconomy";
            this.grpeventeconomy.Size = new System.Drawing.Size(419, 203);
            this.grpeventeconomy.TabIndex = 7;
            this.grpeventeconomy.TabStop = false;
            this.grpeventeconomy.Text = "Event Economy";
            // 
            // txtprofit
            // 
            this.txtprofit.Location = new System.Drawing.Point(208, 154);
            this.txtprofit.Name = "txtprofit";
            this.txtprofit.Size = new System.Drawing.Size(193, 26);
            this.txtprofit.TabIndex = 7;
            // 
            // txttotalfees
            // 
            this.txttotalfees.Location = new System.Drawing.Point(208, 105);
            this.txttotalfees.Name = "txttotalfees";
            this.txttotalfees.Size = new System.Drawing.Size(193, 26);
            this.txttotalfees.TabIndex = 6;
            // 
            // txttotalcost
            // 
            this.txttotalcost.Location = new System.Drawing.Point(208, 73);
            this.txttotalcost.Name = "txttotalcost";
            this.txttotalcost.Size = new System.Drawing.Size(193, 26);
            this.txttotalcost.TabIndex = 5;
            // 
            // txtnumofparticipant
            // 
            this.txtnumofparticipant.Location = new System.Drawing.Point(208, 38);
            this.txtnumofparticipant.Name = "txtnumofparticipant";
            this.txtnumofparticipant.Size = new System.Drawing.Size(193, 26);
            this.txtnumofparticipant.TabIndex = 4;
            // 
            // lblprofit
            // 
            this.lblprofit.AutoSize = true;
            this.lblprofit.Location = new System.Drawing.Point(26, 157);
            this.lblprofit.Name = "lblprofit";
            this.lblprofit.Size = new System.Drawing.Size(112, 20);
            this.lblprofit.TabIndex = 3;
            this.lblprofit.Text = "Surplus/Deficit";
            // 
            // lbltotalfees
            // 
            this.lbltotalfees.AutoSize = true;
            this.lbltotalfees.Location = new System.Drawing.Point(22, 117);
            this.lbltotalfees.Name = "lbltotalfees";
            this.lbltotalfees.Size = new System.Drawing.Size(84, 20);
            this.lbltotalfees.TabIndex = 2;
            this.lbltotalfees.Text = "Total Fees";
            // 
            // lbltotalcost
            // 
            this.lbltotalcost.AutoSize = true;
            this.lbltotalcost.Location = new System.Drawing.Point(22, 83);
            this.lbltotalcost.Name = "lbltotalcost";
            this.lbltotalcost.Size = new System.Drawing.Size(81, 20);
            this.lbltotalcost.TabIndex = 1;
            this.lbltotalcost.Text = "Total Cost";
            // 
            // lblnumofParticipants
            // 
            this.lblnumofParticipants.AutoSize = true;
            this.lblnumofParticipants.Location = new System.Drawing.Point(18, 40);
            this.lblnumofParticipants.Name = "lblnumofParticipants";
            this.lblnumofParticipants.Size = new System.Drawing.Size(170, 20);
            this.lblnumofParticipants.TabIndex = 0;
            this.lblnumofParticipants.Text = "Number of Participants";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.grpeventeconomy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.lbladdresslst);
            this.Controls.Add(this.lblparticipantlst);
            this.Controls.Add(this.lstparticipants);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpeventeconomy.ResumeLayout(false);
            this.grpeventeconomy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtfeeperparticiapant;
        private System.Windows.Forms.TextBox txtcostperparticipant;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Button btncreateevent;
        private System.Windows.Forms.Label lblfeeperparticpant;
        private System.Windows.Forms.Label lblcostperparticipant;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbcountry;
        private System.Windows.Forms.TextBox txtzipcode;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.Label lblzipcode;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblstreet;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.ListBox lstparticipants;
        private System.Windows.Forms.Label lblparticipantlst;
        private System.Windows.Forms.Label lbladdresslst;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpeventeconomy;
        private System.Windows.Forms.TextBox txtprofit;
        private System.Windows.Forms.TextBox txttotalfees;
        private System.Windows.Forms.TextBox txttotalcost;
        private System.Windows.Forms.TextBox txtnumofparticipant;
        private System.Windows.Forms.Label lblprofit;
        private System.Windows.Forms.Label lbltotalfees;
        private System.Windows.Forms.Label lbltotalcost;
        private System.Windows.Forms.Label lblnumofParticipants;
    }
}

