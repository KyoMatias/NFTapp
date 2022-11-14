using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using Console = Colorful.Console;

namespace NFTapp
{
  public class ConsoleMain
    { 
        public static void ConsoleHeader()
        {
        
        /* These components under teh ConsoleHeader, are responsible for 
        fetching the data and variables from the ApplicationComponents.cs Class
        the ApplicationComponents class has Getters and Setters Responsible for the data types being imported 
        by the main class.
        */
        ConsoleComponents consoletitle = new ConsoleComponents();
        string author = consoletitle.AppAuthor;
        string app = consoletitle.ApplicationName;
        string appVer = consoletitle.ApplicationVersion;
        string appType = consoletitle.ApplicationType;
        string appPlat = consoletitle.ApplicationPlatform;

        string title = author +"/"+ app + "/" + appVer + "/" + appType + "/" + appPlat;
        Console.Title = title;
        }

        public static void ConsoleMenu()
        {
            ConsoleComponents consolelines = new ConsoleComponents();
            string author = consolelines.AppAuthor;
            string app = consolelines.ApplicationName;
            string platform = consolelines.ApplicationPlatform;
            string email = consolelines.AuthorEmail;
            string ver = consolelines.ApplicationVersion;
            string type = consolelines.ApplicationType;

            Thread.Sleep(100);

            Console.WriteLine("\nCommitting... \n", Color.HotPink);
            Thread.Sleep(1500);

            Console.WriteLine(app, Color.MediumAquamarine);

            Thread.Sleep(1000);

            var directoryName = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            Console.WriteLine("\nFile Directory : " + directoryName);
            Thread.Sleep(500);
            Console.WriteLine("Author : " + author);
            Thread.Sleep(500);
            Console.WriteLine("Author Computer : " + platform);
            Thread.Sleep(500);
            Console.WriteLine(email + " / " + app + " / " + ver + " / " + type + " / " + platform + " / " + directoryName);
            Thread.Sleep(1000);
            Console.Write("\n" + author + "-" + platform + "-" + app + "_" + author + "$");

            string answer = Console.ReadLine();


            /*These are the switch cases for the program, These provide the admin user with the master backend for initializing, securing and starting the program, 
            though there will be plans to add the database startup here in future builds, we are still configuring the proper basics of the console menu 
            to start the program. Thus why this switch case menu stands as the basic layout for the future build of the setup, making it easier to configure for 
            first time setup and use, Admin should note that first time setups will require a request from the developer (Kyo Matias) and shall provide authorization codes
            */
            switch (answer)
            {

                case "purple.cs":
                    Console.Clear();
                    runForm();
                    Console.Clear();
                    ConsoleMain.ConsoleMenu();
                    break;
                    /* The purple.cs case is the run code to start the program, its functionality is the basic startup of the windows form, and thus this is the basic function of the case.
                    Future plans for this development should have the unit testing for the database, servers, items and the prerequisites of the program, making it functional with larger builds and runtimes.
                    */ 

                case "exit":

                    /* the exit case is the exit code for the program, its functionality 
                    is a clean console with an asciii design 
                    of the EUROX Title that has a countdown timer until the program exits
                    Future development plans on closing the database, servers, and main program 
                    with codes to terminate the process.
                    */
                    Console.Clear();
                    for (int a = 3; a >= 0; a--)
                    {
                        Console.Write("\rExiting Program in {0:00}", a, Color.LightSeaGreen);
                        System.Threading.Thread.Sleep(1000);
                    }
                    Console.Clear();
                    Console.WriteAscii("EUROX NFT SYSTEMS", Color.Violet);
                    Environment.Exit(0);
                    break;


                    /*
                    Nose is the replication of the nose.py from python, i try to replicate or make a working formula, hence the nose name
                    of the case switch
                    */
                case "nose":
                    Console.Clear();
                    Test.call_Components();
                    break;

                case "options":
                    Console.Clear();
                    break;

                case "Fuck":
                    Console.Clear();
                    console.WriteLine("Fuck my Life, Good Job Typing That shit");
                    break;
                
            }
        }
            /* this method creates and runs the application via windows .net 
            These Switch cases allows the admin to have full control on the program, thus the Console is essential to start the application.
            This would add better security and maintain the same values in the database.*/
    
            public static void runForm() { 
             // these statements below initiates the software on the console.
            Console.WriteLine("Running The Software...", Color.PaleVioletRed);
            Thread.Sleep(500);
            
             //these variables enables the .net form to run with prerequisites.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EuroxMain());
            
              //These statements clear the console.
            Console.Clear();
            ConsoleMenu();
           
        }

        //[Logs Matias 11/14/2022 - 9:12 am @ CIIT Interweave Campus]

    }
    }


