using System;
using System.Threading;

class A
{
    public static void Main(String[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("                             WELCOME TO KDMART");
        Console.WriteLine();
        Console.WriteLine("1 ─ ADMIN LOGIN");
        Console.WriteLine("2 ─ USER LOGIN");
        Console.Write("SELECT UR LOGIN: ");
        Console.WriteLine();
        int n = Convert.ToInt32(Console.ReadLine());
        
        int a, ph;
        int[] p;
        int[] up = new int[] { 10, 20, 30 };
        string[] uc = new string[] { "CHOCLATES", "STRAWBERRY", "VINILLA" };
        string[] s;
        string pwd = "admin", pwd1, ea, name, mail, na = "admin";
        while (n == 1)
        {
            
            Console.WriteLine("ADMIN ID      :" + na);
            Console.WriteLine("ADMIN PASSWORD:" + na);
            Console.WriteLine();
            Console.WriteLine("YOUR PASSWORD IS TOO WEAK ");
            Console.WriteLine();
            Console.WriteLine("DO U WANT CHANGE UR PASSWORD");
            Console.WriteLine();
            Console.Write("SELECT '1' OR '0' : ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.Write("ENTER UR NEW ADMIN PASSWORD : ");
                Console.WriteLine();
                pwd = Console.ReadLine();
                Console.WriteLine("               .... PASSWORD CHANGED SUCCESFULLY .... ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("                .... PASSWORD IS NOT CHANGED .... ");
                Console.WriteLine();
            }
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("                         ADMIN LOGIN ");
            Console.WriteLine();
            Console.Write("ENTER ADMIN ID      : ");
            Console.WriteLine();
            ea = Console.ReadLine();
            Console.Write("ENTER ADMIN PASSWORD : ");
                 
            pwd1 = Console.ReadLine();
            while (pwd1 != pwd && ea != na)
            {
                Console.Clear();
                Console.Write("ENTER ADMIN ID       : ");
                ea = Console.ReadLine();
                Console.Write("ENTER ADMIN PASSWORD : ");
                pwd1 = Console.ReadLine();
            }
            if (pwd1 == pwd && ea == na)
            {
                Console.Clear();
                Console.WriteLine("                         ADMIN MENU ");
                Console.WriteLine();
                
                Console.Write("ENTER THE NO.OF ITEMS : ");
                a = Convert.ToInt32(Console.ReadLine());
                s = new string[a];
                p = new int[a];
                for (int i = 0; i < s.Length; i++)
                {
                    Console.WriteLine();
                    Console.Write("ENTER THE " + (i + 1) + " ITEM NAME  : ");
                    s[i] = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("ENTER THE " + (i + 1) + " ITEM PRICE : ");
                    p[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine("ITEMS LIST ...");
                Console.WriteLine();
                
                Console.WriteLine(" ITEM NAME                           ITEM PRICE");
                for (int i = 0; i < s.Length; i++)
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("  " + s[i] + "\t\t\t\t\t\t\t\t" + p[i]);
                    Console.WriteLine();
                }
                Thread.Sleep(5000);
                
                Console.WriteLine("\t\t\t\t\t\tWELCOME TO KDMART");
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("1 ─ ADMIN LOGIN");
                Console.WriteLine("2 ─ USER LOGIN");
                Console.Write("ENTER UR CHOICE : ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    Console.Clear();
                    Console.Write("ENTER ADMIN ID       : ");
                    ea = Console.ReadLine();
                    Console.Write("ENTER ADMIN PASSWORD : ");
                    pwd1 = Console.ReadLine();
                    if (pwd == pwd1)
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\tADMIN MENU ");
                        Console.WriteLine("       ITEMS LIST ...");
                        Console.WriteLine();
                        
                        Console.WriteLine(" ITEM NAME                           ITEM PRICE ");
                        for (int i = 0; i < s.Length; i++)
                        {
                            Thread.Sleep(3000);
                            Console.WriteLine("  " + s[i] + "\t\t\t\t\t\t" + p[i]);
                            Console.WriteLine();
                        }
                    }

                }
                else if (n == 2)
                {
                    Console.WriteLine("USER LOGIN");
                    Console.WriteLine("ITEMS IN KDMART...");
                    for (int i = 0; i < s.Length; i++)
                    {
                        Console.WriteLine((i + 1) + " - ITEMS NAME  " + s[i] + " AND PRICE = " + p[i]);
                        Console.WriteLine();
                    }
                    Console.Write("ITEMS WANT TO PURCHASE: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    string[] c = new string[b];
                    int[] q = new int[b];
                    Console.WriteLine("ENTER THE ITEMS NAMES : ");
                    Console.WriteLine();
                    for (int i = 0; i < b; i++)
                    {
                        Console.Write((i + 1) + " - ITEM NAME : ");
                        c[i] = Console.ReadLine();
                        Console.Write((i + 1) + " - ITEM QUANTITY : ");
                        q[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                    if (b == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("PROVIDE UR DETAILS..");
                        Console.Write("NAME        : ");
                        name = Console.ReadLine();
                        Console.Write("PHONE NUMBER : ");
                        ph = Convert.ToInt32(Console.ReadLine());
                        Console.Write("MAIL ID    : ");
                        mail = Console.ReadLine();
                        Console.Clear();
                        
                        Console.WriteLine();
                        Console.WriteLine("                             BILL                        ");
                        Console.WriteLine();
                        Thread.Sleep(1000);
                        Console.WriteLine("                             CUSTOMER DETAILS");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("NAME          : " + name);
                        Thread.Sleep(1300);
                        Console.WriteLine("PHONE NUMBER  : " + ph);
                        Thread.Sleep(1300);
                        Console.WriteLine("MAIL ID       : " + mail);
                        Thread.Sleep(1300);
                        Console.WriteLine();
                        
                        Console.WriteLine();
                        
                        Console.WriteLine("                              ITEMS PURCHASED                     ");
                        Console.WriteLine();
                        Thread.Sleep(1300);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("ITEMS NAME                       QUANTITY                       TOTAL PRICE");
                        Console.WriteLine();
                        Console.WriteLine();
                        int sum = 0;
                        for (int i = 0; i < c.Length; i++)
                        {
                            Thread.Sleep(3000);
                            Console.WriteLine(c[i] + "\t\t\t\t" + q[i] + "\t\t\t\t\t\t\t" + (q[i] * p[i]));
                            sum += (q[i] * p[i]);
                            Console.WriteLine();
                        }
                        double d;
                        d = sum - (sum * 0.2);
                        Console.WriteLine("───────────────────────────────────────────────────────────────────────────");
                        Console.WriteLine();
                        Console.WriteLine("                                                 AMOUNT   = " + sum + "RS/-");
                        
                        
                        Console.WriteLine("                                             TOTAL AMOUNT = " + d + "RS/-");
                    }

                }
            }

        }
        Console.WriteLine("\t\t\t\t\tUSER LOGIN");
        Console.WriteLine("ITEMS LIST ...");
        for (int i = 0; i < uc.Length; i++)
        {
            Console.WriteLine((i + 1) + " - ITEM NAME " + uc[i] + " ITEM PRICE = " + up[i]);
            Console.WriteLine();
        }
        Console.Write("ITEMS TO PURCHASE : ");
        int ub = Convert.ToInt32(Console.ReadLine());
        string[] uuc = new string[ub];
        int[] uq = new int[ub];
        Console.WriteLine("ENTER ITEMS: ");
        Console.WriteLine();
        for (int i = 0; i < ub; i++)
        {
            Console.Write((i + 1) + " - ITEM NAME : ");
            uuc[i] = Console.ReadLine();
            Console.Write((i + 1) + " - QUANTITY : ");
            uq[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        if (ub != 0)
        {
            Console.WriteLine("Customer please provide the following details..");
            Console.Write("NAME         : ");
            name = Console.ReadLine();
            Console.Write("PHONE NUMBER : ");
            ph = Convert.ToInt32(Console.ReadLine());
            Console.Write("MAIL ID      : ");
            mail = Console.ReadLine();
            Console.Clear();
           
            Console.WriteLine();
            Console.WriteLine("                             BILL                        ");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("                        CUSTOMER DETAILS");
            Console.WriteLine();
            Console.WriteLine("───────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("CUSTOMER NAME : " + name);
            Thread.Sleep(1300);
            Console.WriteLine("PHONE NUMBER  : " + ph);
            Thread.Sleep(1300);
            Console.WriteLine("MAIL ID     : " + mail);
            Thread.Sleep(1300);
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                              ITEMS Purchased                      ");
            Console.WriteLine();
            Thread.Sleep(1300);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ITEMS NAME                       QUANTITY                       TOTAL PRICE");
           
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < uuc.Length; i++)
            {
                Thread.Sleep(3000);
                Console.WriteLine(uuc[i] + "\t\t\t\t" + uq[i] + "\t\t\t\t\t" + (uq[i] * up[i]));
                sum += (uq[i] * up[i]);
                Console.WriteLine();
            }
            double d;
            d = sum - (sum * 0.2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                 AMOUNT   = " + sum + "rs/-");
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                             TOTAL AMOUNT = " + d + "rs/-");
        }

    }

}