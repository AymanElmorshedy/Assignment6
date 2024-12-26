using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    //what wer can write in struct
    //1.Attributes [Fields]=>Member value
    //2.functions[constructor Geter Seter method]
    //3.propeerities[full automatic indexer ]
    //4.Events
    //Access modifier allowed in struct 
    //1)public 
    //2)internal
    //3)private[defualt]
    internal struct Point
    {
        //what wer can write in struct
        //1.Attributes [Fields]=>Member value
        #region attributes
        public double x;
        public double y;
        #endregion
        //2.functions[constructor Geter Seter method]
        //Constructor:Special function
        //name => same name of class or struct
        //No return data type
        #region Constructor
        public Point(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        #endregion
        //3.propeerities[full automatic indexer ]
        //4.Events


        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }
    }    
}     

