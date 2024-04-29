using Lec03Blib;
using PP03;
using System.Text;

namespace lr3_abstract_factory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.UTF8;
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Лабораторная работа #3");

			IFactory l1 = Lec03LibN.getL1();

			Empoloyee empoloyee1 = new(l1.getA(25));
			Console.WriteLine(string.Format("Bonus-L1-A = {0}", empoloyee1.calcBonus(4)));

			Empoloyee empoloyee2 = new(l1.getB(25, 1.1f));
			Console.WriteLine(string.Format("Bonus-L1-B = {0}", empoloyee2.calcBonus(4)));

			Empoloyee empoloyee3 = new(l1.getC(25, 1.1f, 5.0f));
			Console.WriteLine(string.Format("Bonus-L1-C = {0]", empoloyee3.calcBonus(4)));

			IFactory l2 = Lec03LibN.getL2(1);

			Empoloyee empoloyee4 = new(l2.getA(25));
			Console.WriteLine(string.Format("Bonus-L1-A = {0}", empoloyee1.calcBonus(4)));

			Empoloyee empoloyee5 = new(l2.getB(25, 1.1f));
			Console.WriteLine(string.Format("Bonus-L1-B = {0}", empoloyee2.calcBonus(4)));

			Empoloyee empoloyee6 = new(l2.getC(25, 1.1f, 5.0f));
			Console.WriteLine(string.Format("Bonus-L1-C = {0]", empoloyee3.calcBonus(4)));

			IFactory l3 = Lec03LibN.getL3(1, 0.5f);

			Empoloyee empoloyee7 = new(l3.getA(25));
			Console.WriteLine(string.Format("Bonus-L1-A = {0}", empoloyee1.calcBonus(4)));

			Empoloyee empoloyee8 = new(l3.getB(25, 1.1f));
			Console.WriteLine(string.Format("Bonus-L1-B = {0}", empoloyee2.calcBonus(4)));

			Empoloyee empoloyee9 = new(l3.getC(25, 1.1f, 5.0f));
			Console.WriteLine(string.Format("Bonus-L1-C = {0]", empoloyee3.calcBonus(4)));
		}
	}
}
