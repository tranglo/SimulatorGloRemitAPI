
using CG = System.Configuration.ConfigurationManager;

namespace Simulator_GloRemitNew_API_Form
{
    partial class SimulatorForm
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
            this.components = new System.ComponentModel.Container();
            this.btnInvoke = new System.Windows.Forms.Button();
            this.richTxtBoxStatus = new System.Windows.Forms.RichTextBox();
            this.rdbtnDoTransfer = new System.Windows.Forms.RadioButton();
            this.rdbtnGetValidation = new System.Windows.Forms.RadioButton();
            this.gbMethod = new System.Windows.Forms.GroupBox();
            this.rdbtnDoChangeName = new System.Windows.Forms.RadioButton();
            this.rdbtnDoCancel = new System.Windows.Forms.RadioButton();
            this.rdbtnGetTrxStatus = new System.Windows.Forms.RadioButton();
            this.rdbtnDoBillInquiry = new System.Windows.Forms.RadioButton();
            this.rdbtnDoBillPayment = new System.Windows.Forms.RadioButton();
            this.gbEnvironment = new System.Windows.Forms.GroupBox();
            this.rdbtnStaging = new System.Windows.Forms.RadioButton();
            this.label32 = new System.Windows.Forms.Label();
            this.txtRSPID = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtbSecretKey = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.tbFunctions = new System.Windows.Forms.TabControl();
            this.tbDoTransfer = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtb_payoutid = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtb_payoutpin = new System.Windows.Forms.TextBox();
            this.txtbTransid = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtBRegencyCode = new System.Windows.Forms.TextBox();
            this.txtSCountry = new System.Windows.Forms.TextBox();
            this.txtSCurrency = new System.Windows.Forms.TextBox();
            this.txtBCountry = new System.Windows.Forms.TextBox();
            this.txtBCurrency = new System.Windows.Forms.TextBox();
            this.txtBProvinceCode = new System.Windows.Forms.TextBox();
            this.txtSenderDOB = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtPurposeCode = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtbBeneEmail = new System.Windows.Forms.TextBox();
            this.txtbBenePostcode = new System.Windows.Forms.TextBox();
            this.txtbBeneCity = new System.Windows.Forms.TextBox();
            this.txtbBeneAdd = new System.Windows.Forms.TextBox();
            this.txtbSenderEmail = new System.Windows.Forms.TextBox();
            this.txtbSenderPostcode = new System.Windows.Forms.TextBox();
            this.txtbSenderCity = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtbSenderAdd = new System.Windows.Forms.TextBox();
            this.txtBSenderHPNo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBHPNo = new System.Windows.Forms.TextBox();
            this.lblBeneHP = new System.Windows.Forms.Label();
            this.txtRelationship = new System.Windows.Forms.TextBox();
            this.txtBIdNumber = new System.Windows.Forms.TextBox();
            this.txtBLastName = new System.Windows.Forms.TextBox();
            this.txtBFirstName = new System.Windows.Forms.TextBox();
            this.txtSFundSource = new System.Windows.Forms.TextBox();
            this.txtSOccupation = new System.Windows.Forms.TextBox();
            this.txtSIdNumber = new System.Windows.Forms.TextBox();
            this.txtSLastName = new System.Windows.Forms.TextBox();
            this.txtSFirstName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTrxnChannel = new System.Windows.Forms.ComboBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.txtBranchCode = new System.Windows.Forms.TextBox();
            this.txtIssuerCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGetValidation = new System.Windows.Forms.TabPage();
            this.label64 = new System.Windows.Forms.Label();
            this.cmbValidateBAcctType = new System.Windows.Forms.ComboBox();
            this.txtValidateTrxValue = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.txtValidateBAcctNumber = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.txtValidateBIssuerCode = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.txtValidateBCountry = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.txtValidateBLastName = new System.Windows.Forms.TextBox();
            this.txtValidateBFirstName = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.txtValidateSLastName = new System.Windows.Forms.TextBox();
            this.txtValidateSFirstName = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.txtValidateSIdNumber = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.tbGetTrxStatusDoCancellation = new System.Windows.Forms.TabPage();
            this.txtbTrangloGTN = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tbChangeName = new System.Windows.Forms.TabPage();
            this.txtCNBeneLastName = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.txtCNBeneFirstName = new System.Windows.Forms.TextBox();
            this.txtCNGTN = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.tbBillPayment = new System.Windows.Forms.TabPage();
            this.txtBillPaymentBAccountNum = new System.Windows.Forms.TextBox();
            this.txtBillPaymentBIsuserCode = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.txtBillPaymentBAmount = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.txtBillPaymentBCountry = new System.Windows.Forms.TextBox();
            this.txtBillPaymentBCurrency = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.txtBillPaymentSCountry = new System.Windows.Forms.TextBox();
            this.txtBillPaymentSCurrency = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.txtBillPaymentSContactNum = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtBillPaymentSEmail = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.txtBillPaymentSIdNum = new System.Windows.Forms.TextBox();
            this.txtBillPaymentSLastName = new System.Windows.Forms.TextBox();
            this.txtBillPaymentSFirstName = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.txtCustomInfo4 = new System.Windows.Forms.TextBox();
            this.txtCustomInfo3 = new System.Windows.Forms.TextBox();
            this.txtCustomInfo2 = new System.Windows.Forms.TextBox();
            this.txtCustomInfo1 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.txtBillDueDate = new System.Windows.Forms.TextBox();
            this.txtBillType = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtBillAccName = new System.Windows.Forms.TextBox();
            this.txtBillStatementDate = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tbBillInquiry = new System.Windows.Forms.TabPage();
            this.txtBillInquiryBAcctNum = new System.Windows.Forms.TextBox();
            this.txtBillInquiryBIssuerCode = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.txtBillInquiryBCountry = new System.Windows.Forms.TextBox();
            this.txtBillInquiryBCurrency = new System.Windows.Forms.TextBox();
            this.txtBillInquiryBAmount = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBillInquirySLastName = new System.Windows.Forms.TextBox();
            this.txtBillInquirySFirstName = new System.Windows.Forms.TextBox();
            this.txtBillInquirySIdNum = new System.Windows.Forms.Label();
            this.toolTipFeature = new System.Windows.Forms.ToolTip(this.components);
            this.gbMethod.SuspendLayout();
            this.gbEnvironment.SuspendLayout();
            this.tbFunctions.SuspendLayout();
            this.tbDoTransfer.SuspendLayout();
            this.tbGetValidation.SuspendLayout();
            this.tbGetTrxStatusDoCancellation.SuspendLayout();
            this.tbChangeName.SuspendLayout();
            this.tbBillPayment.SuspendLayout();
            this.tbBillInquiry.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInvoke
            // 
            this.btnInvoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoke.Location = new System.Drawing.Point(826, 488);
            this.btnInvoke.Name = "btnInvoke";
            this.btnInvoke.Size = new System.Drawing.Size(130, 52);
            this.btnInvoke.TabIndex = 0;
            this.btnInvoke.Text = "Invoke";
            this.toolTipFeature.SetToolTip(this.btnInvoke, "Invoke the function call.");
            this.btnInvoke.UseVisualStyleBackColor = true;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
            // 
            // richTxtBoxStatus
            // 
            this.richTxtBoxStatus.BackColor = System.Drawing.Color.Linen;
            this.richTxtBoxStatus.EnableAutoDragDrop = true;
            this.richTxtBoxStatus.Location = new System.Drawing.Point(729, 4);
            this.richTxtBoxStatus.Name = "richTxtBoxStatus";
            this.richTxtBoxStatus.ReadOnly = true;
            this.richTxtBoxStatus.Size = new System.Drawing.Size(227, 478);
            this.richTxtBoxStatus.TabIndex = 1;
            this.richTxtBoxStatus.Text = "";
            // 
            // rdbtnDoTransfer
            // 
            this.rdbtnDoTransfer.AutoSize = true;
            this.rdbtnDoTransfer.Checked = true;
            this.rdbtnDoTransfer.Location = new System.Drawing.Point(3, 18);
            this.rdbtnDoTransfer.Name = "rdbtnDoTransfer";
            this.rdbtnDoTransfer.Size = new System.Drawing.Size(84, 17);
            this.rdbtnDoTransfer.TabIndex = 28;
            this.rdbtnDoTransfer.TabStop = true;
            this.rdbtnDoTransfer.Text = "Do_Transfer";
            this.toolTipFeature.SetToolTip(this.rdbtnDoTransfer, "Select \"Do Transfer\" function.");
            this.rdbtnDoTransfer.UseVisualStyleBackColor = true;
            // 
            // rdbtnGetValidation
            // 
            this.rdbtnGetValidation.AutoSize = true;
            this.rdbtnGetValidation.Location = new System.Drawing.Point(92, 18);
            this.rdbtnGetValidation.Name = "rdbtnGetValidation";
            this.rdbtnGetValidation.Size = new System.Drawing.Size(94, 17);
            this.rdbtnGetValidation.TabIndex = 29;
            this.rdbtnGetValidation.Text = "Get_Validation";
            this.toolTipFeature.SetToolTip(this.rdbtnGetValidation, "Select \"Get Account Validation\" function.");
            this.rdbtnGetValidation.UseVisualStyleBackColor = true;
            // 
            // gbMethod
            // 
            this.gbMethod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbMethod.Controls.Add(this.rdbtnDoChangeName);
            this.gbMethod.Controls.Add(this.rdbtnDoCancel);
            this.gbMethod.Controls.Add(this.rdbtnGetTrxStatus);
            this.gbMethod.Controls.Add(this.rdbtnDoBillInquiry);
            this.gbMethod.Controls.Add(this.rdbtnDoBillPayment);
            this.gbMethod.Controls.Add(this.rdbtnGetValidation);
            this.gbMethod.Controls.Add(this.rdbtnDoTransfer);
            this.gbMethod.Location = new System.Drawing.Point(9, 488);
            this.gbMethod.Name = "gbMethod";
            this.gbMethod.Size = new System.Drawing.Size(718, 52);
            this.gbMethod.TabIndex = 30;
            this.gbMethod.TabStop = false;
            this.gbMethod.Text = "Method";
            // 
            // rdbtnDoChangeName
            // 
            this.rdbtnDoChangeName.AutoSize = true;
            this.rdbtnDoChangeName.Location = new System.Drawing.Point(596, 18);
            this.rdbtnDoChangeName.Name = "rdbtnDoChangeName";
            this.rdbtnDoChangeName.Size = new System.Drawing.Size(110, 17);
            this.rdbtnDoChangeName.TabIndex = 34;
            this.rdbtnDoChangeName.Text = "Do_ChangeName";
            this.toolTipFeature.SetToolTip(this.rdbtnDoChangeName, "Select \"Change Name\" function.");
            this.rdbtnDoChangeName.UseVisualStyleBackColor = true;
            // 
            // rdbtnDoCancel
            // 
            this.rdbtnDoCancel.AutoSize = true;
            this.rdbtnDoCancel.Location = new System.Drawing.Point(488, 18);
            this.rdbtnDoCancel.Name = "rdbtnDoCancel";
            this.rdbtnDoCancel.Size = new System.Drawing.Size(103, 17);
            this.rdbtnDoCancel.TabIndex = 33;
            this.rdbtnDoCancel.Text = "Do_Cancellation";
            this.toolTipFeature.SetToolTip(this.rdbtnDoCancel, "Select \"Transaction Cancellation\" function.");
            this.rdbtnDoCancel.UseVisualStyleBackColor = true;
            // 
            // rdbtnGetTrxStatus
            // 
            this.rdbtnGetTrxStatus.AutoSize = true;
            this.rdbtnGetTrxStatus.Location = new System.Drawing.Point(390, 18);
            this.rdbtnGetTrxStatus.Name = "rdbtnGetTrxStatus";
            this.rdbtnGetTrxStatus.Size = new System.Drawing.Size(93, 17);
            this.rdbtnGetTrxStatus.TabIndex = 32;
            this.rdbtnGetTrxStatus.Text = "Get_TrxStatus";
            this.toolTipFeature.SetToolTip(this.rdbtnGetTrxStatus, "Select \"Get Transaction Status\" function.");
            this.rdbtnGetTrxStatus.UseVisualStyleBackColor = true;
            // 
            // rdbtnDoBillInquiry
            // 
            this.rdbtnDoBillInquiry.AutoSize = true;
            this.rdbtnDoBillInquiry.Location = new System.Drawing.Point(296, 18);
            this.rdbtnDoBillInquiry.Name = "rdbtnDoBillInquiry";
            this.rdbtnDoBillInquiry.Size = new System.Drawing.Size(89, 17);
            this.rdbtnDoBillInquiry.TabIndex = 31;
            this.rdbtnDoBillInquiry.Text = "Do_BillInquiry";
            this.toolTipFeature.SetToolTip(this.rdbtnDoBillInquiry, "Select \"Bill Inquiry\" function.");
            this.rdbtnDoBillInquiry.UseVisualStyleBackColor = true;
            // 
            // rdbtnDoBillPayment
            // 
            this.rdbtnDoBillPayment.AutoSize = true;
            this.rdbtnDoBillPayment.Location = new System.Drawing.Point(191, 18);
            this.rdbtnDoBillPayment.Name = "rdbtnDoBillPayment";
            this.rdbtnDoBillPayment.Size = new System.Drawing.Size(99, 17);
            this.rdbtnDoBillPayment.TabIndex = 30;
            this.rdbtnDoBillPayment.Text = "Do_BillPayment";
            this.toolTipFeature.SetToolTip(this.rdbtnDoBillPayment, "Select \"Bill Payment\" function.");
            this.rdbtnDoBillPayment.UseVisualStyleBackColor = true;
            // 
            // gbEnvironment
            // 
            this.gbEnvironment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbEnvironment.Controls.Add(this.rdbtnStaging);
            this.gbEnvironment.Location = new System.Drawing.Point(733, 488);
            this.gbEnvironment.Name = "gbEnvironment";
            this.gbEnvironment.Size = new System.Drawing.Size(87, 52);
            this.gbEnvironment.TabIndex = 77;
            this.gbEnvironment.TabStop = false;
            this.gbEnvironment.Text = "Environment";
            // 
            // rdbtnStaging
            // 
            this.rdbtnStaging.AutoSize = true;
            this.rdbtnStaging.Checked = true;
            this.rdbtnStaging.Location = new System.Drawing.Point(14, 19);
            this.rdbtnStaging.Name = "rdbtnStaging";
            this.rdbtnStaging.Size = new System.Drawing.Size(61, 17);
            this.rdbtnStaging.TabIndex = 28;
            this.rdbtnStaging.TabStop = true;
            this.rdbtnStaging.Text = "Staging";
            this.toolTipFeature.SetToolTip(this.rdbtnStaging, "Staging environment is selected.");
            this.rdbtnStaging.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 16);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 13);
            this.label32.TabIndex = 78;
            this.label32.Text = "RSPID";
            // 
            // txtRSPID
            // 
            this.txtRSPID.Location = new System.Drawing.Point(51, 13);
            this.txtRSPID.Name = "txtRSPID";
            this.txtRSPID.Size = new System.Drawing.Size(124, 20);
            this.txtRSPID.TabIndex = 1;
            this.txtRSPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtRSPID, "Enter \"RSP User Id\". ");
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(235, 13);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(116, 20);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(179, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 13);
            this.label33.TabIndex = 80;
            this.label33.Text = "Password";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(354, 16);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(56, 13);
            this.label34.TabIndex = 83;
            this.label34.Text = "SecretKey";
            // 
            // txtbSecretKey
            // 
            this.txtbSecretKey.Location = new System.Drawing.Point(412, 12);
            this.txtbSecretKey.Name = "txtbSecretKey";
            this.txtbSecretKey.Size = new System.Drawing.Size(180, 20);
            this.txtbSecretKey.TabIndex = 3;
            this.txtbSecretKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(600, 13);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(110, 23);
            this.btnReload.TabIndex = 88;
            this.btnReload.Text = "Restore Credential";
            this.toolTipFeature.SetToolTip(this.btnReload, "Restore credential from configuration file.");
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // tbFunctions
            // 
            this.tbFunctions.Controls.Add(this.tbDoTransfer);
            this.tbFunctions.Controls.Add(this.tbGetValidation);
            this.tbFunctions.Controls.Add(this.tbGetTrxStatusDoCancellation);
            this.tbFunctions.Controls.Add(this.tbChangeName);
            this.tbFunctions.Controls.Add(this.tbBillPayment);
            this.tbFunctions.Controls.Add(this.tbBillInquiry);
            this.tbFunctions.Location = new System.Drawing.Point(9, 40);
            this.tbFunctions.Name = "tbFunctions";
            this.tbFunctions.SelectedIndex = 0;
            this.tbFunctions.Size = new System.Drawing.Size(718, 442);
            this.tbFunctions.TabIndex = 112;
            this.tbFunctions.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbFunctions_Selected);
            // 
            // tbDoTransfer
            // 
            this.tbDoTransfer.Controls.Add(this.label11);
            this.tbDoTransfer.Controls.Add(this.label10);
            this.tbDoTransfer.Controls.Add(this.txtb_payoutid);
            this.tbDoTransfer.Controls.Add(this.label30);
            this.tbDoTransfer.Controls.Add(this.label31);
            this.tbDoTransfer.Controls.Add(this.txtb_payoutpin);
            this.tbDoTransfer.Controls.Add(this.txtbTransid);
            this.tbDoTransfer.Controls.Add(this.label36);
            this.tbDoTransfer.Controls.Add(this.txtBRegencyCode);
            this.tbDoTransfer.Controls.Add(this.txtSCountry);
            this.tbDoTransfer.Controls.Add(this.txtSCurrency);
            this.tbDoTransfer.Controls.Add(this.txtBCountry);
            this.tbDoTransfer.Controls.Add(this.txtBCurrency);
            this.tbDoTransfer.Controls.Add(this.txtBProvinceCode);
            this.tbDoTransfer.Controls.Add(this.txtSenderDOB);
            this.tbDoTransfer.Controls.Add(this.label39);
            this.tbDoTransfer.Controls.Add(this.label38);
            this.tbDoTransfer.Controls.Add(this.txtPurposeCode);
            this.tbDoTransfer.Controls.Add(this.label37);
            this.tbDoTransfer.Controls.Add(this.txtbBeneEmail);
            this.tbDoTransfer.Controls.Add(this.txtbBenePostcode);
            this.tbDoTransfer.Controls.Add(this.txtbBeneCity);
            this.tbDoTransfer.Controls.Add(this.txtbBeneAdd);
            this.tbDoTransfer.Controls.Add(this.txtbSenderEmail);
            this.tbDoTransfer.Controls.Add(this.txtbSenderPostcode);
            this.tbDoTransfer.Controls.Add(this.txtbSenderCity);
            this.tbDoTransfer.Controls.Add(this.label26);
            this.tbDoTransfer.Controls.Add(this.label27);
            this.tbDoTransfer.Controls.Add(this.label28);
            this.tbDoTransfer.Controls.Add(this.label29);
            this.tbDoTransfer.Controls.Add(this.label25);
            this.tbDoTransfer.Controls.Add(this.label24);
            this.tbDoTransfer.Controls.Add(this.label23);
            this.tbDoTransfer.Controls.Add(this.label21);
            this.tbDoTransfer.Controls.Add(this.txtbSenderAdd);
            this.tbDoTransfer.Controls.Add(this.txtBSenderHPNo);
            this.tbDoTransfer.Controls.Add(this.label22);
            this.tbDoTransfer.Controls.Add(this.txtBHPNo);
            this.tbDoTransfer.Controls.Add(this.lblBeneHP);
            this.tbDoTransfer.Controls.Add(this.txtRelationship);
            this.tbDoTransfer.Controls.Add(this.txtBIdNumber);
            this.tbDoTransfer.Controls.Add(this.txtBLastName);
            this.tbDoTransfer.Controls.Add(this.txtBFirstName);
            this.tbDoTransfer.Controls.Add(this.txtSFundSource);
            this.tbDoTransfer.Controls.Add(this.txtSOccupation);
            this.tbDoTransfer.Controls.Add(this.txtSIdNumber);
            this.tbDoTransfer.Controls.Add(this.txtSLastName);
            this.tbDoTransfer.Controls.Add(this.txtSFirstName);
            this.tbDoTransfer.Controls.Add(this.label20);
            this.tbDoTransfer.Controls.Add(this.label19);
            this.tbDoTransfer.Controls.Add(this.label18);
            this.tbDoTransfer.Controls.Add(this.label16);
            this.tbDoTransfer.Controls.Add(this.label17);
            this.tbDoTransfer.Controls.Add(this.label15);
            this.tbDoTransfer.Controls.Add(this.label14);
            this.tbDoTransfer.Controls.Add(this.label13);
            this.tbDoTransfer.Controls.Add(this.label12);
            this.tbDoTransfer.Controls.Add(this.label9);
            this.tbDoTransfer.Controls.Add(this.cmbTrxnChannel);
            this.tbDoTransfer.Controls.Add(this.txtAmt);
            this.tbDoTransfer.Controls.Add(this.txtAccNum);
            this.tbDoTransfer.Controls.Add(this.txtBranchCode);
            this.tbDoTransfer.Controls.Add(this.txtIssuerCode);
            this.tbDoTransfer.Controls.Add(this.label8);
            this.tbDoTransfer.Controls.Add(this.label7);
            this.tbDoTransfer.Controls.Add(this.label6);
            this.tbDoTransfer.Controls.Add(this.label5);
            this.tbDoTransfer.Controls.Add(this.label4);
            this.tbDoTransfer.Controls.Add(this.label3);
            this.tbDoTransfer.Controls.Add(this.label2);
            this.tbDoTransfer.Controls.Add(this.label1);
            this.tbDoTransfer.Location = new System.Drawing.Point(4, 22);
            this.tbDoTransfer.Name = "tbDoTransfer";
            this.tbDoTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tbDoTransfer.Size = new System.Drawing.Size(710, 416);
            this.tbDoTransfer.TabIndex = 0;
            this.tbDoTransfer.Text = "Do_Transfer";
            this.tbDoTransfer.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 184;
            this.label11.Text = "sLastName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 180;
            this.label10.Text = "sFirstName";
            // 
            // txtb_payoutid
            // 
            this.txtb_payoutid.Location = new System.Drawing.Point(570, 195);
            this.txtb_payoutid.Name = "txtb_payoutid";
            this.txtb_payoutid.Size = new System.Drawing.Size(129, 20);
            this.txtb_payoutid.TabIndex = 135;
            this.txtb_payoutid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(465, 198);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(76, 13);
            this.label30.TabIndex = 177;
            this.label30.Text = "BenePayoutID";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(466, 228);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(80, 13);
            this.label31.TabIndex = 178;
            this.label31.Text = "BenePayoutPin";
            // 
            // txtb_payoutpin
            // 
            this.txtb_payoutpin.Location = new System.Drawing.Point(570, 224);
            this.txtb_payoutpin.Name = "txtb_payoutpin";
            this.txtb_payoutpin.Size = new System.Drawing.Size(129, 20);
            this.txtb_payoutpin.TabIndex = 136;
            this.txtb_payoutpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbTransid
            // 
            this.txtbTransid.Location = new System.Drawing.Point(570, 255);
            this.txtbTransid.Name = "txtbTransid";
            this.txtbTransid.Size = new System.Drawing.Size(129, 20);
            this.txtbTransid.TabIndex = 163;
            this.txtbTransid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtbTransid, "Custom RSP Transaction ID");
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(466, 258);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(86, 13);
            this.label36.TabIndex = 179;
            this.label36.Text = "Custom Trans ID";
            this.toolTipFeature.SetToolTip(this.label36, "Custom RSP Transaction ID");
            // 
            // txtBRegencyCode
            // 
            this.txtBRegencyCode.Location = new System.Drawing.Point(570, 15);
            this.txtBRegencyCode.Name = "txtBRegencyCode";
            this.txtBRegencyCode.Size = new System.Drawing.Size(127, 20);
            this.txtBRegencyCode.TabIndex = 151;
            this.txtBRegencyCode.Text = "0191";
            this.txtBRegencyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSCountry
            // 
            this.txtSCountry.Location = new System.Drawing.Point(570, 75);
            this.txtSCountry.Name = "txtSCountry";
            this.txtSCountry.Size = new System.Drawing.Size(127, 20);
            this.txtSCountry.TabIndex = 155;
            this.txtSCountry.Text = "MY";
            this.txtSCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSCurrency
            // 
            this.txtSCurrency.Location = new System.Drawing.Point(570, 105);
            this.txtSCurrency.Name = "txtSCurrency";
            this.txtSCurrency.Size = new System.Drawing.Size(127, 20);
            this.txtSCurrency.TabIndex = 156;
            this.txtSCurrency.Text = "MYR";
            this.txtSCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBCountry
            // 
            this.txtBCountry.Location = new System.Drawing.Point(570, 135);
            this.txtBCountry.Name = "txtBCountry";
            this.txtBCountry.Size = new System.Drawing.Size(127, 20);
            this.txtBCountry.TabIndex = 159;
            this.txtBCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtBCountry, "Beneficiary\'s Country Code");
            // 
            // txtBCurrency
            // 
            this.txtBCurrency.Location = new System.Drawing.Point(570, 165);
            this.txtBCurrency.Name = "txtBCurrency";
            this.txtBCurrency.Size = new System.Drawing.Size(127, 20);
            this.txtBCurrency.TabIndex = 160;
            this.txtBCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtBCurrency, "Beneficiary\'s Currency Code");
            // 
            // txtBProvinceCode
            // 
            this.txtBProvinceCode.Location = new System.Drawing.Point(570, 45);
            this.txtBProvinceCode.Name = "txtBProvinceCode";
            this.txtBProvinceCode.Size = new System.Drawing.Size(127, 20);
            this.txtBProvinceCode.TabIndex = 152;
            this.txtBProvinceCode.Text = "0100";
            this.txtBProvinceCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSenderDOB
            // 
            this.txtSenderDOB.Location = new System.Drawing.Point(97, 375);
            this.txtSenderDOB.Name = "txtSenderDOB";
            this.txtSenderDOB.Size = new System.Drawing.Size(129, 20);
            this.txtSenderDOB.TabIndex = 133;
            this.txtSenderDOB.Text = "28/02/1999";
            this.txtSenderDOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(16, 384);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(71, 13);
            this.label39.TabIndex = 183;
            this.label39.Text = "(dd/mm/yyyy)";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(10, 371);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(67, 13);
            this.label38.TabIndex = 182;
            this.label38.Text = "Sender DOB";
            // 
            // txtPurposeCode
            // 
            this.txtPurposeCode.Location = new System.Drawing.Point(97, 345);
            this.txtPurposeCode.Name = "txtPurposeCode";
            this.txtPurposeCode.Size = new System.Drawing.Size(129, 20);
            this.txtPurposeCode.TabIndex = 132;
            this.txtPurposeCode.Text = "99999";
            this.txtPurposeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(10, 344);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(71, 13);
            this.label37.TabIndex = 181;
            this.label37.Text = "PurposeCode";
            this.toolTipFeature.SetToolTip(this.label37, "Purpose of the Transaction");
            // 
            // txtbBeneEmail
            // 
            this.txtbBeneEmail.Location = new System.Drawing.Point(337, 225);
            this.txtbBeneEmail.Name = "txtbBeneEmail";
            this.txtbBeneEmail.Size = new System.Drawing.Size(117, 20);
            this.txtbBeneEmail.TabIndex = 145;
            this.txtbBeneEmail.Text = "bEmail@gmail.com";
            this.txtbBeneEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtbBeneEmail, "Beneficiary\'s Email ");
            // 
            // txtbBenePostcode
            // 
            this.txtbBenePostcode.Location = new System.Drawing.Point(337, 195);
            this.txtbBenePostcode.Name = "txtbBenePostcode";
            this.txtbBenePostcode.Size = new System.Drawing.Size(117, 20);
            this.txtbBenePostcode.TabIndex = 144;
            this.txtbBenePostcode.Text = "79600";
            this.txtbBenePostcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtbBenePostcode, "Beneficiary\'s Post Code");
            // 
            // txtbBeneCity
            // 
            this.txtbBeneCity.Location = new System.Drawing.Point(337, 165);
            this.txtbBeneCity.Name = "txtbBeneCity";
            this.txtbBeneCity.Size = new System.Drawing.Size(117, 20);
            this.txtbBeneCity.TabIndex = 142;
            this.txtbBeneCity.Text = "KL";
            this.txtbBeneCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtbBeneCity, "Beneficiary\'s City");
            // 
            // txtbBeneAdd
            // 
            this.txtbBeneAdd.Location = new System.Drawing.Point(337, 135);
            this.txtbBeneAdd.Name = "txtbBeneAdd";
            this.txtbBeneAdd.Size = new System.Drawing.Size(117, 20);
            this.txtbBeneAdd.TabIndex = 141;
            this.txtbBeneAdd.Text = "Place";
            this.txtbBeneAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtbBeneAdd, "Beneficiary\'s Address");
            // 
            // txtbSenderEmail
            // 
            this.txtbSenderEmail.Location = new System.Drawing.Point(97, 225);
            this.txtbSenderEmail.Name = "txtbSenderEmail";
            this.txtbSenderEmail.Size = new System.Drawing.Size(129, 20);
            this.txtbSenderEmail.TabIndex = 123;
            this.txtbSenderEmail.Text = "sEmail@gmail.com";
            this.txtbSenderEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbSenderPostcode
            // 
            this.txtbSenderPostcode.Location = new System.Drawing.Point(97, 195);
            this.txtbSenderPostcode.Name = "txtbSenderPostcode";
            this.txtbSenderPostcode.Size = new System.Drawing.Size(129, 20);
            this.txtbSenderPostcode.TabIndex = 122;
            this.txtbSenderPostcode.Text = "79600";
            this.txtbSenderPostcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtbSenderPostcode, "Sender’s address postcode");
            // 
            // txtbSenderCity
            // 
            this.txtbSenderCity.Location = new System.Drawing.Point(97, 165);
            this.txtbSenderCity.Name = "txtbSenderCity";
            this.txtbSenderCity.Size = new System.Drawing.Size(129, 20);
            this.txtbSenderCity.TabIndex = 119;
            this.txtbSenderCity.Text = "KL";
            this.txtbSenderCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtbSenderCity, "Sender’s resident city");
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(241, 228);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 176;
            this.label26.Text = "bEmail";
            this.toolTipFeature.SetToolTip(this.label26, "Beneficiary\'s Email ");
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(241, 198);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 13);
            this.label27.TabIndex = 175;
            this.label27.Text = "bPostCode";
            this.toolTipFeature.SetToolTip(this.label27, "Beneficiary\'s Post Code");
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(241, 168);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(30, 13);
            this.label28.TabIndex = 174;
            this.label28.Text = "bCity";
            this.toolTipFeature.SetToolTip(this.label28, "Beneficiary\'s City");
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(241, 138);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(51, 13);
            this.label29.TabIndex = 173;
            this.label29.Text = "bAddress";
            this.toolTipFeature.SetToolTip(this.label29, "Beneficiary\'s Address");
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 224);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 13);
            this.label25.TabIndex = 172;
            this.label25.Text = "sEmail";
            this.toolTipFeature.SetToolTip(this.label25, "Sender\'s Email");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 195);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 171;
            this.label24.Text = "sPostCode";
            this.toolTipFeature.SetToolTip(this.label24, "Sender’s address postcode");
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 165);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 170;
            this.label23.Text = "sCity";
            this.toolTipFeature.SetToolTip(this.label23, "Sender’s resident city");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 135);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 169;
            this.label21.Text = "sAddress";
            this.toolTipFeature.SetToolTip(this.label21, "Sender\'s Address");
            // 
            // txtbSenderAdd
            // 
            this.txtbSenderAdd.Location = new System.Drawing.Point(97, 135);
            this.txtbSenderAdd.Name = "txtbSenderAdd";
            this.txtbSenderAdd.Size = new System.Drawing.Size(129, 20);
            this.txtbSenderAdd.TabIndex = 118;
            this.txtbSenderAdd.Text = "Place";
            this.txtbSenderAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtbSenderAdd, "Sender\'s Address");
            // 
            // txtBSenderHPNo
            // 
            this.txtBSenderHPNo.Location = new System.Drawing.Point(97, 105);
            this.txtBSenderHPNo.Name = "txtBSenderHPNo";
            this.txtBSenderHPNo.Size = new System.Drawing.Size(129, 20);
            this.txtBSenderHPNo.TabIndex = 117;
            this.txtBSenderHPNo.Text = "0000000000";
            this.txtBSenderHPNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtBSenderHPNo, "Sender Contact Number");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 168;
            this.label22.Text = "sContactNum";
            // 
            // txtBHPNo
            // 
            this.txtBHPNo.Location = new System.Drawing.Point(337, 105);
            this.txtBHPNo.Name = "txtBHPNo";
            this.txtBHPNo.Size = new System.Drawing.Size(117, 20);
            this.txtBHPNo.TabIndex = 140;
            this.txtBHPNo.Text = "000000000";
            this.txtBHPNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtBHPNo, "Beneficiary\'s Contact Number");
            // 
            // lblBeneHP
            // 
            this.lblBeneHP.AutoSize = true;
            this.lblBeneHP.Location = new System.Drawing.Point(241, 108);
            this.lblBeneHP.Name = "lblBeneHP";
            this.lblBeneHP.Size = new System.Drawing.Size(72, 13);
            this.lblBeneHP.TabIndex = 167;
            this.lblBeneHP.Text = "bContactNum";
            this.toolTipFeature.SetToolTip(this.lblBeneHP, "Beneficiary\'s Contact Number");
            // 
            // txtRelationship
            // 
            this.txtRelationship.Location = new System.Drawing.Point(97, 315);
            this.txtRelationship.Name = "txtRelationship";
            this.txtRelationship.Size = new System.Drawing.Size(129, 20);
            this.txtRelationship.TabIndex = 130;
            this.txtRelationship.Text = "19";
            this.txtRelationship.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtRelationship, "Beneficiary and Sender Relationship. Check the Code List from Tranglo Website. ");
            // 
            // txtBIdNumber
            // 
            this.txtBIdNumber.Location = new System.Drawing.Point(337, 75);
            this.txtBIdNumber.Name = "txtBIdNumber";
            this.txtBIdNumber.Size = new System.Drawing.Size(117, 20);
            this.txtBIdNumber.TabIndex = 139;
            this.txtBIdNumber.Text = "00002017206";
            this.txtBIdNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtBIdNumber, "Beneficiary\'s Identification Number");
            // 
            // txtBLastName
            // 
            this.txtBLastName.Location = new System.Drawing.Point(337, 45);
            this.txtBLastName.Name = "txtBLastName";
            this.txtBLastName.Size = new System.Drawing.Size(117, 20);
            this.txtBLastName.TabIndex = 138;
            this.txtBLastName.Text = "BLastName";
            this.txtBLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtBLastName, "Beneficiary\'s Last Name");
            // 
            // txtBFirstName
            // 
            this.txtBFirstName.Location = new System.Drawing.Point(337, 15);
            this.txtBFirstName.Name = "txtBFirstName";
            this.txtBFirstName.Size = new System.Drawing.Size(117, 20);
            this.txtBFirstName.TabIndex = 137;
            this.txtBFirstName.Text = "Bene";
            this.txtBFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtBFirstName, "Beneficiary\'s First Name");
            // 
            // txtSFundSource
            // 
            this.txtSFundSource.Location = new System.Drawing.Point(97, 285);
            this.txtSFundSource.Name = "txtSFundSource";
            this.txtSFundSource.Size = new System.Drawing.Size(129, 20);
            this.txtSFundSource.TabIndex = 127;
            this.txtSFundSource.Text = "18";
            this.txtSFundSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtSFundSource, "Sender’s source of fund. Check the Code List from Tranglo Website. ");
            // 
            // txtSOccupation
            // 
            this.txtSOccupation.Location = new System.Drawing.Point(97, 255);
            this.txtSOccupation.Name = "txtSOccupation";
            this.txtSOccupation.Size = new System.Drawing.Size(129, 20);
            this.txtSOccupation.TabIndex = 125;
            this.txtSOccupation.Text = "Individual-Employed (Others)";
            this.txtSOccupation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSIdNumber
            // 
            this.txtSIdNumber.Location = new System.Drawing.Point(97, 75);
            this.txtSIdNumber.Name = "txtSIdNumber";
            this.txtSIdNumber.Size = new System.Drawing.Size(129, 20);
            this.txtSIdNumber.TabIndex = 116;
            this.txtSIdNumber.Text = "861119-56-6349";
            this.txtSIdNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtSIdNumber, "Sender\'s Identification Number");
            // 
            // txtSLastName
            // 
            this.txtSLastName.Location = new System.Drawing.Point(97, 45);
            this.txtSLastName.Name = "txtSLastName";
            this.txtSLastName.Size = new System.Drawing.Size(129, 20);
            this.txtSLastName.TabIndex = 115;
            this.txtSLastName.Text = "Smith";
            this.txtSLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtSLastName, "Sender\'s Last Name");
            // 
            // txtSFirstName
            // 
            this.txtSFirstName.Location = new System.Drawing.Point(97, 15);
            this.txtSFirstName.Name = "txtSFirstName";
            this.txtSFirstName.Size = new System.Drawing.Size(129, 20);
            this.txtSFirstName.TabIndex = 114;
            this.txtSFirstName.Text = "Joe";
            this.txtSFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtSFirstName, "Sender\'s First Name");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(465, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 13);
            this.label20.TabIndex = 166;
            this.label20.Text = "bRegencyCode";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(466, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 165;
            this.label19.Text = "bProvinceCode";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 314);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 164;
            this.label18.Text = "Relationship";
            this.toolTipFeature.SetToolTip(this.label18, "Beneficiary and Sender Relationship. Check the Code List from Tranglo Website. ");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(241, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 162;
            this.label16.Text = "bIdNumber";
            this.toolTipFeature.SetToolTip(this.label16, "Beneficiary\'s Identification Number");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(241, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 161;
            this.label17.Text = "bLastName";
            this.toolTipFeature.SetToolTip(this.label17, "Beneficiary\'s Last Name");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(241, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 158;
            this.label15.Text = "bFirstName";
            this.toolTipFeature.SetToolTip(this.label15, "Beneficiary\'s First Name");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 157;
            this.label14.Text = "sFundSource";
            this.toolTipFeature.SetToolTip(this.label14, "Sender’s source of fund. Check the Code List from Tranglo Website. ");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 154;
            this.label13.Text = "sOccupation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 153;
            this.label12.Text = "sIdNumber";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 143;
            this.label9.Text = "Trx Channel";
            this.toolTipFeature.SetToolTip(this.label9, "Refer to [bAccType] in API document.");
            // 
            // cmbTrxnChannel
            // 
            this.cmbTrxnChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbTrxnChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTrxnChannel.FormattingEnabled = true;
            this.cmbTrxnChannel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cmbTrxnChannel.Location = new System.Drawing.Point(337, 375);
            this.cmbTrxnChannel.Name = "cmbTrxnChannel";
            this.cmbTrxnChannel.Size = new System.Drawing.Size(117, 21);
            this.cmbTrxnChannel.TabIndex = 150;
            this.cmbTrxnChannel.Text = "1";
            this.toolTipFeature.SetToolTip(this.cmbTrxnChannel, "Refer to [bAccType] in API document.");
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(337, 345);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(117, 20);
            this.txtAmt.TabIndex = 149;
            this.txtAmt.Text = "10";
            this.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAccNum
            // 
            this.txtAccNum.Location = new System.Drawing.Point(337, 315);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(117, 20);
            this.txtAccNum.TabIndex = 148;
            this.txtAccNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtAccNum, "Beneficiary\'s Account Number. Optional for \"Cash Pickup\".");
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.Location = new System.Drawing.Point(337, 285);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(117, 20);
            this.txtBranchCode.TabIndex = 147;
            this.txtBranchCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtBranchCode, "Bank Branch Code or IFSC code");
            // 
            // txtIssuerCode
            // 
            this.txtIssuerCode.Location = new System.Drawing.Point(337, 255);
            this.txtIssuerCode.Name = "txtIssuerCode";
            this.txtIssuerCode.Size = new System.Drawing.Size(117, 20);
            this.txtIssuerCode.TabIndex = 146;
            this.txtIssuerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtIssuerCode, "Beneficiary Account Issuer Code, such as banks, e-wallet operator or mobile opera" +
        "tors");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 134;
            this.label8.Text = "Amount/TrxValue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 131;
            this.label7.Text = "bAccNum";
            this.toolTipFeature.SetToolTip(this.label7, "Beneficiary\'s Account Number. Optional for \"Cash Pickup\".");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 129;
            this.label6.Text = "Bank Branch Code";
            this.toolTipFeature.SetToolTip(this.label6, "Bank Branch Code or IFSC code");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 128;
            this.label5.Text = "Issuer Code";
            this.toolTipFeature.SetToolTip(this.label5, "Beneficiary Account Issuer Code, such as banks, e-wallet operator or mobile opera" +
        "tors");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 126;
            this.label4.Text = "bCurrency";
            this.toolTipFeature.SetToolTip(this.label4, "Beneficiary\'s Currency Code");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "bCountry";
            this.toolTipFeature.SetToolTip(this.label3, "Beneficiary\'s Country Code");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Source Currency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Source Country";
            // 
            // tbGetValidation
            // 
            this.tbGetValidation.Controls.Add(this.label64);
            this.tbGetValidation.Controls.Add(this.cmbValidateBAcctType);
            this.tbGetValidation.Controls.Add(this.txtValidateTrxValue);
            this.tbGetValidation.Controls.Add(this.label63);
            this.tbGetValidation.Controls.Add(this.txtValidateBAcctNumber);
            this.tbGetValidation.Controls.Add(this.label62);
            this.tbGetValidation.Controls.Add(this.txtValidateBIssuerCode);
            this.tbGetValidation.Controls.Add(this.label61);
            this.tbGetValidation.Controls.Add(this.txtValidateBCountry);
            this.tbGetValidation.Controls.Add(this.label60);
            this.tbGetValidation.Controls.Add(this.txtValidateBLastName);
            this.tbGetValidation.Controls.Add(this.txtValidateBFirstName);
            this.tbGetValidation.Controls.Add(this.label58);
            this.tbGetValidation.Controls.Add(this.label59);
            this.tbGetValidation.Controls.Add(this.txtValidateSLastName);
            this.tbGetValidation.Controls.Add(this.txtValidateSFirstName);
            this.tbGetValidation.Controls.Add(this.label56);
            this.tbGetValidation.Controls.Add(this.label57);
            this.tbGetValidation.Controls.Add(this.txtValidateSIdNumber);
            this.tbGetValidation.Controls.Add(this.label55);
            this.tbGetValidation.Location = new System.Drawing.Point(4, 22);
            this.tbGetValidation.Name = "tbGetValidation";
            this.tbGetValidation.Padding = new System.Windows.Forms.Padding(3);
            this.tbGetValidation.Size = new System.Drawing.Size(710, 416);
            this.tbGetValidation.TabIndex = 1;
            this.tbGetValidation.Text = "Get_Validation";
            this.tbGetValidation.UseVisualStyleBackColor = true;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(424, 81);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(64, 13);
            this.label64.TabIndex = 72;
            this.label64.Text = "Trx Channel";
            // 
            // cmbValidateBAcctType
            // 
            this.cmbValidateBAcctType.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbValidateBAcctType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbValidateBAcctType.FormattingEnabled = true;
            this.cmbValidateBAcctType.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cmbValidateBAcctType.Location = new System.Drawing.Point(516, 85);
            this.cmbValidateBAcctType.Name = "cmbValidateBAcctType";
            this.cmbValidateBAcctType.Size = new System.Drawing.Size(117, 21);
            this.cmbValidateBAcctType.TabIndex = 73;
            this.cmbValidateBAcctType.Text = "1";
            // 
            // txtValidateTrxValue
            // 
            this.txtValidateTrxValue.Location = new System.Drawing.Point(516, 60);
            this.txtValidateTrxValue.Name = "txtValidateTrxValue";
            this.txtValidateTrxValue.Size = new System.Drawing.Size(117, 20);
            this.txtValidateTrxValue.TabIndex = 71;
            this.txtValidateTrxValue.Text = "10";
            this.txtValidateTrxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(424, 58);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(43, 13);
            this.label63.TabIndex = 70;
            this.label63.Text = "Amount";
            // 
            // txtValidateBAcctNumber
            // 
            this.txtValidateBAcctNumber.Location = new System.Drawing.Point(516, 35);
            this.txtValidateBAcctNumber.Name = "txtValidateBAcctNumber";
            this.txtValidateBAcctNumber.Size = new System.Drawing.Size(117, 20);
            this.txtValidateBAcctNumber.TabIndex = 69;
            this.txtValidateBAcctNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtValidateBAcctNumber, "Beneficiary Issuer Account Number");
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(423, 36);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(54, 13);
            this.label62.TabIndex = 68;
            this.label62.Text = "bAccNum";
            this.toolTipFeature.SetToolTip(this.label62, "Beneficiary Issuer Account Number");
            // 
            // txtValidateBIssuerCode
            // 
            this.txtValidateBIssuerCode.Location = new System.Drawing.Point(516, 10);
            this.txtValidateBIssuerCode.Name = "txtValidateBIssuerCode";
            this.txtValidateBIssuerCode.Size = new System.Drawing.Size(117, 20);
            this.txtValidateBIssuerCode.TabIndex = 67;
            this.txtValidateBIssuerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtValidateBIssuerCode, "Beneficiary Account Issuer Code");
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(424, 9);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(63, 13);
            this.label61.TabIndex = 66;
            this.label61.Text = "Issuer Code";
            this.toolTipFeature.SetToolTip(this.label61, "Beneficiary Account Issuer Code");
            // 
            // txtValidateBCountry
            // 
            this.txtValidateBCountry.Location = new System.Drawing.Point(289, 60);
            this.txtValidateBCountry.Name = "txtValidateBCountry";
            this.txtValidateBCountry.Size = new System.Drawing.Size(125, 20);
            this.txtValidateBCountry.TabIndex = 65;
            this.txtValidateBCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(212, 63);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(71, 13);
            this.label60.TabIndex = 64;
            this.label60.Text = "Bene Country";
            // 
            // txtValidateBLastName
            // 
            this.txtValidateBLastName.Location = new System.Drawing.Point(290, 35);
            this.txtValidateBLastName.Name = "txtValidateBLastName";
            this.txtValidateBLastName.Size = new System.Drawing.Size(124, 20);
            this.txtValidateBLastName.TabIndex = 61;
            this.txtValidateBLastName.Text = "BLastName";
            this.txtValidateBLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValidateBFirstName
            // 
            this.txtValidateBFirstName.Location = new System.Drawing.Point(290, 10);
            this.txtValidateBFirstName.Name = "txtValidateBFirstName";
            this.txtValidateBFirstName.Size = new System.Drawing.Size(124, 20);
            this.txtValidateBFirstName.TabIndex = 60;
            this.txtValidateBFirstName.Text = "Bene";
            this.txtValidateBFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(212, 38);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(61, 13);
            this.label58.TabIndex = 63;
            this.label58.Text = "bLastName";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(212, 13);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(60, 13);
            this.label59.TabIndex = 62;
            this.label59.Text = "bFirstName";
            // 
            // txtValidateSLastName
            // 
            this.txtValidateSLastName.Location = new System.Drawing.Point(73, 35);
            this.txtValidateSLastName.Name = "txtValidateSLastName";
            this.txtValidateSLastName.Size = new System.Drawing.Size(129, 20);
            this.txtValidateSLastName.TabIndex = 57;
            this.txtValidateSLastName.Text = "Smith";
            this.txtValidateSLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValidateSFirstName
            // 
            this.txtValidateSFirstName.Location = new System.Drawing.Point(73, 10);
            this.txtValidateSFirstName.Name = "txtValidateSFirstName";
            this.txtValidateSFirstName.Size = new System.Drawing.Size(129, 20);
            this.txtValidateSFirstName.TabIndex = 56;
            this.txtValidateSFirstName.Text = "Joe";
            this.txtValidateSFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(10, 38);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(60, 13);
            this.label56.TabIndex = 59;
            this.label56.Text = "sLastName";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(10, 13);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(59, 13);
            this.label57.TabIndex = 58;
            this.label57.Text = "sFirstName";
            // 
            // txtValidateSIdNumber
            // 
            this.txtValidateSIdNumber.Location = new System.Drawing.Point(73, 60);
            this.txtValidateSIdNumber.Name = "txtValidateSIdNumber";
            this.txtValidateSIdNumber.Size = new System.Drawing.Size(129, 20);
            this.txtValidateSIdNumber.TabIndex = 54;
            this.txtValidateSIdNumber.Text = "861119-56-6349";
            this.txtValidateSIdNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(10, 62);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(58, 13);
            this.label55.TabIndex = 55;
            this.label55.Text = "sIdNumber";
            // 
            // tbGetTrxStatusDoCancellation
            // 
            this.tbGetTrxStatusDoCancellation.Controls.Add(this.txtbTrangloGTN);
            this.tbGetTrxStatusDoCancellation.Controls.Add(this.label35);
            this.tbGetTrxStatusDoCancellation.Location = new System.Drawing.Point(4, 22);
            this.tbGetTrxStatusDoCancellation.Name = "tbGetTrxStatusDoCancellation";
            this.tbGetTrxStatusDoCancellation.Size = new System.Drawing.Size(710, 416);
            this.tbGetTrxStatusDoCancellation.TabIndex = 2;
            this.tbGetTrxStatusDoCancellation.Text = "Get_TrxStatus/ Do_Cancellation";
            this.tbGetTrxStatusDoCancellation.UseVisualStyleBackColor = true;
            // 
            // txtbTrangloGTN
            // 
            this.txtbTrangloGTN.Location = new System.Drawing.Point(80, 16);
            this.txtbTrangloGTN.Name = "txtbTrangloGTN";
            this.txtbTrangloGTN.Size = new System.Drawing.Size(171, 20);
            this.txtbTrangloGTN.TabIndex = 87;
            this.txtbTrangloGTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtbTrangloGTN, "Transaction GTN number");
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(10, 20);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(66, 13);
            this.label35.TabIndex = 88;
            this.label35.Text = "TrangloGTN";
            this.toolTipFeature.SetToolTip(this.label35, "Transaction GTN number");
            // 
            // tbChangeName
            // 
            this.tbChangeName.Controls.Add(this.txtCNBeneLastName);
            this.tbChangeName.Controls.Add(this.label54);
            this.tbChangeName.Controls.Add(this.label53);
            this.tbChangeName.Controls.Add(this.txtCNBeneFirstName);
            this.tbChangeName.Controls.Add(this.txtCNGTN);
            this.tbChangeName.Controls.Add(this.label52);
            this.tbChangeName.Location = new System.Drawing.Point(4, 22);
            this.tbChangeName.Name = "tbChangeName";
            this.tbChangeName.Size = new System.Drawing.Size(710, 416);
            this.tbChangeName.TabIndex = 3;
            this.tbChangeName.Text = "Do_ChangeName";
            this.tbChangeName.UseVisualStyleBackColor = true;
            // 
            // txtCNBeneLastName
            // 
            this.txtCNBeneLastName.Location = new System.Drawing.Point(518, 16);
            this.txtCNBeneLastName.Name = "txtCNBeneLastName";
            this.txtCNBeneLastName.Size = new System.Drawing.Size(153, 20);
            this.txtCNBeneLastName.TabIndex = 98;
            this.txtCNBeneLastName.Text = "BLastName";
            this.toolTipFeature.SetToolTip(this.txtCNBeneLastName, "Beneficiary\'s Last Name");
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(451, 19);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(61, 13);
            this.label54.TabIndex = 97;
            this.label54.Text = "bLastName";
            this.toolTipFeature.SetToolTip(this.label54, "Beneficiary\'s Last Name");
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(211, 19);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(60, 13);
            this.label53.TabIndex = 96;
            this.label53.Text = "bFirstName";
            this.toolTipFeature.SetToolTip(this.label53, "Beneficiary\'s First Name");
            // 
            // txtCNBeneFirstName
            // 
            this.txtCNBeneFirstName.Location = new System.Drawing.Point(277, 16);
            this.txtCNBeneFirstName.Name = "txtCNBeneFirstName";
            this.txtCNBeneFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtCNBeneFirstName.TabIndex = 95;
            this.txtCNBeneFirstName.Text = "Bene";
            this.toolTipFeature.SetToolTip(this.txtCNBeneFirstName, "Beneficiary\'s First Name");
            // 
            // txtCNGTN
            // 
            this.txtCNGTN.Location = new System.Drawing.Point(77, 16);
            this.txtCNGTN.Name = "txtCNGTN";
            this.txtCNGTN.Size = new System.Drawing.Size(114, 20);
            this.txtCNGTN.TabIndex = 94;
            this.toolTipFeature.SetToolTip(this.txtCNGTN, "Transaction GTN number");
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(7, 19);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(66, 13);
            this.label52.TabIndex = 93;
            this.label52.Text = "TrangloGTN";
            this.toolTipFeature.SetToolTip(this.label52, "Transaction GTN number");
            // 
            // tbBillPayment
            // 
            this.tbBillPayment.Controls.Add(this.txtBillPaymentBAccountNum);
            this.tbBillPayment.Controls.Add(this.txtBillPaymentBIsuserCode);
            this.tbBillPayment.Controls.Add(this.label82);
            this.tbBillPayment.Controls.Add(this.label83);
            this.tbBillPayment.Controls.Add(this.txtBillPaymentBAmount);
            this.tbBillPayment.Controls.Add(this.label81);
            this.tbBillPayment.Controls.Add(this.txtBillPaymentBCountry);
            this.tbBillPayment.Controls.Add(this.txtBillPaymentBCurrency);
            this.tbBillPayment.Controls.Add(this.label79);
            this.tbBillPayment.Controls.Add(this.label80);
            this.tbBillPayment.Controls.Add(this.txtBillPaymentSCountry);
            this.tbBillPayment.Controls.Add(this.txtBillPaymentSCurrency);
            this.tbBillPayment.Controls.Add(this.label77);
            this.tbBillPayment.Controls.Add(this.label78);
            this.tbBillPayment.Controls.Add(this.txtBillPaymentSContactNum);
            this.tbBillPayment.Controls.Add(this.label76);
            this.tbBillPayment.Controls.Add(this.textBox5);
            this.tbBillPayment.Controls.Add(this.txtBillPaymentSEmail);
            this.tbBillPayment.Controls.Add(this.label75);
            this.tbBillPayment.Controls.Add(this.label67);
            this.tbBillPayment.Controls.Add(this.label73);
            this.tbBillPayment.Controls.Add(this.txtBillPaymentSIdNum);
            this.tbBillPayment.Controls.Add(this.txtBillPaymentSLastName);
            this.tbBillPayment.Controls.Add(this.txtBillPaymentSFirstName);
            this.tbBillPayment.Controls.Add(this.label74);
            this.tbBillPayment.Controls.Add(this.label50);
            this.tbBillPayment.Controls.Add(this.label49);
            this.tbBillPayment.Controls.Add(this.txtCustomInfo4);
            this.tbBillPayment.Controls.Add(this.txtCustomInfo3);
            this.tbBillPayment.Controls.Add(this.txtCustomInfo2);
            this.tbBillPayment.Controls.Add(this.txtCustomInfo1);
            this.tbBillPayment.Controls.Add(this.label48);
            this.tbBillPayment.Controls.Add(this.label47);
            this.tbBillPayment.Controls.Add(this.label46);
            this.tbBillPayment.Controls.Add(this.label45);
            this.tbBillPayment.Controls.Add(this.txtBillDueDate);
            this.tbBillPayment.Controls.Add(this.txtBillType);
            this.tbBillPayment.Controls.Add(this.label40);
            this.tbBillPayment.Controls.Add(this.label44);
            this.tbBillPayment.Controls.Add(this.txtBillNumber);
            this.tbBillPayment.Controls.Add(this.label41);
            this.tbBillPayment.Controls.Add(this.label43);
            this.tbBillPayment.Controls.Add(this.txtBillAccName);
            this.tbBillPayment.Controls.Add(this.txtBillStatementDate);
            this.tbBillPayment.Controls.Add(this.label42);
            this.tbBillPayment.Location = new System.Drawing.Point(4, 22);
            this.tbBillPayment.Name = "tbBillPayment";
            this.tbBillPayment.Size = new System.Drawing.Size(710, 416);
            this.tbBillPayment.TabIndex = 4;
            this.tbBillPayment.Text = "Do_BillPayment";
            this.tbBillPayment.UseVisualStyleBackColor = true;
            // 
            // txtBillPaymentBAccountNum
            // 
            this.txtBillPaymentBAccountNum.Location = new System.Drawing.Point(325, 130);
            this.txtBillPaymentBAccountNum.Name = "txtBillPaymentBAccountNum";
            this.txtBillPaymentBAccountNum.Size = new System.Drawing.Size(127, 20);
            this.txtBillPaymentBAccountNum.TabIndex = 209;
            this.txtBillPaymentBAccountNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillPaymentBIsuserCode
            // 
            this.txtBillPaymentBIsuserCode.Location = new System.Drawing.Point(325, 100);
            this.txtBillPaymentBIsuserCode.Name = "txtBillPaymentBIsuserCode";
            this.txtBillPaymentBIsuserCode.Size = new System.Drawing.Size(127, 20);
            this.txtBillPaymentBIsuserCode.TabIndex = 208;
            this.txtBillPaymentBIsuserCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtBillPaymentBIsuserCode, "Beneficiary Account Issuer Code, such as banks, e-wallet operator or mobile opera" +
        "tors");
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(236, 133);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(87, 13);
            this.label82.TabIndex = 207;
            this.label82.Text = "Account Number";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(236, 102);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(63, 13);
            this.label83.TabIndex = 206;
            this.label83.Text = "Issuer Code";
            this.toolTipFeature.SetToolTip(this.label83, "Beneficiary Account Issuer Code, such as banks, e-wallet operator or mobile opera" +
        "tors");
            // 
            // txtBillPaymentBAmount
            // 
            this.txtBillPaymentBAmount.Location = new System.Drawing.Point(325, 70);
            this.txtBillPaymentBAmount.Name = "txtBillPaymentBAmount";
            this.txtBillPaymentBAmount.Size = new System.Drawing.Size(127, 20);
            this.txtBillPaymentBAmount.TabIndex = 205;
            this.txtBillPaymentBAmount.Text = "10";
            this.txtBillPaymentBAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(236, 75);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(90, 13);
            this.label81.TabIndex = 204;
            this.label81.Text = "Amount/TrxValue";
            // 
            // txtBillPaymentBCountry
            // 
            this.txtBillPaymentBCountry.Location = new System.Drawing.Point(325, 10);
            this.txtBillPaymentBCountry.Name = "txtBillPaymentBCountry";
            this.txtBillPaymentBCountry.Size = new System.Drawing.Size(127, 20);
            this.txtBillPaymentBCountry.TabIndex = 202;
            this.txtBillPaymentBCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillPaymentBCurrency
            // 
            this.txtBillPaymentBCurrency.Location = new System.Drawing.Point(325, 40);
            this.txtBillPaymentBCurrency.Name = "txtBillPaymentBCurrency";
            this.txtBillPaymentBCurrency.Size = new System.Drawing.Size(127, 20);
            this.txtBillPaymentBCurrency.TabIndex = 203;
            this.txtBillPaymentBCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(236, 43);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(77, 13);
            this.label79.TabIndex = 201;
            this.label79.Text = "Bene Currency";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(236, 13);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(71, 13);
            this.label80.TabIndex = 200;
            this.label80.Text = "Bene Country";
            // 
            // txtBillPaymentSCountry
            // 
            this.txtBillPaymentSCountry.Location = new System.Drawing.Point(97, 160);
            this.txtBillPaymentSCountry.Name = "txtBillPaymentSCountry";
            this.txtBillPaymentSCountry.Size = new System.Drawing.Size(129, 20);
            this.txtBillPaymentSCountry.TabIndex = 198;
            this.txtBillPaymentSCountry.Text = "MY";
            this.txtBillPaymentSCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillPaymentSCurrency
            // 
            this.txtBillPaymentSCurrency.Location = new System.Drawing.Point(97, 191);
            this.txtBillPaymentSCurrency.Name = "txtBillPaymentSCurrency";
            this.txtBillPaymentSCurrency.Size = new System.Drawing.Size(129, 20);
            this.txtBillPaymentSCurrency.TabIndex = 199;
            this.txtBillPaymentSCurrency.Text = "MYR";
            this.txtBillPaymentSCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(10, 194);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(86, 13);
            this.label77.TabIndex = 197;
            this.label77.Text = "Source Currency";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(10, 164);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(80, 13);
            this.label78.TabIndex = 196;
            this.label78.Text = "Source Country";
            // 
            // txtBillPaymentSContactNum
            // 
            this.txtBillPaymentSContactNum.Location = new System.Drawing.Point(97, 99);
            this.txtBillPaymentSContactNum.Name = "txtBillPaymentSContactNum";
            this.txtBillPaymentSContactNum.Size = new System.Drawing.Size(129, 20);
            this.txtBillPaymentSContactNum.TabIndex = 194;
            this.txtBillPaymentSContactNum.Text = "0000000000";
            this.txtBillPaymentSContactNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(10, 102);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(71, 13);
            this.label76.TabIndex = 195;
            this.label76.Text = "sContactNum";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(694, -10);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(127, 20);
            this.textBox5.TabIndex = 192;
            this.textBox5.Text = "MY";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillPaymentSEmail
            // 
            this.txtBillPaymentSEmail.Location = new System.Drawing.Point(97, 129);
            this.txtBillPaymentSEmail.Name = "txtBillPaymentSEmail";
            this.txtBillPaymentSEmail.Size = new System.Drawing.Size(129, 20);
            this.txtBillPaymentSEmail.TabIndex = 191;
            this.txtBillPaymentSEmail.Text = "sEmail@gmail.com";
            this.txtBillPaymentSEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(10, 132);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(66, 13);
            this.label75.TabIndex = 193;
            this.label75.Text = "SenderEmail";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(10, 40);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(60, 13);
            this.label67.TabIndex = 190;
            this.label67.Text = "sLastName";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(10, 13);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(59, 13);
            this.label73.TabIndex = 189;
            this.label73.Text = "sFirstName";
            // 
            // txtBillPaymentSIdNum
            // 
            this.txtBillPaymentSIdNum.Location = new System.Drawing.Point(97, 70);
            this.txtBillPaymentSIdNum.Name = "txtBillPaymentSIdNum";
            this.txtBillPaymentSIdNum.Size = new System.Drawing.Size(129, 20);
            this.txtBillPaymentSIdNum.TabIndex = 187;
            this.txtBillPaymentSIdNum.Text = "861119-56-6349";
            this.txtBillPaymentSIdNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillPaymentSLastName
            // 
            this.txtBillPaymentSLastName.Location = new System.Drawing.Point(97, 40);
            this.txtBillPaymentSLastName.Name = "txtBillPaymentSLastName";
            this.txtBillPaymentSLastName.Size = new System.Drawing.Size(129, 20);
            this.txtBillPaymentSLastName.TabIndex = 186;
            this.txtBillPaymentSLastName.Text = "Smith";
            this.txtBillPaymentSLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillPaymentSFirstName
            // 
            this.txtBillPaymentSFirstName.Location = new System.Drawing.Point(97, 10);
            this.txtBillPaymentSFirstName.Name = "txtBillPaymentSFirstName";
            this.txtBillPaymentSFirstName.Size = new System.Drawing.Size(129, 20);
            this.txtBillPaymentSFirstName.TabIndex = 185;
            this.txtBillPaymentSFirstName.Text = "Joe";
            this.txtBillPaymentSFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(10, 70);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(58, 13);
            this.label74.TabIndex = 188;
            this.label74.Text = "sIdNumber";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(474, 101);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(71, 13);
            this.label50.TabIndex = 130;
            this.label50.Text = "(mm/dd/yyyy)";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(474, 76);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(71, 13);
            this.label49.TabIndex = 128;
            this.label49.Text = "(mm/dd/yyyy)";
            // 
            // txtCustomInfo4
            // 
            this.txtCustomInfo4.Location = new System.Drawing.Point(551, 209);
            this.txtCustomInfo4.Name = "txtCustomInfo4";
            this.txtCustomInfo4.Size = new System.Drawing.Size(123, 20);
            this.txtCustomInfo4.TabIndex = 119;
            this.txtCustomInfo4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCustomInfo3
            // 
            this.txtCustomInfo3.Location = new System.Drawing.Point(551, 184);
            this.txtCustomInfo3.Name = "txtCustomInfo3";
            this.txtCustomInfo3.Size = new System.Drawing.Size(123, 20);
            this.txtCustomInfo3.TabIndex = 118;
            this.txtCustomInfo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCustomInfo2
            // 
            this.txtCustomInfo2.Location = new System.Drawing.Point(551, 159);
            this.txtCustomInfo2.Name = "txtCustomInfo2";
            this.txtCustomInfo2.Size = new System.Drawing.Size(123, 20);
            this.txtCustomInfo2.TabIndex = 117;
            this.txtCustomInfo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCustomInfo1
            // 
            this.txtCustomInfo1.Location = new System.Drawing.Point(551, 134);
            this.txtCustomInfo1.Name = "txtCustomInfo1";
            this.txtCustomInfo1.Size = new System.Drawing.Size(123, 20);
            this.txtCustomInfo1.TabIndex = 116;
            this.txtCustomInfo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(469, 213);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(72, 13);
            this.label48.TabIndex = 129;
            this.label48.Text = "Custom Info 4";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(469, 188);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(72, 13);
            this.label47.TabIndex = 127;
            this.label47.Text = "Custom Info 3";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(469, 163);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(72, 13);
            this.label46.TabIndex = 126;
            this.label46.Text = "Custom Info 2";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(469, 138);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(72, 13);
            this.label45.TabIndex = 125;
            this.label45.Text = "Custom Info 1";
            // 
            // txtBillDueDate
            // 
            this.txtBillDueDate.Location = new System.Drawing.Point(551, 84);
            this.txtBillDueDate.Name = "txtBillDueDate";
            this.txtBillDueDate.Size = new System.Drawing.Size(123, 20);
            this.txtBillDueDate.TabIndex = 114;
            this.txtBillDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillType
            // 
            this.txtBillType.Location = new System.Drawing.Point(551, 109);
            this.txtBillType.Name = "txtBillType";
            this.txtBillType.Size = new System.Drawing.Size(123, 20);
            this.txtBillType.TabIndex = 115;
            this.txtBillType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(469, 13);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(60, 13);
            this.label40.TabIndex = 120;
            this.label40.Text = "Bill Number";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(469, 113);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(47, 13);
            this.label44.TabIndex = 124;
            this.label44.Text = "Bill Type";
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Location = new System.Drawing.Point(551, 9);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(123, 20);
            this.txtBillNumber.TabIndex = 111;
            this.txtBillNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(469, 38);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(60, 13);
            this.label41.TabIndex = 121;
            this.label41.Text = "Acct Name";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(469, 88);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(53, 13);
            this.label43.TabIndex = 123;
            this.label43.Text = "Due Date";
            // 
            // txtBillAccName
            // 
            this.txtBillAccName.Location = new System.Drawing.Point(551, 34);
            this.txtBillAccName.Name = "txtBillAccName";
            this.txtBillAccName.Size = new System.Drawing.Size(123, 20);
            this.txtBillAccName.TabIndex = 112;
            this.txtBillAccName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillStatementDate
            // 
            this.txtBillStatementDate.Location = new System.Drawing.Point(551, 59);
            this.txtBillStatementDate.Name = "txtBillStatementDate";
            this.txtBillStatementDate.Size = new System.Drawing.Size(123, 20);
            this.txtBillStatementDate.TabIndex = 113;
            this.txtBillStatementDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(469, 63);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(81, 13);
            this.label42.TabIndex = 122;
            this.label42.Text = "Statement Date";
            // 
            // tbBillInquiry
            // 
            this.tbBillInquiry.Controls.Add(this.txtBillInquiryBAcctNum);
            this.tbBillInquiry.Controls.Add(this.txtBillInquiryBIssuerCode);
            this.tbBillInquiry.Controls.Add(this.label71);
            this.tbBillInquiry.Controls.Add(this.label72);
            this.tbBillInquiry.Controls.Add(this.txtBillInquiryBCountry);
            this.tbBillInquiry.Controls.Add(this.txtBillInquiryBCurrency);
            this.tbBillInquiry.Controls.Add(this.txtBillInquiryBAmount);
            this.tbBillInquiry.Controls.Add(this.label68);
            this.tbBillInquiry.Controls.Add(this.label69);
            this.tbBillInquiry.Controls.Add(this.label70);
            this.tbBillInquiry.Controls.Add(this.label65);
            this.tbBillInquiry.Controls.Add(this.label66);
            this.tbBillInquiry.Controls.Add(this.textBox1);
            this.tbBillInquiry.Controls.Add(this.txtBillInquirySLastName);
            this.tbBillInquiry.Controls.Add(this.txtBillInquirySFirstName);
            this.tbBillInquiry.Controls.Add(this.txtBillInquirySIdNum);
            this.tbBillInquiry.Location = new System.Drawing.Point(4, 22);
            this.tbBillInquiry.Name = "tbBillInquiry";
            this.tbBillInquiry.Size = new System.Drawing.Size(710, 416);
            this.tbBillInquiry.TabIndex = 5;
            this.tbBillInquiry.Text = "Do_BillInquiry";
            this.tbBillInquiry.UseVisualStyleBackColor = true;
            // 
            // txtBillInquiryBAcctNum
            // 
            this.txtBillInquiryBAcctNum.Location = new System.Drawing.Point(580, 42);
            this.txtBillInquiryBAcctNum.Name = "txtBillInquiryBAcctNum";
            this.txtBillInquiryBAcctNum.Size = new System.Drawing.Size(117, 20);
            this.txtBillInquiryBAcctNum.TabIndex = 200;
            this.txtBillInquiryBAcctNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtBillInquiryBAcctNum, "Bill Account Number or any other unique account identifier as determined by bille" +
        "r");
            // 
            // txtBillInquiryBIssuerCode
            // 
            this.txtBillInquiryBIssuerCode.Location = new System.Drawing.Point(580, 15);
            this.txtBillInquiryBIssuerCode.Name = "txtBillInquiryBIssuerCode";
            this.txtBillInquiryBIssuerCode.Size = new System.Drawing.Size(117, 20);
            this.txtBillInquiryBIssuerCode.TabIndex = 199;
            this.txtBillInquiryBIssuerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFeature.SetToolTip(this.txtBillInquiryBIssuerCode, "Beneficiary Account Issuer Code, such as banks, e-wallet operator or mobile opera" +
        "tors");
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(484, 45);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(87, 13);
            this.label71.TabIndex = 198;
            this.label71.Text = "Account Number";
            this.toolTipFeature.SetToolTip(this.label71, "Bill Account Number or any other unique account identifier as determined by bille" +
        "r");
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(484, 18);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(63, 13);
            this.label72.TabIndex = 197;
            this.label72.Text = "Issuer Code";
            this.toolTipFeature.SetToolTip(this.label72, "Beneficiary Account Issuer Code, such as banks, e-wallet operator or mobile opera" +
        "tors");
            // 
            // txtBillInquiryBCountry
            // 
            this.txtBillInquiryBCountry.Location = new System.Drawing.Point(337, 15);
            this.txtBillInquiryBCountry.Name = "txtBillInquiryBCountry";
            this.txtBillInquiryBCountry.Size = new System.Drawing.Size(127, 20);
            this.txtBillInquiryBCountry.TabIndex = 195;
            this.txtBillInquiryBCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillInquiryBCurrency
            // 
            this.txtBillInquiryBCurrency.Location = new System.Drawing.Point(337, 42);
            this.txtBillInquiryBCurrency.Name = "txtBillInquiryBCurrency";
            this.txtBillInquiryBCurrency.Size = new System.Drawing.Size(127, 20);
            this.txtBillInquiryBCurrency.TabIndex = 196;
            this.txtBillInquiryBCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillInquiryBAmount
            // 
            this.txtBillInquiryBAmount.Location = new System.Drawing.Point(337, 75);
            this.txtBillInquiryBAmount.Name = "txtBillInquiryBAmount";
            this.txtBillInquiryBAmount.Size = new System.Drawing.Size(127, 20);
            this.txtBillInquiryBAmount.TabIndex = 194;
            this.txtBillInquiryBAmount.Text = "10";
            this.txtBillInquiryBAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(246, 77);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(71, 13);
            this.label68.TabIndex = 193;
            this.label68.Text = "Bene Amount";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(246, 48);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(77, 13);
            this.label69.TabIndex = 192;
            this.label69.Text = "Bene Currency";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(246, 18);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(71, 13);
            this.label70.TabIndex = 191;
            this.label70.Text = "Bene Country";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(13, 45);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(60, 13);
            this.label65.TabIndex = 190;
            this.label65.Text = "sLastName";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(14, 18);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(59, 13);
            this.label66.TabIndex = 189;
            this.label66.Text = "sFirstName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 187;
            this.textBox1.Text = "861119-56-6349";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillInquirySLastName
            // 
            this.txtBillInquirySLastName.Location = new System.Drawing.Point(101, 45);
            this.txtBillInquirySLastName.Name = "txtBillInquirySLastName";
            this.txtBillInquirySLastName.Size = new System.Drawing.Size(129, 20);
            this.txtBillInquirySLastName.TabIndex = 186;
            this.txtBillInquirySLastName.Text = "Smith";
            this.txtBillInquirySLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillInquirySFirstName
            // 
            this.txtBillInquirySFirstName.Location = new System.Drawing.Point(101, 15);
            this.txtBillInquirySFirstName.Name = "txtBillInquirySFirstName";
            this.txtBillInquirySFirstName.Size = new System.Drawing.Size(129, 20);
            this.txtBillInquirySFirstName.TabIndex = 185;
            this.txtBillInquirySFirstName.Text = "Joe";
            this.txtBillInquirySFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBillInquirySIdNum
            // 
            this.txtBillInquirySIdNum.AutoSize = true;
            this.txtBillInquirySIdNum.Location = new System.Drawing.Point(13, 77);
            this.txtBillInquirySIdNum.Name = "txtBillInquirySIdNum";
            this.txtBillInquirySIdNum.Size = new System.Drawing.Size(58, 13);
            this.txtBillInquirySIdNum.TabIndex = 188;
            this.txtBillInquirySIdNum.Text = "sIdNumber";
            // 
            // SimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(965, 550);
            this.Controls.Add(this.tbFunctions);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.txtbSecretKey);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtRSPID);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.gbEnvironment);
            this.Controls.Add(this.gbMethod);
            this.Controls.Add(this.richTxtBoxStatus);
            this.Controls.Add(this.btnInvoke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SimulatorForm";
            this.Text = "Simulator GloRemit API";
            this.gbMethod.ResumeLayout(false);
            this.gbMethod.PerformLayout();
            this.gbEnvironment.ResumeLayout(false);
            this.gbEnvironment.PerformLayout();
            this.tbFunctions.ResumeLayout(false);
            this.tbDoTransfer.ResumeLayout(false);
            this.tbDoTransfer.PerformLayout();
            this.tbGetValidation.ResumeLayout(false);
            this.tbGetValidation.PerformLayout();
            this.tbGetTrxStatusDoCancellation.ResumeLayout(false);
            this.tbGetTrxStatusDoCancellation.PerformLayout();
            this.tbChangeName.ResumeLayout(false);
            this.tbChangeName.PerformLayout();
            this.tbBillPayment.ResumeLayout(false);
            this.tbBillPayment.PerformLayout();
            this.tbBillInquiry.ResumeLayout(false);
            this.tbBillInquiry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvoke;
        private System.Windows.Forms.RichTextBox richTxtBoxStatus;
        private System.Windows.Forms.RadioButton rdbtnDoTransfer;
        private System.Windows.Forms.RadioButton rdbtnGetValidation;
        private System.Windows.Forms.GroupBox gbMethod;
        private System.Windows.Forms.GroupBox gbEnvironment;
        private System.Windows.Forms.RadioButton rdbtnStaging;
        private System.Windows.Forms.RadioButton rdbtnGetTrxStatus;
        private System.Windows.Forms.RadioButton rdbtnDoBillInquiry;
        private System.Windows.Forms.RadioButton rdbtnDoBillPayment;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtRSPID;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtbSecretKey;
        private System.Windows.Forms.RadioButton rdbtnDoCancel;
        private System.Windows.Forms.RadioButton rdbtnDoChangeName;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TabControl tbFunctions;
        private System.Windows.Forms.TabPage tbDoTransfer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtb_payoutid;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtb_payoutpin;
        private System.Windows.Forms.TextBox txtbTransid;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtBRegencyCode;
        private System.Windows.Forms.TextBox txtSCountry;
        private System.Windows.Forms.TextBox txtSCurrency;
        private System.Windows.Forms.TextBox txtBCountry;
        private System.Windows.Forms.TextBox txtBCurrency;
        private System.Windows.Forms.TextBox txtBProvinceCode;
        private System.Windows.Forms.TextBox txtSenderDOB;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtPurposeCode;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtbBeneEmail;
        private System.Windows.Forms.TextBox txtbBenePostcode;
        private System.Windows.Forms.TextBox txtbBeneCity;
        private System.Windows.Forms.TextBox txtbBeneAdd;
        private System.Windows.Forms.TextBox txtbSenderEmail;
        private System.Windows.Forms.TextBox txtbSenderPostcode;
        private System.Windows.Forms.TextBox txtbSenderCity;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtbSenderAdd;
        private System.Windows.Forms.TextBox txtBSenderHPNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBHPNo;
        private System.Windows.Forms.Label lblBeneHP;
        private System.Windows.Forms.TextBox txtRelationship;
        private System.Windows.Forms.TextBox txtBIdNumber;
        private System.Windows.Forms.TextBox txtBLastName;
        private System.Windows.Forms.TextBox txtBFirstName;
        private System.Windows.Forms.TextBox txtSFundSource;
        private System.Windows.Forms.TextBox txtSOccupation;
        private System.Windows.Forms.TextBox txtSIdNumber;
        private System.Windows.Forms.TextBox txtSLastName;
        private System.Windows.Forms.TextBox txtSFirstName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTrxnChannel;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.TextBox txtBranchCode;
        private System.Windows.Forms.TextBox txtIssuerCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbGetValidation;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.ComboBox cmbValidateBAcctType;
        private System.Windows.Forms.TextBox txtValidateTrxValue;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox txtValidateBAcctNumber;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox txtValidateBIssuerCode;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox txtValidateBCountry;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox txtValidateBLastName;
        private System.Windows.Forms.TextBox txtValidateBFirstName;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox txtValidateSLastName;
        private System.Windows.Forms.TextBox txtValidateSFirstName;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox txtValidateSIdNumber;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TabPage tbGetTrxStatusDoCancellation;
        private System.Windows.Forms.TextBox txtbTrangloGTN;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TabPage tbChangeName;
        private System.Windows.Forms.TabPage tbBillPayment;
        private System.Windows.Forms.TabPage tbBillInquiry;
        private System.Windows.Forms.TextBox txtCNBeneLastName;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox txtCNBeneFirstName;
        private System.Windows.Forms.TextBox txtCNGTN;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtBillInquiryBAcctNum;
        private System.Windows.Forms.TextBox txtBillInquiryBIssuerCode;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox txtBillInquiryBCountry;
        private System.Windows.Forms.TextBox txtBillInquiryBCurrency;
        private System.Windows.Forms.TextBox txtBillInquiryBAmount;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBillInquirySLastName;
        private System.Windows.Forms.TextBox txtBillInquirySFirstName;
        private System.Windows.Forms.Label txtBillInquirySIdNum;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox txtCustomInfo4;
        private System.Windows.Forms.TextBox txtCustomInfo3;
        private System.Windows.Forms.TextBox txtCustomInfo2;
        private System.Windows.Forms.TextBox txtCustomInfo1;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtBillDueDate;
        private System.Windows.Forms.TextBox txtBillType;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtBillAccName;
        private System.Windows.Forms.TextBox txtBillStatementDate;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox txtBillPaymentSIdNum;
        private System.Windows.Forms.TextBox txtBillPaymentSLastName;
        private System.Windows.Forms.TextBox txtBillPaymentSFirstName;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox txtBillPaymentSContactNum;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtBillPaymentSEmail;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TextBox txtBillPaymentSCountry;
        private System.Windows.Forms.TextBox txtBillPaymentSCurrency;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox txtBillPaymentBCountry;
        private System.Windows.Forms.TextBox txtBillPaymentBCurrency;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox txtBillPaymentBAmount;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox txtBillPaymentBAccountNum;
        private System.Windows.Forms.TextBox txtBillPaymentBIsuserCode;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.ToolTip toolTipFeature;
    }
}

