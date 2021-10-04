using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> product = new MyDictionary<string, int>();

            product.Add("Pc", 20300);
            product.Add("Klavye", 300);
            product.Add("Hoparlor", 1000);
        }
    }
}
