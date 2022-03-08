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
        void cik_cak_szelet (double meret, Color kintszin, Color bentszin)
        {
            /*
            for (int i = 0; i < 2; i++)
            {
                //  segédvonal
                Jobbra(180);
                Tollat(le);
                //Előre(meret * 0.14333);
                //Hátra(meret * 0.14333);
                Előre(meret);
                Hátra(meret);
                Balra(180);
                //  segédvonal vége
                Tollat(le);
                Tollszín(bentszin);
                Jobbra(90);
                Előre(meret * 0.15);
                Tollszín(kintszin);
                Előre(meret * 0.35);
                //  segédvonal
                Jobbra(90);
                //Előre(meret * 0.14333);
                //Hátra(meret * 0.14333);
                Előre(meret / 2);
                Hátra(meret / 2);
                Balra(90);
                //  segédvonal vége
                Előre(meret * 0.35);
                Tollszín(bentszin);
                Előre(meret * 0.15);

                Jobbra(90);
                Előre((meret * 0.15) / 2);
                Tollat(fel);
                Előre(meret * 0.7);
                Előre(meret * 0.15);
                Tollat(le);
                Előre((meret * 0.15) / 2);
            }
            */
            Tollszín(bentszin);
            Jobbra(90);
            Előre(meret * 0.15);
            Jobbra(22.5);
            Előre(meret / 2.65);
            Balra(45);
            Előre(meret / 2.65);
            Jobbra(22.5);
            Előre(meret * 0.15);
            Jobbra(90);
            Előre((meret * 0.15) / 2);
            Jobbra(90 - 22.5);
            Előre(meret / 1.853);
            Jobbra(45);
            Előre(meret / 1.853);


            Balra(112.5);
            Hátra((meret * 0.15) / 2);
            Előre((meret * 0.15) / 2);
            Tollat(fel);
            Balra(90);
            Előre(meret / 10);
            Tölt(bentszin);
            Hátra(meret / 10);
            Jobbra(90);
            Előre(meret * 0.7);
            Előre(meret * 0.15);
            Balra(90);
            Előre(meret / 2);
            Balra(90);
            Balra(90 - 22.5);
            Tollat(le);

            Előre(meret / 1.853);
            Balra(112.5);
            Előre(meret * 0.133333);
            Balra(90 - 22.5);
            Előre(meret / 2.65);
            Balra(22.5);
            Előre(meret * 0.3);
            Balra(22.5);
            Előre(meret / 2.65);
            Balra(90 - 22.5);
            Előre(meret * 0.133333);
            Balra(112.5);
            Előre(meret / 1.853);
            Tollat(fel);
            Előre(meret / 10);
            Tölt(bentszin);
            Hátra(meret / 10);


            Tollszín(kintszin);
            Jobbra(45);
            Előre(meret / 1.853);
            Balra(112.5);
            Előre(meret * 0.133333);
            Tollat(le);
            Előre(meret * 0.148);
            Balra(90);
            Előre((meret / 2) - (meret * 0.15));
            Tollat(fel);
            Hátra(meret * 0.2);
            Balra(90);
            Előre(meret / 15);
            Tölt(kintszin);
            Hátra(meret / 15);
            Jobbra(90);
            Előre(meret * 0.2);
            Előre(meret * 0.3);
            Tollat(le);
            Előre((meret / 2) - (meret * 0.15));
            Balra(90);
            Előre(meret * 0.148);
            Tollat(fel);
            Hátra(meret * 0.07);
            Balra(90);
            Előre(meret / 15);
            Tölt(kintszin);
            Hátra(meret / 15);
            Jobbra(90);
            Előre(meret * 0.07);
            Tollat(fel);
            Előre(meret * 0.133333);
            Előre(meret * 0.72);
            Balra(90);


            Előre(meret);
            Jobbra(180);
            Előre(meret * 0.15);
            Tollat(le);
            Előre(meret * 0.7);
            Tollat(fel);
            Hátra(meret * 0.35);
            Jobbra(90);
            Előre(meret / 15);
            Tölt(kintszin);
            Hátra(meret / 15);
            Balra(90);
            Hátra(meret * 0.5);

            Balra(90);

        }

        void elnyujtott_virag (double meret, Color belsoszin, Color kulsoszin)
        {
            Jobbra(90);
            Tollat(fel);
            Tollszín(kulsoszin);
            Előre(meret / 6);
            Balra(90);
            Tollat(le);
            Bezier(meret / 4, 0, -meret / 4, 90, (meret / 6) * 4);
            Jobbra(180);
            Bezier(meret / 4, 0, meret / 4, 90, (meret / 6) * 4);
            Balra(90);
            Tollat(fel);
            Előre(meret / 6);
            Balra(90);
            Tollat(le);
            Tollszín(belsoszin);
            Bezier(meret / 8, 0, -meret / 8, 90, (meret / 6) * 2);
            Jobbra(180);
            Bezier(meret / 8, 0, meret / 8, 90, (meret / 6) * 2);
            Tollat(fel);
            Tollszín(kulsoszin);
            Jobbra(90);
            Előre((meret / 6) * 2);
            
            Balra(107);
            Előre(meret / 5);
            Jobbra(107);
            Tollat(le);
            Bezier(meret / 3, 270, -meret / 3, 90, (meret / 6) * 2.3);
            Jobbra(153);
            Bezier(meret / 3, 333, -meret / 3, 85, (meret / 6) * 1.8);
            Jobbra(54);
            Bezier(meret / 3, 0, -meret / 3, 90, (meret / 6) * 2.2);
            Jobbra(26);
            Bezier(meret / 3, 28, -meret / 3, 95, (meret / 6) * 1.8);
            Jobbra(36);
            Bezier(meret / 3, 270, meret / 3, 90, (meret / 6) * 2.3);

            Jobbra(153);
            Bezier(meret / 3, 333, meret / 3, 85, (meret / 6) * 1.8);
            Jobbra(54);
            Bezier(meret / 3, 0, meret / 3, 90, (meret / 6) * 2.2);
            Jobbra(26);
            Bezier(meret / 3, 28, meret / 3, 95, (meret / 6) * 1.8);
            Jobbra(36);
            Tollat(fel);
            Jobbra(90);
            Előre(meret / 5.235);
            Balra(90);
            Előre(meret / 17.05);
            Jobbra(180);
            Tölt(kulsoszin);
            Előre(meret / 2);
            Tölt(belsoszin);
            Hátra(meret / 2);
            Balra(90);
            Tollat(le);

        }
        void szele (int irany, double meret, Color pontszin, Color ivszin)
        {
            if (irany == -1)
            {
                Tollat(le);
                Tollszín(ivszin);
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

                Tollszín(pontszin);
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
                Tollszín(Color.Black);
            }
            if (irany == 1)
            {
                Tollat(le);
                Tollszín(ivszin);
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
                
                Tollszín(pontszin);
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
                Tollszín(Color.Black);
            }
        }
    }
}
