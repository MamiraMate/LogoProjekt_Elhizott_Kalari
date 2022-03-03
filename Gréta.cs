using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
    partial class Form1
    {
        void téglalap(double szélesség, double magasság, Color szín)
        {
            for (int i = 0; i < 2; i++)
            {
                Előre(magasság);
                Jobbra(90);
                Előre(szélesség);
                Jobbra(90);
            }
            using (new Rajzol(false))
            {
                Előre(magasság / 2);
                Jobbra(90);
                Előre(szélesség / 2);
                Tölt(szín);
                Hátra(szélesség / 2);
                Balra(90);
                Hátra(magasság / 2);
            }
        }
        void torony(double méret, Color szín, Color tollszín)
        {
            Tollszín(tollszín);
            téglalap(méret * 2 + méret / 3, méret, szín);
            Előre(méret);
            téglalap(méret / 2, méret / 2, szín);
            Jobbra(90);
            Előre(méret / 2);
            Balra(90);
            Előre(méret / 2);
            Jobbra(90);
            Ív(90, méret / 2);
            using (new Rajzol(false))
            {
                Jobbra(90);
                Előre(méret / 8);
                Jobbra(90);
                Előre(méret / 8);
                Tölt(szín);
                Hátra(méret / 8);
                Balra(90);
                Hátra(méret / 8);
                Jobbra(90);
            }
            Jobbra(90);
            Előre(méret / 3 + méret / 2);
            Balra(90);
            téglalap(méret / 2, méret / 2, szín);
            Balra(90);
            Előre(méret / 2);
            Jobbra(90);
            Ív(90, méret / 2);
            using (new Rajzol(false))
            {
                Jobbra(90);
                Előre(méret / 8);
                Jobbra(90);
                Előre(méret / 8);
                Tölt(szín);
                Hátra(méret / 8);
                Balra(90);
                Hátra(méret / 8);
                Jobbra(90);
            }


        }

        
    }
}
