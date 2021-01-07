using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Patern
{
    public class Policy
    {
        private static Policy _instance;

        public static Policy Instance 
        { 
            get
            {
                if (_instance==null)
                {
                    _instance = new Policy();
                }
                return _instance;
            } 
        }
        public int Id { get; set; }
        private string Insured { get; set; } = "Atheek Ahammed";
        public string GetInsured() => Insured;
    }
}
