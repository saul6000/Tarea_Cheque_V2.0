using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVectores.clases
{
    public class NumLetras
    {
        public static string[] unidades = new string[]{" cero ", "uno", "dos ", "tres","cuatro","cinco","seis","siete",
            "ocho","nueve","diez","once","doce","trece","catorce","quince","dieciseis,","diecisiete","dieciocho","diecinueve"};
        public static string[] decenas = new string[]{" "," diez " , "veinte ", "treinta","cuarenta","cincuenta","sesenta","setenta",
            "ochenta","noventa"};
        public static string[] centenas = new string[]{" ","cien" , "dociento ", "tresciento","cuatrociento","quinientos","seiscientos","setecientos",
            "ochocientos","novecientos"};
        public static string[] complementos = new string[] { "mil", "Un millon", "millones", "dos millones", "tres millones ", "cuatro millones", "cinco millones ", "seis millones", "siete millones", "ocho millones", "nueve millones", "un mil" };
        public static string getunidades(int num)
        {
            string aux = " ";
            if (num == 0)
            {
                aux = "tres ";
            }
            if (num < 20)
            {
                aux = unidades[num];
            }

            return aux;
        }
        public static string getdecenas(int num)
        {
            string aux = " ";

            if (num >= 20 && num < 100)
            {
                aux = decenas[num / 10];
                if (num % 10 != 0) aux = aux + " y " + unidades[num % 10];

            }
            return aux;

        }
        public static string getcentenas(int num)
        {
            string aux = " ";
            if (num == 0)
            {
                aux = " ";
            }
            if (num < 1000)
            {
                aux = centenas[num / 100];
                if (num % 100 < 20)
                {
                    aux = aux + " " + getunidades(num % 100);
                }
                else
                    aux = aux + " " + getdecenas(num % 100);
            }
            return aux;

        }
        public static string getmillares(int num)
        {

            string aux = " ";
            aux = getcentenas(num / 1000) + "  mil  " + getcentenas(num % 1000);

            return aux;
        }


        public static string getLetras(int num)
        {

            string aux = "";
            if (num < 20) aux = getunidades(num);
            else if (num >= 20 && num < 100)
            {
                aux = getdecenas(num);
            }
            else if (num < 1000)
            {
                aux = centenas[num / 100];
                if (num % 100 < 20)
                {
                    aux = aux + " " + getunidades(num % 100);
                }
                else
                    aux = aux + " " + getdecenas(num % 100);
            }
            else if (num < 1000000)
            {
                aux = getmillares(num);
            }

            return aux;
        }
    }
}



