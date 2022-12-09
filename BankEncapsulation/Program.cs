namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBank = new BankAccount();
            bool check = true;



            do
            {
                Console.Write("Enter your pin # : ");
                int pin = int.Parse(Console.ReadLine());
                bool verify = myBank.GetPin(pin);
                if (verify == true)
                {
                    Console.Write("Choose amount to deposit: ");
                    double amount = double.Parse(Console.ReadLine());
                    myBank.Deposit(amount);
                    double balance = myBank.GetBalance();
                    Console.WriteLine($"Your Bank Account Balance is ${balance}");
                    check = true;
                }
                else
                {
                    Console.WriteLine("Incorrect pin, Try again.");
                    check = false;
                }

            } while (!check);









        }
    }
}
