using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backbank
{
    class Program
    {
        static void Main(string[] args)
        {
             var account1 = new Account();
           account1.EmailAddress="test@test.com"
        account1.TypeOfAcconut = "checking";
            account1.deposit(105.40M);
            Console.WriteLine($"Accountnumber: {account1.}")

        }
    }
}
