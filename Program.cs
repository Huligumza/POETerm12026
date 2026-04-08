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
                "I am functioning optimally. All security protocols are nominal.",
                "My purpose is to educate users on digital safety and threat prevention.",
                "You can ask me about: Password Safety, Phishing, or Safe Browsing tips.",
                "PASSWORD SAFETY: Use long phrases, mix symbols/numbers, and use a Password Manager.",
                "PHISHING: Never click unexpected links. Verify the sender's email address carefully.",
                "SAFE BROWSING: Only use HTTPS sites, avoid public Wi-Fi for banking, and keep your browser updated."
            };

            bool chatActive = true;
            while (chatActive)
            {
                Console.Write($"\n{userName.ToUpper()} > ");
                string input = Console.ReadLine().ToLower();

                if (input == "exit" || input == "quit")
                {
                    chatActive = false;
                    continue;
                }

                bool foundMatch = false;
                for (int i = 0; i < keywords.Length; i++)
                {
                    if (input.Contains(keywords[i]))
                    {
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        TypeEffect($"[AI]: {responses[i]}");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        foundMatch = true;
                        break;
                    }
                }

                if (!foundMatch)
                {
                    TypeEffect("[AI]: I didn't quite understand that, could you rephrase?");
                }
            }

            Console.WriteLine("\nSession Terminated. Press any key to close.");
            Console.ReadKey();
        }

        
        static void TypeEffect(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(25); 
            }
            Console.WriteLine();
        }
    }
}