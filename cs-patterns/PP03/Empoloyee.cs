using Lec03BLibN;

namespace PP03
{
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