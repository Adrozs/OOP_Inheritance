using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Interfaces
{
    // Declares interface IWild to let classes be "wild". 
    // Instead of creating 2 separate classes for all animals, 1 wild and 1 tame. This interface promises that all 
    // "wild" animals will implement its features.
    public interface IWild
    {
        void Wild();
    }
}
