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

            string userName = "";
            while (true)
            {
                Console.WriteLine("\n: Please enter your UserName");
                userName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userName))
                {
                    Console.WriteLine("Field for Name shouldn't be empty");
                    continue;
                }
                if (userName.Length < 2)
                {
                    Console.WriteLine("Name cannot be less than 2 characters short");
                    continue;
                }
                if (!Regex.IsMatch(userName, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Name should only contain letters and not numbers");
                    continue;
                }
                break;
            }


        }
    }
}