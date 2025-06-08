using ClassLibraryDOV.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDOV.Class
{
    public class Warrior : Character, IAble
    {
        #region Properties
        public bool Berserk { get; set; } // Special ability
        #endregion

        #region Constructors
        public Warrior(string name)
        {
            Name = name;
            Health = 100;
            Strength = 20;
            Intelligence = 5;
            Berserk = false;
        }
        #endregion

        #region Methods
        public void Attack(Character target)
        {
            if (Berserk)
            {
                target.Health -= Strength * 2;
            }
            else
            {
                target.Health -= Strength;
            }

            Berserk = false;
        }

        public string UseSpecialAbility()
        {
            Berserk = true;
            return "Berserk activated!";
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Health: {Health}, Strength: {Strength}, Intelligence: {Intelligence}, Berserk: {Berserk}");
        }
        #endregion
    }
}
