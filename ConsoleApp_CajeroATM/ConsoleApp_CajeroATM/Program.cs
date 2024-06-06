using System;
using System.Collections.Generic;
using System.Linq;

public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public cardHolder(string cardnum, int pin, string firtName, string lastName, double balance)
    {
        this.cardNum = cardnum;
        this.pin = pin;
        this.firstName= firtName;
        this.lastName = lastName;
        this.balance = balance;
    }
    public string getNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setNum(string newCardNum)
    {
        cardNum = newCardNum;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(string newFirstName)
    {
        firstName=newFirstName;
    }
    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance= newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1.   Desposit ");
            Console.WriteLine("2.   Withdraw ");
            Console.WriteLine("3.   Show balance ");
            Console.WriteLine("4.   Exit "); 
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money $ would you like to deposit: ");
            double deposit=double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your money $. Your new balance is: " + currentUser.getBalance());
        }

        void withDraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money $ would you like to withdraw: ");
            double withDrawal = Double.Parse(Console.ReadLine());
            //Check if the user has enough money.
            if (currentUser.getBalance() < withDrawal)
            {
                Console.WriteLine("Insufficient balance :(");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withDrawal);
                Console.WriteLine("You're good to go! Thank you :) ");
            }
        }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("1234567890", 1001, "Jesus", "De La Paz", 105700.58));
        cardHolders.Add(new cardHolder("1234567891", 2002, "Clarineisy", "Frias Perez", 80540.13));
        cardHolders.Add(new cardHolder("1234567892", 3003, "Marys", "Ferreras", 17000.00));
        cardHolders.Add(new cardHolder("1234567893", 4004, "Santos", "De La Pacheco", 500.46));
        cardHolders.Add(new cardHolder("1234567894", 5005, "Ruth Eda", "Diaz", 30500.78));
        cardHolders.Add(new cardHolder("1234567895", 6006, "Maria", "Jose", 25500.90));
        

        //Prompt user
        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your debir card: ");
        string debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                //check againt our db.
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not reconized. Please try again"); }
            }
            catch { Console.WriteLine("Card not reconized. Please try again"); }
        }

        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect pin. Please try again"); }
            }
            catch { Console.WriteLine("Incorrect pin. Please try again"); }
        }
        Console.WriteLine("Welcome " + currentUser.getFirstName() +" "+ currentUser.lastName + " :)");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withDraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }

        }
        while (option != 4);
        Console.WriteLine("Thank you! Have a nice day :)");
            
    }

}




//namespace ConsoleApp_CajeroATM
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
            
//        }
//    }

//    public class CuentaBancaria
//    {
//        public string Banco { get; set; }
//        public string tipotarjeta { get; set; }
        
//    }
//}
