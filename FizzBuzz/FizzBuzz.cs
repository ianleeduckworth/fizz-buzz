using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public IEnumerable<string> DoFizzBuzz(int start, int end, int fizz, int buzz)
        {
            List<string> returnValue = new List<string>();
            for (int i = start; i <= end; i++)
            {
                if (i % fizz == 0 && i % buzz == 0)
                {
                    returnValue.Add("FizzBuzz");
                }
                else if (i % fizz == 0)
                {
                    returnValue.Add("Fizz");
                }
                else if (i % buzz == 0)
                {
                    returnValue.Add("Buzz");
                }
                else
                {
                    returnValue.Add(i.ToString());
                }
            }

            return returnValue;
        }
    }
}
