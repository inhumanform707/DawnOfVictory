using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDOV.Record
{
    internal class FightLog
    {
        #region Properties
        public Character Attacker { get; set; }
        public Character Target { get; set; }
        public string TypeOfAttack { get; set; }
        public int Damage { get; set; }
        #endregion

        public FightLog(Character attacker, Character target, string typeOfAttack, int damage)
        {
            Attacker = attacker;
            Target = target;
            TypeOfAttack = typeOfAttack;
            Damage = damage;
        }

        public override string ToString()
        {
            return $"{Attacker} attacks {Target} with {TypeOfAttack} & deals {Damage} points of damage.";
        }
    }
}
    

