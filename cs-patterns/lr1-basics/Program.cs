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

			public C1(int privateField1, int privateField2, int publicField1, int publicField2, int protectedField1, int protectedField2, int privateProperty, int publicProperty, int protectedProperty)
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
			private void PrivateMethod1() { }
			private void PrivateMethod2() { }
			public void PublicMethod1() { }
			public void PublicMethod2() { }
			protected void ProtectedMethod1() { }
			protected void ProtectedMethod2() { }
		}

		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.UTF8;
			Console.OutputEncoding = Encoding.UTF8;
		}
	}
}