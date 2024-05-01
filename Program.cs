using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lab11;

class Program
{
    static void Main(string[] args)
    {
        var players = new List<Player>
        {
            new Player
            {
                Initials = "DJD",
                Scores = new List<Score>
                {
                    new Score { Points = 500, ScoreDate = DateTime.Now },
                    new Score { Points = 497, ScoreDate = DateTime.Now.AddDays(-30) }
                }
            },
            new Player
            {
                Initials = "KJL",
                Scores = new List<Score>
                {
                    new Score { Points = 499, ScoreDate = DateTime.Now.AddDays(-7) },
                    new Score { Points = 496, ScoreDate = DateTime.Now.AddDays(-40) }
                }
            }
        };

        string json = JsonConvert.SerializeObject(players, Formatting.Indented);
        System.IO.File.WriteAllText("Lab.Json", json);
    }
}

