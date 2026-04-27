using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrays
{
    internal class Program
    {
        static string BitArrayToString(BitArray bArr)
        {
            char[] chars = new char[bArr.Length];//create char array with the same length as the BitArray
            for(int i = 0; i< bArr.Length; i++)
            {
                chars[i] = bArr[i] ? '1' : '0';//if the bit is true, set the char to '1', otherwise set it to '0'
            }
            return new string(chars);
        }
        static void Main(string[] args)
        {
            #region BitArray Creation
            //contain 0,1 default value is 0 or false
            BitArray bArr1 = new BitArray(10);

            bArr1.Set(0, true);//set 0 index to true
            bArr1.Set(3, true);//set 3 index to true and 1,2 index to false
            bArr1.Set(4, true);//set 4 index to true

            Console.WriteLine(BitArrayToString(bArr1));//print the BitArray as a string


            bool[] bools = { true, false, true, false, true, false, true, false, true };
            BitArray bArr2 = new BitArray(bools);//create a BitArray from a bool array
            Console.WriteLine("BitArray from bool array:");
            Console.WriteLine(BitArrayToString(bArr2));//print the BitArray as a string
            for (int i = 0; i < bArr2.Count; i++)
            {
                Console.WriteLine($"Index {i}: {bArr2.Get(i)}");//print each bit in the BitArray
            }

            byte[] bytes = { 0xFF, 0x0F, 0xA0 };//create a byte array
            BitArray bArr3 = new BitArray(bytes);//create a BitArray from a byte array
            Console.WriteLine("BitArray from byte array:");
            Console.WriteLine(BitArrayToString(bArr3));//print the BitArray as a string
            for (int i = 0; i < bArr3.Count; i++)
            {
                Console.WriteLine($"Index {i}: {bArr3.Get(i)}");//print each bit in the BitArray

            }

            //Basic Operations:
            BitArray bArr4 = new BitArray(8);
            bArr4.Set(0, true);
            bArr4[7] = true;//set the last bit to true using indexer
            bArr4.SetAll(true);//set all bits to true
            bArr4.SetAll(false);//set all bits to false


            bool bit1 = bArr4.Get(0);//get the value of the first bit
            int length1 = bArr4.Length;//get the length of the BitArray
            int count1 = bArr4.Count;//get the count of bits in the BitArray
            #endregion

            #region Bitwise Operators in BitArray
            BitArray bits1 = new BitArray(new bool[] { true, false, true, false });
            BitArray bits2 = new BitArray(new bool[] { false, true, false, true });

            Console.WriteLine("\nBits1:");
            Console.WriteLine(BitArrayToString(bits1));

            Console.WriteLine("Bits2:");
            Console.WriteLine(BitArrayToString(bits2));

            //and operator
            BitArray andResult = new BitArray(bits1);
            andResult.And(bits2);
            Console.WriteLine("AND Result:");
            Console.WriteLine(BitArrayToString(andResult));

            //or operator
            BitArray orResult = new BitArray(bits1);
            orResult.Or(bits2);
            Console.WriteLine("OR Result:");
            Console.WriteLine(BitArrayToString(orResult));

            //xor operator
            BitArray xorResult = new BitArray(bits1);
            xorResult.Xor(bits2);
            Console.WriteLine("XOR Result:");
            Console.WriteLine(BitArrayToString(xorResult));

            //not operator
            BitArray notResult = new BitArray(bits1);
            notResult.Not();
            Console.WriteLine("NOT Result:");
            Console.WriteLine(BitArrayToString(notResult));

            #endregion


        }
    }
}
