namespace Lec03LibN
{
	public interface IBonus
	{
		float cost1hour { get; set; }
		float calc(float number_hours);
	}

	public interface IFactory
	{
		IBonus getA(float cost1hour);
		IBonus getB(float cost1hour, float x);
		IBonus getC(float cost1hour, float x, float y);
	}

	public static partial class Lec03BLib
	{
		static public partial IFactory getL1()
		{

		}

		static public partial IFactory getL2(float a)
		{

		}

		static public partial IFactory getL3(float a, float b)
		{

		}
	}

	public class Empoloyee
	{
		public IBonus bonus { get; private set; }
		public Empoloyee(IBonus bonus)
		{
			this.bonus = bonus;
		}
		public float calcBonus(float number_hours)
		{
			return bonus.calc(number_hours);
		}
	}
}
