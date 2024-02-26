using System;

namespace GenericClassExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BattleShip<int> battleShip = new BattleShip<int>();
            battleShip.Speed = 100;
            battleShip.Name = "Battle Ship";

            BattleShip<int> clonedBattleShip = battleShip.CloneShip();
            Console.WriteLine($"Cloned Battleship Speed: {clonedBattleShip.Speed}");
            Console.WriteLine($"Cloned Battleship Name: {clonedBattleShip.Name}");
            Console.WriteLine();

            Cruiser<double> cruiser = new Cruiser<double>();
            cruiser.Speed = 200.5;
            cruiser.Name = "Cruser Ship";

            Cruiser<double> clonedCruiser = cruiser.CloneShip();
            Console.WriteLine($"Cloned Cruiser Speed: {clonedCruiser.Speed}");
            Console.WriteLine($"Cloned Cruiser Name: {clonedCruiser.Name}");
        }
    }
}
