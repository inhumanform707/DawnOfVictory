using ClassLibraryDOV.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDOV.Class
{
    public class Sorcerer : Character, IAble
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

                GreatVision = false;
            }
            else
            {
                Console.WriteLine($"{Name} does not have enough mana to attack!");
            }
        }

        public string UseSpecialAbility()
        {
            GreatVision = true;
            return "Great Vision activated!";
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Health: {Health}, Strength: {Strength}, Intelligence: {Intelligence}, Great Vision: {GreatVision}");
        }
        #endregion
    }
}
