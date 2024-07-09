using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_ATM
{
    internal class Myconnection
    {
        public SqlConnection con;

        public Myconnection() 
        {
          
          con = new SqlConnection("Data source = HP\\SQL2022; initial Catalog = FinanceBanking; Integrated Security = True");
        }

    }
}
