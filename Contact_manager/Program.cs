using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_manager
{
    class Program
    {
        static void Main(string[] args)
        {

            Contact C1 = new Contact();
            C1.AddUser("mohamed");
            C1.Show_users();


            Console.ReadKey();

        }
    }
}
