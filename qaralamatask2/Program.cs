using System.ComponentModel.Design;

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

            string maritalstatus, healthystatus; float grossincome, netincome, taxamount, familyallowance; int childallowance, childrencount, taxrate;
            childrencount = 0; taxrate = 0; netincome = 0;childallowance = 0;familyallowance = 0;taxamount = 0;

            Console.Write("Umumi emek haqqinizi daxil edin: ");
            grossincome = float.Parse(Console.ReadLine());

            Console.Write("Aile veziyyetinizi qeyd edin (evli;subay;dul): ");
            maritalstatus = Console.ReadLine();


            if (maritalstatus == "evli")
            {
                Console.Write("Ushaglarinizin sayini daxil edin: ");
                childrencount = int.Parse(Console.ReadLine());
                familyallowance = 50;
                grossincome += familyallowance;
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
                grossincome += childallowance;
            }
            else if(childrencount == 2) 
            {
                childallowance = 55;
                grossincome += childallowance;
            }
            else if (childrencount == 3)
            {
                childallowance = 75;
                grossincome += childallowance;
            }
            else if (childrencount > 3)
            {
                childallowance = 75 + childallowance * 15;
                grossincome += childallowance;
            }

            

            if (grossincome <= 1000)
            {
                taxrate = 15;
                if (healthystatus == "beli")
                {  taxrate = 15/2;   }
            }

            else if (grossincome > 1000)
            {
                taxrate = 20;
                if (healthystatus == "beli")
                { taxrate = 20/2; }
            }

            else if (grossincome > 2000)
            {
                taxrate = 25;
                if (healthystatus == "beli")
                { taxrate = 25/2; }
            }
            else if (grossincome > 3000)
            {
                taxrate = 30; 
                if (healthystatus =="beli")
                { taxrate = 30/2; } 
            }

            taxamount = grossincome * taxrate / 100;
            netincome = grossincome - taxamount;

            

            Console.WriteLine("*********************************");
            Console.WriteLine("Aile muavineti:" + familyallowance);
            Console.WriteLine("Ushag pulu:" + childallowance);
            Console.WriteLine("Gelir vergisi derecesi:" + taxrate);
            Console.WriteLine("Gelir vergisi meblegi:" + taxamount);
            Console.WriteLine("Umumi emek haqqi: " + grossincome);
            Console.WriteLine("Xalis emek haqqi: " + netincome);
            



        }



    }
}
