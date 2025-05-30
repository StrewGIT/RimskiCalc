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
        private string broj;
        private int arapski;
        public RimskiBroj(string broj) {
            this.broj = broj;
        }
        public RimskiBroj() { }
        public string Broj { get {  return broj; } }

        public void DodajCifru(char cifra) {
            if (IspravnostRimskogBroja(broj + cifra))
            {
                broj += cifra;
            }
            else { MessageBox.Show("Uneti rimski broj je neispravan"); }
        }
        private void UArapski()
        {

        }
        static bool IspravnostRimskogBroja(string roman)
        {
            // Regularni izraz za ispravne rimske brojeve do 3999
            string pattern = "^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";

            return Regex.IsMatch(roman, pattern);
        }
    }
}
