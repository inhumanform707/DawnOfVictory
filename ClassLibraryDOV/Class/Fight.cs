using ClassLibraryDOV.Record;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDOV.Class
{
    public class Fight
    {
        #region Methods
        public static string SimulateFight(Warrior a, Sorcerer b)
        {
            Random rand = new Random();

            while (a.Health > 0 && b.Health > 0)
            {
                byte[] bytes = new byte[2];
                rand.NextBytes(bytes);

                byte warriorNumber = bytes[0];
                byte sorcererNumber = bytes[1];
                Console.WriteLine(warriorNumber);
                Console.WriteLine(sorcererNumber);
                Console.WriteLine();

                if (warriorNumber > sorcererNumber)
                {
                    a.Attack(b);
                }
                else if (sorcererNumber > warriorNumber)
                {
                    b.Attack(a);
                }
            }

            if (a.Health > b.Health)
            {
                return "Warrior is the winner of the fight!";
            }
            else if (b.Health > a.Health)
            {
                return "Sorcerer is the winner of the fight!!";
            }
            else
            {
                return "Tie! No winner declared!";
            }
            
            
            
        }
        // Sadrži metodu SimulirajBorbu(Lik a, Lik b) koja koristi napade i specijalne moći

        // Sprema log u listu ZapisBorbe

        // BONUS IDEJE(ako stigneš):
        // Dodaj polimorfizam u prikazu likova(PrikaziInfo)

        // Dodaj izračun stvarne štete koji ovisi o obrani(možeš definirati dodatno svojstvo)

        // Dodaj metodu za oporavak zdravlja
        #endregion
    }
}
