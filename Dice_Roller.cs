/*
 	Один глаз на кавказ, другой на того кто смотрит этот текст!
 	Используя данную программу, Вы соглашаетесь с нижеследующим:
	* Вы незамедлительно поступаете в анальное рабство к автору данной программы!
	* Вы обязуетесь не распростраянть данную программу(отдельные компоненты программы) под своим авторским правом!
 */
using System;
namespace Dice_Roller
{
	class Program
	{
		public static void Main(string[] args)
		{
			Random random = new Random();
			int selection = random.Next(1, 7);
			switch (selection)
			{
				case 1:
					Console.WriteLine("+---------+");
					Console.WriteLine("/         /");
					Console.WriteLine("/    *    /");
					Console.WriteLine("/         /");
					Console.WriteLine("+---------+");
					break;
				case 2:
					Console.WriteLine("+---------+");
					Console.WriteLine("/ *       /");
					Console.WriteLine("/         /");
					Console.WriteLine("/       * /");
					Console.WriteLine("+---------+");
					break;
				case 3:
					Console.WriteLine("+---------+");
					Console.WriteLine("/ *       /");
					Console.WriteLine("/    *    /");
					Console.WriteLine("/       * /");
					Console.WriteLine("+---------+");
					break;
				case 4:
					Console.WriteLine("+---------+");
					Console.WriteLine("/ *     * /");
					Console.WriteLine("/         /");
					Console.WriteLine("/ *     * /");
					Console.WriteLine("+---------+");
					break;
				case 5:
					Console.WriteLine("+---------+");
					Console.WriteLine("/ *     * /");
					Console.WriteLine("/    *    /");
					Console.WriteLine("/ *     * /");
					Console.WriteLine("+---------+");
					break;
				case 6:
					Console.WriteLine("+---------+");
					Console.WriteLine("/ *     * /");
					Console.WriteLine("/ *     * /");
					Console.WriteLine("/ *     * /");
					Console.WriteLine("+---------+");
					break;
			}
		}
	}
}
