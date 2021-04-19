using System;

namespace TvApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new TV and check its power state, volume and channel
            Tv currentTv = new Tv();
            // Display the TV power state, volume and channel
            //Console.WriteLine($"Power On: {currentTv.PowerOn}");
            //Console.WriteLine($"Channel: {currentTv.Channel}");
            //Console.WriteLine($"Volume Level: {currentTv.VolumeLevel}");
            Console.WriteLine(currentTv);

            // Power on the TV
            currentTv.TogglePower();
            // Change the channel to 13
            currentTv.Channel = 13;
            // Change the volume level to 5
            currentTv.VolumeUp();
            currentTv.VolumeUp();
            currentTv.VolumeUp();
            currentTv.VolumeUp();
            // Display the current state of the TV object
            // Display the TV power state, volume and channel
            //Console.WriteLine($"Power On: {currentTv.PowerOn}");
            //Console.WriteLine($"Channel: {currentTv.Channel}");
            //Console.WriteLine($"Volume Level: {currentTv.VolumeLevel}");
            Console.WriteLine(currentTv);



        }
    }
}
