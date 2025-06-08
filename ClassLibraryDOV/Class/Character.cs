using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDOV
{
    public abstract class Character
    {
        #region Properties
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        #endregion

        #region Constructors
        public Character()
        {
        }
        #endregion

        #region Methods
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Health: {Health}, Strength: {Strength}, Intelligence: {Intelligence}");
        }
        #endregion
    }
}
