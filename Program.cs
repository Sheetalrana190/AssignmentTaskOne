/*
* Author: Sheetal Rana
* Date: 30 January 2025
* Project: Task_1
* Description:
* Calculate total money spent and average price per trip for Carlo's business travels.
*/

namespace AssignmentTaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize variable for Round-trips price
            int torontoToCalgary = 1350 * 2;
            int torontoToVancouver = 1500 * 2;
            int torontoToMontreal = 575 * 2;
            // Code to enter number of trips taken
            Console.WriteLine("Enter number of trips to Calgary:");
            int tripsCalgary = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter number of trips to Vancouver:");
            int tripsVancouver = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter number of trips to Montreal:");
            int tripsMontreal = int.Parse(Console.ReadLine());

        }
    }
}
