using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamChallenge
{
    public class Team
    {
        public string TeamName { get; set; }
        public char TeamID { get; set; }
        public List <Developers> _developers { get; set; }

        public Team(){}
        
        public Team(string team, char teamID, List<Developers> developers)
        {
            TeamName = team;
            TeamID = teamID;
            _developers = developers;

        }
        
    }
    public class Developers
    {

    }

}
