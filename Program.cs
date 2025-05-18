using ClassLibraryDOV.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawnOfVictory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior character = new Warrior("Pero");
            character.ShowInfo();
        }
    }
}
