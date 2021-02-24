#include <iostream>
#include "Header.h"
using namespace std;

int main()
{
    cout << "input a num1: ";
    int a;
    cin >> a;
    MinusOne(a);
    cout << "result of decrementing: " << a << endl;
    cout << "input a num2: ";
    int b;
    cin >> b;
    cout << "input a num3: ";
    int c;
    cin >> c;
    if (Equal(b, c))
    {
        cout << b << " = " << c << ": true" << endl;
    }
    else
    {
        cout << b << " = " << c << ": false" << endl;

    }
}
