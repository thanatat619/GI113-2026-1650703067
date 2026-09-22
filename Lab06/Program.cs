/*
* Student ID :1650703067
* Name       :Thanatat Muangduang
* Section    :129B
* No.        :01
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int live = 0; /// ตัวแปรหลักเพื่อเช็ค

            //if (live <= 0) /// ในเกมนี้ต้องเอาไข่มาทำให้เป็นจริง
            //{
            //    Console.WriteLine("Game over"); /// ในบล็อกจะทำงานเมื่อเงื่อนไขเป็นจริง
            //}
            //else
            //{
            //    Console.WriteLine("Continue to play!");
            //}

            ///// เมื่อเงื่อนไขทำงานเสร็จแล้ว หรือ เงื่อนไขไม่ผ่านจะทำงานต่อ
            //Console.WriteLine("Continue to run");

            //bool isPoisioned = false;
            //if (isPoisioned) { }
            //if (!isPoisioned) { }

            /////int level = 7;

            //bool haskey = true;
            //Console.Write("Your level (1-99): ");
            //bool ok = int.TryParse(Console.ReadLine(), out int level);

            //if (!ok || level < 1 || level > 99)
            //{
            //    Console.WriteLine("Invalid level.");
            //}

            //if (level >= 10 && haskey)
            //{
            //    Console.WriteLine("Boss floor unlocked");
            //}
            //else if (level >= 5)
            //{
            //    if (haskey == true)
            //    {
            //        Console.WriteLine("The door open");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Locked find a key");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The door stay shut");
            //}



            // ===== Fishing Game Status =====
            int playerEnergy = 100;
            int normalFish = 0;
            int rareFish = 0;

            Console.WriteLine("=================================");
            Console.WriteLine("       RARE FISHING ADVENTURE");
            Console.WriteLine("=================================");
            Console.WriteLine($"Energy    : {playerEnergy}");
            Console.WriteLine($"Normal Fish: {normalFish}");
            Console.WriteLine($"Rare Fish : {rareFish}");
            Console.WriteLine();

            Console.WriteLine("You arrived at a mysterious fishing lake.");
            Console.WriteLine("Catch a rare fish to unlock the new stage.");
            Console.WriteLine();

            Console.WriteLine("ACTION 1: FISH");
            Console.WriteLine("ACTION 2: WAIT");
            Console.WriteLine("ACTION 3: LEAVE");
            Console.WriteLine();

            Console.Write("Choose your action (1-3): ");

            bool inputOk = int.TryParse(
                Console.ReadLine(),
                out int choice
            );

            // ===== Check Action Input =====
            if (!inputOk || choice < 1 || choice > 3)
            {
                Console.WriteLine();
                Console.WriteLine(
                    "Invalid input. Please choose 1, 2 or 3."
                );
            }
            else if (choice == 1)
            {
                Console.WriteLine();
                Console.Write("How many times do you want to fish (1-3): ");

                bool fishOk = int.TryParse(
                    Console.ReadLine(),
                    out int fishCount
                );

                // ===== Check Fishing Input =====
                if (!fishOk || fishCount < 1 || fishCount > 3)
                {
                    Console.WriteLine();
                    Console.WriteLine(
                        "Invalid input. Please enter a number between 1 and 3."
                    );
                }
                else if (fishCount == 1)
                {
                    playerEnergy = playerEnergy - 20;
                    normalFish = normalFish + 1;

                    Console.WriteLine();
                    Console.WriteLine("You cast your fishing rod.");
                    Console.WriteLine("You caught a normal fish!");
                    Console.WriteLine($"Normal Fish: {normalFish}");
                    Console.WriteLine($"Energy left: {playerEnergy}");
                    Console.WriteLine("The rare fish is still hiding.");
                }
                else if (fishCount == 2)
                {
                    playerEnergy = playerEnergy - 40;
                    normalFish = normalFish + 2;

                    Console.WriteLine();
                    Console.WriteLine("You cast your fishing rod twice.");
                    Console.WriteLine("You caught 2 normal fish!");
                    Console.WriteLine($"Normal Fish: {normalFish}");
                    Console.WriteLine($"Energy left: {playerEnergy}");
                    Console.WriteLine("Keep fishing to find a rare fish.");
                }
                else
                {
                    playerEnergy = playerEnergy - 60;
                    normalFish = normalFish + 2;
                    rareFish = rareFish + 1;

                    Console.WriteLine();
                    Console.WriteLine("You cast your fishing rod three times.");
                    Console.WriteLine("You caught 2 normal fish!");
                    Console.WriteLine("Amazing! You found a RARE FISH!");
                    Console.WriteLine($"Normal Fish: {normalFish}");
                    Console.WriteLine($"Rare Fish: {rareFish}");
                    Console.WriteLine($"Energy left: {playerEnergy}");
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("NEW STAGE UNLOCKED!");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                Console.WriteLine("You wait quietly beside the lake.");
                Console.WriteLine("You did not catch any fish.");
                Console.WriteLine("The stage is still locked.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You leave the fishing lake.");
                Console.WriteLine("The stage is still locked.");
            }

            Console.WriteLine();
            Console.WriteLine("========== GAME END ==========");

        }
    }
}

