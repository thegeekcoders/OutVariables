using System;

namespace OutVariables
{
    public class Sleep
    {
        public void GetSleep(out int hoursOfSleep)
        {
            hoursOfSleep = 8;
            Console.WriteLine($"Hours of Sleep: {hoursOfSleep}");
        }
    }
}
