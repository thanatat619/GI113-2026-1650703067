namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== >> GAME TITLE << ==");
            Console.WriteLine("Hero vs. monsters -- Calculate Damage\n");

            // Hero satats
            Console.WriteLine("Hero HP:  ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack:  ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defense:  ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster stats
            Console.WriteLine("Monster HP:  ");
            bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.WriteLine("Monster Attack:  ");
            bool monsterAtkOk = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.WriteLine("Monster Defense:  ");
            bool monsterDefOk = int.TryParse(Console.ReadLine(), out int monsterDef);

            // check for valid input
            bool heroInputValid = heroHpOk && heroAtkOk && heroDefOk;
            bool monsterInputValid = monsterHpOk && monsterAtkOk && monsterDefOk;
            Console.WriteLine($">> Hero stats valid: {heroInputValid}");
            Console.WriteLine($">> Monster stats valid: {monsterInputValid}");
            Console.WriteLine($"[HERO]       HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]    HP: {monsterHp}, ATK: {monsterAtk}, DEF: {monsterDef}");

            // Hero drinks a potion before thr fight (compond assignemt: += )
            int potionHeal = 14;
            // hero = HeroHp + potionHeal ผลคือ 114 (สมมติ HP 100)
            // heroHp += potionHeal ผลคือ 114 การคำนวณเหมือนกัน แต่เขียนสั้นกว่า
            heroHp += potionHeal; //Hero ดื่ม Hp Potion
            Console.WriteLine($"\nHero drink a potion, healing {potionHeal} HP, Hero HP is: {heroHp}");

            int normalDamage = Math.Max(0, heroAtk - monsterDef); // โจมตีปกติ โดยการ -
            Console.WriteLine($"Normal attack deals: {normalDamage} DMG.");

            int powerdamage = Math.Max(0, heroAtk * 2 - monsterDef); // โจมตีแบบพลัง โดยการ *2
            Console.WriteLine($"Power attack deals: {powerdamage} DMG.");

            int counterDamage = Math.Max(0, monsterAtk - heroDef); // โจมตีสวนกลับ โดยการ -
            Console.WriteLine($"Counter attack deals: {counterDamage} DMG.");

            Random randomSomething = new Random();
            int roll = randomSomething.Next(1, 101); // Random number between 1 and 100
            bool isCritical = roll <= 10; // 10% chance for critical hit
            int criticalDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage;
            Console.WriteLine($"Crit Damage roll: {roll} (crit?: {isCritical})");
            Console.WriteLine($"If critical, normal attack would deals: {criticalDamage} DMG.");


        }
    }
}
