using System.ComponentModel.Design;
using System.Data.SqlTypes;

namespace qaralamatask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] Responses = { "grossincome", "maritalstatus", "childrencount", "healthystatus" };



            //Console.Write("Umumi emek haqqinizi daxil edin: ");
            //Responses[0] = Console.ReadLine();

            //Console.Write("Aile veziyyetinizi qeyd edin (evli;subay;dul): ");
            //Responses[1] = Console.ReadLine();

            //if (Responses[1] == "evli")
            //{
            //    Console.Write("Ushaglarinizin sayini daxil edin: ");
            //    Responses[2] = Console.ReadLine();
            //    Responses[0] = Responses[0] + 50 ;
            //}

            //else if (Responses[1] == "dul")
            //{
            //    Console.Write("Ushaglarinizin sayini daxil edin: ");
            //    Responses[2] = Console.ReadLine();
            //}

            //else
            //{
            //    Console.Write(" ");
            //}

            string maritalstatus, healthystatus; float grosssalary, netsalary, taxamount, taxrate, familyallowance; ; int childallowance, childrencount; 
            childrencount = 0; taxrate = 0; netsalary = 0; childallowance = 0; familyallowance = 0; taxamount = 0; 

            Console.Write("Umumi emek haqqinizi daxil edin: ");
            grosssalary = float.Parse(Console.ReadLine());

            Console.Write("Aile veziyyetinizi qeyd edin (evli;subay;dul): ");
            maritalstatus = Console.ReadLine();


            if (maritalstatus == "evli")
            {
                Console.Write("Ushaglarinizin sayini daxil edin: ");
                childrencount = int.Parse(Console.ReadLine());
                familyallowance = 50;
                grosssalary += familyallowance;
            }

            else if (maritalstatus == "dul")
            {
                Console.Write("Ushaglarinizin sayini daxil edin: ");
                childrencount = int.Parse(Console.ReadLine());
            }

            Console.Write("Elillik dereceniz varsa qeyd edin(beli;xeyr): ");
            healthystatus = Console.ReadLine();


            if (childrencount == 1)
            {
                childallowance = 30;
                grosssalary += childallowance;
            }
            else if (childrencount == 2)
            {
                childallowance = 55;
                grosssalary += childallowance;
            }
            else if (childrencount == 3)
            {
                childallowance = 75;
                grosssalary += childallowance;
            }
            else if (childrencount > 3)
            {
                childallowance = 75 + (childrencount -3) * 15;
                grosssalary += childallowance;
            }


            if (grosssalary <= 1000)
            {
                taxrate = 15;
            }
            else if (grosssalary <= 2000)
            {
                taxrate = 20;
            }
            else if (grosssalary <= 3000)
            {
                taxrate = 25;
            }
            else 
            {
                taxrate = 30;
            }

           if (healthystatus == "beli")
            {
                taxrate /= 2;
            }
            

            taxamount = grosssalary * taxrate / 100;
            netsalary = grosssalary - taxamount;
            



            Console.WriteLine("*********************************");
                Console.WriteLine("Aile muavineti: " + familyallowance + " AZN");
                Console.WriteLine("Ushag pulu: " + childallowance + " AZN");
                Console.WriteLine("Gelir vergisi derecesi: " + taxrate + "%");
                Console.WriteLine("Gelir vergisi meblegi: " + taxamount + " AZN");
                Console.WriteLine("Umumi emek haqqi: " + grosssalary + " AZN"); 
                Console.WriteLine("Xalis emek haqqi: " + (Math.Round(netsalary)) + "AZN");

            int[] currency = { 1, 5, 10, 20, 50, 100, 200 };
            int[] counts = new int[currency.Length];

            for (int i = currency.Length-1; i >=0; i--)
            {
                counts[i] = (int)MathF.Ceiling(netsalary) / currency[i];
                netsalary = netsalary % currency[i];
                Console.WriteLine("Emek haqqinin odenilmesinde " + currency[i] + " AZN esginasdan " + counts[i] + " defe istifade edilmishdir");
            }






    }
    }
}
