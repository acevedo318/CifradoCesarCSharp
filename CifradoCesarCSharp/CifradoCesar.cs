using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifradoCesarCSharp
{
    static class CifradoCesar
    {

        /// <summary>
        /// Metodo Para Cifrar
        /// </summary>
        /// <param name="text">El texto que se planea cifrar</param>
        /// <returns></returns>
        public static String CifrarCadena(String text)
        {
            int t, letras;
            string cadena = text,cifrado = "";
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                t = (int)cadena[i];
                ch[i] = (char)(t + 3);
                cifrado += ch[i];
            }
            return cifrado;
        }
        
        /// <summary>
        /// Metodo para descifrar
        /// </summary>
        /// <param name="textCifrado"></param>
        public static String DecifrarCadena(String textCifrado)
        {
            int t, letras;
            string cadena = textCifrado, descifrado = "";
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                t = (int)cadena[i];
                ch[i] = (char)(t - 3);
                descifrado += ch[i];
            }
            return descifrado;
        }



    }
}
