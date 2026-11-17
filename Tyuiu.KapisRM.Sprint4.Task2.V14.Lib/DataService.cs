using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KapisRM.Sprint4.Task2.V14.Lib
{
    public class DataService : ISprint4Task2V14
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasOdd = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    product *= array[i];
                    hasOdd = true;
                }
            }

            return hasOdd ? product : 0;
        }
    }
}
