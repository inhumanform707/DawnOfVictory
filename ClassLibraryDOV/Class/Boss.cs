using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDOV.Class
{
    sealed class Boss : Character
    {
        #region Properties
        public int Rage { get; set; } // Special ability
        public bool Enraged { get; set; } // Special ability
        #endregion

        #region Constructors
        public Boss(string name)
        {
            Name = name;
            Health = 200;
            Strength = 30;
            Intelligence = 10;
            Rage = 10;
            Enraged = false;
        }
        #endregion

        #region Methods
        public void BossAttack(Character target)
        {
            if (Enraged)
            {
                target.Health -= Strength * 2;
            }
            else
            {
                target.Health -= Strength;
            }
        }
        #endregion
    }
}
