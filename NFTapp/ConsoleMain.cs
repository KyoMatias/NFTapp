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

            switch (answer)
            {
                case "purple.cs":
                    Console.Clear();
                    runForm();
                    Console.Clear();
                    ConsoleMain.ConsoleMenu();
                    break;
                case "exit":
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

                case "nose":
                    Console.Clear();
                    Test.call_Components();
                    break;
            }
        }
            public static void runForm() { 
            
            Console.WriteLine("Running The Software...", Color.PaleVioletRed);
            Thread.Sleep(500);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EuroxMain());

            Console.Clear();
            ConsoleMenu();
           
        }
        //Sample Text for Claro


    }
    }



