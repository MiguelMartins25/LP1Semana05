using System;
using Spectre.Console;

namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int attack = int.Parse(args[0]);
            int defense;

            if (args.Length > 1)
                defense = int.Parse(args[1]);
            else
                defense = 2;

            Table table = new Table();
            table.AddColumn("Operation");
            table.AddColumn("Result");

            table.AddRow("Damage(" + attack + ")", Damage(attack).ToString());
            table.AddRow("Damage(" + attack + ", " + defense + ")", Damage(attack, defense).ToString());

            int dmg = Damage(attack, defense);
            table.AddRow("CriticalHit(" + dmg + ")", CriticalHit(dmg).ToString());

            AnsiConsole.Write(table);
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
