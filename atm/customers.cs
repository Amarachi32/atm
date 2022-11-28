using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    public class customers
    {
        private int _pin;//abstract
        public int Pin { get { return _pin; } set { _pin = value; } }
        public string? Name { get; set; }
        public int AccountNumber { get; set; }

        public List<int> PinBox;
        public customers()
        {
            PinBox = new List<int>();
            PinBox.Add(Pin);
            //Collection();
        }
        //public abstract void CutomerDetails();

    }

    public class EsteemedCustomer : customers
    {

        public  void CutomerDetails()//override
        {
          

            Console.WriteLine("Please enter first name:");
            Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter 4 digit pin:");
            // Pin = Convert.ToInt32(Console.ReadLine());
        enterpin:
            string Pin = Console.ReadLine();


            if (Pin.Length == 4 && int.TryParse(Pin, out int pinNumber))
            {
                if (!PinBox.Contains(pinNumber)) {
                    Console.WriteLine("Pin not recognized");

                    Console.WriteLine("press enter to Register your Pin");
                    Console.ReadKey();
                    register();

                    //SelectLanguage();
                }
                else {
                    Console.WriteLine("\nLogin successful\n");
                    Console.WriteLine($"\nWelcome back....\n");
                }

                //return pinNumber;
            }
            else
            {
                Console.WriteLine("invalid input: try again");
                goto enterpin;
            }

            throw new NotImplementedException();

            //Console.WriteLine("Customer Id: {0}", Pin);
            //Console.WriteLine("First Name: {0}", Name);
        }
        public void collection()
        {
            List<customers> pinBox = new List<customers>();
            pinBox.Add(new customers
            {
                Name = Name,
                AccountNumber = AccountNumber,
                Pin = Pin,
            });
            foreach (var customers in pinBox)
            {
                Console.WriteLine(customers);
            }
        }
        public int register()
        {

            Console.WriteLine("Enter new 4 digit pin:");
        //Pin = Convert.ToInt32(Console.ReadLine());
        enterpin:
            string Pin = Console.ReadLine();


            if (Pin.Length == 4 && int.TryParse(Pin, out int pinNumber))
            {

                PinBox.Add(pinNumber); //add to list
                Console.WriteLine("registration Successful");
                Console.WriteLine("press enter to login");
                Console.ReadKey();
                Console.Clear();

                //login
                Console.WriteLine("login with 4 digit pin:");
            //Pin = Convert.ToInt32(Console.ReadLine());
            loginpin:
                int pass = Convert.ToInt32(Console.ReadLine());
                if (pass != pinNumber)
                {
                    Console.WriteLine("Pin mismatched");
                    goto loginpin;
                }
                else
                {
                    //Console.Clear();
                    Console.WriteLine("login successful");
                    Console.WriteLine("ddsagddga");

                    entryPoint();
                    SelectLanguage();
                }


                return pinNumber;


            }
            else
            {
                Console.WriteLine("invalid input");
                goto enterpin;
            }
        }

        /*        public void PinCollection()
                {
                    List<int> Password = new List<int>() { Pin, 1111 };
                    if (!Pin.Contains(Pin))
                    {
                        Console.WriteLine("please  register your pin");
                    }
                    else
                    {
                        Console.WriteLine("login successful");
                    }
                }

                public int GetPin()
                {
                    int allowedpinTries = 3;
                    Console.WriteLine("\nEnter 4 digit pin\n");

                enterpin:
                    string pin = Console.ReadLine();


                    if (pin.Length == 4 && int.TryParse(pin, out int pinNumber))
                    {
                        Console.WriteLine("\nLogin successful\n");
                        Console.WriteLine($"\nWelcome ....\n");
                        return pinNumber;
                    }
                    else
                    {
                        for (int i = 1; i <= allowedpinTries; i++)
                        {
                            allowedpinTries--;
                            Console.WriteLine($"\nPin must be a 4-digit number.\nYou have {allowedpinTries} tries left\n");
                            goto enterpin;
                        }
                        if (allowedpinTries == 0)
                        {
                            Console.WriteLine("\nCard blocked. Visit the bank for further assistance");
                            Environment.Exit(1);
                        }
                    }
                    return 0;
                }*/

        /* public void Login()
         {

             Console.WriteLine("Enter new 4 digit pin:");
         //Pin = Convert.ToInt32(Console.ReadLine());
         loginpin:
             int pass = Convert.ToInt32(Console.ReadLine());
             if (pass != Pin)
             {
                 Console.WriteLine("Pin mismatched");
                 goto loginpin;
             }
             else
             {
                 Console.WriteLine("login successful");
                 entryPoint();
             }
         }*/

        static void entryPoint()
        {
            Console.Clear();
            Console.WriteLine("AchA Bank\n... everyone is a baller\n");
            Console.WriteLine("Choose your preferred language\nChoisissez votre langue préférée\nWählen Sie Ihre bevorzugte Sprache");
            Console.WriteLine("\nPress\\Presse\\Drücken Sie \n\n1. English\n\n2. French\n\n3. German\n");

        }
        public void SelectLanguage()
        {
            string action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    EnglishLanguage AtmEng = new EnglishLanguage();
                    break;
                case "2":
                    // MyATMInFrench myATMInFrench = new MyATMInFrench();
                    break;
                case "3":
                    // MyATMInGerman myATMInGerman = new MyATMInGerman();
                    break;
                default:
                    Console.WriteLine("\nINVALID INPUT\nNON VALIDE\nUNGÜLTIG");
                    break;
            }
        }
    }

    /*public class Users(){

    }*/


}
