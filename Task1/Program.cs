using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals=new Animal[2];
            animals[0] = new Cat("Рыжик");
            animals[1] = new Dog("Шарик");
            foreach (var animal in animals)
            {
                animal.ShowInfo();
            }
            Console.ReadKey();
            
        }
    }
}
