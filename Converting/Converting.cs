using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingNumericSystems
{

    // puk

    // asd

    // pavel - lox
    public class Converting
    {
        /// <summary>
        /// хуйхуйхуй
        /// </summary>
        public const string Alp = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        /// <summary>
        /// Перевод из любой СС в любую СС
        /// </summary>
        /// <param name="num">Число с типом string</param>
        /// <param name="fromBase">Изначальная СС</param>
        /// <param name="toBase">Конечная СС</param>
        /// <returns></returns>
        public static string ConvertBase(string num, int fromBase, int toBase)
        {
            double decNum = AnyToDec(num, fromBase);
            string numToBase = DecToAny(decNum, toBase);

            return numToBase;
        }

        /// <summary>
        /// Перевод из любой с десятичную СС
        /// </summary>
        /// <param name="value">Число с типом string</param>
        /// <param name="fromBase">Изначальная СС</param>
        /// <returns></returns>
        public static double AnyToDec(string value, int fromBase)
        {
            double result = 0;
            int rank = 0;
            value = value.Replace(".", ",");
            string[] splitted = value.Split(',');
            bool isDouble = value.Contains(',');

            for (int l = splitted[0].Length - 1; l >= 0; l--) 
                result += Alp.IndexOf(splitted[0][rank++].ToString().ToUpper()) * Math.Pow(fromBase, l);

            rank = value.IndexOf(",") + 1;

            if (isDouble) 
                for (int l = -1; l >= -splitted[1].Length; l--) 
                    result += Alp.IndexOf(value[rank++].ToString().ToUpper()) * Math.Pow(fromBase, l);
            
            return result;
        }
        /// <summary>
        /// Перевод из десятичной в любую СС
        /// </summary>
        /// <param name="value">Число с типом int</param>
        /// <param name="toBase">Конечная СС</param>
        /// <returns></returns>
        public static string DecToAny(double value, int toBase)
        {
            string result = "";
            string doublePart = "";
            bool isDouble = value.ToString().Contains(',');
            string[] splitted = value.ToString().Split(",");
            int intPart = int.Parse(splitted[0]);

            while (intPart > 0)
            {
                int m = intPart % toBase;
                intPart /= toBase;
                result += Alp[m];
            }

            if (isDouble)
                doublePart = "0" + "," + Alp[(int)(double.Parse("0" + "," + splitted[1]) * toBase)].ToString();

            result = new string(result.ToCharArray().Reverse().ToArray());

            return isDouble ? result + doublePart.Substring(1) : result;
        }
    }
}
