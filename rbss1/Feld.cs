﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rbss1
{
    internal class Feld
    {
        public PictureBox textur { get; set; }

        public Feld() 
        {
            textur = new PictureBox();
        }
    }
}