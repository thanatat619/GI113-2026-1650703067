/*
 * Student ID :1650703067
 * Name       :Thanatat Muangduang
 * Section    :129B
 * No.        :01
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            //FORGE SMELT / BREAKDOWN
            // ==========================================

            // Constants
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500.0;

            // Program Header
            Console.WriteLine("======================================");
            Console.WriteLine("        FORGE CRAFTING SYSTEM         ");
            Console.WriteLine("======================================");
            Console.WriteLine($"Smelt Rate   : {SmeltRate:F4}");
            Console.WriteLine($"Salvage Rate : {SalvageRate:F4}");
            Console.WriteLine($"Max Batch    : {MaxBatch:F2}");

            // Check Economy Rate
            Console.WriteLine();
            Console.WriteLine("========== RATE CHECK ==========");

            if (SmeltRate < SalvageRate)
            {
                Console.WriteLine("Rate Check: OK");
                Console.WriteLine("SmeltRate is lower than SalvageRate.");
            }
            else
            {
                Console.WriteLine("ERROR: Invalid Rate!");
                Console.WriteLine("SmeltRate must be lower than SalvageRate.");
            }

            // Menu
            Console.WriteLine();
            Console.WriteLine("S = Smelt");
            Console.WriteLine("B = Breakdown");
            Console.Write("Enter Menu: ");

            // Read menu using char.TryParse
            if (char.TryParse(Console.ReadLine(), out char menu))
            {
                // Smelt Menu
                if (menu == 'S' || menu == 's')
                {
                    Console.WriteLine();
                    Console.WriteLine("========== SMELT ==========");

                    Console.Write("Enter Iron Ore Amount: ");

                    // Read amount using double.TryParse
                    if (double.TryParse(Console.ReadLine(), out double amount))
                    {
                        // Validate amount
                        if (amount > 0 && amount <= MaxBatch)
                        {
                            // Check valid economy rate before calculation
                            if (SmeltRate < SalvageRate)
                            {
                                // Smelt: Ore -> Ingot
                                double result = amount * SmeltRate;

                                Console.WriteLine();
                                Console.WriteLine("------- SMELT RESULT -------");
                                Console.WriteLine($"Input  : {amount:F2} Iron Ore");
                                Console.WriteLine($"Rate   : {SmeltRate:F4}");
                                Console.WriteLine($"Result : {result:F2} Iron Ingot");
                                Console.WriteLine("----------------------------");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("ERROR: Invalid Rate.");
                                Console.WriteLine("Smelt operation cannot be used.");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine(
                                $"ERROR: Amount must be greater than 0 and <= {MaxBatch:F2}."
                            );
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("ERROR: Amount must be a valid number.");
                    }
                }

                // Breakdown Menu
                else if (menu == 'B' || menu == 'b')
                {
                    Console.WriteLine();
                    Console.WriteLine("======= BREAKDOWN =======");

                    Console.Write("Enter Iron Ingot Amount: ");

                    // Read amount using double.TryParse
                    if (double.TryParse(Console.ReadLine(), out double amount))
                    {
                        // Validate amount
                        if (amount > 0 && amount <= MaxBatch)
                        {
                            // Check valid economy rate before calculation
                            if (SmeltRate < SalvageRate)
                            {
                                // Breakdown: Ingot -> Ore
                                double result = amount / SalvageRate;

                                Console.WriteLine();
                                Console.WriteLine("------ BREAKDOWN RESULT ------");
                                Console.WriteLine($"Input  : {amount:F2} Iron Ingot");
                                Console.WriteLine($"Rate   : {SalvageRate:F4}");
                                Console.WriteLine($"Result : {result:F2} Iron Ore");
                                Console.WriteLine("------------------------------");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("ERROR: Invalid Rate.");
                                Console.WriteLine("Breakdown operation cannot be used.");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine(
                                $"ERROR: Amount must be greater than 0 and <= {MaxBatch:F2}."
                            );
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("ERROR: Amount must be a valid number.");
                    }
                }

                // Invalid Menu
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("ERROR: Invalid menu.");
                    Console.WriteLine("Please enter S for Smelt or B for Breakdown.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("ERROR: Please enter only one character.");
            }

            // End Program
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
