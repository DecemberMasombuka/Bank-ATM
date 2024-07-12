using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Bank_ATM
{
    public partial class LoginScreen : Form
    {

       
        //Instantiating myconnection class
        Myconnection mycon = new Myconnection();

        string myvar = null;


        public LoginScreen()
        {
            InitializeComponent();

            //Disables the Login Button
            //btnOk.Enabled = false;


            //Changes the Boarder of picture1 to round
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;

            //Picture 2 
            gp.AddEllipse(0, 0, pictureBox2.Width - 3, pictureBox2.Height - 3);
            Region rg2 = new Region(gp);
            pictureBox1.Region = rg2;

            //Picture 3
            gp.AddEllipse(0, 0, pictureBox3.Width - 3, pictureBox3.Height - 3);
            Region rg3 = new Region(gp);
            pictureBox1.Region = rg3;
        }

        private void txtCardNo_TextChanged(object sender, EventArgs e)
        {
            txtCardNo.MaxLength = 13;

        }


        //LoginButton
        private void btnOk_Click(object sender, EventArgs e)
        {   //Create Bank_Client customers
            Bank_Clients client = new Bank_Clients("Sipho", "Mahlangu", 3333, 1234567890123, 450.00);

            // Validated users details
            // bs.Show();

            string customerId = "";
            if (isValidated())
            {
                try
                {
                    mycon.con.Open(); //Opens the connection
                    SqlCommand cmd = new SqlCommand("pr_customers", mycon.con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usercardno", txtCardNo.Text);
                    cmd.Parameters.AddWithValue("@userpin", txtPin.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {

                        this.Hide();
                        reader.Read();
                        customerId = reader["Customer_id"].ToString();
                        BankingScreen bs = new BankingScreen(customerId);
                        bs.Show();



                    }
                    else
                    {
                        MessageBox.Show("Enter valid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCardNo.Clear();
                        txtCardNo.Focus();
                        txtPin.Clear();
                    }
                    mycon.con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }

            }


        }



        //Is user validated
        private bool isValidated()
        {
           if(txtCardNo.Text.Trim() == String.Empty) 
            {
                MessageBox.Show("Enter card number", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtCardNo.Clear();
                txtPin.Clear();
                txtCardNo.Focus();

                return false;
            }

            if (txtPin.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Enter Pin code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //txtCardNo.Clear();
                txtPin.Clear();
                txtPin.Focus();

                return false;
            }

            return true;
        }

       
        private bool isValidatedNewPin()
        {
            //MessageBox.Show("Enter a new 5 digit pin");
            if (txtPin.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Enter a new Pin code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //txtCardNo.Clear();
                txtPin.Clear();
                txtPin.Focus();

                return false;
            }

            return true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            txtPin.MaxLength = 4;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {
            /*if(isValidated())
            {
                try
                {
                    //See if the user's old pin matches/exists in the database
                    mycon.con.Open(); //Opens the connection
                    SqlCommand cmd = new SqlCommand("customer_login", mycon.con); //pass our procedure's name and connection to the db
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usercardno", txtCardNo.Text); //Pass cardNo and Pin as parameters to Sql procedure
                    cmd.Parameters.AddWithValue("@userpin", txtPin.Text);

                    SqlDataReader reader = cmd.ExecuteReader(); //Reading data from sql

                    if (reader.HasRows)
                    {

                        //txtCardNo.Clear();
                        //txtPin.Clear();
                       // txtCardNo.Focus();
                        MessageBox.Show("Enter Card Number and Your Pin");
                       // mycon.con.Close();
                        //mycon.con.Open();


                            SqlCommand cmdpinupdate = new SqlCommand("Update BankCustomers set Pin = @Pin where CardNumber = @CardNumber ", mycon.con);

                            cmdpinupdate.Parameters.AddWithValue("@Pin", txtPin.Text);
                            cmdpinupdate.Parameters.AddWithValue("@CardNumber", txtCardNo.Text);


                            cmdpinupdate.ExecuteNonQuery();

                            MessageBox.Show("Pin Code Successfully changed, Login with your new pin");
                        

                        
                      
                    }
                    else
                    {
                        MessageBox.Show("Enter valid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCardNo.Text = "";
                        txtCardNo.Focus();
                        txtPin.Text = "";

                        // mycon.con.Close() ;
                    }

                    mycon.con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }

            *//*MessageBox.Show("Please enter your card number and old pin code");
            txtCar*//*dNo.Text = "";
            txtCardNo.Focus();
            txtPin.Text = ""; */
           

        }
    }
}