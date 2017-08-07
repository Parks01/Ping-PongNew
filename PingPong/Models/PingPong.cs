using System.Collections.Generic;

namespace PingPongApp.Models
{
    public class PingPong
    {
        public static List<string> CountToNumber(int number)
        {
            List<string> listOfNumbers = new List<string> {};
            for (int i = 1; i <= number; i++)
            {
                listOfNumbers.Add(i.ToString());
            }
            for (int j = 1; j <= number; j++)
            {
                if (j % 3 == 0)
                {
                    listOfNumbers[j] = "ping";
                }
            }
            return listOfNumbers;
        }

    }
}
