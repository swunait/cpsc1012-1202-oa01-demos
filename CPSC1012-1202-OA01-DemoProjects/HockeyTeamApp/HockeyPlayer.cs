using System;
using System.Collections.Generic;
using System.Text;

namespace HockeyTeamApp
{
    public enum PlayerPosition
    {
        C,  // = 0
        LW, // = 1
        RW, // = 2
        D,  // = 3
        G   // = 4
    }
    public class HockeyPlayer
    {
        // Define data fields to store data about a hockey player
        private string _fullName = "No Name Assigned";
        private int _primaryNumber = 99;
        private PlayerPosition _primaryPosition = PlayerPosition.C;

        // Define properties to encapsulate access to the data fields
        public string FullName
        {
            //get { return _fullName; }
            get => _fullName;
            //set { _fullName = value; }
            set => _fullName = value;
        }
        public int PrimaryNumber
        {
            get => _primaryNumber;
            set => _primaryNumber = value;
        }
        public PlayerPosition Position 
        {
            get => _primaryPosition;
            set => _primaryPosition = value;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{_fullName, -25} {_primaryNumber, 5} {_primaryPosition, 5}";
        }

    }
}
