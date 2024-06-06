using System.Collections;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

//NOT IMPLEMENTED: I wanted to make the product names an array so that I could make a short function using i (Line 40 - 87), but it wouldn't work with the item format i used.
namespace Hunt_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shipper myShipper = new Shipper();

            int[] noi = { 0, 0, 0, 0, 0 };

            item o1 = new item(9.50, " Bicycle");
            item o2 = new item(24.00, " Lawn Mower");
            item o3 = new item(5.95, " Cell Phone");
            item o4 = new item(3.23, " Baseball Glove");
            item o5 = new item(0.57, " Crackers");

            bool cont = true;

            //this adds some space so that the "1 item added text isn't as jarring.
            Console.WriteLine("\n");

            while (cont)
            {
                Console.WriteLine("Choose from the following options:" +
                    "\n1. Add a Bicycle" +
                    "\n2. Add a Lawn Mower" +
                    "\n3. Add a Cell Phone" +
                    "\n4. Add a Baseball Glove" +
                    "\n5. Add Crackers" +
                    "\n6. List Shipment Items" +
                    "\n7. Compute Shipping Charges\n"
                );

                string pinput = Console.ReadLine();
                int input = 100;

                //odd way to work around the crash that occurs if the input parse is null
                if (pinput == null || pinput.All(Char.IsDigit) == false)
                {
                    Console.WriteLine("Please enter a valid number.\npress enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\n");
                }else
                {
                    //it doesn't work very well, error still occurs after initial input
                    input = int.Parse(pinput);
                }

                if (input > 0 && input < 8)
                {
                    if (input == 1)
                    {
                        myShipper.Add(o1);
                        noi[0] = noi[0] + 1;
                        Console.Clear();
                        Console.WriteLine("1 Bicycle Added\n");
                    }
                    if (input == 2)
                    {
                        myShipper.Add(o2);
                        noi[1] = noi[1] + 1;
                        Console.Clear();
                        Console.WriteLine("1 Lawn Mower Added\n");
                    }
                    if (input == 3)
                    {
                        myShipper.Add(o3);
                        noi[2] = noi[2] + 1;
                        Console.Clear();
                        Console.WriteLine("1 Cell Phone Added\n");
                    }
                    if (input == 4)
                    {
                        myShipper.Add(o4);
                        noi[3] = noi[3] + 1;
                        Console.Clear();
                        Console.WriteLine("1 Baseball Glove Added\n");
                    }
                    if (input == 5)
                    {
                        myShipper.Add(o5);
                        noi[4] = noi[4] + 1;
                        Console.Clear();
                        Console.WriteLine("1 Package of Crackers Added\n");
                    }
                    if (input == 6)
                    {
                        Console.WriteLine("\nCart:\n");
                        int i = 0;

                        Console.WriteLine(noi[0] + o1.Product + isPlural(i, noi[0]));
                        Console.WriteLine(noi[1] + o2.Product + isPlural(i, noi[1]));
                        Console.WriteLine(noi[2] + o3.Product + isPlural(i, noi[2]));
                        Console.WriteLine(noi[3] + o4.Product + isPlural(i, noi[3]));
                        Console.WriteLine(noi[4] + o5.Product);

                        Console.WriteLine("\nTotal: " + myShipper.Total());
                        Console.ReadLine();
                        Console.Clear();
                    }
                    if (input == 7)
                    {
                        Console.Clear();
                        Console.WriteLine(myShipper.Total());
                        Console.ReadLine();
                        Console.Clear();
                    }

                }else
                {
                    Console.WriteLine("Please enter a valid number.\npress enter to continue");
                    Console.ReadLine();
                }
                
            }
        }
        static string isPlural(int x, int y)
        {
            if (x < 6)
            {
                if (y > 1 || y < 1)
                {
                    return "s";
                }
            }
            return "";
        }
    }
}
