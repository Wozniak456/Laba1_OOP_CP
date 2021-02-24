using System;

namespace csLib
{
    public class Class1
    {
        public static void MinusOne(int num, out int rez)
        {
            if (num == 0)
            {
                rez = -1;
            }
            else
            {
                rez = num;
                int mask = 1;
                while ((rez & mask) == 0)
                {
                    rez ^= mask;
                    mask <<= 1;
                }
                rez ^= mask;
            }
        }

        public static bool Equal(int num1, int num2)
        {
            int Mask = 1;
            bool equal = true;
            for (int i = 0; i < 31; i++)
            {
                if ((num1 & Mask << i) != (num2 & Mask << i))
                    equal = false;
            }
            return equal;
        }
    }
}
