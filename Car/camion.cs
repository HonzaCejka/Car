using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Car
{
    internal class camion
    {
        

        public string Znacka { get; set; }
        public int Nosnost { get; set; }
        public int Naložení { get; set; }
        public int ObjemNádrže { get; set; }
        public int Palivo { get; set; }
        public int Spotreba { get; set; }
        public int Vzdalenost { get; set; }

        public camion(int nosnost, int objemnadrze, int spotreba)
        {
            Znacka = "";
            Nosnost = nosnost;
            Naložení = 0;
            ObjemNádrže = objemnadrze;
            Palivo = objemnadrze;
            Spotreba = spotreba;
            Vzdalenost = 0;
        }


        public void Jet(int vzdalenost)
        {
            if (((((vzdalenost / 100 * Spotreba)) + (25 * (Naložení / Nosnost))) < Palivo))
            {
                Palivo -= ((((vzdalenost / 100) * Spotreba)) + (25 * (Naložení / Nosnost)));
                Vzdalenost += vzdalenost;
            }
            else
            {
                throw new Exception();
            }
        }

        public void Naloz(int naložení)
        {
            Naložení += naložení;
            if (Naložení > Nosnost)
            {
                Naložení = Nosnost;
            }
            
        }
        public void Vyloz(int vylozeni)
        {
            Naložení -= vylozeni;
            if (Naložení < 0)
            {
                Naložení = 0;
            }
        }

        public void Tankovat(int palivo)
        {
            Palivo += palivo;
            if (Palivo > ObjemNádrže)
            {
                Palivo = ObjemNádrže;
            }
        }
    }
}
