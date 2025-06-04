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
        private static char[] cifre = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        private static int[] vrednosti = { 1,5,10,50,100,500,1000};
        private string broj;
        private int arapski;
        public RimskiBroj(string broj) {
            if (IspravnostRimskogBroja(broj))
            {
                this.broj = broj;
                this.UArapski();
            }
            else { throw new Exception("Uneti rimski broj nije validan"); }
        }
        public RimskiBroj(int broj) {
            this.arapski= broj;
            this.rekurzija(arapski);
        }
        public string Broj { get {  return broj; } }
        public int Arapski { get { return arapski; } }

        public void DodajCifru(char cifra) {
            if (IspravnostRimskogBroja(broj + cifra))
            {
                broj += cifra;
            }
            else { MessageBox.Show("Uneti rimski broj je neispravan"); }
        }
        public static RimskiBroj operator +(RimskiBroj A,RimskiBroj B)
        {
            RimskiBroj C = new RimskiBroj(A.arapski + B.arapski);
            if (C.arapski > 3999) throw new Exception("Dobijeni broj je veci od 3999");
            return C;
        }
        public static RimskiBroj operator -(RimskiBroj A, RimskiBroj B)
        {
            RimskiBroj C = new RimskiBroj(A.arapski - B.arapski);
            if (C.arapski > 3999) throw new Exception("Dobijeni broj je veci od 3999");
            if (C.arapski < 0) throw new Exception("Negativni brojevi nisu definisani rimskim brojevima");
            return C;
        }
        public static RimskiBroj operator *(RimskiBroj A, RimskiBroj B)
        {
            RimskiBroj C = new RimskiBroj(A.arapski * B.arapski);
            if (C.arapski > 3999) throw new Exception("Dobijeni broj je veci od 3999");
            return C;
        }
        public static RimskiBroj operator /(RimskiBroj A, RimskiBroj B)
        {
            try
            {
                RimskiBroj C = new RimskiBroj(A.arapski / B.arapski);
                //MessageBox.Show("Velicina C"+C.arapski.ToString());
                if (C.arapski > 3999) throw new Exception("Dobijeni broj je veci od 3999");
                return C;
            }
            catch (DivideByZeroException ex) { throw new DivideByZeroException("Deljenje nulom je nedefinisano"); }
        }
        //private void URimski()
        //{
        //    rekurzija(arapski);
        void rekurzija(int num)
            {
                if (num >= 1000) { broj = broj + 'M' ;  rekurzija(num - 1000); }
                else if (num >= 900) { broj = broj + 'C'+ 'M'; rekurzija(num - 900); }
                else if (num >= 500) { broj = broj + 'D'; rekurzija(num - 500); }
                else if (num >= 400) { broj = broj + 'C'+'D'; rekurzija(num - 400); }
                else if (num >= 100) { broj = broj + 'C'; rekurzija(num - 100); }
                else if (num >= 90) { broj = broj + 'X'+'C'; rekurzija(num - 90); }
                else if (num >= 50) { broj = broj + 'L'; rekurzija(num - 50); }
                else if (num >= 40) { broj = broj + 'X'+'L'; rekurzija(num - 40); }
                else if (num >= 10) { broj = broj + 'X'; rekurzija(num - 10); }
                else if (num >= 9) { broj = broj + 'I'+'X'; rekurzija(num - 9); }
                else if (num >= 5) { broj = broj + 'V'; rekurzija(num - 5); }
                else if (num >= 4) { broj = broj + 'I'+'V'; rekurzija(num - 4); }
                else if (num >= 1) { broj = broj + 'I'; rekurzija(num - 1); }
            }
      //  }
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
