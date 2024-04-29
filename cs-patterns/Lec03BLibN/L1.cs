using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
	internal class L1A : IBonus
	{
		public float cost1hour { get; set; }

		public L1A(float cost1hour)
		{
			this.cost1hour = cost1hour;
		}

		public float calc(float number_hours)
		{
			return number_hours * cost1hour;
		}
	}

	internal class L1B : IBonus
	{
		public float cost1hour { get; set; }
		private float x { get; set; }

		public L1B(float cost1hour, float x)
		{
			this.cost1hour = cost1hour;
		}

		public float calc(float number_hours)
		{
			return number_hours * cost1hour * x;
		}
	}

	internal class L1C : IBonus
	{
		public float cost1hour { get; set; }
		private float x { get; set; }
		private float y { get; set; }

		public L1C(float cost1hour, float x, float y)
		{
			this.cost1hour = cost1hour;
			this.y = y;
		}

		public float calc(float number_hours)
		{
			return number_hours * cost1hour * x + y;
		}
	}

	internal class L2A : IBonus
	{
		public float cost1hour { get; set; }
		private float a {  get; set; }

		public L2A(float cost1hour, float a)
		{
			this.cost1hour = cost1hour;
			this.a = a;
		}

		public float calc(float number_hours)
		{
			return (number_hours + a) * cost1hour;
		}
	}

	internal class L2B : IBonus
	{
		public float cost1hour { get; set; }
		private float a { get; set; }
		private float x {  get; set; }

		public L2B(float cost1hour, float a, float x)
		{
			this.cost1hour = cost1hour;
			this.a = a;
			this.x = x;
		}

		public float calc(float number_hours)
		{
			return (number_hours + a) * cost1hour * x;
		}
	}

	internal class L2C : IBonus
	{
		public float cost1hour { get; set; }
		private float a { get; set; }
		private float x { get; set; }
		private float y { get; set; }

		public L2C(float cost1hour, float a, float x, float y)
		{
			this.cost1hour = cost1hour;
			this.a = a;
			this.x = x;
			this.y = y;
		}

		public float calc(float number_hours)
		{
			return (number_hours + a) * cost1hour * x + y;
		}
	}

	internal class L3A : IBonus
	{
		public float cost1hour { get; set; }
		private float a { get; set; }
		private float b { get; set; }

		public L3A(float cost1hour, float a, float b)
		{
			this.cost1hour = cost1hour;
			this.a = a;
			this.b = b;
		}

		public float calc(float number_hours)
		{
			return (number_hours + a) * (cost1hour + b);
		}
	}

	internal class L3B : IBonus
	{
		public float cost1hour { get; set; }
		private float a { get; set; }
		private float b { get; set; }
		private float x { get; set; }

		public L3B(float cost1hour, float a, float b, float x)
		{
			this.cost1hour = cost1hour;
			this.a = a;
			this.b = b;
			this.x = x;
		}

		public float calc(float number_hours)
		{
			return (number_hours + a) * (cost1hour + b) * x;
		}
	}

	internal class L3C : IBonus
	{
		public float cost1hour { get; set; }
		private float a { get; set; }
		private float b { get; set; }
		private float x { get; set; }
		private float y { get; set; }

		public L3C(float cost1hour, float a, float b, float x, float y)
		{
			this.cost1hour = cost1hour;
			this.a = a;
			this.b = b;
			this.x = x;
			this.y = y;
		}

		public float calc(float number_hours)
		{
			return (number_hours + a) * (cost1hour + b) * x + y;
		}
	}
}