using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingNumericSystems
{
    public static class Converting
    {
        public const string Alp = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        /// <summary>
        /// Перевод из системы счисления fromBase в систему счисления toBase в диапазоне от 2 до 36
        /// </summary>
        /// <param name="num">Число с типом string</param>
        /// <param name="fromBase">Изначальная СС</param>
        /// <param name="toBase">Конечная СС</param>
        /// <returns>Результат перевода числа num из системы счисления fromBase в систему счисления toBase</returns> 
        public static string ConvertBase(string num, int fromBase, int toBase)
        {
            string[] parts = Splitting(num);
            string IntPart = IntToBase(parts[0], toBase, fromBase);
            string FractPart = parts.Length > 1 ? FractToBase(parts[1], toBase, fromBase) : "";
            string result = parts.Length > 1 ? IntPart + FractPart : IntPart;

            return result;
        }
        /// <summary>
        /// Перевод целой части числа из СС fromBase в CC toBase в диапазоне от 2 до 36
        /// </summary>
        /// <param name="integer">Целая часть числа num</param>
        /// <param name="toBase">Изначальная СС</param>
        /// <param name="fromBase">Конечная СС</param>
        /// <returns>Результат перевода целой части числа из системы счисления fromBase в систему счисления toBase</returns>
        public static string IntToBase(string integer, int toBase, int fromBase)
        {
            string result = "";
            int AnyToDec = 0;
            int rank = 0;

            for (int l = integer.Length - 1; l >= 0; l--)
                AnyToDec += Alp.IndexOf(integer[rank++]) * (int)Math.Pow(fromBase, l);

            while (AnyToDec > 0)
            {
                int m = AnyToDec % toBase;
                AnyToDec /= toBase;
                result += Alp[m];
            }

            return new string(result.ToString().ToCharArray().Reverse().ToArray());
        }
        /// <summary>
        /// Перевод дробной части числа из СС fromBase в CC toBase в диапазоне от 2 до 36
        /// </summary>
        /// <param name="fract">Дробная часть числа num</param>
        /// <param name="toBase">Изначальная СС</param>
        /// <param name="fromBase">Конечная СС</param>
        /// <returns>Результат перевода дробной части числа из системы счисления fromBase в систему счисления toBase</returns>
        public static string FractToBase(string fract, int toBase, int fromBase)
        {
            int rank = 0;
            double DecToAny = 0;

            for (int l = -1; l >= -fract.Length; l--)
                DecToAny += Alp.IndexOf(fract[rank++]) * Math.Pow(fromBase, l);
                

            return toBase == 10 ? DecToAny.ToString().Substring(1) : "," + Alp[(int)(DecToAny * toBase)];
        }
        /// <summary>
        /// Разделение на целую и дробную часть и форматирование входящего числа num
        /// </summary>
        /// <param name="value">Число для разделения с типом string</param>
        /// <returns>Массив строк с двумя отформатированными элементами: целой и дробной частью числа</returns>
        public static string[] Splitting(string value)
        {
            return value.Replace('.', ',').ToUpper().Split(',');
        }
    }
}
