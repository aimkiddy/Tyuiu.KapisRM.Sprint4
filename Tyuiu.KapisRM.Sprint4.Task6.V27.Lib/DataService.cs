using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KapisRM.Sprint4.Task6.V27.Lib
{
    public class DataService : ISprint4Task6V27
    {
        public int Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, s => s.Length < 7);
            return res.Length;
        }
    }
}
