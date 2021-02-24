#include "Header.h"
using namespace std;

void MinusOne(int& rez)
{
    if (rez == 0)
    {
        rez = -1;
    }
    else
    {
        int mask = 1;
        while ((rez & mask) == 0)
        {
            rez ^= mask;
            mask <<= 1;
        }
        rez ^= mask;
    }
}

bool Equal(int num1, int num2)
{
    int Mask = 1;
    bool isEqual = true;
    for (int i = 0; i < 31; i++)
    {
        if ((num1 & Mask << i) != (num2 & Mask << i))
            isEqual = false;
    }
    return isEqual;
}