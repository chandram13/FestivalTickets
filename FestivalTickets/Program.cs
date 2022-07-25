// See https://aka.ms/new-console-template for more information

namespace FestivalTickets
{
    class Festival
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To purchase a festival ticket, please indicate which plan you'd like.");
            var cheapest = "To purchase a GA pass, press select ticket.\n";
            var cheapestSelection = cheapest + "Your total cost of your ticket is $229.\n";
            Console.WriteLine(cheapestSelection);
            var midTier = "To purchase a GA plus pass, press select ticket.\n";
            var midSelection = midTier + "Your total cost of your ticket is $289.\n";
            Console.WriteLine(midSelection);
            var VIP = "To purchase a VIP pass, press select ticket.";
            var exclusiveSelection = VIP + "Your total cost of your ticket is $439.\n";
            Console.WriteLine(exclusiveSelection);
        }
    }
