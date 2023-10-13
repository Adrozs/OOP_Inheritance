using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Interfaces
{
    // Declares interface ITame to let classes be "tame". 
    // Instead of creating 2 separate classes for all animals, 1 wild and 1 tame. This interface promises that all 
    // "tame" animals will implement its features.
    internal interface ITame
    {
        void Tame();
    }
}
