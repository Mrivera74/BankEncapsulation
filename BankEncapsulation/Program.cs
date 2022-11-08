namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount bA = new BankAccount();
            Console.WriteLine("How much money are you looking to Deposit today?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            bA.Deposit(amountToDeposit);
            double userBalance = bA.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance,0:c}");
        }
    }
}
