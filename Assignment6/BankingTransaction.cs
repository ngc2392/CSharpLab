using System;

namespace Assignment6
{

    class BankingTransactionProgram {

        static void Main(string[] args)
        {
         BankingTransaction b = new BankingTransaction();

        }
    }

    class BankingTransaction
    {
        float accountBalance;

        public BankingTransaction(float accountBalance)
        {
            this.accountBalance = accountBalance;
        }
        
        public bool deposit()
        {
            return true;
        }

        public bool withdrawl()
        {
            return true;
        }


    }



}
