using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassExample
{

    public class SpaceShip<TSpeed, TSpaceShip> where TSpaceShip : SpaceShip<TSpeed, TSpaceShip>, new()
    {
        public TSpeed? Speed { get; set; }
        public string Name { get; set; } = string.Empty;

 
        public virtual TSpaceShip CloneShip()
        {
            return new TSpaceShip { Speed = this.Speed, Name = this.Name };
        }
    }
   
    public class BattleShip<TSpeed> : SpaceShip<TSpeed, BattleShip<TSpeed>>
    {
        public int ArmorLevel { get; set; }
        public int Firepower { get; set; }

        public override BattleShip<TSpeed> CloneShip()
        {
            return base.CloneShip();
        }
    }

    public class Cruiser<TSpeed> : SpaceShip<TSpeed, Cruiser<TSpeed>>
    {
        public int ShieldStrength { get; set; }
        public int WeaponCount { get; set; }

        public override Cruiser<TSpeed> CloneShip()
        {
            return base.CloneShip();
        }
    }
}
