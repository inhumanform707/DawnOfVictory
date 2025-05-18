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
        }

        public void UseSpecialAbility()
        {
            Berserk = true;
        }
        #endregion
    }
}
