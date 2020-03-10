using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings
{
    class Basketball
    {
        public string GymLocation { get; set; }
        public string TeamName { get; set; }
        public int WinsNumber { get; set; }
        public int LosesNumber { get; set; }

        public Basketball(string teamName, string gymLocation)
        {
            TeamName = teamName;
            GymLocation = gymLocation;
        }

        public void Hoop(int winsNumber)
        {
            WinsNumber = winsNumber;
            Console.WriteLine($"Last week, I played with the {TeamName} at {GymLocation} and we won {WinsNumber} games!");
        }

        public void Losing(int losesNumber)
        {
            LosesNumber = losesNumber;
            Console.WriteLine($"Raymond loss {LosesNumber} times and quit after he realized he couldn't beat Randy's team.");
        }
    }
}
