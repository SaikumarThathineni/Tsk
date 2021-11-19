using System;

namespace SingleTonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SingleObject first = SingleObject.GetInstance();
            SingleObject second = SingleObject.GetInstance();

            if (first == second)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }


              first.ShowMessage();
              second.Message();
        }
    }
}
