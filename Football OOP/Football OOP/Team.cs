using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_OOP
{
    public class Team
    {
        private Coach coach;
        private List<IFootballPlayer> players = new List<IFootballPlayer>();

        public Team(Coach coach, List<IFootballPlayer> players)
        {
            if (players.Count >= 11 && players.Count <= 22)
            {
                this.coach = coach;
                this.players = players;
            }
            else
            {
                throw new Exception("Incorrect team1's players count. Must be 11!");
            }
        }

        public Coach Coach
        {
            get { return coach; }
            set { coach = value; }
        }

        public List<IFootballPlayer> Players
        {
            get { return players; }
            set { players = value; }
        }

        private double GetAverageAge()
        {
            double average = 0;
            foreach (var player in players)
            {
                average += player.Age;
            }
            return average / players.Count;
        }

        public double AverageAgeOfPlayers => GetAverageAge();



    }
}
