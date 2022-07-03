using System;

namespace ElectricBill
{
    class Program
    {
        static void Main(string[] args)
        {
            int r=0, c=0, u=0;
            Console.WriteLine("-------Welcome to LESCO Billing Calculation System-------");
            Console.WriteLine("Enter Units Consumed = ");
            u= Convert.ToInt32(Console.ReadLine());
            if(u <= 100)
            {
                r = u * 5;
                c = u * 8;
            }
            else if (u>100 && u<200)
            {
                r = u * 17;
                c = u * 21;
            }
            else if (u>200 && u<500)
            {
                r = u * 23;
                c = u * 23;
            }
            else if (u>500)
            {
                r = u * 69;
                c = u * 79;
            }
            r = (r/13) + r;
            c = (c/17) + c;
            Console.WriteLine("The Residential Bill of " + u + " Unit is = " + r);
            Console.WriteLine("The Commercial Bill of " + u + " Unit is = " + c);
            Console.ReadLine();
        }
    }
}
