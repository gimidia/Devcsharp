using System;

namespace Tarefa03
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] array = { 2, 7, 11, 15 };
			var sumResult01 = 0;
			var sumResult02 = 0;

			sumResult01 = array[0] + array[1];
			sumResult02 = array[1] + array[3];
			Console.WriteLine($"Soma Resultado 01: {sumResult01}");
			Console.WriteLine($"Soma Resultado 02: {sumResult02}");
		}
    }
}
