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

            #region Unboxing
            //unboxing is the process of converting an object type back to a value type. to unbox an object type, you need to cast it back to the original value type.
            int unboxedValType = (int)objType; // Unboxing
            Console.WriteLine("Unboxed Value: " + unboxedValType);
            #endregion

        }
    }
}
