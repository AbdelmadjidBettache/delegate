using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDelegate
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int result = 0;
            

            Console.WriteLine("Premier nb svp:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Deuxieme nb svp:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quelle operation '+' ou '*': ");
            char choix = (char)Console.Read();
            switch (choix)
            {
                case '+':
                    { result = Calcul.Somme(n1, n2); break; }
                case '*':
                    { result = Calcul.Produit(n1, n2); break; }
            }
            Console.WriteLine("Resultat: "+result.ToString());

            new Calcul().DemoCalcul(n1, n2);


            Console.ReadKey();
        }
    }
}
