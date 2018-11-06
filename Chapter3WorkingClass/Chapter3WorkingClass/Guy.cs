﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3WorkingClass
{
    class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if(amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show($"I don't have enough cash to give you ${amount} says {Name}.");
                return 0;
            }
        }

        public int RecieveCash(int amount)
        {
            if(amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show($"{amount} isn't an amount I'll take, {Name} says");
                return 0;
            }
        }
    }
}