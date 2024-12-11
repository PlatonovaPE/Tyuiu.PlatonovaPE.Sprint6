using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.PlatonovaPE.Sprint6.Task6.V26.Lib
{
    public class DataService : ISprint6Task6V26
    {
        public string CollectTextFromFile(string str, string path)
        {
            {
                string resStr = "";

                using (StreamReader reader = new StreamReader(path))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        var temp = line.Split(' ');

                        resStr += temp[^1] + " ";
                    }
                    return resStr;
                }
            }
        }
    }
}