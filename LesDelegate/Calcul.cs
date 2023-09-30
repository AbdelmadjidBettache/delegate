using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDelegate
{
    internal class Calcul
    {
        public delegate int DelegateCalcul(int a, int b);
        public static int Somme(int a, int b)
        {
            return a + b;
        }

        public static int Produit(int a, int b)
        {
            return a * b;
        }

        public int DemoCalcul(int a, int b)
        {
            DelegateCalcul delCal = Somme;
            return delCal(a, b);
            delCal = Produit; 
            return delCal(a, b);

        }


    }
}
