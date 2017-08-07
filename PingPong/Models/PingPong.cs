using System.Collections.Generic;

namespace PingPongApp.Models
{
    public class PingPong
    {
        public static List<int> CountToNumber(int number)
        {
            List<int> listOfNumbers = new List<int> {};
            for (int i = 1; i <= number; i++)
            {
                listOfNumbers.Add(i);
            }
            return listOfNumbers;
        }
    }
}
