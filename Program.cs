// By Main_EX#3898
// Made this program for myself since ones I found online were broken and did not work
// Also this simplifies the fixing process so you don't have to always manually find the files and delete it
// Decided to release this out because why not be more helpful :D


using System;
using System.IO;

namespace UnexpectedClientBehaviourFix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro and credits and stuff
            Console.Title = "Unexpected Client Behaviour Fix | By Main_EX#3898";
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nRun this if Roblox is constantly spamming you with 'Unexpected Client Behaviour' :3\n\n");

            // Start fix
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("=== Running fix ===\n\n");

            string localappdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Checking for GlobalBasicSettings_13.xml... ");
            if (File.Exists(localappdata + "/Roblox/GlobalBasicSettings_13.xml")) // Delete GlobalBasicSettings_13.xml
            {
                try
                {
                    File.Delete(localappdata + "/Roblox/GlobalBasicSettings_13.xml");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Found and deleted!\n\n");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Not found, most likely already fixed\n\n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Not found, most likely already fixed\n\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Checking for GlobalSettings_13.xml... ");
            if (File.Exists(localappdata + "/Roblox/GlobalSettings_13.xml")) // Possible it still exists somewhere...
            {
                try
                {
                    File.Delete(localappdata + "/Roblox/GlobalSettings_13.xml");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Found and deleted!\n\n");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Not found, most likely already fixed\n\n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Not found, most likely already fixed\n\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Checking for AnalysticsSettings.xml... ");
            if (File.Exists(localappdata + "/Roblox/AnalysticsSettings.xml")) // Delete AnalysticsSettings.xml
            {
                try
                {
                    File.Delete(localappdata + "/Roblox/AnalysticsSettings.xml");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Found and deleted!\n\n");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Not found, most likely already fixed\n\n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Not found, most likely already fixed\n\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Checking for frm.cfg... ");
            if (File.Exists(localappdata + "/Roblox/frm.cfg")) // Delete frm.cfg
            {
                try
                {
                    File.Delete(localappdata + "/Roblox/frm.cfg");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Found and deleted!\n\n");
                }
                catch
                {
                    Console.Write("Not found, most likely already fixed\n\n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Not found, most likely already fixed\n\n");
            }

            // Finish message
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nFix ran and done successfully!"); // All program is literally doing is deleting files... how could it go wrong
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nIf you still have any issues, feel free to DM me at Main_EX#3898 (most likely in one of your mutal servers)");
            Console.Write("\n\nPress any key to close this program. Make sure to run this program every time you have this issue.");
            Console.ReadKey();
        }
    }
}
