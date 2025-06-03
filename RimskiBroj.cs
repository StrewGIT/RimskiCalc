using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RimskiCalcStefanAndrejevic
{
    internal class RimskiBroj
    {
        private static char[] cifre = { 'I', 'V', 'X', 'D', 'C', 'L', 'M' };
        private static int[] vrednosti = { 1,5,10,50,100,500,1000};
        private string broj;
        private int arapski;
        public RimskiBroj(string broj) {
            this.broj = broj;
            this.UArapski();
        }
        public RimskiBroj(int broj) {
            this.arapski= broj;
            this.this.URimski();
        }
        public string Broj { get {  return broj; } }

        public void DodajCifru(char cifra) {
            if (IspravnostRimskogBroja(broj + cifra))
            {
                broj += cifra;
            }
            else { MessageBox.Show("Uneti rimski broj je neispravan"); }
        }
        public static RimskiBroj operator +(RimskiBroj A,RimskiBroj B)
        {
            return new RimskiBroj();
        }
        private void URimski()
        {
            
        }
        private void UArapski()
        {
            int z=0;
            for(int i=0;i<broj.Length;i++)
            {
                int vrednost = vrednosti[Array.IndexOf(cifre, broj[i])];
                if (i < broj.Length - 1)
                {
                    if (vrednost < vrednosti[Array.IndexOf(cifre, broj[i + 1])])
                    {
                        z -= vrednost;
                    }
                    else 
                    { 
                        z += vrednost;  
                    }
                }
                else
                {
                    z += vrednost;
                }
            }
            arapski = z;
        }
        static bool IspravnostRimskogBroja(string roman)
        {
            // Regularni izraz za ispravne rimske brojeve do 3999
            string pattern = "^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";

            return Regex.IsMatch(roman, pattern);
        }
    }
}
