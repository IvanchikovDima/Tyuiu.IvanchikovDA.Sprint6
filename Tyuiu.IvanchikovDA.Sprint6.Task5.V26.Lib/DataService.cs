using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.IvanchikovDA.Sprint6.Task5.V26.Lib
{
    public class DataService : ISprint6Task5V26
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader read = new StreamReader(path))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] massive = new double[len];
            int i = 0;

            using (StreamReader read = new StreamReader(path))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    massive[i] = Convert.ToDouble(line);
                    i++;
                }

            }
            massive = massive.Where(val => val > 5).ToArray();
            return massive;
        }
    }
}