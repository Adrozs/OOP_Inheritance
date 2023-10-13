using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.AnimalClasses.AnimalTypes.Plants
{
    public class Tree : Plant
    {
        // Sets default values if none are passed in when creating object
        public Tree()
        {
            _favFood = "C02";
            _age = 626;
        }
    }
}
