using System;
using System.Collections.Generic;
using System.Text;

namespace HockerPlayerInfo
{
    // This class contains the description of a NHL Hockey Player
    public class HockeyPlayer   // public access modifier allows this class HockeyPlayer to be used outside of the current namespace HockerPlayerInfo
    {
        // Define data fields that contains data about a hockey player
        // private access modifier means the data field is only accessible within this 
        // current class
        private string _name;
        private string _position;
        private int _number;

        // Define properties to encapsulate access to our data fields
        // Properties allows you to get (accessor) or set (mutator) a data field
        public string Name  // Name is a property of the HockeyPlayer
        {
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;  // value is keyword for the new value being assigned
                                // value is only accessible inside the set block
            }
        }
        // Define a property for Position
        public string Position 
        {
            get { return _position; }
            set { _position = value; }
        }
        // Define a property for Number
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        // Define a constructor to initialize the properties of the current object
        public HockeyPlayer()   // A constructor has the same name as the class name and no return value
        {
            // Assign default/initial values to your data fields
            _name = "No name assigned";
            _position = "C";
            _number = 1;
        }
    }
}
