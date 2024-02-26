namespace Bank_ATM
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            txtCardNo = new TextBox();
            txtPin = new TextBox();
            btnOk = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnChangePin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtCardNo
            // 
            txtCardNo.Location = new Point(138, 139);
            txtCardNo.Multiline = true;
            txtCardNo.Name = "txtCardNo";
            txtCardNo.PlaceholderText = "13 digit card Number";
            txtCardNo.Size = new Size(337, 40);
            txtCardNo.TabIndex = 2;
            txtCardNo.TextChanged += txtCardNo_TextChanged;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(138, 185);
            txtPin.Multiline = true;
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.PlaceholderText = "4 number pin";
            txtPin.Size = new Size(337, 40);
            txtPin.TabIndex = 3;
            txtPin.TextChanged += txtPin_TextChanged;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.LightCyan;
            btnOk.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Location = new Point(199, 297);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(167, 40);
            btnOk.TabIndex = 5;
            btnOk.Text = "Login";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Cyan;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(245, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 88);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(88, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 39);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(88, 186);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 39);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // btnChangePin
            // 
            btnChangePin.BackColor = Color.LightCyan;
            btnChangePin.FlatStyle = FlatStyle.Popup;
            btnChangePin.Font = new Font("Sitka Small", 8F, FontStyle.Italic, GraphicsUnit.Point);
            btnChangePin.Location = new Point(354, 231);
            btnChangePin.Name = "btnChangePin";
            btnChangePin.Size = new Size(121, 35);
            btnChangePin.TabIndex = 9;
            btnChangePin.Text = "Change Pin";
            btnChangePin.UseVisualStyleBackColor = false;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(563, 455);
            Controls.Add(btnChangePin);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnOk);
            Controls.Add(txtPin);
            Controls.Add(txtCardNo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginScreen";
            Text = "Welcome Screen";
            Load += LoginScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCardNo;
        private TextBox txtPin;
        private Button btnOk;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnChangePin;
    }
}