/*
* Student ID :1650703067
* Name       :Thanatat Muangduang
* Section    :129B
* No.        :01
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== Ragnarok Character Status =====

            // const - ค่าคงที่ เปลี่ยนไม่ได้
            const string GameTitle = @"
 ____   __    ___  __ _   __   ____   __  __ _
(  _ \ / _\  / __)(  ( \ / _\ (  _ \ /  \(  / )
 )   //    \( (_ \/    //    \ )   /(  O ))  (
(__\_)\_/\_/ \___/\_)__)\_/\_/(__\_) \__/(__\_)";

            // ===== var =====
            // ให้ Compiler เดาชนิดข้อมูล
            var characterName = "YaiMakMak";       // var บน string
            var characterRank = 'S';               // var บน char
            var characterClass = "Night Walker";   // var บน string

            // ===== ชนิดข้อมูลต่าง ๆ =====
            int characterLevel = 80;
            float attackPower = 2153.5f;
            float criticalRate = 95.25f;
            double attackSpeed = 192.6;
            double defense = 150.75;
            double stamina = 2500.0;
            bool isAlive = true;

            // ===== Character Status Card =====
            Console.WriteLine($"========================================");
            Console.WriteLine($"{GameTitle}");
            Console.WriteLine($"========================================");
            Console.WriteLine($"Character Name : {characterName}");
            Console.WriteLine($"Rank           : {characterRank}");
            Console.WriteLine($"Class          : {characterClass}");
            Console.WriteLine($"Level          : {characterLevel}");
            Console.WriteLine($"Attack Power   : {attackPower}");
            Console.WriteLine($"Critical Rate  : {criticalRate}");
            Console.WriteLine($"Attack Speed   : {attackSpeed}");
            Console.WriteLine($"Defense        : {defense}");
            Console.WriteLine($"Stamina        : {stamina}");
            Console.WriteLine($"Alive          : {isAlive}");
            Console.WriteLine($"========================================");
            Console.WriteLine($"");

            // ===== Implicit Conversion =====
            // int -> double โดยไม่ต้องใช้ Cast
            double levelAsDouble = characterLevel;

            Console.WriteLine($"===== IMPLICIT CONVERSION =====");
            Console.WriteLine($"Level as double (implicit): {levelAsDouble}");
            Console.WriteLine($"");

            // ===== Explicit Cast vs Convert =====
            // Cast จะตัดทศนิยมออก
            // Convert.ToInt32() จะปัดเศษ
            int speedTruncated = (int)attackSpeed;
            int speedRounded = Convert.ToInt32(attackSpeed);

            Console.WriteLine($"===== EXPLICIT CAST VS CONVERT =====");
            Console.WriteLine($"Original Attack Speed       : {attackSpeed}");
            Console.WriteLine($"Attack Speed cast (truncates): {speedTruncated}");
            Console.WriteLine($"Attack Speed Convert (rounds): {speedRounded}");
            Console.WriteLine($"");

            // ===== Final Character Card =====
            Console.WriteLine($"******** RAGNAROK CHARACTER ********");
            Console.WriteLine($"Name       : {characterName}");
            Console.WriteLine($"Rank       : {characterRank}");
            Console.WriteLine($"Class      : {characterClass}");
            Console.WriteLine($"Level      : {characterLevel}");
            Console.WriteLine($"Attack     : {attackPower}");
            Console.WriteLine($"Critical   : {criticalRate}");
            Console.WriteLine($"Speed      : {attackSpeed}");
            Console.WriteLine($"Defense    : {defense}");
            Console.WriteLine($"Stamina    : {stamina}");
            Console.WriteLine($"Alive      : {isAlive}");
            Console.WriteLine($"************************************");
        }
    }
}
