using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_OOP
{
    public class Game
    {
        public Game(Team team1, Team team2, Referee mainReferee, Referee assistantReferee1, Referee assistantReferee2
            , Dictionary<string, IFootballPlayer> goals, string gameResult, string winner)
        {
            if (team1.Players.Count == 11 && team2.Players.Count == 11)
            {
                Team1 = team1;
                Team2 = team2;
                MainReferee = mainReferee;
                AssistantReferee1 = assistantReferee1;
                AssistantReferee2 = assistantReferee2;
                Goals = goals;
                GameResult = gameResult;
                Winner = winner;
            }
            else
            {
                if (team1.Players.Count != 11)
                {
                    throw new Exception("Incorrect team1's players count. Must be 11!");
                }
                if (team2.Players.Count != 11)
                {
                    throw new Exception("Incorrect team2's players count. Must be 11!");
                }
            }
        }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee MainReferee { get; set; }
        public Referee AssistantReferee1 { get; set; }
        public Referee AssistantReferee2 { get; set; }
        public Dictionary<string, IFootballPlayer> Goals { get; set; }
        public string GameResult { get; set; }
        public string Winner { get; set; }
    }
}
