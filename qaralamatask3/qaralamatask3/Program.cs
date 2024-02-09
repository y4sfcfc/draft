using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace qaralamatask3
{
    internal class Program
    {
        static void Main(string[] args)
        { mainMenu(); }
         public static void mainMenu() 
         { 
            int option = 0;

            do
            {
                Console.WriteLine("       ESAS MENYU");
                Console.WriteLine("1. Sahenin hesablanmasi...");
                Console.WriteLine("2. Perimetr hesablanmasi..");
                Console.WriteLine("3. Cixis..................");
                Console.Write("Seciminizi daxil edin: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    secondaryMenu1();
                }
                else if (option == 2)
                {
                   secondaryMenu2();
                }
                else if (option == 3)
                {
                    endProgram();
                }
                else if(option >= 4)
                {
                    Console.WriteLine("Secim duzgun daxil edilmedi...");
                    mainMenu();
                }
            } while (option <= 3);
         }

        public static void secondaryMenu1() 
        {             
            Console.WriteLine("FIQURUN SECIMI ALT MENYU ");
            Console.WriteLine("1. Kvadrat......");
            Console.WriteLine("2. Duzbucaqli...");
            Console.WriteLine("3. Ucbucaq......");
            Console.WriteLine("4. Cevre........");
            Console.WriteLine("5. Esas menyu...");
            Console.Write("Seciminizi daxil edin: ");
            int option = int.Parse(Console.ReadLine());       
                   
            do
            {                
                
                if (option == 1)
                {
                    areasSquare();
                }
                else if (option == 2)
                {
                    areasRectangle();
                }
                else if (option == 3)
                {
                    areasTriangle();
                }
                else if (option == 4)
                {
                    areasCircle();
                }
                else if (option == 5)
                {
                    mainMenu();
                }
                else if (option >= 6)
                {
                    Console.Write("Zehmet olmasa yeniden secim edin: ");
                    option = int.Parse(Console.ReadLine());
                }
            } while (option <= 5);                     
             
        }
        public static void secondaryMenu2()
        {
            Console.WriteLine("FIQURUN SECIMI ALT MENYU ");
            Console.WriteLine("1. Kvadrat......");
            Console.WriteLine("2. Duzbucaqli...");
            Console.WriteLine("3. Ucbucaq......");
            Console.WriteLine("4. Cevre........");
            Console.WriteLine("5. Esas menyu...");
            Console.Write("Seciminizi daxil edin: ");
            int option = int.Parse(Console.ReadLine());

            do
            {

                if (option == 1)
                {
                    perimetersSquare();
                }
                else if (option == 2)
                {
                    perimetersRectangle();
                }
                else if (option == 3)
                {
                    perimetersTriangle();
                }
                else if (option == 4)
                {
                    perimetersCircle();
                }
                else if (option == 5)
                {
                    mainMenu();
                }
                else if (option >= 6)
                {
                    Console.Write("Zehmet olmasa yeniden secim edin: ");
                    option = int.Parse(Console.ReadLine());
                }
            } while (option <= 5);

        }
        public static void areasSquare()
        {
            Console.Write("Zehmet olmasa kvadratin terefinin uzunlugunu qeyd edin: ");
            float side = float.Parse(Console.ReadLine());
            float areaSquare = 0;
            while (true)
            {              

                if (side > 0)
                {
                    areaSquare = side * side;
                    Console.WriteLine($"Kvadratin sahesi: {areaSquare}");
                    break;
                }
                else
                { 
                    Console.WriteLine("Daxil edilen deyer 0-dan boyuk olmalidir...");
                    Console.Write("Kvadratin terefini yeniden daxil edin: ");
                    side = float.Parse(Console.ReadLine());
                }
                
            }
            
            Console.WriteLine("Yeniden hesablama aparmaq isteyirsiniz?(y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
            { areasSquare(); }
            else { secondaryMenu1(); }
        }
        public static void perimetersSquare()
        {
            Console.Write("Zehmet olmasa kvadratin terefinin uzunlugunu qeyd edin: ");
            float side = float.Parse(Console.ReadLine());
            float perimeterSquare = 0;
            while (true)
            {
                if (side > 0)
                {
                    perimeterSquare = 4 * side;
                    Console.WriteLine($"Kvadratin perimetri: {perimeterSquare}");
                    break;
                }
                else 
                {
                    Console.WriteLine("Daxil edilen deyer 0-dan boyuk olmalidir...");
                    Console.Write("Kvadratin terefini yeniden daxil edin: ");
                    side = float.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Yeniden hesablama aparmaq isteyirsiniz?(y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
            { perimetersSquare(); }
            else { secondaryMenu2(); }
        }
        public static void areasRectangle()
        {
            Console.Write("Zehmet olmasa duzbucaqlinin uzunlugunu daxil edin: ");
            float lengthRectangle = float.Parse(Console.ReadLine());
            Console.Write("Zehmet olmasa duzbucaqlinin enini daxil edin: ");
            float widthRectangle = float.Parse(Console.ReadLine());
            float areaRectangle = 0;
            while (true)
            {
                if (lengthRectangle > 0 && widthRectangle > 0)
                {
                    areaRectangle = lengthRectangle * widthRectangle;
                    Console.WriteLine($"Duzbucaqlinin sahesi: {areaRectangle}");
                    break;
                }
                else 
                {
                    Console.WriteLine("Daxil edilen deyer 0-dan boyuk olmalidir...");
                    Console.Write("Duzbucaqlinin uzunlugunu yeniden daxil edin: ");
                    lengthRectangle = float.Parse(Console.ReadLine());
                    Console.Write("Duzbucaqlinin enini yeniden daxil edin: ");
                    widthRectangle = float.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Yeniden hesablama aparmaq isteyirsiniz?(y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
            { areasRectangle(); }
            else { secondaryMenu1(); }
        }
        public static void perimetersRectangle()
        {
            Console.Write("Zehmet olmasa duzbucaqlinin uzunlugunu daxil edin: ");
            float lengthRectangle = float.Parse(Console.ReadLine());
            Console.Write("Zehmet olmasa duzbucaqlinin enini daxil edin: ");
            float widthRectangle = float.Parse(Console.ReadLine());
            float perimeterRectangle = 0;
            while (true)
            {
                if (lengthRectangle > 0 && widthRectangle > 0)
                {
                    perimeterRectangle = 2 * (widthRectangle + lengthRectangle);
                    Console.WriteLine($"Duzbucaqlinin perimetri: {perimeterRectangle}");
                    break;
                }
                else 
                {
                    Console.WriteLine("Daxil edilen deyer 0-dan boyuk olmalidir...");
                    Console.Write("Duzbucaqlinin uzunlugunu yeniden daxil edin: ");
                    lengthRectangle = float.Parse(Console.ReadLine());
                    Console.Write("Duzbucaqlinin enini yeniden daxil edin: ");
                    widthRectangle = float.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Yeniden hesablama aparmaq isteyirsiniz?(y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
            { perimetersRectangle(); }
            else { secondaryMenu2(); }
        }
        public static void areasTriangle ()
        {
            Console.Write("Zehmet olmasa ucbucagin 1-ci terefini daxil edin: ");
            float sideA = float.Parse(Console.ReadLine());
            Console.Write("Zehmet olmasa ucbucagin 2-ci terefini daxil edin:");
            float sideB = float.Parse(Console.ReadLine());
            Console.Write("Zehmet olmasa ucbucagin 3-cu terefini daxil edin:");
            float sideC = float.Parse(Console.ReadLine());
            float perimeterTriangle = sideA + sideB + sideC;
            float halfPT = 0;
            float areaTriangle = 0;
            while (true)
            {
                if (sideA >0 && sideB >0 && sideC >0)
                {
                    halfPT = (sideA + sideB + sideC) / 2;
                    areaTriangle = (float)Math.Sqrt(halfPT * (halfPT - sideA) * (halfPT - sideB) * (halfPT - sideC));
                    Console.WriteLine($"Ucbucagin sahesi: {areaTriangle}");
                    break;
                }
                else 
                {
                    Console.WriteLine("Daxil edilen deyer 0-dan boyuk olmalidir...");
                    Console.Write("Ucbucagin 1-ci terefini yeniden daxil edin: ");
                    sideA = float.Parse(Console.ReadLine());
                    Console.Write("Ucbucagin 2-ci terefini yeniden daxil edin:");
                    sideB = float.Parse(Console.ReadLine());
                    Console.Write("Ucbucagin 3-cu terefini yeniden daxil edin:");
                    sideC = float.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Yeniden hesablama aparmaq isteyirsiniz?(y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
            { areasTriangle(); }
            else { secondaryMenu1(); }
        }
        public static void perimetersTriangle()
        {
            Console.Write("Zehmet olmasa ucbucagin 1-ci terefini daxil edin: ");
            float sideA = float.Parse(Console.ReadLine());
            Console.Write("Zehmet olmasa ucbucagin 2-ci terefini daxil edin:");
            float sideB = float.Parse(Console.ReadLine());
            Console.Write("Zehmet olmasa ucbucagin 3-ci terefini daxil edin:");
            float sideC = float.Parse(Console.ReadLine());
            float perimeterTriangle = 0;
            while (true)
            {
                if (sideA > 0 && sideB > 0 && sideC > 0)
                {
                    perimeterTriangle = sideA + sideB + sideC;
                    Console.WriteLine($"Ucbucagin perimetri: {perimeterTriangle}");
                    break;
                }
                else 
                {
                    Console.WriteLine("Daxil edilen deyer 0-dan boyuk olmalidir...");
                    Console.Write("Ucbucagin 1-ci terefini yeniden daxil edin: ");
                    sideA = float.Parse(Console.ReadLine());
                    Console.Write("Ucbucagin 2-ci terefini yeniden daxil edin:");
                    sideB = float.Parse(Console.ReadLine());
                    Console.Write("Ucbucagin 3-cu terefini yeniden daxil edin:");
                    sideC = float.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Yeniden hesablama aparmaq isteyirsiniz?(y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
            { perimetersTriangle(); }
            else { secondaryMenu2(); }
        }
        public static void areasCircle()
        {
            Console.Write("Zehmet olmasa cevrenin radiusunu daxil edin: ");
            float radius = float.Parse(Console.ReadLine());
            float areaCircle = 0;
            while (true)
            {
                if (radius > 0)
                {
                    areaCircle = radius * radius * 3;
                    Console.WriteLine($"Cevrenin sahesi: {areaCircle}");
                    break;
                }
                else
                {
                    Console.WriteLine("Daxil edilen deyer 0-dan boyuk olmalidir...");
                    Console.Write("Zehmet olmasa cevrenin radiusunu daxil edin: ");
                    radius = float.Parse(Console.ReadLine());
                }
           
            }
            Console.WriteLine("Yeniden hesablama aparmaq isteyirsiniz?(y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
            { areasCircle(); }
            else { secondaryMenu1(); }
        }
        public static void perimetersCircle() 
        {
            Console.Write("Zehmet olmasa cevrenin radiusunu daxil edin: ");
            float radius = float.Parse(Console.ReadLine());
            while (true)
            {
                if (radius > 0)
                {
                    float lengthCircle = 2 * radius * 3;
                    Console.WriteLine($"Cevrenin uzunlugu: {lengthCircle}");
                    break;
                }
                else
                {
                    Console.WriteLine("Daxil edilen deyer 0-dan boyuk olmalidir...");
                    Console.Write("Zehmet olmasa cevrenin radiusunu daxil edin: ");
                    radius = float.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Yeniden hesablama aparmaq isteyirsiniz?(y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
            { perimetersCircle(); }   
            else { secondaryMenu2(); }
        }
        public static void endProgram() 
        {
            Console.Write("Cixis etmek istediyinizden eminsiniz? (y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
                Environment.Exit(0);
            else if (option == 'n')
            {
                mainMenu();
            }
        }
        



    }
}
