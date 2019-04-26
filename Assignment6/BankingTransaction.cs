using System;

namespace Assignment6
{

    class BankingTransactionProgram
    {

        static void Main(string[] args)
        {
            BankingTransaction b = new BankingTransaction(500.00f);
            b.TransactionMade += HandleCustomEvent;
            b.withdrawal(250.00f);
            b.withdrawal(200.00f);
            b.deposit(150.14f);
            b.withdrawal(300.00f);
        }

        static void HandleCustomEvent(object sender, TransactionMadeEventArgs e)
        {
            Console.WriteLine("Transaction type: {0}   Transaction amount: {1}", e.TypeOfTransation, e.amountOfTransaction);
            //Environment.Exit(0);
        }
    }

    class BankingTransaction
    {
        float accountBalance;
        public event EventHandler<TransactionMadeEventArgs> TransactionMade;

        public BankingTransaction(float accountBalance)
        {
            this.accountBalance = accountBalance;
        }

        public bool deposit(float amountToAdd)
        {
            accountBalance += amountToAdd;

            TransactionMadeEventArgs env = new TransactionMadeEventArgs();
            env.TypeOfTransation = "deposit ";
            env.amountOfTransaction = amountToAdd;

            // raise the event
            onTransaction(env);

            return true;
        }

        public bool withdrawal(float amountToWithdrawal)
        {
            if (amountToWithdrawal > accountBalance)
            {
                Console.WriteLine("Transaction Failed: Not enough funds");
                return false;
            }
            else
            {

                accountBalance -= amountToWithdrawal;
               
               // Console.WriteLine("Withdrawing {0}, your account balance is {1}", amountToWithdrawal, accountBalance);

                TransactionMadeEventArgs env = new TransactionMadeEventArgs();
                env.TypeOfTransation = "withdrawl";
                env.amountOfTransaction = amountToWithdrawal;

                // raise the event
                onTransaction(env);

                return true;
            }
        }



        protected virtual void onTransaction(TransactionMadeEventArgs e)
        {
            EventHandler<TransactionMadeEventArgs> handler = TransactionMade;
            if (handler != null)
            {

                handler(this, e);
            }
        }
    }

    public class TransactionMadeEventArgs : EventArgs
    {
        public string TypeOfTransation { get; set; }
        public float amountOfTransaction { get; set; }
    }



}
