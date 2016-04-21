using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Test the various forms of Main(); returning void, int. 
// Include a batch file to run the program and capture the error code.
    // This is located at the directory containing the compiled .exe
namespace CH3EX1
{
    class CH3EX1
    {
        static int Main(string[] args)
        {
            // Display a simple message to the user.
            Console.WriteLine("***** My First C# App (Not really) *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Wait for the Enter key to be pressed before shutting down.
            Console.ReadLine();

            // Update the program to have a return type of int instead of void.
            // Return an arbitrary error code.
            return -1;
        }
    }
}
