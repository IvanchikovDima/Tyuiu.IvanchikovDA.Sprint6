using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.IvanchikovDA.Sprint6.Task1.V23.Lib
{
    public class DataService : ISprint6Task1V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; // объявляется пустой массив
            int len = (stopValue - startValue) + 1; //вычисляем длинну массива
            valueArray = new double[len];//создаем массив с указанной длинной
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x) + ((2.0 * x) / 3.0) - Math.Cos(x) * (4.0 * x)), 2);// округлили до 2 знаков
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
