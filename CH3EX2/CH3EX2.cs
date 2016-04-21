using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3EX2
{
    class CH3EX2
    {
        static int Main(string[] args)
        {
            Console.WriteLine("**********************");

            // Process any incoming args using a for loop:
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg: {0}", args[i]);
            }

            Console.WriteLine("**********************");

            // Process any incoming args using a foreach:
            foreach (string arg in args)
            {
                Console.WriteLine("Arg {0}", arg);
            }

            Console.WriteLine("**********************");

            // Process incoming args using the static GetCommandLineArgs() method from System.Environment:
            // If using this method it is no longer necessary to declare string[] args in the Main method.
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
            {
                Console.WriteLine("Arg {0}", arg);
            }

            Console.WriteLine("**********************");
            
            // Helper method within the Program class.
            ShowEnvironmentDetails();

            Console.ReadLine();

            return -1;
        }

        static void ShowEnvironmentDetails()
        {
            // Print out the drives on this machine, and other interesting details:
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET version: {0}", Environment.Version);
        }
    }
}
