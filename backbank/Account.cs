using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backbank
{
    class Account
    {
        #region Properties
        /// <summary>
        /// Account number of the account
        /// </summary>
        public int AccountNumber { get;  }
        /// <summary>
        /// Email address of the account
        /// </summary>
        public string EmailAddress { get; set; }

        public decimal Balance { get; private set; }

        public string TypeOfAcconut { get; set; }

        #endregion
        #region methods
        public void deposit(decimal amount)
        {
            // Balance= Balance+amount
            Balance += amount;
        }
             public void Withdraw(decimal amount)
        { Balance -= amount; 
      
    }
   

    
}
