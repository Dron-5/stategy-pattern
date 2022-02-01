using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    abstract public class Duck
    {
        public string Quack()
        {
            return "Quacking" + " " + this.GetType();
        }

        public string Swim()
        {
            return "Swimming" + " " + this.GetType();
        }

        abstract public string Display();
    }
}
