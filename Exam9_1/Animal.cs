using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam9_1
{
    internal class Animal
    {
        public int Age {  get; set; }
        public SexEnum MyProperty { get; set; }
        public int Weight {  get; set; }

        public Animal() {
            Console.WriteLine("Animal" + this.ToString());
        }

        public void Sleep()
        {

        }
        public void Eat()
        {

        }public void Walk()
        {

        }
    }
}
