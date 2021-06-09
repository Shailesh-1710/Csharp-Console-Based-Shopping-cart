using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/// <summary>
/// <student_name> Shailesh Patel </student_name>
/// </summary>
namespace Cashless_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            int cust_no = 1;
            bool valid=false;
            int customer_choice = 0 ,choice =0 ;
            int item_counter = 1;
            string itemname;
            bool namevalidator;
            bool pricevalidator = false;
            double price;
            double total_amount=0;
            int card_no;
            int f3, rem, last;
            bool card_validator;
            double discount;
            double net_payable;



            do
            {
                WriteLine("----MAIN MENU---");
                WriteLine("\n1) ADD NEW CUSTOMER");
                WriteLine("2) EXIT PROGRAM");
                valid = int.TryParse(ReadLine(), out customer_choice);

                if (valid == true)
                {
                    switch(customer_choice)
                    {
                        case 1:
                            {
                                do
                                {
                                    Clear();
                                    WriteLine("\nWELCOME Customer {0} TO E-STORE", cust_no);
                                    //WriteLine("----MENU----");
                                    WriteLine("1) ADD NEW ITEM");
                                    WriteLine("2) PAY BILL");
                                    valid = int.TryParse(ReadLine(), out choice);
                                    if (valid == true)
                                    {
                                        do
                                        {
                                            switch (choice)
                                            {
                                                case 1:
                                                    {
                                                        do//Name Validation
                                                        {
                                                            WriteLine("Enter Name of Item {0}", item_counter);
                                                            itemname = ReadLine();
                                                            if (itemname.Length >= 8 || itemname.Length == 0)
                                                            {
                                                                WriteLine("Item Name should be Less than 7 characters");
                                                                namevalidator = false;
                                                            }
                                                            else
                                                            {
                                                                WriteLine("Valid Name");
                                                                namevalidator = true;

                                                            }
                                                        } while (namevalidator != true);

                                                        do//Price Validation
                                                        {
                                                            WriteLine("Enter Price of Item {0} \n ", item_counter);
                                                            valid = double.TryParse(ReadLine(), out price);
                                                            if( valid == true)
                                                            {
                                                                if (price > 0)
                                                                {
                                                                    WriteLine("Item Successfully Added");
                                                                    WriteLine("Press key to continue");
                                                                    pricevalidator = true;
                                                                    item_counter++;
                                                                    total_amount = price + total_amount;
                                                                    ReadKey();
                                                                }
                                                                else
                                                                {
                                                                    WriteLine("Price must be more than 0\n");
                                                                    
                                                                }
                                                            }
                                                            else
                                                            {
                                                                WriteLine("Price must be Numeric \n");
                                                               
                                                            }

                                                        } while (pricevalidator != true);

                                                        break;
                                                    }
                                                case 2:
                                                    {
                                                       
                                                        do
                                                        {
                                                            if (total_amount >=100 && total_amount <300)
                                                            {
                                                                discount = (total_amount * 1.5) / 100;
                                                                net_payable = total_amount - discount;
                                                                WriteLine("\n-----INVOICE-----");
                                                                WriteLine("Total Items Purchased         :   {0} ", item_counter - 1);
                                                                WriteLine("Total Amount Without Discount :  ${0} ", total_amount);
                                                                WriteLine("DISCOUNT ON PURCHASE (1.5%)   :  ${0}", discount);
                                                                WriteLine("Total Amount Payable          =  ${0}", net_payable);
                                                            }
                                                            else if (total_amount > 300)
                                                            {
                                                                discount = (total_amount * 2.5) / 100;
                                                                net_payable = total_amount - discount;
                                                                WriteLine("\n-----INVOICE-----");
                                                                WriteLine("Total Items Purchased         :  {0} ", item_counter - 1);
                                                                WriteLine("Total Amount Without Discount : ${0} ", total_amount);
                                                                WriteLine("DISCOUNT ON PURCHASE (2.5%)   : ${0}", discount);
                                                                WriteLine("Total Amount Payable          = ${0}", net_payable);
                                                            }
                                                            else
                                                            {
                                                                discount = 0;
                                                                net_payable = total_amount;
                                                                WriteLine("\n-----FINAL INVOICE-----");
                                                                WriteLine("Total Items Purchased         :  {0} ", item_counter - 1);
                                                                WriteLine("Total Amount Without Discount : ${0} ", total_amount);
                                                                WriteLine("DISCOUNT ON PURCHASE          : ${0}", discount);
                                                                WriteLine("Total Amount Payable          = ${0}", net_payable);
                                                            }


                                                            WriteLine("Emter CREDIT CARD Number");
                                                            card_validator = int.TryParse(ReadLine() , out card_no);
                                                            if (card_validator == true)
                                                            {

                                                                f3 = card_no / 10;
                                                                last = card_no % 10;
                                                                rem = f3 % 7;


                                                                if (rem == last)
                                                                {
                                                                    WriteLine("CARD ACCEPTED");
                                                                    WriteLine("Patment Successful");
                                                                    WriteLine("\n");
                                                                    WriteLine("Total Amount Paid         : ${0}", net_payable);
                                                                    WriteLine("Amount OWNIG              : ${0:F2}", net_payable - net_payable);
                                                                    WriteLine("Proceed For Next Customer");
                                                                    WriteLine("\n");
                                                                    card_validator = true;
                                                                    cust_no++;
                                                                    total_amount = 0;
                                                                    discount = 0;
                                                                    net_payable = 0;
                                                                    item_counter = 1;
                                                                }
                                                                else
                                                                {
                                                                    Clear();
                                                                    WriteLine("Invalid Card Number \n PLEASE ENTER NUMBER AGAIN");
                                                                    card_validator = false;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                WriteLine("Enter 4 digit card no");
                                                            }
                                                        } while (card_validator != true);
                                                        break;
                                                    }
                                                default:
                                                    {
                                                        WriteLine("Enter proper input");
                                                        break;
                                                    }
                                            }
                                            break;
                                        } while (choice != 3);
                                    }
                                    else
                                    {
                                        WriteLine("ENTER 1 OR 2");
                                    }

                                } while (choice != 2);
                                break;
                            }
                        case 2:
                            {
                                WriteLine("THANK YOU VISIT AGAIN :)");
                                ReadKey();
                                break;
                            }
                        default:
                            {
                                Clear();
                                WriteLine("ENTER 1 OR 2 ");
                                break;
                            }
                    }
                }
                else
                {
                    Clear();
                    WriteLine("Enter Valid Input");
                }
            } while (customer_choice != 2);
        }//END OF MAIN
    }//END OF CLASS
}//END OF NAMESPACE
