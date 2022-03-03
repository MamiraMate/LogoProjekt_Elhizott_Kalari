using System;
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
                Előre(meret * 0.9);
                Balra(45);
                Bezier(meret/3.5, 45, -meret/3.5, -45, meret);
                Jobbra(90);
                Bezier(meret/2, 0, -meret/2, 45, meret*1.273);
                Előre(meret / 10);
                Balra(90);


            }
        }
    }
}
