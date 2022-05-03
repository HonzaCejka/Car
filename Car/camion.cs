using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Palivo = 0;
            Spotreba = spotreba;
            Vzdalenost = 0;
        }


        public void Jet(int Vzdalenost)
        {
            if (Vzdalenost )
            {

            }   
        }

        public void Naloz()
        {

        }
        public void Vyloz()
        {

        }

        public void Tankovat()
        {
            Palivo += input1.Text ;
            if (Palivo > ObjemNádrže)
            {
                Palivo = ObjemNádrže;
            }
        }
    }
}
