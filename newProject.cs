using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Developer_Information
{
    class EmployeeType
    {
        public string Type1099;
        public string TypeW2;

        public void print()
        {
            Console.WriteLine("---------WELCOME TO OUR COMPANY A BIG CONGRATULATIONS AND WE'RE SO EXCITED FOR YOU-----------");
            Console.WriteLine("\nIN OUR COMPANY WE HAVE TWO TYPES OF EMPLOYEE: \n-Employee type W2 : {0} \n-Employee type 1099 :{1}", TypeW2, Type1099);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeType E = new EmployeeType();
            E.TypeW2 = "First type of employee";
            E.Type1099 = "Second type of employee";
            E.print();

            try
            {                
                Console.WriteLine("Plesae, Enter the requested Information for Three Software developers':");

                for (int SoftwareDevelopreInformatin = 1; SoftwareDevelopreInformatin <= 3; SoftwareDevelopreInformatin++)
                {                    
                    Console.Write("\nPlease, Enter the Full Name : ");
                    string FullName = Console.ReadLine();

                    Console.Write("Please, Enter zip code : ");
                    string ZipCode = Console.ReadLine();

                    Console.Write("Please, Enter Gross monthly Gross pay without the $ sign : ");
                    string MonthlyGrossPay = Console.ReadLine();
                    string number1 = MonthlyGrossPay;
                    double number2 = 0.07;
                    double taxes;
                    double MonthlyNetPay;
                    MonthlyNetPay = Convert.ToDouble(number1) - Convert.ToDouble(number1) * number2; 
                    taxes = Convert.ToDouble(number1) * number2;  // To convert the (monthly pay) to double and multyplay it by the taxes percent.
                    double YearleyIncome = 12;  // repersenting the number of months in each year
                    double AnnualGrossPay;
                    AnnualGrossPay = Convert.ToDouble(number1) * YearleyIncome;  // the monthly gross pay multiply by the number of months.
                    double AnnualNetPay;
                    AnnualNetPay = AnnualGrossPay - taxes * 12;
                    double AnnualTaxes;
                    AnnualTaxes = taxes * 12;  //the taxes paid each month multiplay by number of months.
                    Console.WriteLine("Are you Self-Employeed (type1099) ? ");  
                    Console.WriteLine("Enter yes/no, plesae note if you enter any other value will consider -no-(should be lower case letters):");
                    string SelfEmployeed = Console.ReadLine();
                    if (SelfEmployeed == "yes")  // The 1099 software development employees' records always have zero tax amounts
                    {
                        Console.WriteLine("------------------ INFO ABOUT EMPLOYEE -------------------");
                        Console.WriteLine("The taxes will be zero the 1099 software development employees' always have zero tax amounts");
                        Console.WriteLine("\n-The above software developers' Information");
                        Console.WriteLine("Hello: " + " " + FullName);
                        Console.WriteLine("Zip Code: " + " " + ZipCode);
                        Console.WriteLine("Gross Monthly Pay: " + " " + "$" + MonthlyGrossPay);  // i added the($) sign, so the user just need to enter a number and the result will be in dollars.                                                                                                              
                        Console.WriteLine("Annual Gross Pay:" + " " + "$" + AnnualGrossPay);
                        Console.WriteLine("===============================================");
                        Console.WriteLine("For the next software developer please provide the requested information: IF YOU DONE WITH THE THRID ONE :");
                    }
                    else
                    {
                        Console.WriteLine("------------------ INFO ABOUT EMPLOYEE -------------------");
                        Console.WriteLine("This employee Annual wages (type W2) and the taxes applied");
                        Console.WriteLine("\n-The above software developers' Information");
                        Console.WriteLine("Hello: " + " " + FullName);
                        Console.WriteLine("Zip Code: " + " " + ZipCode);
                        Console.WriteLine("Gross Monthly Pay: " + " " + "$" + MonthlyGrossPay);  // i added the($) sign, so the user just need to enter a number and the result will be in dollars.                                                                                       
                        Console.WriteLine("The Monthly Netpay: " + " " + "$" + MonthlyNetPay);
                        Console.WriteLine("Taxes(%7): " + " " + "$" + taxes);
                        Console.WriteLine("Annual Gross Pay:" + " " + "$" + AnnualGrossPay);
                        Console.WriteLine("Annual Netpay:" + " " + "$" + AnnualNetPay);
                        Console.WriteLine("Annual Taxes :" + "  " + "$" + AnnualTaxes);
                        Console.WriteLine("===============================================");
                        Console.WriteLine("For the next software developer please provide the requested information: IF YOU DONE WITH THE THRID ONE :");                       
                    }
                    Console.WriteLine("THE PROGRAM WILL STOP ASKING YOU TO PROVIDE MORE INFORMATION");                  
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("plesae enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("only number{0} && {1} are allowed", double.MinValue, double.MaxValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  //This a general exception message and will catch any type of exception we forgot to mention it
            }
            Console.WriteLine("\nTHANK YOU: AFTER YOU DONE WITH REVIEWING THE INFORMATION PRESS ENTER AND ANY KEY TO EXIT");
            Console.ReadKey();  //To control the screen so the user will be able to press enter to continue
        }
    }
}        
    
