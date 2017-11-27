/*
 	Один глаз на кавказ, другой на того кто смотрит этот текст!
 	Используя данную программу, Вы соглашаетесь с нижеследующим:
	* Вы незамедлительно поступаете в анальное рабство к автору данной программы!
	* Вы обязуетесь не распростраянть данную программу(отдельные компоненты программы) под своим авторским правом!
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProgramma2017byKotikWilson
{
	class Program
	{
		static string BruteForce()
		{
			Console.WriteLine("Вставьте пароль: ");
			string pass = Console.ReadLine();
			Console.WriteLine("Вставленый пароль: " + pass);
			string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ[]{};:\"\',<>./?`~!@#$%^&*()-=+_№";
			string result = "";
			Console.WriteLine("[+][+] Начало брутфорса...");
			pass.Split(new[] { ',' }).ToList<string>();
			charset.Split(new[] { ',' }).ToList<string>();
			for (int x = 0; x <= pass.Length - 1; x++)
			{
				foreach (char ch in charset)
				{
					char pch = Convert.ToChar(pass[x]);
					if (ch == pch)
					{
						Console.WriteLine("[+] Попытка... {0}", ch);
						Console.WriteLine("[+][+] Подбор ({0})", ch);
						result += ch;
						break;
					}
					else
					{
						Console.WriteLine("[+] Попытка... {0}", ch);
					}
				}
			}
			return result;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("[+][+] Всё подобрано - пароль найден: {0}", BruteForce());
		}
	}
}