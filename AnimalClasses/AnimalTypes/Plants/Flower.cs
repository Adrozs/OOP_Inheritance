using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.AnimalClasses.AnimalTypes.Plants
{
    internal class Flower : Plant
    {
        // Sets default values if no arguments are passed in when creating new object
        public Flower()
        {
            _age = 3;
        }
    }
}
