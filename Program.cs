﻿using ClassLibraryDOV.Class;
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
            Warrior warrior = new Warrior("Pero");
            Sorcerer sorcerer = new Sorcerer("Janko");
            var winner = Fight.SimulateFight(warrior, sorcerer);
            Fight.CheckWinner(winner);
            

        }
    }
}



