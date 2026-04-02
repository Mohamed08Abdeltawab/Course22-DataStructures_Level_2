using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_and_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing
            //boxing is the process of converting a value type to an object type. to box a value type, you simply assign it to an object variable.
            // Boxing
            int valType = 10;
            object objType = valType; // Boxing


            Console.WriteLine("Value Type: " + valType);
            Console.WriteLine("Object Type: " + objType);
            #endregion


        }
    }
}
