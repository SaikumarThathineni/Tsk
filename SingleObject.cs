using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    public class SingleObject
    {
        private static readonly SingleObject instance = new();

        private SingleObject() { }

        public static SingleObject GetInstance()
        {
            return instance;
        }

        public  void ShowMessage()
        {
            Console.WriteLine ("This is singleton design pattern");
        }

        public void Message()
        {
            Console.WriteLine("This is also a singleton design pattern");
        }

    }
}
