using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
        void szele(int irany, double meret, Color pontszin, Color ivszin)
        {
            if (irany == -1)
            {
                Tollat(le);
                Tollszín(ivszin);
                Előre(meret * 0.9);
                Balra(45);
                Bezier(meret / 3.5, 45, -meret / 3.5, -45, meret);
                Jobbra(90);
                Bezier(meret / 2, 0, -meret / 2, 45, meret * 1.273);
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
        void projekt (double meret)
        {
            for (int i = 0; i < 4; i++)
            {
                Előre(meret);
                Jobbra(90);
            }
            Tollat(fel);
            Jobbra(45);
            Előre(meret / 2);
            Tölt(Color.Black);
            Hátra(meret / 2);
            Jobbra(45);
            Előre(meret / 16);
            Balra(90);
            Tollat(le);
            for (int i = 0; i < 16; i++)
            {
                szele(-1, meret / 16, Color.White, Color.Orange);
                Előre(meret / 16);
            }
            Hátra(meret / 16);
            for (int i = 0; i < 7; i++)
            {
                Jobbra(90);
                Előre(meret / 16);
                Balra(90);
                szele(-1, meret / 16, Color.White, Color.Orange);
            }
            Balra(90);
            Előre(meret / 16);
            Jobbra(90);
            for (int i = 0; i < 8; i++)
            {
                Jobbra(90);
                Előre(meret / 16);
                Balra(90);
                szele(1, meret / 16, Color.White, Color.Orange);
            }
            for (int i = 0; i < 15; i++)
            {
                Hátra(meret / 16);
                szele(1, meret / 16, Color.White, Color.Orange);
            }
            for (int i = 0; i < 7; i++)
            {
                Balra(90);
                Előre(meret / 16);
                Jobbra(90);
                szele(1, meret / 16, Color.White, Color.Orange);
            }
            Jobbra(90);
            Előre(meret / 16);
            Balra(90);
            for (int i = 0; i < 7; i++)
            {
                Balra(90);
                Előre(meret / 16);
                Jobbra(90);
                szele(-1, meret / 16, Color.White, Color.Orange);
            }
            
        }


        void FELADAT()
		{
            /* Ezt indítja a START gomb! */
            Teleport(közép.X - 200, közép.Y+150, észak);

            /// lehetséges feladatok

            /*
			 * széle: Máté kész
			 * tetején lévő madár: 
			 * várnak a torony része (amelyik kilóg a téglalapból): Gréta kész
			 * felül lévő virág a vár mellett:
			 * vár ajtaja: 
			 * középen lévő cik-cak: Máté kész
			 * középen lévő hal feje:
			 * középen lévő hal teste:
			 * alul lévő zöld-fehér kerek virág:
			 * alul lévő zöld-fehér elnyújtott virág: Máté kész
			 * alul lévő fehér magas virág:
			*/

            projekt(300);
		}
	}
}
