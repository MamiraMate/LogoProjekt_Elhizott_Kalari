﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoKaresz
{
    public partial class Form1
    {
        void szele (int irany, double meret, Color pontszin, Color ivszin)
        {
            if (irany == -1)
            {
                Tollat(le);
                Előre(meret * 0.9);
                Balra(45);
                Bezier(meret/ 3.5, 45, -meret/ 3.5, -45, meret);
                Jobbra(90);
                Bezier(meret/ 2, 0, -meret/ 2, 45, meret* 1.273);
                Előre(meret / 10);
                Balra(90);

                Tollat(fel);
                Előre(meret * 0.9);
                Balra(120);
                Előre(meret / 10);
                Tölt(ivszin);
                Hátra(meret / 10);
                Jobbra(120);
                Hátra(meret * .9);

                Balra(90);
                Előre(meret * 0.85);
                Jobbra(90);
                Előre(meret / 2.5);
                Tollat(le);
                Ív(360, meret / 5);

                Jobbra(90);
                Tollat(fel);
                Előre(meret / 5);
                Tölt(pontszin);
                Hátra(meret / 5);
                Balra(90);
                Hátra(meret / 2.5);
                Jobbra(90);
                Előre(meret * 0.85);
                Balra(90);
            }
            if (irany == 1)
            {
                Tollat(le);
                Előre(meret * 0.9);
                Jobbra(45);
                Bezier(meret / 3.5, -45, -meret / 3.5, 45, meret);
                Balra(90);
                Bezier(meret / 2, 0, -meret / 2, -45, meret * 1.273);
                Előre(meret / 10);
                Jobbra(90);
                
                Tollat(fel);
                Előre(meret * 0.9);
                Jobbra(120);
                Előre(meret / 10);
                Tölt(ivszin);
                Hátra(meret / 10);
                Balra(120);
                Hátra(meret * .9);
                
                Jobbra(90);
                Előre((meret * 0.85) - (meret / 5 * 2));
                Balra(90);
                Előre(meret / 2.5);
                Tollat(le);
                Ív(360, meret / 5);
                
                Jobbra(90);
                Tollat(fel);
                Előre(meret / 5);
                Tölt(pontszin);
                Hátra(meret / 5);
                Balra(90);
                Hátra(meret / 2.5);
                Balra(90);
                Előre((meret * 0.85) - (meret / 5 * 2));
                Jobbra(90);
            }
        }
    }
}
