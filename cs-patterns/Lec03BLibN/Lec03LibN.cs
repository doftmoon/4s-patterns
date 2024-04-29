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

	static public partial class Lec03BLib
	{
		static public partial IFactory getL1()
		{
			IBonus getA(float cost1hour)
			{
				return new L1A(cost1hour);
			}

			IBonus getB(float cost1hour, float x)
			{
				return new L1B(cost1hour, x);
			}

			IBonus getC(float cost1hour, float x, float y)
			{
				return new L1C(cost1hour, x, y);
			}
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