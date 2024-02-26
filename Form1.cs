namespace Bank_ATM
{
    public partial class LoginScreen : Form
    {

        BankingScreen bs = new BankingScreen();





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



            //MessageBox.Show(clients.Getbalance().ToString());
        }

        private void txtCardNo_TextChanged(object sender, EventArgs e)
        {
            txtCardNo.MaxLength = 13;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {   //Create Bank_Client customers
            Bank_Clients client = new Bank_Clients("Sipho", "Mahlangu", 3333, 1234567890123, 450.00);
            // Validated users details

            try
            {
                if (long.Parse(txtCardNo.Text) == client.GetcardNo() ||
                    short.Parse(txtPin.Text) == client.Getpin())
                {

                    DialogResult d = MessageBox.Show("Succesfully Logged In");
                    txtCardNo.Text = "";
                    txtPin.Text = "";

                    //If Successfully Authenticated, Procced to next screen

                    bs.Show();

                    if (d == DialogResult.OK)
                    {
                        btnOk.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show("Wrong details!! , Failed To Log In , Try Again");
                    txtCardNo.Text = "";
                    txtPin.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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
    }
}