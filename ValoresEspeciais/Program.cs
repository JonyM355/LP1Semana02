using System;
using System.Reflection;
using System.Reflection.PortableExecutable;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ex. 6

            byte b = byte.MaxValue;
            byte b1 = byte.MinValue;

            sbyte sb = sbyte.MaxValue;
            sbyte sb1 = sbyte.MinValue;

            short s = short.MaxValue;
            short s1 = short.MinValue;

            ushort us = ushort.MaxValue;
            ushort us1 = ushort.MinValue;

            int i = int.MaxValue;
            int i1 = int.MinValue;

            uint ui = uint.MaxValue;
            uint ui1 = uint.MinValue;

            long l = long.MaxValue;
            long l1 = long.MinValue;

            ulong ul = ulong.MaxValue;
            ulong ul1 = ulong.MinValue;

            char c = char.MaxValue;
            char c1 = char.MinValue;

            float f = float.MaxValue;
            float f1 = float.MinValue;

            double d = double.MaxValue;
            double d1 = double.MinValue;

            Console.WriteLine($"{b}\n{b1}\n");
            Console.WriteLine($"{sb}\n{sb1}\n");
            Console.WriteLine($"{s}\n{s1}\n");
            Console.WriteLine($"{us}\n{us1}\n");
            Console.WriteLine($"{i}\n{i1}\n");
            Console.WriteLine($"{ui}\n{ui1}\n");
            Console.WriteLine($"{l}\n{l1}\n");
            Console.WriteLine($"{ul}\n{ul1}\n");
            Console.WriteLine($"{c}\n{c1}\n");
            Console.WriteLine($"{f}\n{f1}\n");
            Console.WriteLine($"{d}\n{d1}\n");


            double infpositive = double.PositiveInfinity;
            double infnegative = double.NegativeInfinity;

            float nan = float.NaN;

            Console.WriteLine($"{infpositive}");
            Console.WriteLine($"{infnegative}");
            Console.WriteLine($"{nan}");


            // Ex. 7

            uint ui2 = ushort.MaxValue;
            Console.WriteLine((ushort)(ui2 + 1));

        }
    }
}
