namespace Lec03BLibN
{
	public interface IBonus
	{
		float cost1hour { get; set; }
		float calc(float number_hours);
	}
}