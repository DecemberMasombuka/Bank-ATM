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
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            pministatement.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(3, 132);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.RowTemplate.Height = 33;
            dgv.Size = new Size(753, 328);
            dgv.TabIndex = 0;
            dgv.CellContentClick += dgv_CellContentClick;
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
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(599, 30);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(147, 38);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button1_Click;
            // 
            // btnGetStatement
            // 
            btnGetStatement.BackColor = Color.Green;
            btnGetStatement.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetStatement.Location = new Point(267, 66);
            btnGetStatement.Name = "btnGetStatement";
            btnGetStatement.Size = new Size(212, 38);
            btnGetStatement.TabIndex = 12;
            btnGetStatement.Text = "Get Statement";
            btnGetStatement.UseVisualStyleBackColor = false;
            btnGetStatement.Click += btnGetStatement_Click;
            // 
            // pministatement
            // 
            pministatement.Controls.Add(dgv);
            pministatement.Controls.Add(btnGetStatement);
            pministatement.Controls.Add(btnExit);
            pministatement.Controls.Add(btnClose);
            pministatement.Location = new Point(32, 48);
            pministatement.Name = "pministatement";
            pministatement.Size = new Size(759, 481);
            pministatement.TabIndex = 13;
            // 
            // MiniStatement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 541);
            Controls.Add(pministatement);
            MaximizeBox = false;
            Name = "MiniStatement";
            Text = "MiniStatement";
            Load += MiniStatement_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            pministatement.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private Button btnClose;
        private Button btnExit;
        private Button btnGetStatement;
        private Panel pministatement;
    }
}