﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rbss1
{
    public class Nahkaempfer : Truppe   
    {
        public Nahkaempfer()
        {
            Bewegungsreichweite = 2;
            Schaden = 35;
            textur.Image = Properties.Resources.melee_character;

        }
        public override void Angreifen(Truppe targetTruppe)
        {
            if (targetTruppe == null || targetTruppe.Besitzer.truppen.Contains(targetTruppe))
                return;
            targetTruppe.Leben -= Schaden;
            if (targetTruppe.Leben <= 0)
            {
                targetTruppe.EntferneTruppe();
            }
        }
        public override string ToString()
        {
            return "Nahkämpfer";
        }
    }
}