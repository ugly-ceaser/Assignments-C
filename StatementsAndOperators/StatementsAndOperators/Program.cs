using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementsAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Detroit.detroitBank();
        }
    }

    class Detroit 
    {


        public static void openAccount()
        {
           

            

            void choiceopen() {
                string name;
                int age;
                string address;
                double balance;
                int transactions = 40;

                Console.Write("Enter Your Fullname: ");

                name = Console.ReadLine();




                Console.Write("Enter Your Age: ");

                age = Convert.ToInt32(Console.ReadLine());



                Console.Write("Enter Your Address: ");

                address = Console.ReadLine();


                Console.Write("Enter Your Opening Balance: ");

                balance = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Weldone");


                void Switch()
                {
                    Console.WriteLine("Choose 1 to  view details");
                    Console.WriteLine("Choose 2 to  Re-Register");
                    Console.WriteLine("Choose 0 to  Return Back to Previous");


                    int Option = Convert.ToInt32(Console.ReadLine());

                    switch (Option)
                    {

                        case 1:
                            Console.WriteLine("Loading Details");

                            Console.WriteLine("Customer Name is {0}", name);
                            Console.WriteLine("Customer Age is {0}", age);
                            Console.WriteLine("Customer Address is {0}", address);
                            Console.WriteLine("Customer opening balance is {0}", balance);
                            Console.WriteLine("the number of performed transactions is {0}", transactions);

                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------");


                            Switch();







                            break;




                        case 2:
                            Console.WriteLine(" Re-Register Accoun Again");
                            openAccount();
                            
                            Switch();
                            break;


                        case 0:
                            detroitBank();
                            
                            Switch();


                            break;

                        default:
                            Console.WriteLine("please choose a valid operation");

                            choiceopen();

                            

                            Switch();

                            break;



                    }

                }

                Switch();

               
            }

            choiceopen();



           


        }
        public static void transactions()
        {
            Console.WriteLine("Welcome");

            int choice;

            void Choice()
            {
                Console.WriteLine("Choose 1 to  perform Deposit");
                Console.WriteLine("Choose 2 to  perform Withdrawal");
                Console.WriteLine("Choose 3 to  Change Account Name");
                Console.WriteLine("Choose 4 to  Display Transaction and Closing Balance");
                Console.WriteLine("Choose 0 to  Return Back to Previous");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Depositing");

                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------");

                        Choice();


                        break;


                    case 2:
                        Console.WriteLine("Withdrawing");

                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------");

                        Choice();
                        break;

                    case 3:
                        Console.WriteLine("Changing Name");

                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------");

                        Choice();
                        break;

                    case 4:

                        Console.WriteLine("Showing Transactions");

                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------");

                        Choice();

                        break;

                    case 0:
                        detroitBank();
                        
                        break;
                    default:
                        Console.WriteLine("Please Choose A Valid Option");
                        Choice();
                        break;
                }

            }

            Choice();








        }

        public static void detroitBank()
        {
            Console.WriteLine("Welcom to Detriot Bank ");

            Console.WriteLine("Choose 1 to open an Account ");

            Console.WriteLine("Choose 2 to perform transactions ");

            Console.WriteLine("Choose 3 to Exit ");

            int option;

            option = Convert.ToInt32(Console.ReadLine()); 

            switch( option)
            {
                case 1:
                    openAccount();
                    break;

                case 2:
                    transactions();
                    break;

                 case 3:
                    Console.WriteLine("Bye.........");
                 break;

                case 0:
                    detroitBank();
                    break;
                default:
                    Console.WriteLine("Invalide Selections");
                    detroitBank();
                    break;
            }

        }
    }
}


  