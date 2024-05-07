namespace Lec03BLibN
{
	internal class FactoryL1 : IFactory
	{
		public IBonus getA(float cost1hour)
		{
			return new L1A(cost1hour);
		}

		public IBonus getB(float cost1hour, float x)
		{
			return new L1B(cost1hour, x);
		}

		public IBonus getC(float cost1hour, float x, float y)
		{
			return new L1C(cost1hour, x, y);
		}
	}

	internal class FactoryL2 : IFactory
	{
		public float a {  get; set; }

		public FactoryL2(float a)
		{
			this.a = a;
		}

		public IBonus getA(float cost1hour)
		{
			return new L2A(cost1hour, a);
		}

		public IBonus getB(float cost1hour, float x)
		{
			return new L2B(cost1hour, a, x);
		}

		public IBonus getC(float cost1hour, float x, float y)
		{
			return new L2C(cost1hour, a, x, y);
		}
	}

	internal class FactoryL3 : IFactory
	{
		public float a { get; set; }
		public float b { get; set; }

		public FactoryL3(float a, float b)
		{
			this.a = a;
			this.b = b;
		}

		public IBonus getA(float cost1hour)
		{
			return new L3A(cost1hour, a, b);
		}

		public IBonus getB(float cost1hour, float x)
		{
			return new L3B(cost1hour, a, b, x);
		}

		public IBonus getC(float cost1hour, float x, float y)
		{
			return new L3C(cost1hour, a, b, x, y);
		}
	}
}
