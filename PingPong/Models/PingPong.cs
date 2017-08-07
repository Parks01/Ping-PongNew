namespace PingPongApp.Models
{
    public class PingPong
    {
        public List<int> CountToNumber(int number)
        {
            List<int> listOfNumbers = new List<int> {};
            for (int i = 0; i < number; i++)
            {
                listOfNumbers.Add(i);
            }
            return listOfNumbers;
        }
    }
}
