﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rbss1
{
    public partial class Form1 : Form
    {
        private PictureBox lastClicked = null;
        public Form1()
        {
            InitializeComponent();

            Feldgenerierung();
        }
        public void Feldgenerierung() 
        {
            int x = 0;
            int y = 0;

            for(int i = 0; i < 10; i++) 
            {
                Feld feld = new Feld();
                feld.textur.Size = new Size(50, 50);
                feld.textur.Location = new Point(x, y);
                feld.textur.Image = Properties.Resources.squar2;
                feld.textur.BackColor = Color.White;
                feld.textur.Click += new EventHandler(feld_Click);
                
                this.Controls.Add(feld.textur);
                
                for (int j = 0; j < 10; j++)
                {
                    Feld feldy = new Feld();
                    feldy.textur.Size = new Size(50, 50);
                    feldy.textur.Location = new Point(x, y);
                    feldy.textur.Image = Properties.Resources.squar2;
                    feldy.textur.BackColor = Color.White;
                    feldy.textur.Click += new EventHandler(feld_Click);

                    this.Controls.Add(feldy.textur);
                    y += 50;
                }
                y = 0;
                x += 50;
            }
        }

        public void feld_Click(object sender, EventArgs e) 
        {
            PictureBox feld = sender as PictureBox;
            if(feld.BackColor == Color.White) 
            {
                feld.BackColor = Color.Gray;
            }
            else if(feld.BackColor == Color.Gray) 
            {
                feld.BackColor= Color.White;
            }

            if (lastClicked != null && lastClicked != feld)
            {
                lastClicked.BackColor = Color.White;
            }
            
            lastClicked = feld;
        }
    }
}
