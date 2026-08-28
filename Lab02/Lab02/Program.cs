/*
 * Student ID :1650703067
 * Name       :Lab2
 * Section    :129B
 * No.        :NA
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Past A lab 2
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;


            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {critMultiplier}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp percent:{hpPercent}");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====" );
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            // =========================
            // Part B
            // Game: RPG Adventure
            // 4 Characters / 5 Stats
            // =========================

            Console.WriteLine("=================================");
            Console.WriteLine("       Monter Hunting");
            Console.WriteLine("=================================");
            Console.WriteLine();


            // =========================
            // Character 1 : Rao
            // =========================

            string KnightName = "Rao";
            char KnightRank = 'S';
            int KnightHp = 250;
            double KnightAttackPower = 75.5;
            bool KnightIsBoss = false;

            Console.WriteLine("===== CHARACTER 1: Rao =====");
            Console.WriteLine($"Name: {KnightName}");
            Console.WriteLine($"Rank: {KnightRank}");
            Console.WriteLine($"HP: {KnightHp}");
            Console.WriteLine($"Attack Power: {KnightAttackPower}");
            Console.WriteLine($"Is Boss: {KnightIsBoss}");
            Console.WriteLine();


            // =========================
            // Character 2 : Luna
            // =========================

            string mageName = "Luna";
            char mageRank = 'A';
            int mageHp = 180;
            double mageMagicPower = 75.5;
            bool mageIsBoss = false;

            Console.WriteLine("===== CHARACTER 2: LUNA =====");
            Console.WriteLine($"Name: {mageName}");
            Console.WriteLine($"Rank: {mageRank}");
            Console.WriteLine($"HP: {mageHp}");
            Console.WriteLine($"Magic Power: {mageMagicPower}");
            Console.WriteLine($"Is Boss: {mageIsBoss}");
            Console.WriteLine();


            // =========================
            // Character 3 : Robin
            // =========================

            string archerName = "Robin";
            char archerRank = 'B';
            int archerHp = 200;
            float archerSpeed = 12.5f;
            bool archerIsBoss = false;

            Console.WriteLine("===== CHARACTER 3: ROBIN =====");
            Console.WriteLine($"Name: {archerName}");
            Console.WriteLine($"Rank: {archerRank}");
            Console.WriteLine($"HP: {archerHp}");
            Console.WriteLine($"Speed: {archerSpeed}");
            Console.WriteLine($"Is Boss: {archerIsBoss}");
            Console.WriteLine();


            // =========================
            // Character 4 : Shadow
            // =========================

            string assassinName = "Shadow";
            char assassinRank = 'S';
            int assassinHp = 160;
            double assassinCritMultiplier = 2.25;
            bool assassinIsBoss = false;

            Console.WriteLine("===== CHARACTER 4: SHADOW =====");
            Console.WriteLine($"Name: {assassinName}");
            Console.WriteLine($"Rank: {assassinRank}");
            Console.WriteLine($"HP: {assassinHp}");
            Console.WriteLine($"Crit Multiplier: {assassinCritMultiplier}");
            Console.WriteLine($"Is Boss: {assassinIsBoss}");
            Console.WriteLine();




        }


    }
    
}
