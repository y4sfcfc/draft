using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Concurrent;
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
                    secondaryMenu();
                }
                else if (option == 2)
                {
                   secondaryMenu();
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

        public static void secondaryMenu() 
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
                    Square();
                }
                else if (option == 2)
                {
                   Rectangle();
                }
                else if (option == 3)
                {
                    Triangle();
                }
                else if (option == 4)
                {
                    Circle();
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
        public static void Square()
        {
            Console.Write("Zehmet olmasa kvadratin terefinin uzunlugunu qeyd edin: ");
            float side = float.Parse(Console.ReadLine());
            float areaSquare = side * side;            
            float perimeterSquare = 4 * side;
            Console.WriteLine($"Kvadratin sahesi: {areaSquare}");
            Console.WriteLine($"Kvadratin perimetri: {perimeterSquare}");

            Console.WriteLine("Yeniden hesablama aparmaq isteyirsiniz?(y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
            { Square(); }
            else { secondaryMenu(); }
        }
        public static void Rectangle()
        {
            Console.Write("Zehmet olmasa duzbucaqlinin uzunlugunu daxil edin: ");
            float lengthRectangle = float.Parse(Console.ReadLine());
            Console.Write("Zehmet olmasa duzbucaqlinin enini daxil edin: ");
            float widthRectangle = float.Parse(Console.ReadLine());
            float areaRectangle = lengthRectangle * widthRectangle;
            float perimeterRectangle = 2 * (widthRectangle + lengthRectangle);
            Console.WriteLine($"Duzbucaqlinin sahesi: {areaRectangle}");    
            Console.WriteLine($"Duzbucaqlinin perimetri: {perimeterRectangle}");

            Console.WriteLine("Yeniden hesablama aparmaq isteyirsiniz?(y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
            { Rectangle(); }
            else { secondaryMenu(); }
        }
        public static void Triangle ()
        {
            Console.Write("Zehmet olmasa ucbucagin 1-ci terefini daxil edin: ");
            float sideA = float.Parse(Console.ReadLine());
            Console.Write("Zehmet olmasa ucbucagin 2-ci terefini daxil edin:");
            float sideB = float.Parse(Console.ReadLine());
            Console.Write("Zehmet olmasa ucbucagin 3-ci terefini daxil edin:");
            float sideC = float.Parse(Console.ReadLine());
            float perimeterTriangle = sideA + sideB + sideC;
            float halfPT = (sideA+sideB+sideC) / 2;
            float areaTriangle = (float)Math.Sqrt(halfPT * (halfPT - sideA) * (halfPT - sideB) * (halfPT - sideC));
            Console.WriteLine($"Ucbucagin sahesi: {areaTriangle}");
            Console.WriteLine($"Ucbucagin perimetri: {perimeterTriangle}");

            Console.WriteLine("Yeniden hesablama aparmaq isteyirsiniz?(y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
            { Triangle(); }
            else { secondaryMenu(); }
        }

        public static void Circle()
        {
            Console.Write("Zehmet olmasa cevrenin radiusunu daxil edin: ");
            float radius = float.Parse(Console.ReadLine());
            float areaCircle = radius * radius * 3;
            float lengthCircle = 2 * radius * 3;
            Console.WriteLine($"Cevrenin sahesi: {areaCircle}");
            Console.WriteLine($"Cevrenin uzunlugu: {lengthCircle}");

            Console.WriteLine("Yeniden hesablama aparmaq isteyirsiniz?(y/n): ");
            char option = char.Parse(Console.ReadLine().ToLower());
            if (option == 'y')
            { Circle(); }
            else { secondaryMenu(); }
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
