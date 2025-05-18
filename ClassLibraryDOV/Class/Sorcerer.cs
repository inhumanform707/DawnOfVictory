using ClassLibraryDOV.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDOV.Class
{
    internal class Sorcerer : Character, IAble
    {
        #region Properties
        public int Mana { get; set; }
        public bool GreatVision { get; set; }  // Special ability
        #endregion

        #region Constructors
        public Sorcerer(string name)
        {
            Name = name;
            Health = 80;
            Strength = 5;
            Intelligence = 20;
            Mana = 100;
            GreatVision = false;
        }
        #endregion

        #region Methods
        public void Attack (Character target)
        {
            if (Mana >= 10)
            {
                if (GreatVision)
                {
                    target.Health -= Intelligence * 3;
                }
                else
                {
                    target.Health -= Intelligence * 2;
                    Mana -= 10;
                }      
            }
            else
            {
                Console.WriteLine($"{Name} does not have enough mana to attack!");
            }
        }

        public void UseSpecialAbility()
        {
            GreatVision = true;
        }
        #endregion
    }
}
