using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refleksiya
{
    public class User
    {
        public string Name;
        public string SurName;
        public int ID;
        public static int age;
        public void GetFullNme()
        {
            Console.WriteLine(Name + " "+ SurName);
        }
        public static void ChangeAge(int Newage)
        {
            age = Newage;
            Console.WriteLine(age);
        }
    }
}
