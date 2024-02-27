using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTask;

internal class Combination
{
    public void FindCombination()
    {
        for (int a1 = 11; a1 < 100; a1++)
        {
            for (int a2 = 1; a2 < 10; a2++)
            {
                for (int a3 = 11; a3 < 100; a3++)
                {
                    for (int a4 = 11; a4 < 100; a4++)
                    {
                        if (a1 % 10 == 0 || a3 % 10 == 0 || a4 % 10 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (AreTheNumbersEqual(a1, a2, a3, a4))
                            {
                                Console.WriteLine($"({a1} * {a2}) + {a3} = {a4}");
                            }
                        }
                    }
                }
            }
        }
    }
    public bool AreTheNumbersEqual(int a1, int a2, int a3, int a4)
    {
        int x = (a1 * a2) + a3;
        if (x == a4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
