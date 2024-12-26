using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //inside itis project and External Project [Import]
    public class TypeA
    {
        //it is project and external project [import]
       public TypeA()
       {
            TypeB typeB = new TypeB(); 
       }

        private int X; // Class scope only
        internal int Y; //Class Scope And Internal Project
        public int Z; //

        void Print()
        {
            Console.WriteLine(X);
        }
        
    }
  
    

   
}
