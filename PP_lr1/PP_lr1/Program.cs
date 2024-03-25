using System.Text;

namespace PP_lr1
{
	internal class Program
	{
		public class C1
		{
			private const int _PRIVATECONSTANT1 = 1;
			private const string _PRIVATECONSTANT2 = "Constant";

			public const int _PUBLICCONSTANT1 = 2;
			public const string _PUBLICCONSTANT2 = "PublicConstant";

			protected const int _PROTECTEDCONSTANT1 = 3;
			protected const string _PROTECTEDCONSTANT2 = "ProtectedConstant";

			private int? _privateField;
			private string? _privateField2;

			public int? _publicField;
			public string? _publicField2;

			protected int? _protectedField;
			protected string? _protectedField2;

			private int PrivateProperty { get; set; }
			public string? PublicProperty { get; set; }
			protected bool ProtectedProperty { get; set; }

			// Builders
			public C1()
			{
			}

			public C1(C1 other)
			{
				this._privateField = other._privateField;
				this._privateField2 = other._privateField2;
				this._publicField = other._publicField;
				this._publicField2 = other._publicField2;
				this._protectedField = other._protectedField;
				this._protectedField2 = other._protectedField2;
				this.PrivateProperty = other.PrivateProperty;
				this.PublicProperty = other.PublicProperty;
				this.ProtectedProperty = other.ProtectedProperty;
			}

			public C1(int privateField, string privateField2, int publicField, string publicField2, int protectedField,
				string protectedField2, int privateProperty, string publicProperty, bool protectedProperty)
			{
				this._privateField = privateField;
				this._privateField2 = privateField2;
				this._publicField = publicField;
				this._publicField2 = publicField2;
				this._protectedField = protectedField;
				this._protectedField2 = protectedField2;
				this.PrivateProperty = privateProperty;
				this.PublicProperty = publicProperty;
				this.ProtectedProperty = protectedProperty;
			}

			private void PrivateMethod()
			{
			}

			public void PublicMethod()
			{
			}

			protected void ProtectedMethod()
			{
			}

			public event EventHandler? MyEvent;
		}

		public interface I1
		{
			string? MyProperty { get; set; }

			void MyMethod();

			event EventHandler MyEvent;

			// Индексатор
			int? this[int index] { get; set; }
		}

		public class C2 : C1, I1
		{
			public string? MyProperty
			{
				get { return base.PublicProperty; }
				set { base.PublicProperty = value; }
			}

			public void MyMethod()
			{
				base.PublicMethod();
			}

			public new event EventHandler? MyEvent
			{
				add { base.MyEvent += value; }
				remove { base.MyEvent -= value; }
			}

			public int? this[int index]
			{
				get { return base._publicField; }
				set { base._publicField = value; }
			}
		}


		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.UTF8;
			Console.OutputEncoding = Encoding.UTF8;

			C1 obj1 = new C1();

			obj1._publicField = 10;
			Console.WriteLine("PublicField: " + obj1._publicField);

			obj1.PublicProperty = "Hello";
			Console.WriteLine("PublicProperty: " + obj1.PublicProperty);

			obj1.PublicMethod();


			C1 obj2 = new C1(obj1);

			obj2._publicField = 20;
			Console.WriteLine("PublicField in obj2: " + obj2._publicField);

			C1 obj3 = new C1(5, "PrivateFieldValue", 30, "PublicFieldValue", 40, "ProtectedFieldValue",
				50, "PropertyValue", true);

			/*
			obj3.PrivateMethod();

			obj3.ProtectedProperty = false;

			obj3.ProtectedMethod();
			*/


			//C2
			C2 obj4 = new C2();

			obj1._publicField = 10;
			Console.WriteLine("PublicField: " + obj1._publicField);

			obj4.MyProperty = "Hello";
			Console.WriteLine("MyProperty: " + obj4.MyProperty);

			obj4.MyMethod();
		}
	}
}