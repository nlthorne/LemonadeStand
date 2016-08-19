using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class CashBox
    {
        public int onHandCash;

        public CashBox(int startCash=25)
        {
            onHandCash = startCash;
        }
        public int GetCashBox()
        {
            return onHandCash;
        }
        // add and substract money functiond. make sure to not allow you balance to go below 0
        //public int CashBoxDebit()
        //{
            //onHandCash - bought* 
            //return onHandCash
        //}
        //public int CashBoxCredit()
        //{
            //onHandCash + AddEndDay
            //return onHandCash
        //}
    }
}