using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace atm
{
    //base iterface inheritance
    internal partial class EnglishLanguage : IatmOperations
    {
        //private string _name;
        //private string _accountNumber;
        private static double _accbal;
        public decimal AcctBal { get; set; }
        public  EnglishLanguage() {
            TakeAction();
            AcctBal = 1000;
        }
        public EnglishLanguage(double amount)
        {
            _accbal = amount;


        }
        /*        public MyATMInEng()
                {
                    _insertCard = GetCard();
                    _cardUser = GetCardUserName();
                    _cardPin = GetPin();
                    AcctBal = 1000.00;

                }*/
        private static void TakeAction()
        {
            Console.Clear();//also down
            Console.WriteLine("\nWhat would you like to do? Press\n\n1. For withdrawal\n\n2. For Deposit\n\n3. To check Balance\n\n4. To Transfer\n\n5. To change Pin\n" +
                "\nPress 0 to cancel");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Withdrawal();
                    break;
                case "2":
                    Deposit();
                    break;
                case "3":
                    CheckBalance();
                    break;
                case "4":
                    Transfer();
                    break;
                case "5":
                    ChangePin();
                    break;
                case "0":
                    Console.WriteLine("\nSee you some other time");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nINVALID OPTION");
                    break;
                    
            }
            
        }

        public static void Navigation()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n. Press\n\n1. continue transaction \n\n2. To chose another Language\n\n" + "3. To logout\n");

            string nextSteps = Console.ReadLine();

            switch (nextSteps)
            {
                case "1":
                    TakeAction();
                    break;
                case "2":
                    EsteemedCustomer LangEnter = new();
                    LangEnter.SelectLanguage();
                    break;
                case "3":
                    EsteemedCustomer reEnter = new();
                        reEnter.CutomerDetails();
                    break;
                case "4":
                    Console.WriteLine("\nThank you. See you");
                    //Enviroment.FailFast("ggfd");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nINVALID INPUT.\nPress any key to end operation\n");
                    break;

            }

        }
    }
    
    //withd
    internal partial class EnglishLanguage
    {
        public static void Withdrawal()
        {
            
              
            enterAmount:
                Regex rgx = new Regex("[^0-9]");
                Console.WriteLine("\nEnter amount below:\n");
                string amountString = Console.ReadLine();

                if (!rgx.IsMatch(amountString) && double.TryParse(amountString, out double amount))
                {
                    if (amount  > _accbal)
                    {
                        Console.WriteLine("\nInsufficient funds\n");
                    goto enterAmount;
                  
                    //return;
                    }
                    else if (amount < 100)
                    {
                        Console.WriteLine("Amount must be up t0 100");
                            goto enterAmount;
                       }
                    else
                    {
                        _accbal -= amount;
                        Console.WriteLine("\nPlease wait...\n");
                        Thread.Sleep(1000);
                    Console.WriteLine("Withdrwal successful \n your available balance is: {0}", _accbal);
                    Navigation();


                     }
                }
                else
                {
                    Console.WriteLine("\nInvalid amount\n");
                    goto enterAmount;
                }

        }
    }
    //deposit
    internal partial class EnglishLanguage
    {
        public static void Deposit()
        {
            Console.WriteLine("enter amount to deposit");
            double myDeposit = int.Parse(Console.ReadLine());
            if (myDeposit != null)
            {
                _accbal += myDeposit;
                Console.WriteLine("Deposit of {0} is successful :  total : {1}", myDeposit, _accbal);
                Navigation();
            }
            else
            {
                Console.WriteLine("invalid");
                Deposit();
            }

            //return _accbal;
        }
    }
    //bal
    internal partial class EnglishLanguage
    {
        public static void CheckBalance()
        {
            Console.WriteLine($"\nYour account balance is ${_accbal}.");
            Navigation();           
        }
    }

    //transfer
    internal partial class EnglishLanguage
    {
        public static void Transfer()
        {

        }
    }
    //changePin
    internal partial class EnglishLanguage
    {
        public static void ChangePin()
        {

        }
    }
}
