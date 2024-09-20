using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal public abstract void = new Animal(); 
            //Создать экзм абстракт класса не возможно
            Wolf wolf = new Wolf();
            wolf.Sound();

            Chihuahua nedosobaka = new Chihuahua();
            nedosobaka.Sound();
        }
    }
}
