using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class TypeB
    {
        //it is project only
        public TypeB() 
        {
            TypeA typeA = new TypeA();
            typeA.Y=2;
        }
    }
}
