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
            Console.Clear();


            Console.WriteLine("********************************************************************************");
            TypeEffect($"* Good day {userName.ToUpper().PadRight(61)}*");
            TypeEffect($"* Welcome to the Cybersecurity AI Assistant                                          *");
            TypeEffect($"* I am here to help you identify and defend against cyber attacks                    *");
            Console.WriteLine("********************************************************************************");



            string[] keywords = { "how are you", "purpose", "what can i ask", "password", "phishing", "browsing" };
            string[] responses = {
                "I am functioning optimally. All security protocols are nominal and my database is up to date.",
                "My purpose is to provide real-time education on digital safety, helping users mitigate risks like social engineering and data breaches.",
                "You can ask me about: 'Password' security, 'Phishing' red flags, or 'Browsing' safely online.",
                "PASSWORD SAFETY: Use a minimum of 12 characters. Combine uppercase, lowercase, numbers, and symbols. Most importantly, use a unique password for every account and enable Multi-Factor Authentication (MFA).",
                "PHISHING: Be wary of urgent language or threats. Check for 'spoofed' email addresses that look official but have typos. Never click links or download attachments from unknown senders—visit the official site directly instead.",
                "SAFE BROWSING: Ensure the URL starts with 'HTTPS'. Avoid using public Wi-Fi for sensitive transactions like banking. Use a reputable VPN if you must connect to a public network, and keep your browser and OS patched with the latest security updates."
            };


        }
    }
}