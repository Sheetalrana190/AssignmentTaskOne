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
            //Console.WriteLine("Enter number of trips to Calgary:");
            //int tripsCalgary = int.Parse(Console.ReadLine());

            //Console.WriteLine("\nEnter number of trips to Vancouver:");
            //int tripsVancouver = int.Parse(Console.ReadLine());

            //Console.WriteLine("\nEnter number of trips to Montreal:");
            //int tripsMontreal = int.Parse(Console.ReadLine());

            int tripsCalgary = GetValidTrips("Calgary");
            int tripsVancouver = GetValidTrips("Vancouver");
            int tripsMontreal = GetValidTrips("Montreal");

            // code to calculate total number of business trips
            int totalTrips = tripsCalgary + tripsVancouver + tripsMontreal;
            Console.WriteLine("Total numbers of Business Trips: " + totalTrips);

            // code to calculate the total amount of money spent on all the businss trips
            double totalAmount = (tripsCalgary * torontoToCalgary) + (tripsVancouver * torontoToVancouver) + (tripsMontreal * torontoToMontreal);
            Console.WriteLine("Total amount spent on all the Business Trips: $" + totalAmount.ToString("C"));

            // code to calculate average tavel expenses per Trip
            double average = totalAmount / totalTrips;
            Console.WriteLine("Average tavel expenses per Trip: $" + average.ToString("C"));
        }
        //fuction to catch invalid entry of negative number or character for user input numbers of trips
        static int GetValidTrips(string city)
        {
            int trips = -1;
            while (trips < 0)
            {
                try
                {
                    Console.WriteLine($"Enter number of trips to {city}:");
                    trips = int.Parse(Console.ReadLine());

                    if (trips < 0)
                    {
                        Console.WriteLine("Number of trips cannot be negative. Please enter a non-negative number.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
                }
            }

            return trips;

        }
    }
}