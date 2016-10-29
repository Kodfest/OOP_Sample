using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01
{
    public class Baby
    {
        //Baby Nesnesinin Özellikleri
        public string Name;
        public string Surname;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Baby b = new Baby();
            b.Name = "Yavuz";
            b.Surname = "Gedik";
            b.Age = 3;
            
            Console.WriteLine("İsim Soyisim\t: {0} {1}", b.Name,b.Surname);
            Console.WriteLine("Yaş\t\t: {0}", b.Age);

            Console.ReadKey();
        }
    }
}
