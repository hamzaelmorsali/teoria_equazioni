using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public static class Equazioni
    {
        public static bool IsDetermined(double a,double b)
        {
            bool risp = false;
            if (a != 0 && b!=0)
            {
                risp = true;
            }


            return risp;

        }
        public static bool IsImpossible(double b, double a)
        {
            bool risp = false;
            if (b != 0 && a == 0)
            {
                risp = true;
            }


            return risp;
        }
        public static bool IsNotDetermined(double a,double b)
        {
            bool risp = true;
            if (a == 0 && b==0)
            {
                risp = false;
            }


            return risp;

        }

        public static bool IsDegree2(double a)
            {
                bool risp = true;
                if (a==0)
                {
                    risp = false;
                }


                return risp;

            }
        public static string Delta(double a,double b,double c)
        {
            string risp = "";
            if (IsImpossible(a,b))
            {
                risp = "il delta è impossibile";
            }
            else if (IsNotDetermined(a, b))
            {
                risp = "il delta ha una di una soluzione";
            }
            else if(IsDetermined(a,b))
            {
                risp = "il delta ha piu di una soluzione";
            }
            double d = (b * b) - 4 * a * c;
            double x1 = -b + Math.Sqrt(d);
            double x2 = -b - Math.Sqrt(d);
           
            if(d== 0)
            {
                risp = "eseiste solo una soluzione";
            }
            else if(d>0)
            {
                risp = "l'equazione ha 2 soluzioni";
            }
            else
            {
                risp = "il delta è impossibile";
            }
            return risp;

        }
        public static string IsDegree1(double a,double b)
        {
          string risp = "";
            if (a == 0 && b == 0)
            {
                risp = "l'equazione è indeterminata";
            }
            else if (a == 0 && b != 0)
            {
                risp = "l'equazione è impossibile";
            }
            else
            {
                risp = "l'equazione è determinata";
            }


            return risp;

        }


    }
    }
