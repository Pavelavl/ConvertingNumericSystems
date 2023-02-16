using ConvertingNumericSystems;

namespace TestProgram
{
    class Program
    {
        /// <summary>
        /// Функция точка доступа к консольному приложению
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Введите число: ");
            string num = Console.ReadLine() ?? "";
            Console.WriteLine("Введите изначальную СС: ");
            int fromBase = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Введите СС для перевода числа: ");
            int toBase = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine($"Число {num} из СС:{fromBase} в СС:{toBase} = {Converting.ConvertBase(num, fromBase, toBase)}");
        }
    }
}