/*
 * Student ID :1650703067
 * Name       :Thanatat Muangduang
 * Section    :129B
 * No.        :01
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Boss Stats
            Console.WriteLine("===== KRITIN SAVE CONVERTER =====");
            Console.WriteLine($"NAME: {bossName}" +
                $"\nRANK: {rank}" +
                $"\nLEVEL: {level} / {MaxLevel}" +
                $"\nHP: {currentHp} / {maxHp}" +
                $"\nATTACK POWER: {attackPower}" +
                $"\nCRIT MULTIPLIER: {critMultiplier}" +
                $"\nIS BOSS: {isBoss}");

            // Implicit conversion HP (int) ---> double
            Console.WriteLine("\n--- Implicit Conversion: HP as double ----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");

            // Calculate Percent as double
            Console.WriteLine("\n--- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");

            // Explicit casting attack power (float) ---> int
            Console.WriteLine("\n--- Explicit Casting: Attack Power as int ----");
            int attackPowerInt = (int)attackPower;
            Console.WriteLine($"Attack Power (int): {attackPowerInt}");

            // Cast vs. Convert: Crit Multiplier (double) ---> int
            Console.WriteLine("\n--- Cast vs. Convert: Crit Multiplier ----");
            int critMultiplierInt = (int)critMultiplier;
            int critMultiplierConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int): {critMultiplierInt}");
            Console.WriteLine($"Crit Multiplier (converted): {critMultiplierConvert}");
        }
    }
}
