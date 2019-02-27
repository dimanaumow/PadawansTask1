using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        { 
            if(percent < 0)
            {
                throw new ArgumentException(); 
            }

            int years = 0; 

            while(true)
            {
                if (initialPopulation >= currentPopulation)
                {
                    return years; 
                }
                years++;

                initialPopulation += (int)(percent * initialPopulation / 100);

                initialPopulation += visitors;
            }
        }
    }
}