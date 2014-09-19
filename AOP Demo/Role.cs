using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP_Demo
{
    public class Role : IRole
    {
        public string GetRoleName()
        {
            Console.WriteLine("Actual logic of getting a RoleName is being executed here.");
            return "Administrator";
        }
    }
}
