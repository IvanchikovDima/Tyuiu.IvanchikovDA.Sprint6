using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.IvanchikovDA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string str, string path)
        {
            List<string> res = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null && line != "")
                {
                    var temp = line.Split();
                    res.Add(temp[temp.Length - 1]);
                }
            }
            return String.Join(" ", res);
        }
    }
}
