using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Teheneszet_lyukasztott
{
	internal class Program
	{
		static int N;
		static int M;
		static int[] kapacitasok;
		static int[] termelesek;
		static int[,] koltseg;

		static int[] legjobbmo;
		static int legjobb_osszkoltseg;
		static int[] aktualismo;
		static int aktualis_osszkoltseg;
		static bool defined;

		static void Minimumkereses(int i = 0) 
		{
			bool level = /* ITT */;
			bool remenytelen =/* ITT */;

			if (remenytelen)
				return;

			if (level)
			{
				if (!defined || /* ITT */)
				{
					legjobbmo = (int[])aktualismo.Clone(); // itt könnyű elnézni! Azért csináljuk ezt, hogy ne referenciát másoljon, és beragadjon!
					/* ITT */
				}
				/* ITT */
				return;
			}

			for (int j = 0; j < M; j++)
			{
				aktualismo[i] = j;
				if (termelesek[i] <= kapacitasok[j])
				{
					int ezakoltseg = /* ITT */;
					aktualis_osszkoltseg += ezakoltseg;
					kapacitasok[j] /* ITT */;
					Minimumkereses(i + 1);
					kapacitasok[j] /* ITT */;
					aktualis_osszkoltseg -= ezakoltseg;
				}
			}
		}
		static void Beolvas()
		{
			string[] st = Console.ReadLine().Split(' ');
			(N, M) = /* ITT */;
			termelesek = new int[N];
			kapacitasok = new int[M];
			koltseg = new int[N, M];

			/* ITT */

		}
		static void Main(string[] args)
		{
			Beolvas();

			aktualis_osszkoltseg = /* ITT */;
			aktualismo = new int[N];
			for (int i = 0; i < N; i++)
			{
				aktualismo[i] = /* ITT */;
			}
			defined = /* ITT */;

			Minimumkereses();

			Console.WriteLine(legjobb_osszkoltseg);
			Console.WriteLine(string.Join(" ", legjobbmo.Select(x => x + 1)));
		}
	}
}
 
/*
3 2
100 100 50
200 100
10 5
10 5
15 8

 */
