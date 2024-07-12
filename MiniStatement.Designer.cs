namespace Bank_ATM
{
    partial class MiniStatement
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
            dgv = new DataGridView();
            btnClose = new Button();
            btnExit = new Button();
            btnGetStatement = new Button();
            pministatement = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            pministatement.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(2, 79);
            dgv.Margin = new Padding(2);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.RowTemplate.Height = 33;
            dgv.Size = new Size(527, 197);
            dgv.TabIndex = 0;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gold;
            btnClose.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(10, 18);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 23);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(419, 18);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button1_Click;
            // 
            // btnGetStatement
            // 
            btnGetStatement.BackColor = Color.Green;
            btnGetStatement.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetStatement.Location = new Point(187, 40);
            btnGetStatement.Margin = new Padding(2);
            btnGetStatement.Name = "btnGetStatement";
            btnGetStatement.Size = new Size(148, 23);
            btnGetStatement.TabIndex = 12;
            btnGetStatement.Text = "Get Statement";
            btnGetStatement.UseVisualStyleBackColor = false;
            btnGetStatement.Click += btnGetStatement_Click;
            // 
            // pministatement
            // 
            pministatement.Controls.Add(label1);
            pministatement.Controls.Add(dgv);
            pministatement.Controls.Add(btnGetStatement);
            pministatement.Controls.Add(btnExit);
            pministatement.Controls.Add(btnClose);
            pministatement.Location = new Point(22, 29);
            pministatement.Margin = new Padding(2);
            pministatement.Name = "pministatement";
            pministatement.Size = new Size(531, 289);
            pministatement.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 143);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 13;
            label1.Text = "label1";
            // 
            // MiniStatement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 325);
            Controls.Add(pministatement);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MiniStatement";
            Text = "MiniStatement";
            Load += MiniStatement_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            pministatement.ResumeLayout(false);
            pministatement.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private Button btnClose;
        private Button btnExit;
        private Button btnGetStatement;
        private Panel pministatement;
        private Label label1;
    }
}