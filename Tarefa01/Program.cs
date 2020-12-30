using System;
using System.Collections.Generic;

namespace Tarefa01
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("---------- Codigo lista Original ----------");
			int[] array = { 7, 5, 3, 9, 6, 4, 1 };
			foreach (int i in array)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("---------- Codigo Nova lista ----------");
			int[] arraynew = { 7, 5, 3, 9, 6, 4, 1 };
			arraynew[3] = 5; //substituir o valor 9 para 5
			var listnew = new List<int>(arraynew);
			listnew.Remove(4); //remover o valor 4 da lista
			arraynew = listnew.ToArray();
			foreach (int i in arraynew)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("---------- Codigo Soma Nova lista ----------");
			int[] arraysum = { 7, 5, 3, 9, 6, 4, 1 };
			arraysum[3] = 5; //substituir o valor 9 para 5
			var listsum = new List<int>(arraysum);
			listsum.Remove(4); //remover o valor 4 da lista
			arraysum = listsum.ToArray();
			var sum = 0;
			for (var i = 0; i < arraysum.Length; i++)
			{
				sum += arraysum[i];
			}
			Console.WriteLine($"Soma: {sum}");
		}
    }
}
