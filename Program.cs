using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Patern
{
    class Program
    {
        static void Main(string[] args)
        {
            var policy = new Policy();
            var InsuredName = Policy.Instance.GetInsured();
            Console.WriteLine(InsuredName);
        }
    }
}
