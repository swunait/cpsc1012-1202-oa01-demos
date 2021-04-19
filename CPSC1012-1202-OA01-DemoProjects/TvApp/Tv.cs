using System;
using System.Collections.Generic;
using System.Text;

namespace TvApp
{
    public class Tv
    {
        // Define data fields to storing data
        private bool _powerOn = false;      // Is the TV on or off
        private int _channel = 1;       // The current Channel of the TV
        private int _volumeLevel = 1;  // The current volume level of the TV

        // Define properties to encapsulate access to our data fields
        public bool PowerOn
        {
            get { return _powerOn; }
        }
        public int Channel
        {
            get { return _channel; }
            set
            {
                // Our TV only supports channel 1 to 13
                if (value >= 1 && value <= 13)
                {
                    _channel = value;
                }
                else
                {
                    throw new Exception("Channel must be between 1 and 13.");
                }
            }
        }

        public int VolumeLevel
        {
            get { return _volumeLevel; }
        }

        // Define methods that performs operations using data fields
        public void TogglePower()
        {
            _powerOn = !_powerOn;
        }

        public void ChannelUp()
        {
            if (_powerOn && _channel < 13)
            {
                _channel++;
            }
        }

        public void ChannelDown()
        {
            if (_powerOn && _channel > 1 )
            {
                _channel--;
            }
        }

        public void VolumeUp()
        {
            if (_powerOn && _volumeLevel < 10)
            {
                _volumeLevel++;
            }
        }

        public void VolumnDown()
        {
            if (_powerOn && _volumeLevel > 1)
            {
                _volumeLevel--;
            }
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Power: {_powerOn}, Channel: {_channel}, Volume: {_volumeLevel}";
        }
    }
}
