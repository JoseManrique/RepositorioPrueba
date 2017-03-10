using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public class Account
    {
        //private string _name;

        //public string getName()
        //{
          //  return _name;
        //}

        //public void setName(string name)
        //{
          //  _name = name;
        //}

        //public string name
        //{
            //get
          //  {
             //   return _name;
          //  }

          //  set
          //  {
               // _name = value;
           // }
       // }

        public string Name { get; set; }

        private decimal balance;

        public Account(string name, decimal initialBalance)
        {
                Name=name;
                Balance = initialBalance;
        }

        public Account(string name)
        {
            Name = name;

        }

       

        public decimal Balance
        {
            get 
            { 
                return balance; 
            }

            set 
            {
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }

        public void Deposit(decimal depositAmount)
        {
            if(depositAmount > 0.0m)
            {
                Balance += depositAmount;
            }
        }



    }
}
