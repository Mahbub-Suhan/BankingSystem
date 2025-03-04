
while (true)
{
    Console.WriteLine("\n");
    Console.WriteLine("Simple Banking System");
    Console.WriteLine("\n");
    Console.WriteLine("Options are below \n");
    Console.WriteLine("1. Create Account");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Check Balance");
    Console.WriteLine("5. Apply Interest (Savings Account)");
    Console.WriteLine("6. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();
    Console.WriteLine("the value you gave is " + choice);
    //switch (choice)
    //{
    //    case "1": CreateAccount(); break;
    //    case "2": Deposit(); break;
    //    case "3": Withdraw(); break;
    //    case "4": CheckBalance(); break;
    //    case "5": ApplyInterest(); break;
    //    case "6": return;
    //    default: Console.WriteLine("Invalid option. Try again."); break;
    //}
}