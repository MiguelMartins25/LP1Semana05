using System;

namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
        }

        static int Damage(int attack, int defense)
        {
            int result = attack - defense;
            return result < 0 ? 0 : result; //minimo 0
        }

        static int Damage(int attack)
        {
            return attack;
        }

        static int CriticalHit(int damage)
        {
            if (damage <= 0)
                return 0;

            return damage + CriticalHit(damage - 1);
        }
    }
}
