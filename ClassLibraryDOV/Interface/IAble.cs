using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDOV.Interface
{
    internal interface IAble
    {
        string UseSpecialAbility();
        void Attack(Character target);
    }
}
