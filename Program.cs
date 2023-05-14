using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace L5
{
    class Program
    {
           class products
        {
            public products()
            {
                name = "coke";
                catgory = 'G';
                price = 70;
                stock = 500;
                minstock = 80;
            }
            public string name;
            public char catgory;
            public int price;
            public int stock;
            public int minstock;

        }
        static List<products> it = new List<products>();
        static void Main(string[] args)
        {

            products p1 = new products();
            it.Add(p1);
            string username, password;
            string choice, key;
        z: d: v:
            Console.WriteLine("1-----Sign in");
            Console.WriteLine("2-----Sign up");
            Console.WriteLine("3-----Exit");
            Console.WriteLine("");
            Console.WriteLine(">>>>>>>>>>>>>>>>Select one of them ");


            Console.Write("Enter your choice :  ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("......Enter your username : ");
                username = Console.ReadLine();
                Console.Write("......Enter your password : ");
                password = Console.ReadLine();
                signin(username, password);
                Console.Write("Press any Key: ");
                key = Console.ReadLine();
                Console.Clear();
                goto v;
            }
            else if (choice == "2")
            {
                Console.Write("......Enter your username : ");
                username = Console.ReadLine();
                Console.Write("......Enter your password : ");
                password = Console.ReadLine();
                signup(username, password);
                Console.WriteLine("-------------Successfully sign up !------------------");
                Console.Write("Press any Key: ");
                key = Console.ReadLine();
                Console.Clear();
                goto d;
            }
            else if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine("<<<<<<<<<<<<<<Program End!>>>>>>>>>>>>>>>");
            }
            else
            {
                Console.WriteLine(">>>>>>>>>>>>>>>Invalid choice");
                Console.Write("Press any Key: ");
                key = Console.ReadLine();
                Console.Clear();
                goto z;
            }





            Console.ReadKey();


        }
        public static void mainmenu()
        {
            Console.Clear();
        c:
            string choice;
            Console.WriteLine("a---ADD PRODUCT");
            Console.WriteLine("b---VIEW ALL PRODUCT");
            Console.WriteLine("c---FIND PRODUCT WITH HIGHEST UNIT PRICE");
            Console.WriteLine("d---VIEW SALE TAX OF ALL PRODUCTS");
            Console.WriteLine("e---PRODUCT TO BE ORDERED");
            Console.WriteLine("z---Exit");

            Console.Write("Enter your Choice: ");
            choice = Console.ReadLine();
            if (choice == "a")
                add();
            else if (choice == "b")
                view();
            else if (choice == "c")
                highestP();
            else if (choice == "d")
                saletax();
            else if (choice == "e")
                threshold();
            else if (choice == "z")
            {
               
            }

            else
            {
                Console.WriteLine("Your Choice is Incorrect choice the correct--------------!!!!!!");
                goto c;
            }



        }
        public static void add()
        {
            Console.Clear();
            char key;
            products p = new products();
            Console.Write("Enter name of product: ");
            p.name = Console.ReadLine();
            Console.Write("Enter catgory of product(G for GROCERY| F for FRUITES | o for other): ");
            p.catgory = char.Parse(Console.ReadLine());
            Console.Write("Enter price of product: ");
            p.price = int.Parse(Console.ReadLine());
            Console.Write("Enter stock of product: ");
            p.stock = int.Parse(Console.ReadLine());
            Console.Write("Enter Minimum stock of product: ");
            p.minstock = int.Parse(Console.ReadLine());
            it.Add(p);
            Console.WriteLine("Press any key to exit: ");
            key = char.Parse(Console.ReadLine());
            mainmenu();

        }
        public static void view()
        {


            char key;
            Console.Clear();
            for (int x = 0; x < it.Count; x++)
            {
                Console.WriteLine("Product: " + it[x].name);
                Console.WriteLine("Category: " + it[x].catgory);
                Console.WriteLine("Price: " + it[x].price);
                Console.WriteLine("Stock: " + it[x].stock);
                Console.WriteLine("Min stock: " + it[x].minstock);
                Console.WriteLine("---------------------------------------------------------------------------");

            }

            Console.WriteLine("Press any key to exit: ");
            key = char.Parse(Console.ReadLine());
            mainmenu();
        }
        public static void highestP()
        {
            char key;
            int lar = 0;
            int index = 0;
            Console.Clear();
            for (int x = 0; x < it.Count; x++)
            {
                if (it[x].price > lar)
                {
                    index = x;

                }
            }
            Console.WriteLine("PRODUCT WITH HIGHEST UNIT PRICE: " + it[index].name);
            Console.WriteLine("Category: " + it[index].catgory);
            Console.WriteLine("Price: " + it[index].price);
            Console.WriteLine("Press any key to exit: ");
            key = char.Parse(Console.ReadLine());
            mainmenu();

        }
        public static void saletax()
        {
            Console.Clear();
            char key;
            float tax;
            for (int x = 0; x < it.Count; x++)
            {
                if (it[x].catgory == 'G' || it[x].catgory == 'g')
                {
                    tax = (it[x].price * 10) / 100;
                    Console.WriteLine("PRODUCT: " + it[x].price);
                    Console.WriteLine("SALETAX: " + tax);
                    Console.WriteLine("---------------------------------------------------------------------------");
                }
                else if (it[x].catgory == 'F' || it[x].catgory == 'f')
                {
                    tax = (it[x].price * 5) / 100;
                    Console.WriteLine("PRODUCT: " + it[x].price);
                    Console.WriteLine("SALETAX: " + tax);
                    Console.WriteLine("---------------------------------------------------------------------------");
                }
                else
                {
                    tax = (it[x].price * 15) / 100;
                    Console.WriteLine("PRODUCT: " + it[x].price);
                    Console.WriteLine("SALETAX: " + tax);
                    Console.WriteLine("---------------------------------------------------------------------------");
                }

            }
            Console.WriteLine("Press any key to exit: ");
            key = char.Parse(Console.ReadLine());
            mainmenu();
        }
        public static void threshold()
        {
            Console.Clear();
            char key;
            string p;
            int value;
            Console.Write("Enter the product: ");
            p = Console.ReadLine();
            Console.Write("Enter the threshold value of  product: ");
            value = int.Parse(Console.ReadLine());
            for (int x = 0; x < it.Count; x++)
            {

                if (value < 10)
                {
                    Console.WriteLine("Product  Ordered ");
                }
                else
                    Console.WriteLine("Product Not Ordered ");
            }
            Console.WriteLine("Press any key to exit: ");
            key = char.Parse(Console.ReadLine());
            mainmenu();

        }
        public static void signup(string username, string password)
        {
            string path = "E:\\signupsignin\\data.txt";
            StreamWriter filevariable = new StreamWriter(path, true);
            filevariable.WriteLine(username);
            filevariable.WriteLine(password);
            filevariable.Flush();
            filevariable.Close();
        }
        public static void signin(string username, string password)
        {
            string path = "E:\\signupsignin\\data.txt";
            string record;
            string fileusername, filepassword;
            int flag = 0;
            if (File.Exists(path))
            {
                StreamReader filevariable = new StreamReader(path);
                while ((record = filevariable.ReadLine()) != null)
                {
                    fileusername = record;
                    if (fileusername == username)
                    {
                        flag++;
                    }
                }
                filevariable.Close();
                StreamReader file = new StreamReader(path);
                while ((record = file.ReadLine()) != null)
                {
                    filepassword = record;
                    if (filepassword == password)
                    {
                        flag++;
                    }
                }
                file.Close();

            }
            else
                Console.Write("NOT EXISTS");
            if (flag == 2)
            {
                mainmenu();
            }
            else
                Console.WriteLine("Invalid username and password");



        }
    }
    
}
