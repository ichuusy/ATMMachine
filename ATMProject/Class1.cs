using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
    internal class Class1
    {
        public static Class1 Instance;
        public string Name;
        public int Money;
        public List<string> History = new List<string>();

        public static void ObjeVer() 
        {
            if (Instance != null)
                return;
            Instance = new Class1();

        }
        
    }
}
