using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeather
{
    public class Menu
    {
        public string Welcome = @"
________                          __      __               __  .__                  
\_____  \ ______   ____   ____   /  \    /  \ ____ _____ _/  |_|  |__   ___________ 
 /   |   \\____ \_/ __ \ /    \  \   \/\/   // __ \\__  \\   __\  |  \_/ __ \_  __ \
/    |    \  |_> >  ___/|   |  \  \        /\  ___/ / __ \|  | |   Y  \  ___/|  | \/
\_______  /   __/ \___  >___|  /   \__/\  /  \___  >____  /__| |___|  /\___  >__|   
        \/|__|        \/     \/         \/       \/     \/          \/     \/       

";
        public Menu()
        {
            Console.Title = "OPEN WEATHER APP";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(Welcome);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");



        }
    }
}
