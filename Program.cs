using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

using System;
using System.Text.RegularExpressions;
using System.Threading; 

namespace POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            greetingVoice into = new greetingVoice();

            string sign = @"
 /$$$$$$  /$$      /$$ /$$$$$$$  /$$$$$$$$  /$$$$$$$         /$$$$$$   /$$$$$$  /$$$$$$$$ /$$$$$$$$ /$$$$$$$$ /$$      /$$
/$$__  $$|  $$    /$$/ | $$__  $$| $$_____ | $$__  $$       /$$__  $$ /$$__  $$| $$_____/| $$_____/|__  $$__/|  $$    /$$/
| $$  \__/ \  $$  /$$/ | $$  \ $$| $$      | $$  \ $$      | $$  \__/| $$  \ $$| $$      | $$         | $$    \  $$  /$$/ 
| $$        \  $$/$$/  | $$$$$$$ | $$$$$   | $$$$$$$/      |  $$$$$$ | $$$$$$$$| $$$$$   | $$$$$      | $$     \  $$/$$/  
| $$         \  $$$/   | $$__  $$| $$__/   | $$__  $$       \____  $$| $$__  $$| $$__/   | $$__/      | $$      \  $$/   
| $$    $$    |  $$/   | $$  \ $$| $$      | $$  \ $$       /$$  \ $$| $$  | $$| $$      | $$         | $$       | $$    
| $$$$$$/     | $$     | $$$$$$$/| $$$$$$$$| $$  | $$      |  $$$$$$/| $$  | $$| $$      | $$$$$$$$   | $$       | $$    
 \______/     |__/     |_______/ |________/|__/  |__/       \______/ |__/  |__/|__/      |________/   |__/       |__/    
            ";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(sign);
            Console.ResetColor();

        }
    }
}