﻿using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */


		/* Függvények vége */
		void FELADAT()
		{
			/* Ezt indítja a START gomb! */
			Teleport(közép.X, közép.Y+50, észak);

			elnyujtott_virag(50, Color.Yellow, Color.DarkGreen);
			// szele(1, 100, Color.White, Color.DarkOrange); // 1 jobbra, -1 balra



			/// lehetséges feladatok

			/*
			 * széle: Máté
			 * tetején lévő madár: 
			 * várnak a torony része (amelyik kilóg a téglalapból): Gréta kész
			 * felül lévő virág a vár mellett:
			 * vár ajtaja: 
			 * középen lévő cik-cak:
			 * középen lévő hal feje:
			 * középen lévő hal teste:
			 * alul lévő zöld-fehér kerek virág:
			 * alul lévő zöld-fehér elnyújtott virág: Máté kész
			 * alul lévő fehér magas virág:
			*/


		}
	}
}
