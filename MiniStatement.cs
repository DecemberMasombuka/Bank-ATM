using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_ATM
{
    public partial class MiniStatement : Form
    {

        //Creates a new instance of the BankingScreen form
        //BankingScreen bs = new BankingScreen();





        public MiniStatement()
        {
            InitializeComponent();
        }

        private void MiniStatement_Load(object sender, EventArgs e)
        {
            //DataGridView Setup
           // dgv.ColumnCount = 8;

           // dgv.Columns[0].Name = "ID";
           // dgv.Columns[1].Name = "DELETE";
           // dgv.Columns[2].Name = "Reference";
           // dgv.Columns[3].Name = "Transaction Date";
           // dgv.Columns[4].Name = "Description";
           // dgv.Columns[5].Name = "DELETE";
          //  dgv.Columns[6].Name = "Amount ";
           // dgv.Columns[7].Name = "Balance";


        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            //bs.Close(); 

        }

        private void btnGetStatement_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
