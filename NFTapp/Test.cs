using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTapp
{
    public class Test
    {
        public static void call_Components()
        {
            ConsoleComponents TestingComponents = new ConsoleComponents();

            string callAuthor = TestingComponents.AppAuthor;
            string callAppName = TestingComponents.ApplicationName;
            string method = "My Method";

            var CheckString = Type.GetType(String.Format("{0}, {1}", callAuthor, callAppName));
            object instance = CheckString == null ? null : Activator.CreateInstance(CheckString);
            var stringExists = CheckString.GetMethod(method) != null;

            Console.WriteLine(stringExists);
            Console.WriteLine(CheckString);

        }

        public void read_Components()
        {
        }
    }
}
