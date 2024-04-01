using System.Text;

namespace lr1_basics
{
	internal class Program
	{
		public class C1
		{
			//cons
			private const int PrivateConst1 = 0;
			private const int PrivateConst2 = 1;
			public const int PublicConst1 = 2;
			public const int PublicConst2 = 3;
			protected const int ProtectedConst1 = 4;
			protected const int ProtectedConst2 = 5;
			//fields
			private int _privateField1;
			private int _privateField2;
			public int PublicField1;
			public int PublicField2;
			protected int ProtectedField1;
			protected int ProtectedField2;
			//prop
			private int PrivateProperty { get; set; }
			public int PublicProperty { get; set; }
			protected int ProtectedProperty { get; set; }
			//builders
			public C1() { }

			public C1(C1 other)
			{
				_privateField1 = other._privateField1;
				_privateField2 = other._privateField2;
				PublicField1 = other.PublicField1;
				PublicField2 = other.PublicField2;
				ProtectedField1 = other.ProtectedField1;
				ProtectedField2 = other.ProtectedField2;
				PrivateProperty = other.PrivateProperty;
				PublicProperty = other.PublicProperty;
				ProtectedProperty = other.ProtectedProperty;
			}

			public C1(int privateField1, int privateField2, int publicField1, int publicField2, int protectedField1,
				int protectedField2, int privateProperty, int publicProperty, int protectedProperty)
			{
				_privateField1 = privateField1;
				_privateField2 = privateField2;
				PublicField1 = publicField1;
				PublicField2 = publicField2;
				ProtectedField1 = protectedField1;
				ProtectedField2 = protectedField2;
				PrivateProperty = privateProperty;
				PublicProperty = publicProperty;
				ProtectedProperty = protectedProperty;
			}
			//methods
			private void PrivateGetAllValues()
			{
				string[] tempS = ProtectedFieldsListString();
				int[] tempI = ProtectedFieldsValuesInt();
				for (short i = 0; i < tempS.Length; i++)
				{
					Console.WriteLine("{0} value by PrivateMethod: {1}", tempS[i], tempI[i]);
				}
			}
			private void PrivateMethod2() { }
			public void PublicGetAllValues()
			{
				string[] tempS = ProtectedFieldsListString();
				int[] tempI = ProtectedFieldsValuesInt();
				for (ushort i = 0; i < tempS.Length; i++)
				{
					Console.WriteLine("{0} value by PublicMethod: {1}", tempS[i], tempI[i]);
				}
			}
			public void PublicGetAllValuesFromPrivateMethod()
			{
				PrivateGetAllValues();
			}
			protected string[] ProtectedFieldsListString()
			{
				string[] fields = ["_privateField1", "_privateField2", "PublicField1", "PublicField2", "ProtectedField1", "ProtectedField2", "PrivateProperty", "PublicProperty", "ProtectedProperty"];
				return fields;
			}
			protected int[] ProtectedFieldsValuesInt()
			{
				int[] values = [_privateField1, _privateField2, PublicField1, PublicField2, ProtectedField1, ProtectedField2, PrivateProperty, PublicProperty, ProtectedProperty];
				return values;
			}
		}

		interface I1
		{
			int MyProperty { get; set; }
			void MyMethod();
			event EventHandler MyEvent;
			int this[int index] { get; set; }
		}

		public class C2 : C1, I1
		{
			public int MyProperty
			{
				get { return base.PublicProperty; }
				set { base.PublicProperty = value; }
			}

			public void MyMethod() { }
			public event EventHandler? MyEvent;
			public int this[int index]
			{
				get { return base.PublicField1; }
				set { base.PublicField1 = value; }
			}
		}

		public class C3
		{

		}

		public class C4 : C3
		{

		}

		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.UTF8;
			Console.OutputEncoding = Encoding.UTF8;

			//C1 showcase
			C1 obj1 = new();
			Console.WriteLine("_____C1 class showcase_____");
			obj1.PublicField1 = 1;
			Console.WriteLine($"PublicField1 value: {obj1.PublicField1}");
			obj1.PublicProperty = 2;
			Console.WriteLine($"PublicProperty value: {obj1.PublicProperty}");

			C1 obj2 = new(obj1);
			Console.WriteLine($"PublicField1 value right from copy builder: {obj2.PublicField1}");
			obj2.PublicField1 = 3;
			Console.WriteLine($"PublicField1 value after change: {obj2.PublicField1}");
			obj2.PublicProperty = 4;
			Console.WriteLine($"PublicProperty value after change: {obj2.PublicProperty}");

			C1 obj3 = new(9, 8, 7, 6, 5, 4, 3, 2, 1);
			Console.WriteLine();
			Console.WriteLine($"PublicField2 value: {obj3.PublicField2}");
			obj3.PublicGetAllValues();
			Console.WriteLine();
			obj3.PublicGetAllValuesFromPrivateMethod();
			Console.WriteLine();

			//C2 class showcase
			C1 obj4 = new();
			Console.WriteLine("______C2 class showcase_____");
			obj1.PublicField1 = 10;
			Console.WriteLine($"PublicField1 value: {obj4.PublicField1}");
			obj1.PublicProperty = 9;
			Console.WriteLine($"PublicProperty value: {obj4.PublicProperty}");

			C1 obj5 = new(obj4);
			Console.WriteLine($"PublicField1 value right from copy builder: {obj5.PublicField1}");
			obj2.PublicField1 = 8;
			Console.WriteLine($"PublicField1 value after change: {obj5.PublicField1}");
			obj2.PublicProperty = 7;
			Console.WriteLine($"PublicProperty value after change: {obj5.PublicProperty}");

			C1 obj6 = new(1, 2, 3, 4, 5, 6, 7, 8, 9);
			Console.WriteLine();
			Console.WriteLine($"PublicField2 value: {obj6.PublicField2}");
			obj6.PublicGetAllValues();
			Console.WriteLine();
			obj6.PublicGetAllValuesFromPrivateMethod();

			//C4 class showcase
			Console.WriteLine("______C4 class showcase_____");
		}
	}
}