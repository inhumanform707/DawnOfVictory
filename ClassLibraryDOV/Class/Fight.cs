using ClassLibraryDOV.Record;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibraryDOV.Class
{
    public class Fight
    {
        #region Methods
        public static Character SimulateFight(Warrior a, Sorcerer b)
        {
            Random rand1 = new Random();
            Random rand2 = new Random();

            while (a.Health > 0 && b.Health > 0)
            {
                byte[] bytes1 = new byte[2];
                rand1.NextBytes(bytes1);
                byte[] bytes2 = new byte[2];
                rand2.NextBytes(bytes2);

                byte warriorNumber = bytes1[0];
                byte sorcererNumber = bytes1[1];
                byte warriorSpecial = bytes2[0];
                byte sorcererSpecial = bytes2[1];

                Console.WriteLine($"The Warrior draws number: {warriorNumber}");
                Console.WriteLine($"The Sorcerer draws number: {sorcererNumber}");
                Console.WriteLine();

                if (warriorNumber > sorcererNumber)
                {
                    Console.WriteLine("Warrior attacks Sorcerer");
                    
                    if (warriorSpecial > 112)
                    {
                        Console.WriteLine(a.UseSpecialAbility());
                    }

                    a.Attack(b);
                    a.ShowInfo();
                    b.ShowInfo();
                    Console.WriteLine();
                }
                else if (sorcererNumber > warriorNumber)
                {
                    Console.WriteLine("Sorcerer attacks Warrior");

                    if (sorcererSpecial > 112)
                    {
                        Console.WriteLine(b.UseSpecialAbility());
                    }

                    b.Attack(a);
                    a.ShowInfo();
                    b.ShowInfo();
                    Console.WriteLine();
                }
            }

            if (a.Health > b.Health)
            {
                return a;
            }
            else if (b.Health > a.Health)
            {
                return b;
            }
            else
            {
                return a;
            }
            
            
            
        }

        public static void CheckWinner(Character winner)
        {
            if (winner is ClassLibraryDOV.Class.Warrior)
            {
                Console.WriteLine("The winner of the fight is Warrior!!");
            }
            else if (winner is ClassLibraryDOV.Class.Sorcerer)
            {
                Console.WriteLine("The winner of the fight is Sorcerer!!");
            }
        }

        // Sprema log u listu ZapisBorbe

        // BONUS IDEJE(ako stigneš):
        // Dodaj polimorfizam u prikazu likova(PrikaziInfo)

        // Dodaj izračun stvarne štete koji ovisi o obrani(možeš definirati dodatno svojstvo)

        // Dodaj metodu za oporavak zdravlja
        #endregion
    }
}
