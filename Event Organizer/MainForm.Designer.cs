
namespace Event_Organizer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpNewEvent = new System.Windows.Forms.GroupBox();
            this.txtFeePerP = new System.Windows.Forms.TextBox();
            this.txtCostPerP = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpAddParticipant = new System.Windows.Forms.GroupBox();
            this.cmbCoountry = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblSurDef = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblNr = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lstParticipant = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpNewEvent.SuspendLayout();
            this.grpAddParticipant.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewEvent
            // 
            this.grpNewEvent.Controls.Add(this.txtFeePerP);
            this.grpNewEvent.Controls.Add(this.txtCostPerP);
            this.grpNewEvent.Controls.Add(this.txtTitle);
            this.grpNewEvent.Controls.Add(this.label3);
            this.grpNewEvent.Controls.Add(this.label2);
            this.grpNewEvent.Controls.Add(this.label1);
            this.grpNewEvent.Controls.Add(this.btnCreate);
            this.grpNewEvent.Location = new System.Drawing.Point(34, 12);
            this.grpNewEvent.Name = "grpNewEvent";
            this.grpNewEvent.Size = new System.Drawing.Size(308, 171);
            this.grpNewEvent.TabIndex = 0;
            this.grpNewEvent.TabStop = false;
            this.grpNewEvent.Text = "New Event";
            // 
            // txtFeePerP
            // 
            this.txtFeePerP.Location = new System.Drawing.Point(155, 95);
            this.txtFeePerP.Name = "txtFeePerP";
            this.txtFeePerP.Size = new System.Drawing.Size(125, 27);
            this.txtFeePerP.TabIndex = 6;
            // 
            // txtCostPerP
            // 
            this.txtCostPerP.Location = new System.Drawing.Point(155, 60);
            this.txtCostPerP.Name = "txtCostPerP";
            this.txtCostPerP.Size = new System.Drawing.Size(125, 27);
            this.txtCostPerP.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(155, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(125, 27);
            this.txtTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fee per participant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cost per participant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event life";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(82, 128);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(105, 29);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create event";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // grpAddParticipant
            // 
            this.grpAddParticipant.Controls.Add(this.cmbCoountry);
            this.grpAddParticipant.Controls.Add(this.btnAdd);
            this.grpAddParticipant.Controls.Add(this.txtZip);
            this.grpAddParticipant.Controls.Add(this.txtCity);
            this.grpAddParticipant.Controls.Add(this.txtStreet);
            this.grpAddParticipant.Controls.Add(this.label9);
            this.grpAddParticipant.Controls.Add(this.label8);
            this.grpAddParticipant.Controls.Add(this.label7);
            this.grpAddParticipant.Controls.Add(this.label6);
            this.grpAddParticipant.Controls.Add(this.label5);
            this.grpAddParticipant.Controls.Add(this.label4);
            this.grpAddParticipant.Controls.Add(this.txtLastName);
            this.grpAddParticipant.Controls.Add(this.txtFirstName);
            this.grpAddParticipant.Location = new System.Drawing.Point(34, 199);
            this.grpAddParticipant.Name = "grpAddParticipant";
            this.grpAddParticipant.Size = new System.Drawing.Size(308, 248);
            this.grpAddParticipant.TabIndex = 1;
            this.grpAddParticipant.TabStop = false;
            this.grpAddParticipant.Text = "Add participant";
            // 
            // cmbCoountry
            // 
            this.cmbCoountry.FormattingEnabled = true;
            this.cmbCoountry.Location = new System.Drawing.Point(119, 184);
            this.cmbCoountry.Name = "cmbCoountry";
            this.cmbCoountry.Size = new System.Drawing.Size(151, 28);
            this.cmbCoountry.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 26);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(119, 153);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(171, 27);
            this.txtZip.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(119, 122);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(171, 27);
            this.txtCity.TabIndex = 9;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(119, 90);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(171, 27);
            this.txtStreet.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Zip code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "LastName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "FirstName";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(119, 57);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(171, 27);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(119, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(171, 27);
            this.txtFirstName.TabIndex = 0;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblSurDef);
            this.grpInfo.Controls.Add(this.lblFees);
            this.grpInfo.Controls.Add(this.lblCost);
            this.grpInfo.Controls.Add(this.lblNr);
            this.grpInfo.Controls.Add(this.label13);
            this.grpInfo.Controls.Add(this.label12);
            this.grpInfo.Controls.Add(this.label11);
            this.grpInfo.Controls.Add(this.label10);
            this.grpInfo.ForeColor = System.Drawing.Color.Black;
            this.grpInfo.Location = new System.Drawing.Point(415, 261);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(434, 177);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Event economy";
            // 
            // lblSurDef
            // 
            this.lblSurDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSurDef.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSurDef.Location = new System.Drawing.Point(208, 147);
            this.lblSurDef.Name = "lblSurDef";
            this.lblSurDef.Size = new System.Drawing.Size(95, 20);
            this.lblSurDef.TabIndex = 11;
            // 
            // lblFees
            // 
            this.lblFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFees.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblFees.Location = new System.Drawing.Point(208, 108);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(95, 20);
            this.lblFees.TabIndex = 10;
            // 
            // lblCost
            // 
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCost.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCost.Location = new System.Drawing.Point(208, 75);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(95, 20);
            this.lblCost.TabIndex = 9;
            // 
            // lblNr
            // 
            this.lblNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNr.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNr.Location = new System.Drawing.Point(208, 39);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(95, 19);
            this.lblNr.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.ForestGreen;
            this.label13.Location = new System.Drawing.Point(7, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Surplus/deficit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.ForestGreen;
            this.label12.Location = new System.Drawing.Point(7, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Total fees";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(7, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Total Cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(7, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Number of participants";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(476, 216);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(94, 29);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(704, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(415, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Participant";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(556, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Address";
            // 
            // lstParticipant
            // 
            this.lstParticipant.FormattingEnabled = true;
            this.lstParticipant.ItemHeight = 20;
            this.lstParticipant.Location = new System.Drawing.Point(372, 39);
            this.lstParticipant.Name = "lstParticipant";
            this.lstParticipant.Size = new System.Drawing.Size(554, 164);
            this.lstParticipant.TabIndex = 15;
            this.lstParticipant.SelectedIndexChanged += new System.EventHandler(this.lstParticipant_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.lstParticipant);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpAddParticipant);
            this.Controls.Add(this.grpNewEvent);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.grpNewEvent.ResumeLayout(false);
            this.grpNewEvent.PerformLayout();
            this.grpAddParticipant.ResumeLayout(false);
            this.grpAddParticipant.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewEvent;
        private System.Windows.Forms.GroupBox grpAddParticipant;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFeePerP;
        private System.Windows.Forms.TextBox txtCostPerP;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSurDef;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox lstParticipant;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbCoountry;
        private System.Windows.Forms.GroupBox grpInfo;
    }
}

