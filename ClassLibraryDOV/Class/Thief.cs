using ClassLibraryDOV.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDOV.Class
{
    public class Thief : Character, IAble
    {
        #region Properties
        public int Stealth { get; set; }
        public bool Backstab { get; set; }  // Special ability
        #endregion

        #region Constructors
        public Thief(string name)
        {
            Name = name;
            Health = 70;
            Strength = 10;
            Intelligence = 15;
            Stealth = 100;
            Backstab = false;
        }
        #endregion

        #region Methods
        public void Attack(Character target)
        {
            if (Backstab)
            {
                target.Health -= Strength * 3;
            }
            else
            {
                target.Health -= Strength;
            }
        }
        public string UseSpecialAbility()
        {
            Backstab = true;
            return "Backstab activated!";
        }
        #endregion
    }
}
