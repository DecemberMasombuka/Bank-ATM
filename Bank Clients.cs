using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_ATM
{
    internal class Bank_Clients
    {

        //Create class attributes
        private string name;
        private string surname;
        private short pin;
        private long cardNo;
        private double balance;


        //Constructor
        public Bank_Clients(string aname,string asurname, short apin, long acardNo, double abalance)
        {
            this.name = aname;
            this.surname = asurname;
            this.pin = apin;
            this.cardNo = acardNo;
            this.balance = abalance;
            
        }

        //Getters
        public String Getname() { return name; }
        public string Getsurname() {  return surname; }
        public short Getpin() { return pin; }   
        public long GetcardNo() {  return cardNo; }
        public double Getbalance() { return balance; }



        //Setters
        public void Setname(String aname) { this.name = aname; }
        public void Setsurname(String asurname) {  this.surname = asurname;}
        public void Setpin(short apin) { this.pin = apin; }
        public void SetCardNo(long acardNo) {  this.cardNo = acardNo;}
        public void Setbalance(double abalance) { this.balance = abalance; }
    }

   
}
