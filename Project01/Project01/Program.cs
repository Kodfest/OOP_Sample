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
        public byte Age;

        public string GiveInfo()
        {
            return string.Format("İsim Soyisim\t: {0} {1}\nYaş\t\t: {2}", Name, Surname, Age);
        }

        public void ChangeAge(byte age)
        {
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Baby b = new Baby();
            b.Name = "Yavuz";
            b.Surname = "Gedik";
            b.Age = 3;

            //Console.WriteLine("İsim Soyisim\t: {0} {1}", b.Name,b.Surname);
            //Console.WriteLine("Yaş\t\t: {0}", b.Age);

            Console.WriteLine(b.GiveInfo());
            b.ChangeAge(4);
            Console.WriteLine(b.GiveInfo());

            Console.ReadKey();
        }
    }
}
