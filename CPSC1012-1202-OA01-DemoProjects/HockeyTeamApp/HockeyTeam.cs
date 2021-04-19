using System;
using System.Collections.Generic;
using System.Text;

namespace HockeyTeamApp
{
    public enum HockeyDivision
    {
        HondaWest,          // 0
        DiscoverCentral,    // 1
        MassMutalEast,      // 2
        ScotiaNorth         // 3
    }
    public class HockeyTeam
    {
        // Define data fields to store data
        private string _teamName = "Avalanche";
        private HockeyDivision _division = HockeyDivision.HondaWest;
        private List<HockeyPlayer> _playerList = new List<HockeyPlayer>();

        // Define properties to encapsulate access to the data fields
        public string TeamName
        {
            get => _teamName;
            set => _teamName = value;
        }
        public HockeyDivision Division
        {
            get => _division;
            set => _division = value;
        }
        public List<HockeyPlayer> PlayerList
        {
            get => _playerList;
        }

        // Define methods that performs operations using data fields
        public int AddPlayer(HockeyPlayer newHockerPlayer)
        {
            _playerList.Add(newHockerPlayer);
            return _playerList.Count;
        }


        public override string ToString()
        {
            //return base.ToString();
            return $"Team Name: {_teamName}, Division: {_division.ToString()}";
        }
    }

}
