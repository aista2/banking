using System;

namespace OnlineBanking
{
    class Program
    {
        static void Main()
        {
            int totalBalance = 10000;
            Console.WriteLine("Welcome to Bank of London");
            int count = 3;
            while (count >= 0)
            {

                Console.WriteLine("Please enter your pin");
                int number = int.Parse(Console.ReadLine());

                int pinnumber =9999;
                if (number == pinnumber)
                {
                    Console.WriteLine(" Welcome to your banking system");
                    count = count - 4;
                    Boolean exit = false;
                    while (exit == false)
                    {
                        Console.WriteLine(
                       "What would you like to do : 1 - view your balance, 2 - deposite , 3 - widthdraw , 4 - exit");
                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                Console.WriteLine(" your totalbalance is {0}", totalBalance);
                                break;

                            case 2:
                                Console.WriteLine("How much would you like to deposite");
                                int cashIn = int.Parse(Console.ReadLine());
                                totalBalance =  totalBalance + cashIn;
                                Console.WriteLine("Your total new balance is {0}", totalBalance);
                                break;

                            case 3:
                                Console.WriteLine("How much would you like to widthdraw");
                                int cashOut = int.Parse(Console.ReadLine());
                                if (totalBalance < cashOut)
                                {
                                   Console.WriteLine("Sorry you do not have enough balance to withdraw");
                                    Console.WriteLine("Max you can withdraw is {0}", totalBalance);
                                }
                                else
                                {
                                    totalBalance = totalBalance - cashOut;
                                    Console.WriteLine("Your total new balance is {0}", totalBalance);
                                }
                               
                                break;

                            case 4:
                                exit = true;
                                Console.WriteLine("Thank You for viewing your account , you have a good day!");
                                count = count - 4;
                                break;
                        }
                    }
                }
                else if (number != 9999 && count == 0)
                {
                    Console.WriteLine("Sorry your account has been blocked");
                    count = count - 1;
                }

                else
                {

                    Console.WriteLine("invalid Pin, you have {0} more chances left", count);
                    count = count - 1;
                }

            }

        }
    }
}
