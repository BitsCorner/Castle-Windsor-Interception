using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP_Demo
{
    public class User : IUser
    {
        public string GetUserName()
        {
            Console.WriteLine("Actual logic of getting a UserName is being executed here.");
            return "Aram Koukia";
        }

    }
}
