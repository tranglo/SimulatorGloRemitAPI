using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CG = System.Configuration.ConfigurationManager;
using System.Xml;
using System.Net;

namespace Simulator_GloRemitNew_API_Form
{
    public partial class SimulatorForm : Form
    {
        public SimulatorForm()
        {
            InitializeComponent();
            GetConfig();
        }

        string richText = "";

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            try
            {
                InvokeAPI();
            }
            catch (Exception err)
            {
                richText = "Exception::" + err.Message;
            }

            richTxtBoxStatus.Text = richText;
            richTxtBoxStatus.SelectionStart = richTxtBoxStatus.Text.Length;
            richTxtBoxStatus.ScrollToCaret();
        }

        private string GenerateRspSign(string input)
        {
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider md5SP = new System.Security.Cryptography.MD5CryptoServiceProvider();
                Byte[] data = md5SP.ComputeHash(Encoding.ASCII.GetBytes(input));

                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                    sBuilder.Append(data[i].ToString("x2"));

                return sBuilder.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        private void GetConfig()
        {
            string enableLive = "";
            try
            {
                txtRSPID.Text = CG.AppSettings["UserID"];
                txtPwd.Text = CG.AppSettings["Password"];
                txtbSecretKey.Text = CG.AppSettings["SecretKey"];
                enableLive = CG.AppSettings["EnableLive"];
            }
            catch (Exception ex)
            {
                richTxtBoxStatus.Text = "Exception::" + ex.Message;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GetConfig();
        }

        private void InvokeAPI()
        {
            Random ran = new Random();
            string transactionID = ran.Next(1, 1000000000).ToString();

            if (!string.IsNullOrEmpty(txtbTransid.Text))
            {
                transactionID = txtbTransid.Text;
            }

            #region Input assignments to Variables

            string transID = transactionID;
            string rspSign = "";
            string UID = txtRSPID.Text; 
            string PWD = txtPwd.Text; 
            string Secret = txtbSecretKey.Text; 
            string UIDBranch = "";
            string sFirstName = txtSFirstName.Text;
            string sLastName = txtSLastName.Text;
            string sIdNum = txtSIdNumber.Text;
            string sIdExpiry = "01/01/2030";
            string sContactNum = txtBSenderHPNo.Text;
            string sOccupation = txtSOccupation.Text;
            string sFundSource = txtSFundSource.Text;
            string sBirthDate = txtSenderDOB.Text;
            string sEmail = txtbSenderEmail.Text;
            string sAddress = txtbSenderAdd.Text;
            string sCity = txtbSenderCity.Text;
            string sPostCode = txtbSenderPostcode.Text;
            string sCountry = txtSCountry.Text;
            string sCurrency = txtSCurrency.Text;
            string bCountry = txtBCountry.Text;                     
            string bCurrency = txtBCurrency.Text; 
            string bFirstName = txtBFirstName.Text;
            string bLastName = txtBLastName.Text;
            string bIssuerCode = txtIssuerCode.Text;             
            string BankProvince = "";
            string BankCity = "";
            string BankBranchName = "";
            string BankBranchCode = txtBranchCode.Text;              
            string bAccNum = txtAccNum.Text; 
            string bIdNum = txtBIdNumber.Text;
            string bContactNum = txtBHPNo.Text; 
            string Relationship = txtRelationship.Text;
            string bAddress = txtbBeneAdd.Text;
            string bCity = txtbBeneCity.Text;
            string bPostCode = txtbBenePostcode.Text;
            string bEmail = txtbBeneEmail.Text; 
            string bProvinceCode = txtBProvinceCode.Text;
            string bRegencyCode = txtBRegencyCode.Text;
            string bPayoutID = txtb_payoutid.Text;
            string bPayoutPIN = txtb_payoutpin.Text;
            string TrangloGTN = txtbTrangloGTN.Text;
            string bBillNumber = txtBillNumber.Text;
            string bBillAccName = txtBillAccName.Text;
            string bBillStatementDate = txtBillStatementDate.Text;
            string bBillDueDate = txtBillDueDate.Text;
            string bBillType = txtBillType.Text;
            string bCustomInfo1 = txtCustomInfo1.Text;
            string bCustomInfo2 = txtCustomInfo2.Text;
            string bCustomInfo3 = txtCustomInfo3.Text;
            string bCustomInfo4 = txtCustomInfo4.Text;

            string FRKey = "";

            decimal sAmount = 0;
            decimal trxValue = decimal.Parse(txtAmt.Text);

            int sIdType = 1;
            int bAccType = int.Parse(cmbTrxnChannel.Text);
            int bIdType = 2;
            int bPurposeCode = string.IsNullOrEmpty(txtPurposeCode.Text) ? 0 : int.Parse(txtPurposeCode.Text);

            #endregion 
 
            StringBuilder sbInput = new StringBuilder();
            XmlDocument xDoc = new XmlDocument();
            XmlNode xNode = null;

            #region Do_Transfer is selected
            if (rdbtnDoTransfer.Checked == true)
            {
                // generate signature
                //
                sbInput.Clear();
                sbInput.Append(UID.Trim());
                sbInput.Append(transID.Trim());
                sbInput.Append(trxValue);
                sbInput.Append(sCurrency.Trim());
                sbInput.Append(sIdNum.Trim());
                sbInput.Append(sFirstName);
                sbInput.Append(sLastName);
                sbInput.Append(bCurrency.Trim());
                sbInput.Append(bIdNum);
                sbInput.Append(bFirstName);
                sbInput.Append(bLastName);
                sbInput.Append(bAccType);
                sbInput.Append(bAccNum.Trim());
                sbInput.Append(bIssuerCode.Trim());
                sbInput.Append(Secret);

                rspSign = GenerateRspSign(sbInput.ToString());

                if (rdbtnStaging.Checked)
                {
                    GloRemitNew_111.API_Service1SoapClient service = new GloRemitNew_111.API_Service1SoapClient();

                    var item = service.Do_Transfer(rspSign, UID, PWD, UIDBranch, transID,
                                            sFirstName, sLastName, sIdType, sIdNum, sIdExpiry, sContactNum, sOccupation, sFundSource,
                                            sBirthDate, sEmail, sAddress, sCity, sPostCode, sCountry, sCurrency,
                                            bCountry, bCurrency, trxValue, bFirstName, bLastName, bAccType, bIssuerCode, BankProvince, BankCity,
                                            BankBranchName, BankBranchCode, bAccNum, bIdType, bIdNum, bContactNum, Relationship,
                                            bAddress, bCity, bPostCode, bEmail, bProvinceCode, bRegencyCode, bPayoutID, bPayoutPIN,
                                            sAmount, FRKey, bPurposeCode);


                    xDoc.LoadXml(item.ToString());
                    xNode = xDoc.FirstChild;
                }
            }
            #endregion

            #region Get_Validation is selected

            else if (rdbtnGetValidation.Checked == true)
            {
                // reassign values to variables with separate controls
                //
                sIdNum = txtValidateSIdNumber.Text;
                sFirstName = txtValidateSFirstName.Text;
                sLastName = txtValidateSLastName.Text;
                bFirstName = txtValidateBFirstName.Text;
                bLastName = txtValidateBLastName.Text;
                bCountry = txtValidateBCountry.Text;
                bAccType = int.Parse(cmbValidateBAcctType.Text);
                bIssuerCode = txtValidateBIssuerCode.Text;
                bAccNum = txtValidateBAcctNumber.Text;
                trxValue = decimal.Parse(txtValidateTrxValue.Text);

                //
                // generate signature
                //
                sbInput.Clear();
                sbInput.Append(UID.Trim());
                sbInput.Append(transID.Trim());
                sbInput.Append(sIdNum.Trim());
                sbInput.Append(bAccType);
                sbInput.Append(bAccNum);
                sbInput.Append(bIssuerCode);
                sbInput.Append(Secret);
                
                rspSign = GenerateRspSign(sbInput.ToString());

                if (rdbtnStaging.Checked)
                {
                    GloRemitNew_111.API_Service1SoapClient service = new GloRemitNew_111.API_Service1SoapClient();

                    var item = service.Get_Validation(rspSign, UID, PWD, transID, sIdType, sIdNum, sFirstName, sLastName, bFirstName, bLastName, bCountry, bAccType, bIssuerCode, bAccNum, trxValue);

                    xDoc.LoadXml(item.ToString());
                    xNode = xDoc.FirstChild;
                }
            }

            #endregion

            #region Bill_Payment is selected
            else if (rdbtnDoBillPayment.Checked == true)
            {
                // reassign values to variables with separate controls
                //
                sFirstName = txtBillPaymentSFirstName.Text;
                sLastName = txtBillPaymentSLastName.Text;
                sIdNum = txtBillPaymentSIdNum.Text;
                sContactNum = txtBillPaymentSContactNum.Text;
                sEmail = txtBillPaymentSEmail.Text;
                sCountry = txtBillPaymentSCountry.Text;
                sCurrency = txtBillPaymentSCurrency.Text;

                bCountry = txtBillPaymentBCountry.Text;
                bCurrency = txtBillPaymentBCurrency.Text;
                trxValue = decimal.Parse(txtBillPaymentBAmount.Text);
                bIssuerCode = txtBillPaymentBIsuserCode.Text;
                bAccNum = txtBillPaymentBAccountNum.Text;
                
                //
                // generate signature
                //
                sbInput.Clear();
                sbInput.Append(UID.Trim());
                sbInput.Append(transID.Trim());
                sbInput.Append(trxValue);
                sbInput.Append(sCurrency.Trim());
                sbInput.Append(sIdNum.Trim());
                sbInput.Append(sFirstName);
                sbInput.Append(sLastName);
                sbInput.Append(bCurrency.Trim());
                sbInput.Append(bAccNum);
                sbInput.Append(bIssuerCode);
                sbInput.Append(Secret);

                rspSign = GenerateRspSign(sbInput.ToString());

                if (rdbtnStaging.Checked)
                {
                    GloRemitNew_111.API_Service1SoapClient service = new GloRemitNew_111.API_Service1SoapClient();

                    var item = service.Do_BillPayment(rspSign, UID, PWD, UIDBranch, transID, 
                        sFirstName, sLastName, sIdType, sIdNum, sIdExpiry, sContactNum, sEmail, sCountry, sCurrency, 
                        bCountry, bCurrency, trxValue, bIssuerCode, bAccNum, bBillNumber, bBillAccName, bBillStatementDate, bBillDueDate, 
                        bBillType, bCustomInfo1, bCustomInfo2, bCustomInfo3, bCustomInfo4, "", "", "", "", "", "");

                    xDoc.LoadXml(item.ToString());
                    xNode = xDoc.FirstChild;
                }
            }
            #endregion

            #region Bill_Inquiry is selected

            else if (rdbtnDoBillInquiry.Checked == true)
            {
                // reassign values to variables with separate controls
                //
                sIdNum = txtBillInquirySIdNum.Text;
                sFirstName = txtBillInquirySFirstName.Text;
                sLastName = txtBillInquirySLastName.Text;
                bCountry = txtBillInquiryBCountry.Text;
                bCurrency = txtBillInquiryBCurrency.Text;
                trxValue = decimal.Parse(txtBillInquiryBAmount.Text);
                bIssuerCode = txtBillInquiryBIssuerCode.Text;
                bAccNum = txtBillInquiryBAcctNum.Text;

                //
                // generate signature
                //
                sbInput.Clear();
                sbInput.Append(UID.Trim());
                sbInput.Append(transID.Trim());
                sbInput.Append(sIdNum.Trim());
                sbInput.Append(bAccNum);
                sbInput.Append(bIssuerCode);
                sbInput.Append(Secret);

                rspSign = GenerateRspSign(sbInput.ToString());

                if (rdbtnStaging.Checked)
                {
                    GloRemitNew_111.API_Service1SoapClient service = new GloRemitNew_111.API_Service1SoapClient();

                    var item = service.Do_BillInquiry(rspSign, UID, PWD, transID, sIdType, sIdNum, sFirstName, sLastName, bCountry, bCurrency, trxValue, bIssuerCode, bAccNum);

                    xDoc.LoadXml(item.ToString());
                    xNode = xDoc.FirstChild;
                }
            }
            #endregion

            #region Change_Name is selected

            else if (rdbtnDoChangeName.Checked == true)
            {
                // reassign values to variables with separate controls
                //
                bFirstName = txtCNBeneFirstName.Text;
                bLastName = txtCNBeneLastName.Text;
                TrangloGTN = txtCNGTN.Text;

                if (String.IsNullOrEmpty(TrangloGTN))
                {
                    richText += "Please enter GTN for Do ChangeName";
                    richTxtBoxStatus.Text = richText;
                    richTxtBoxStatus.SelectionStart = richTxtBoxStatus.Text.Length;
                    richTxtBoxStatus.ScrollToCaret();
                    return;
                }
                else
                {
                   // generate signature
                   //
                    sbInput.Clear();
                    sbInput.Append(UID.Trim());
                    sbInput.Append(transID.Trim());
                    sbInput.Append(bFirstName);
                    sbInput.Append(bLastName);
                    sbInput.Append(Secret);

                    rspSign = GenerateRspSign(sbInput.ToString());

                    if (rdbtnStaging.Checked)
                    {
                        GloRemitNew_111.API_Service1SoapClient service = new GloRemitNew_111.API_Service1SoapClient();

                        var item = service.Do_ChangeName(UID, PWD, rspSign, transID, TrangloGTN, bFirstName, bLastName);

                        xDoc.LoadXml(item.ToString());
                        xNode = xDoc.FirstChild;
                    }
                }
            }
            #endregion

            #region Do_Cancellation is selected

            else if (rdbtnDoCancel.Checked == true)
            {
                if (String.IsNullOrEmpty(TrangloGTN))
                {
                    richText += "Please enter GTN for Do ChangeName";
                    richTxtBoxStatus.Text = richText;
                    richTxtBoxStatus.SelectionStart = richTxtBoxStatus.Text.Length;
                    richTxtBoxStatus.ScrollToCaret();
                    return;

                }
                else
                {
                    // generate signature
                    //
                    sbInput.Clear();
                    sbInput.Append(UID.Trim());
                    sbInput.Append(TrangloGTN);
                    sbInput.Append(transID.Trim());
                    sbInput.Append(Secret);

                    rspSign = GenerateRspSign(sbInput.ToString());

                    if (rdbtnStaging.Checked)
                    {
                        GloRemitNew_111.API_Service1SoapClient service = new GloRemitNew_111.API_Service1SoapClient();

                        var item = service.Do_Cancellation(UID, PWD, rspSign, transID, TrangloGTN);

                        xDoc.LoadXml(item.ToString());
                        xNode = xDoc.FirstChild;
                    }
                }
            }

            #endregion

            #region Get_TrxStatus is selected
            else if (rdbtnGetTrxStatus.Checked)
            {
                if (String.IsNullOrEmpty(TrangloGTN))
                {
                    richText += "Please enter GTN for Get Transaction Status";
                    richTxtBoxStatus.Text = richText;
                    richTxtBoxStatus.SelectionStart = richTxtBoxStatus.Text.Length;
                    richTxtBoxStatus.ScrollToCaret();
                    return;

                }
                else
                {
                    sbInput.Clear();
                    sbInput.Append(UID.Trim());
                    sbInput.Append(TrangloGTN);
                    sbInput.Append(transID.Trim());
                    sbInput.Append(Secret);

                    rspSign = GenerateRspSign(sbInput.ToString());

                    if (rdbtnStaging.Checked)
                    {
                        GloRemitNew_111.API_Service1SoapClient service = new GloRemitNew_111.API_Service1SoapClient();

                        var item = service.Get_TrxStatus(rspSign, UID, PWD, TrangloGTN, transID);

                        xDoc.LoadXml(item.ToString());
                        xNode = xDoc.FirstChild;
                    }
                }
            }
            #endregion 

            foreach (XmlNode childnode in xNode.ChildNodes)
            {
                richText += childnode.Name + ":" + childnode.InnerText + System.Environment.NewLine;
            }

            richText += System.Environment.NewLine;
            richTxtBoxStatus.Text = richText;
        }

        protected internal static bool OnValidationCallback(object sender, System.Security.Cryptography.X509Certificates.X509Certificate cert, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors errors)
        {
            return true; 
        }

        private void tbFunctions_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0: // Do_Transfer
                    rdbtnDoTransfer.Checked = true;
                    break;
                case 1: // Get_Validation
                    rdbtnGetValidation.Checked = true;
                    break;
                case 2: // Get_TrxStatus / Do_Cancellation
                    rdbtnGetTrxStatus.Checked = true;
                    break;
                case 3: // Do_ChangeName
                    rdbtnDoChangeName.Checked = true;
                    break;
                case 4: // Do_BillPayment
                    rdbtnDoBillPayment.Checked = true;
                    break;
                case 5: // Do_BillInquiry
                    rdbtnDoBillInquiry.Checked = true;
                    break;
                default:
                    break;
            }
        }
    }
}
