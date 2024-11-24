using System;

class GreenvilleRevenue
{
    static void Main()
    {

        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");

        // Beginning choices
        while (true)
        {

            Console.WriteLine("\nPlease Enter the following number below from the following menu:");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");


            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();


            if (choice == "1")
            {
                CalculateRevenue();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                break; 
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid option (1 or 2).");
            }
        }
    }
        // Function to calculate revenue for a given year and give a comparative statement. 
    static void CalculateRevenue()
    {
        int thisYearContestants = GetValidContestantNumber("Enter the number of contestants this year: ");
        int lastYearContestants = GetValidContestantNumber("Enter the number of contestants last year: ");

        const int TicketPrice = 25;
        int expectedRevenue = thisYearContestants * TicketPrice;

        Console.WriteLine($"\nRevenue expected this year is: ${expectedRevenue}");

        if (thisYearContestants > 2 * lastYearContestants)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (thisYearContestants > lastYearContestants)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else if (thisYearContestants < lastYearContestants)
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
        else
        {
            Console.WriteLine("This year's competition has the same number of contestants as last year.");
        }
    }
        // Keeping with the lessons learned, I've called a method here to do the validation.
    static int GetValidContestantNumber(string prompt)
    {
        int contestants;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out contestants) && contestants >= 0 && contestants <= 30)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid number. Please enter a value between 0 and 30, inclusive.");
            }
        }
        return contestants;
    }
}
