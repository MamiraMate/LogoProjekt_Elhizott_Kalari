using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
        void cik_cak(double meret, Color kintszin, Color bentszin)
        {
            for (int i = 0; i < 4; i++)
            {
                Tollat(le);
                cik_cak_szelet(meret / 4, kintszin, bentszin);
                Tollat(fel);
                Jobbra(90);
                Előre(meret / 4);
                Balra(90);
            }
        }
        void cik_cak_szelet(double meret, Color kintszin, Color bentszin)
        {
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
            Balra(90);
            Tollat(fel);
            Előre(meret / 16);
            Jobbra(90);
            Előre((meret / 16) * 10);
            cik_cak(meret * 0.869, Color.Green, Color.White);
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
            using (new Frissítés(false))
                projekt(300);
            
		}
	}
}
