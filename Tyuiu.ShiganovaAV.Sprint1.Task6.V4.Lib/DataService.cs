using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShiganovaAV.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string result = "";
            string[] words = value.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains("нн"))
                {
                    if (result != "") result += " ";
                    result += words[i];
                }
            }

            return result;
        }
    }
}
