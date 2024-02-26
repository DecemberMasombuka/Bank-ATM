namespace Bank_ATM
{
    partial class BankingScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankingScreen));
            btnWithdraw = new Button();
            btnDeposit = new Button();
            btnBalance = new Button();
            btnExit = new Button();
            flpMain = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            rbR20 = new RadioButton();
            rbR50 = new RadioButton();
            rbR100 = new RadioButton();
            rbR150 = new RadioButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            rbR200 = new RadioButton();
            rbR1000 = new RadioButton();
            rbR2000 = new RadioButton();
            rbCustAmount = new RadioButton();
            txtWithdrawAmount = new TextBox();
            groupBox1 = new GroupBox();
            lblBalance = new Label();
            gbDeposit = new GroupBox();
            textBox1 = new TextBox();
            txtDeposit = new TextBox();
            groupBox3 = new GroupBox();
            btnConfim = new Button();
            btnCancel = new Button();
            tmr = new System.Windows.Forms.Timer(components);
            btnMiniState = new Button();
            pBankscreen = new Panel();
            pministatement = new Panel();
            dgv = new DataGridView();
            btnGetStatement = new Button();
            button1 = new Button();
            btnClose = new Button();
            flpMain.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            gbDeposit.SuspendLayout();
            groupBox3.SuspendLayout();
            pBankscreen.SuspendLayout();
            pministatement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnWithdraw
            // 
            btnWithdraw.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnWithdraw.Location = new Point(0, 36);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(210, 109);
            btnWithdraw.TabIndex = 0;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeposit.Location = new Point(549, 36);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(210, 109);
            btnDeposit.TabIndex = 1;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnBalance
            // 
            btnBalance.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBalance.Location = new Point(0, 160);
            btnBalance.Name = "btnBalance";
            btnBalance.Size = new Size(210, 109);
            btnBalance.TabIndex = 2;
            btnBalance.Text = "Balance";
            btnBalance.UseVisualStyleBackColor = true;
            btnBalance.Click += btnBalance_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(549, 288);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(210, 109);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // flpMain
            // 
            flpMain.BackColor = Color.PaleGreen;
            flpMain.BorderStyle = BorderStyle.Fixed3D;
            flpMain.Controls.Add(flowLayoutPanel2);
            flpMain.Controls.Add(flowLayoutPanel1);
            flpMain.FlowDirection = FlowDirection.TopDown;
            flpMain.Location = new Point(216, 111);
            flpMain.Name = "flpMain";
            flpMain.Size = new Size(327, 182);
            flpMain.TabIndex = 4;
            flpMain.Paint += flowLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(rbR20);
            flowLayoutPanel2.Controls.Add(rbR50);
            flowLayoutPanel2.Controls.Add(rbR100);
            flowLayoutPanel2.Controls.Add(rbR150);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(152, 177);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 4;
            label1.Text = "Amount(Rands)";
            // 
            // rbR20
            // 
            rbR20.AutoSize = true;
            rbR20.Location = new Point(3, 24);
            rbR20.Name = "rbR20";
            rbR20.Size = new Size(57, 29);
            rbR20.TabIndex = 0;
            rbR20.TabStop = true;
            rbR20.Text = "20";
            rbR20.UseVisualStyleBackColor = true;
            rbR20.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbR50
            // 
            rbR50.AutoSize = true;
            rbR50.Location = new Point(3, 59);
            rbR50.Name = "rbR50";
            rbR50.Size = new Size(57, 29);
            rbR50.TabIndex = 1;
            rbR50.TabStop = true;
            rbR50.Text = "50";
            rbR50.UseVisualStyleBackColor = true;
            rbR50.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbR100
            // 
            rbR100.AutoSize = true;
            rbR100.Location = new Point(3, 94);
            rbR100.Name = "rbR100";
            rbR100.Size = new Size(67, 29);
            rbR100.TabIndex = 2;
            rbR100.TabStop = true;
            rbR100.Text = "100";
            rbR100.UseVisualStyleBackColor = true;
            rbR100.CheckedChanged += rbR150_CheckedChanged;
            // 
            // rbR150
            // 
            rbR150.AutoSize = true;
            rbR150.Location = new Point(3, 129);
            rbR150.Name = "rbR150";
            rbR150.Size = new Size(67, 29);
            rbR150.TabIndex = 3;
            rbR150.TabStop = true;
            rbR150.Text = "150";
            rbR150.UseVisualStyleBackColor = true;
            rbR150.CheckedChanged += rbR200_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(rbR200);
            flowLayoutPanel1.Controls.Add(rbR1000);
            flowLayoutPanel1.Controls.Add(rbR2000);
            flowLayoutPanel1.Controls.Add(rbCustAmount);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(161, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(159, 177);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 4;
            label2.Text = "Amount(Rands)";
            // 
            // rbR200
            // 
            rbR200.AutoSize = true;
            rbR200.Location = new Point(3, 24);
            rbR200.Name = "rbR200";
            rbR200.Size = new Size(67, 29);
            rbR200.TabIndex = 0;
            rbR200.TabStop = true;
            rbR200.Text = "200";
            rbR200.UseVisualStyleBackColor = true;
            rbR200.CheckedChanged += rbR200_CheckedChanged_1;
            // 
            // rbR1000
            // 
            rbR1000.AutoSize = true;
            rbR1000.Location = new Point(3, 59);
            rbR1000.Name = "rbR1000";
            rbR1000.Size = new Size(77, 29);
            rbR1000.TabIndex = 1;
            rbR1000.TabStop = true;
            rbR1000.Text = "1000";
            rbR1000.UseVisualStyleBackColor = true;
            rbR1000.CheckedChanged += rbR1000_CheckedChanged;
            // 
            // rbR2000
            // 
            rbR2000.AutoSize = true;
            rbR2000.Location = new Point(3, 94);
            rbR2000.Name = "rbR2000";
            rbR2000.Size = new Size(77, 29);
            rbR2000.TabIndex = 2;
            rbR2000.TabStop = true;
            rbR2000.Text = "2000";
            rbR2000.UseVisualStyleBackColor = true;
            rbR2000.CheckedChanged += rbR2000_CheckedChanged;
            // 
            // rbCustAmount
            // 
            rbCustAmount.AutoSize = true;
            rbCustAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbCustAmount.Location = new Point(3, 129);
            rbCustAmount.Name = "rbCustAmount";
            rbCustAmount.Size = new Size(124, 29);
            rbCustAmount.TabIndex = 3;
            rbCustAmount.TabStop = true;
            rbCustAmount.Text = "Customise";
            rbCustAmount.UseVisualStyleBackColor = true;
            rbCustAmount.CheckedChanged += rbCustAmount_CheckedChanged;
            // 
            // txtWithdrawAmount
            // 
            txtWithdrawAmount.Location = new Point(141, 32);
            txtWithdrawAmount.Name = "txtWithdrawAmount";
            txtWithdrawAmount.PlaceholderText = "In Rands";
            txtWithdrawAmount.Size = new Size(127, 31);
            txtWithdrawAmount.TabIndex = 11;
            txtWithdrawAmount.TextChanged += txtWithdrawAmount_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleGreen;
            groupBox1.Controls.Add(lblBalance);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(216, 385);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 69);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Available Balance";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = SystemColors.Control;
            lblBalance.BorderStyle = BorderStyle.Fixed3D;
            lblBalance.Location = new Point(144, 27);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(124, 27);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "                      \r\n";
            // 
            // gbDeposit
            // 
            gbDeposit.BackColor = Color.PaleGreen;
            gbDeposit.Controls.Add(textBox1);
            gbDeposit.Controls.Add(txtDeposit);
            gbDeposit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbDeposit.Location = new Point(216, 299);
            gbDeposit.Name = "gbDeposit";
            gbDeposit.Size = new Size(327, 69);
            gbDeposit.TabIndex = 6;
            gbDeposit.TabStop = false;
            gbDeposit.Text = "Deposit Amount(R)";
            gbDeposit.Enter += gbDeposit_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 31);
            textBox1.TabIndex = 10;
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(144, 30);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.PlaceholderText = "In Rands";
            txtDeposit.Size = new Size(124, 31);
            txtDeposit.TabIndex = 9;
            txtDeposit.TextChanged += txtDeposit_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.PaleGreen;
            groupBox3.Controls.Add(txtWithdrawAmount);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(216, 36);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(327, 69);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Withdrawal Amount(R)";
            // 
            // btnConfim
            // 
            btnConfim.BackColor = Color.Green;
            btnConfim.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfim.Location = new Point(549, 160);
            btnConfim.Name = "btnConfim";
            btnConfim.Size = new Size(210, 109);
            btnConfim.TabIndex = 8;
            btnConfim.Text = "Enter";
            btnConfim.UseVisualStyleBackColor = false;
            btnConfim.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gold;
            btnCancel.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(0, 288);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(210, 109);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button1_Click_1;
            // 
            // tmr
            // 
            tmr.Tick += tmr_Tick;
            // 
            // btnMiniState
            // 
            btnMiniState.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMiniState.Location = new Point(32, 8);
            btnMiniState.Name = "btnMiniState";
            btnMiniState.Size = new Size(759, 34);
            btnMiniState.TabIndex = 10;
            btnMiniState.Text = "Mini Statement";
            btnMiniState.UseVisualStyleBackColor = true;
            btnMiniState.Click += button1_Click_2;
            // 
            // pBankscreen
            // 
            pBankscreen.BorderStyle = BorderStyle.FixedSingle;
            pBankscreen.Controls.Add(btnExit);
            pBankscreen.Controls.Add(btnWithdraw);
            pBankscreen.Controls.Add(flpMain);
            pBankscreen.Controls.Add(btnCancel);
            pBankscreen.Controls.Add(btnDeposit);
            pBankscreen.Controls.Add(btnConfim);
            pBankscreen.Controls.Add(btnBalance);
            pBankscreen.Controls.Add(groupBox3);
            pBankscreen.Controls.Add(groupBox1);
            pBankscreen.Controls.Add(gbDeposit);
            pBankscreen.Location = new Point(32, 48);
            pBankscreen.Name = "pBankscreen";
            pBankscreen.Size = new Size(759, 492);
            pBankscreen.TabIndex = 11;
            // 
            // pministatement
            // 
            pministatement.Controls.Add(dgv);
            pministatement.Controls.Add(btnGetStatement);
            pministatement.Controls.Add(button1);
            pministatement.Controls.Add(btnClose);
            pministatement.Location = new Point(32, 48);
            pministatement.Name = "pministatement";
            pministatement.Size = new Size(759, 492);
            pministatement.TabIndex = 14;
            // 
            // dgv
            // 
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(3, 132);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.RowTemplate.Height = 33;
            dgv.Size = new Size(753, 328);
            dgv.TabIndex = 0;
            // 
            // btnGetStatement
            // 
            btnGetStatement.BackColor = Color.Green;
            btnGetStatement.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetStatement.Location = new Point(287, 72);
            btnGetStatement.Name = "btnGetStatement";
            btnGetStatement.Size = new Size(212, 38);
            btnGetStatement.TabIndex = 12;
            btnGetStatement.Text = "Get Statement";
            btnGetStatement.UseVisualStyleBackColor = false;
            btnGetStatement.Click += btnGetStatement_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(599, 30);
            button1.Name = "button1";
            button1.Size = new Size(147, 38);
            button1.TabIndex = 11;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_3;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gold;
            btnClose.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(15, 30);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 38);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // BankingScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(830, 541);
            Controls.Add(pministatement);
            Controls.Add(pBankscreen);
            Controls.Add(btnMiniState);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BankingScreen";
            Text = "BankingScreen";
            Load += BankingScreen_Load;
            flpMain.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbDeposit.ResumeLayout(false);
            gbDeposit.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            pBankscreen.ResumeLayout(false);
            pministatement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnWithdraw;
        private Button btnDeposit;
        private Button btnBalance;
        private Button btnExit;
        private FlowLayoutPanel flpMain;
        private GroupBox groupBox1;
        private Label lblBalance;
        private GroupBox gbDeposit;
        private GroupBox groupBox3;
        private Button btnConfim;
        private TextBox txtDeposit;
        private RadioButton rbR20;
        private RadioButton rbR50;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton rbR100;
        private RadioButton rbR150;
        private RadioButton rbCustAmount;
        private TextBox txtWithdrawAmount;
        private TextBox textBox1;
        private Button btnCancel;
        private Label label1;
        private System.Windows.Forms.Timer tmr;
        private Button btnMiniState;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private RadioButton rbR200;
        private RadioButton rbR1000;
        private RadioButton rbR2000;
        private Panel pBankscreen;
        private Panel pministatement;
        private DataGridView dgv;
        private Button btnGetStatement;
        private Button button1;
        private Button btnClose;
    }
}