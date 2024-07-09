using iText.StyledXmlParser.Jsoup.Nodes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Document = iTextSharp.text.Document;


namespace Bank_ATM
{


    public partial class BankingScreen : Form
    {
        //Creates a new instance of the LoginScreen form
        // LoginScreen ls = new LoginScreen();

        //Creates a new instance of the MiniStatement form
        MiniStatement ms = new MiniStatement();


        // List<Bank_Clients> cardHolders = new List<Bank_Clients>();
        //Creates a client
        Bank_Clients client = new Bank_Clients("Sipho", "Mahlangu", 3333, 123456789123, 450.00);

        //Array to store the user's details
        String[] loggedClient;

        // Unique Id to identify user transactions
        int id = 0;


        //transaction date
        DateTime now = DateTime.Now;

        //Boolean variable to check if balance button is clicked
        private bool btnBalanceisClicked = false;
        //bool variable to check if the Withdraw button is clicked
        bool btnwithdrawClicked = false;
        //bool variable to check if the Deposit button is clicked
        bool btnDepositClicked = false;

        public BankingScreen()
        {
            //Close The logging Screen Form

            InitializeComponent();
            //user cannot deposit any  amount
            gbDeposit.Visible = false;
            //user cannot customise withdrawal amount
            txtWithdrawAmount.Visible = false;
            //Hides the withdrawal options from the user
            flpMain.Visible = false;

            ///Hides the Ministatement Panel
            pministatement.Visible = false;

            //Stores the user's FullName and card number
            loggedClient = new string[8] { id.ToString(), "", client.GetcardNo().ToString(), "", "", "", "", "" };


        }



        private void btnBalance_Click(object sender, EventArgs e)
        {
            //Displays the logged-In user's balance
            lblBalance.Text = "R " + client.Getbalance().ToString();


            //Hides Deposit and Withdraw from the user for 30 seconds
            btnWithdraw.Enabled = false;
            btnDeposit.Enabled = false;


            //Enables the timer
            tmr.Enabled = true;
            // tmr.Start();

            btnBalanceisClicked = true;

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //Makes the deposit input available to the user
            gbDeposit.Visible = true;


            //Hides Withdraw and Balance Options from the user
            btnBalance.Enabled = false;
            btnWithdraw.Enabled = false;

            //bool variable to check if the Deposit button is clicked
            btnDepositClicked = true;

            //Sets the Withdraw boolean to false
            btnwithdrawClicked = false;


        }

        //CONFIRMATION BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            //Check if the Button text is OK
            //Sets the all the buttons to enabled
            //Stops the timer

            if (btnBalanceisClicked)
            {
                tmr.Stop();
                btnDeposit.Enabled = true;
                btnWithdraw.Enabled = true;
                btnCancel.Enabled = true;
                lblBalance.Text = "";
                btnBalanceisClicked = false;

            }
            else
            {

                try
                {
                    //If deposit input is not empty and btn Deposit is clicked and Withdraw function is not Clicked
                    if (btnDepositClicked && btnwithdrawClicked == false)
                    {

                        if (txtDeposit.Text != "")

                        {

                            //updates the user's balance
                            client.Setbalance(double.Parse(txtDeposit.Text) + client.Getbalance());

                            //Confirms if the deposits was succesfull
                            DialogResult d = MessageBox.Show("An amount of " + "R" + double.Parse(txtDeposit.Text) + " was succesfully deposited in your account" +
                                   "\n" + "Your new balance is R" + client.Getbalance());




                            //Stores  the deposited amount, description, trans date and Balance
                            id++;
                            loggedClient[0] = id.ToString();
                            loggedClient[1] = "Dep77765344B";
                            loggedClient[2] = now.ToString();
                            loggedClient[3] = "Deposit";
                            //loggedClient[5] = "Successful";
                            loggedClient[4] = ("R " + double.Parse(txtDeposit.Text).ToString());
                            loggedClient[5] = "R " + client.Getbalance().ToString();

                            Populatedgv();

                            //Resets the txtDeposit
                            txtDeposit.Text = "";

                            gbDeposit.Visible = false;

                            //Checks if the user is done with deposit process and enables other options for the user
                            if (d == DialogResult.OK)
                            {
                                btnWithdraw.Enabled = true;
                                btnBalance.Enabled = true;
                            }

                        }
                        else
                        {

                            MessageBox.Show("NO DEPOSIT MADE");
                        }
                    }

                    //If  btnWithdraw is clicked and Deposit button is not Clicked
                    if (btnwithdrawClicked && btnDepositClicked == false)
                    {

                        if (txtWithdrawAmount.Text != "")
                        {
                            //If the withdrawal Amount is less than the Balance
                            if (double.Parse(txtWithdrawAmount.Text) < client.Getbalance())
                            {
                                //Subract the withdrawal amount from the balance
                                client.Setbalance(client.Getbalance() - double.Parse(txtWithdrawAmount.Text));

                                //Updates the user
                                DialogResult d = MessageBox.Show("An amount of R" + double.Parse(txtWithdrawAmount.Text) + ",00" +
                                    " was Successfully withdrawn " +
                                    "\n" + "Available balance R" + client.Getbalance() + ",00");


                                //Stores the transcation ref number,Withdrawal amount, Description, trans date and Balance
                                id++;
                                loggedClient[0] = id.ToString();
                                loggedClient[1] = "Withdraw77765344B";
                                loggedClient[2] = now.ToString();
                                loggedClient[3] = "Withdrawal";
                                //loggedClient[5] = "Successful";
                                loggedClient[4] = ("-R " + double.Parse(txtWithdrawAmount.Text).ToString());
                                loggedClient[5] = "R " + client.Getbalance().ToString();

                                Populatedgv();

                                //Resets the txtWithdrawAmount input
                                txtWithdrawAmount.Text = "";

                                //Checks if the user is done with Withdrawal process and enables other options for the user
                                if (d == DialogResult.OK)
                                {
                                    btnDeposit.Enabled = true;
                                    btnBalance.Enabled = true;
                                }


                                //Hides the withdrawal options from the user
                                flpMain.Visible = false;

                                txtWithdrawAmount.Visible = false;

                            }
                            else
                            {
                                DialogResult d = MessageBox.Show("Insufficient Funds," + "Available Balance is R" + client.Getbalance());

                                //Stores the Withdrawal amount, transaction refnumber, Description, trans date and Balance
                                id++;
                                loggedClient[0] = id.ToString();
                                loggedClient[1] = "Insuf77765344B";
                                loggedClient[2] = now.ToString();
                                loggedClient[3] = "Withdrawal";
                                loggedClient[5] = "Insufficient Funds";
                                loggedClient[4] = ("R " + double.Parse(txtWithdrawAmount.Text).ToString());
                                loggedClient[5] = "R " + client.Getbalance().ToString();

                                Populatedgv();

                                //Resets the txtWithdrawAmount input
                                txtWithdrawAmount.Text = "";
                                txtWithdrawAmount.Visible = false;

                                //Checks if the user is done with Withdrawal process and enables other options for the user
                                if (d == DialogResult.OK)
                                {
                                    btnDeposit.Enabled = true;
                                    btnBalance.Enabled = true;
                                }


                                //Hides the withdrawal options from the user
                                flpMain.Visible = false;


                            }
                        }
                        else
                        {
                            MessageBox.Show("Please specify the Withdrawal Amount ");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }




        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void txtWithdrawAmount_TextChanged(object sender, EventArgs e)
        {
            txtWithdrawAmount.MaxLength = 4;
        }

        private void rbCustAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustAmount.Checked)
            {

                txtWithdrawAmount.Visible = true;


                //User can customize their withdrawal amount
                txtWithdrawAmount.ReadOnly = false;

                //Uncheck the option
                rbCustAmount.Checked = false;

            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //Makes the withdraw options available to the user
            flpMain.Visible = true;

            //Disables  the Deposit and Balance
            btnBalance.Enabled = false;
            btnDeposit.Enabled = false;

            //bool variable to make sure only the Withdraw fucntion operates
            btnwithdrawClicked = true;

            //Turns the Deposit button boolen off
            btnDepositClicked = false;

            //User can customize their withdrawal amount
            txtWithdrawAmount.ReadOnly = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Cancel all the  processes
            // this.InitializeComponent();

            //user cannot deposit any  amount
            gbDeposit.Visible = false;
            //user cannot customise withdrawal amount
            txtWithdrawAmount.Visible = false;
            //Hides the withdrawal options from the user
            flpMain.Visible = false;


            //--------------------WITHDRAW BUTTON-----------------
            //Enables  the Deposit and Balance
            btnBalance.Enabled = true;
            btnDeposit.Enabled = true;

            //bool variable to make sure only the Withdraw fucntion operates
            btnwithdrawClicked = false;

            //Turns the Deposit button boolen off
            btnDepositClicked = false;



            //--------------------DEPOSIT--------------------------------
            //Makes the deposit input available to the user
            // gbDeposit.Visible = true;


            //Enables  the Balance and Withdraw
            btnBalance.Enabled = true;
            btnWithdraw.Enabled = true;

            //bool variable to check if the Deposit button is clicked
            btnDepositClicked = false;

            //Sets the Withdraw boolean to false
            btnwithdrawClicked = false;


        }

        //--------------------------------------WITHDRAW OPTION-----------------------------------



        //When R20 option is selected
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            WithdrawOption(rbR20);
            //Unchecks the rb
            rbR20.Checked = false;
        }


        //When R50 option is selected
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            WithdrawOption(rbR50);
            //Unchecks the rb
            rbR50.Checked = false;
        }

        //When 100 Option is Selected
        private void rbR150_CheckedChanged(object sender, EventArgs e)
        {
            WithdrawOption(rbR100);
            //Unchecks the rb
            rbR100.Checked = false;
        }

        //When R150 Option Is Selected
        private void rbR200_CheckedChanged(object sender, EventArgs e)
        {
            WithdrawOption(rbR150);
            //Unchecks the rb
            rbR150.Checked = false;
        }

        //When R200 Option Is Selected
        private void rbR200_CheckedChanged_1(object sender, EventArgs e)
        {
            WithdrawOption(rbR200);
            //Unchecks the rb
            rbR200.Checked = false;
        }

        //When R1000 Option Is Selected
        private void rbR1000_CheckedChanged(object sender, EventArgs e)
        {
            WithdrawOption(rbR1000);
            //Unchecks the rb
            rbR1000.Checked = false;
        }

        //When R2000 Option Is Selected
        private void rbR2000_CheckedChanged(object sender, EventArgs e)
        {
            WithdrawOption(rbR2000);
            //Unchecks the rb
            rbR2000.Checked = false;
        }

        //-------------------------------------------------------------------------------------------------------------




        //Timer counter
        int i = 60;
        private void tmr_Tick(object sender, EventArgs e)
        {

            if (i != 0)
            {
                i--;

                //Cancel Button not Enabled
                btnCancel.Enabled = false;

            }
            else
            {
                tmr.Stop();
                btnDeposit.Enabled = true;
                btnWithdraw.Enabled = true;

                //Cancel Button Enabled
                btnCancel.Visible = true;
                lblBalance.Text = "";

                i = 60;
            }
        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {
            txtDeposit.MaxLength = 4;
        }


        ///---------------------------------------FUNCTIONS---------------------------------------
        /// This function allows the user to choose the amount to be withdrawn
        /// 
        /// </summary>
        /// it takes it the selected radioButton by the user
        public void WithdrawOption(RadioButton rb)
        {
            if (rb.Checked)
            {
                //Shows the Withdrawal option to the user
                txtWithdrawAmount.Visible = true;

                //Sets the selected amount 
                txtWithdrawAmount.Text = rb.Text;

                //restricts the user from customizing the withdrawal amount
                txtWithdrawAmount.ReadOnly = true;

                //Uncheck the option
                //rbR100.Checked = false;
            }
        }

        /// Zero parameter function that populates user's transactions to the dgv
        /// 
        /// </summary>
        public void Populatedgv()
        {
            //Prevents the user from duplicating transactions 
            Boolean found = false;
            foreach (DataGridViewRow row in dgv.Rows)
            {

                if (row.Cells[0].Value == loggedClient[0])
                {
                    // row exists
                    found = true;
                    // MessageBox.Show("Row already exists");
                    btnGetStatement.Enabled = false;
                    break;
                }
            }

            if (!found)
            {
                dgv.Rows.Add(loggedClient);

                btnGetStatement.Enabled = true;

            }

        }




        //Shows the MiniStatement Panel and hides the Bankscreen panel
        private void button1_Click_2(object sender, EventArgs e)
        {

            pministatement.Visible = true;
            pBankscreen.Visible = false;

            //Enables  the ViewStatement button
            btnGetStatement.Enabled = true;



            //dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

        }

        private void gbDeposit_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        //Hides the Ministatement Panel and opens the BankingScreen Panel
        private void btnClose_Click(object sender, EventArgs e)
        {
            pministatement.Visible = false;
            pBankscreen.Visible = true;

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Thank you for using our Services ,GoodBye!!!");
            //DialogResult d = 

        }

        //Creates a pdf statemet for the user.
        private void btnGetStatement_Click(object sender, EventArgs e)

        {
          
            if (dgv.Rows.Count > 0)
            {
                
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf)";
                saveFileDialog.FileName = "Result.pdf";
                bool errormessage = false;

                if(saveFileDialog.ShowDialog() == DialogResult.OK) 
                
                {
                    if(File.Exists(saveFileDialog.FileName))
                    {
                        try 
                        {
                            File.Delete(saveFileDialog.FileName);
                        }catch(Exception ex) 
                        {
                            errormessage = true;
                            MessageBox.Show("File already exists "+ex.Message);
                            throw;
                        }
                    
                    }

                    if (!errormessage)
                    {
                        try 
                        {
                            PdfPTable pTable = new PdfPTable(dgv.Columns.Count - 1);
                            //Set the space before the table
                            pTable.SpacingBefore = 20;
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;

                            iTextSharp.text.Font myFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD); //Bold Styling

                            foreach (DataGridViewColumn col in dgv.Columns)
                            {
                                if(!col.Visible) continue; //Makes sure populated columns are only those visible ones.
                               
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText,myFont));
                                pTable.AddCell(pCell);
                            }

                            foreach (DataGridViewRow viewrow in dgv.Rows)
                            {

                                foreach (DataGridViewCell dcell in viewrow.Cells)
                                {
                                    if (!dgv.Columns[dcell.ColumnIndex].Visible) continue;
                                    
                                    //Cast the dgv cells(Objects) to string
                                    pTable.AddCell((string)dcell.Value);
                                }
                            }

                            using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create)) 
                            {
                               Document document = new Document(PageSize.A4,8f,16f,8f,16f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                //Puts in the Bank's logo
                                string imagepath = "C:\\Users\\User\\Documents\\Projects\\BANK Project\\Bank ATM (docs)\\Images\\BankLogo.jpg";
                                iTextSharp.text.Image bankLogo = iTextSharp.text.Image.GetInstance(imagepath);

                                //Resisize the bank logo image
                                bankLogo.ScalePercent(15f);

                                //Writes the BankName
                                var bankPhrase= new Phrase();
                                bankPhrase.Add(new Chunk("Finance Bank",myFont));
                                bankPhrase.Add(new Chunk("\n"+"0987 Second street, Austin, Tx 123567-894" + "\n" + "1-000 87449 7"+ "\n" + "\n"));
                                //iTextSharp.text.Font myFont = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 255));
                               
                                
                                //Writes the Customer's address
                                var customerPhrase = new Phrase();
                                customerPhrase.Add(new Chunk("Photography Bussiness, LLC", myFont));
                                customerPhrase.Add(new Chunk("\n" + "Mr. " + client.Getname() + " " + client.Getsurname() + " 123 End street " + "\n" + "Austin City ,1-000 87449 7"));
                                Paragraph customerdetails = new Paragraph();
                                customerdetails.SpacingBefore = 20;

                                //Writes the Account details
                                Paragraph Accountdetails = new Paragraph("Account Name : "+"    Photography Business,LLC "+ "\n"+"Account Type : " + "     Savings Account " + "\n" +"Account Number  : " + loggedClient[2] + "\n" + "Statement Period : " + "DD/MM/YYYY" );
                                //Accountdetails.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                                Accountdetails.SpacingBefore = -55;
                                Accountdetails.IndentationLeft = 310;

                                document.Add(bankLogo);
                                document.Add(bankPhrase); //Adds the Bank's Name
                               // document.Add(bankdetails);
                                document.Add(customerPhrase);
                               // document.Add(customerdetails);
                                document.Add(Accountdetails);
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();

                            }

                            MessageBox.Show("Data Exported Successfully");

                        }
                        catch (Exception ex) 
                        {
                            MessageBox.Show("Error while Exporting "+ ex.Message);
                        }
                    }
                
                }
            }
            else 
            {
                MessageBox.Show("No Record to export");
            }
            
        }

        private void BankingScreen_Load(object sender, EventArgs e)
        {
            //DataGridView Setup
            dgv.ColumnCount = 6;

            dgv.Columns[0].Name = "ID";
           // dgv.Columns[1].Name = "DELETE";
            dgv.Columns[1].Name = "Reference";
            dgv.Columns[2].Name = "Transaction Date";
            dgv.Columns[3].Name = "Description";
           // dgv.Columns[5].Name = "DELETE";
            dgv.Columns[4].Name = "Amount ";
            dgv.Columns[5].Name = "Balance";

            //User cannot edit data in DataGridView
            dgv.ReadOnly = true;

            //Hides the ID column from the user
            dgv.Columns[0].Visible = false;
        }
    }
}
