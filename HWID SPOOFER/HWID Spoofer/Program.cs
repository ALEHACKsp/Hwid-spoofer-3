using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWID_Spoofer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hentai Spoofer | V1.0 | hanime.tv";
            Misc.DrawASCII();
            Misc.HashText("Welcome To Your First Spoofer");
            Misc.HashText("Press Any Key To Load Options...");
            Console.ReadKey();
            Console.Clear();
            Misc.DrawASCII();
            Misc.OptionText("spoof");
            Misc.OptionText("clean");
            Misc.HashText("Option :");
            var option = Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                Misc.DrawASCII();
                Misc.HashText("Spoofing Diskdrive!");
                Spoof.SpoofHDD();
                Misc.HashText("Spoofed Diskdrive!");
                Console.ReadKey();

            }
            else if (option == "2")
            {
                Console.Clear();
                Misc.DrawASCII();
                Misc.HashText("Cleaning Traces!");
                Spoof.CleanTraces(@"C:\Users\Raymond Shell\Pictures\mapper.exe");
                Misc.HashText("Cleaned Traces!");
                Console.ReadKey();

            }
            else
            {
                Misc.HashText("OK retard Maybe Type Right Next Time");
            }
        }
    }
}
