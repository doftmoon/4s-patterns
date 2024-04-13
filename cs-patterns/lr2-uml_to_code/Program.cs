using System.Text;

namespace lr2_uml_to_code
{
	internal class Program
	{
		public class Organization : IStaff
		{
			protected List<JobVacancy> Vacancies = new List<JobVacancy>();
			protected List<JobTitle> Titles = new List<JobTitle>();
			protected List<Employee> Employees = new List<Employee>();

			private int? _ID;
			public int? ID
			{
				get { return _ID; }
				private set { _ID = value; }
			}
			private string _name;
			public string Name
			{
				get { return _name; }
				protected set { _name = value; }
			}
			private string _shortName;
			public string ShortName
			{
				get { return _shortName; }
				protected set
				{
					_shortName = value;
					ID = value.GetHashCode();
				}
			}
			private string _address;
			public string Address
			{
				get { return _address; }
				protected set { _address = value; }
			}
			private DateTime _timeStamp;
			public DateTime TimeStamp
			{
				get { return _timeStamp; }
				protected set { _timeStamp = value; }
			}

			public Organization()
			{
				Name = "";
				ShortName = "";
				Address = "";
				TimeStamp = DateTime.Now;
			}

			public Organization(Organization organization)
			{
				Name = organization.Name;
				ShortName = organization.ShortName;
				Address = organization.Address;
				TimeStamp = organization.TimeStamp;
			}

			public Organization(string name, string shortName, string address)
			{
				Name = name;
				ShortName = shortName;
				Address = address;
				TimeStamp = DateTime.Now;
			}

			public List<JobVacancy> GetJobVacancies() => Vacancies;
			public List<JobTitle> GetJobTitles() => Titles;
			public List<Employee> GetEmployees() => Employees;

			public void PrintJobVacancies()
			{
				foreach (var vacancy in Vacancies)
				{
					Console.WriteLine(vacancy);
				}
			}

			public int OpenJobVacancy(JobVacancy vacancy)
			{
				Vacancies.Add(vacancy);

				return Vacancies.Count;
			}

			public bool CloseJobVacancy(int index)
			{
				if (index < 0 || index > Vacancies.Count - 1)
				{
					return false;
				}

				Vacancies.RemoveAt(index);

				return true;
			}

			public int AddJobTitle(JobTitle title)
			{
				Titles.Add(title);

				return Titles.Count;
			}

			public bool DeleteJobTitle(int index)
			{
				if (index < 0 || index > Titles.Count - 1)
				{
					return false;
				}

				Titles.RemoveAt(index);

				return true;
			}

			public Employee Recruit(JobVacancy vacancy, Person person)
			{
				Employee employee = new Employee(person, vacancy);

				Employees.Add(employee);

				return employee;
			}

			public bool Dismiss(int index, string reason)
			{
				if (index < 0 || index > Employees.Count - 1)
				{
					return false;
				}

				Employees.RemoveAt(index);
				Console.WriteLine($"Employee dismissed, reason: {reason}");

				return true;
			}

			public virtual void PrintInfo()
			{
				Console.WriteLine($"Name: {Name}({ShortName}), address: {Address}, registration time: {TimeStamp}, ID: {ID}");
				Console.WriteLine($"Employees: {Employees.Count}({Titles.Count} titles), vacancies: {Vacancies.Count}");
			}

			public override int GetHashCode()
			{
				return ShortName.GetHashCode();
			}

			public override bool Equals(object? obj)
			{
				if (obj is Organization organiztion)
				{
					return organiztion.ID == ID;
				}

				return false;
			}
		}

		public class University : Organization, IStaff
		{
			protected List<Faculty> Faculties = new List<Faculty>();

			public University() : base() { }

			public University(University university) : base(university.Name, university.ShortName, university.Address)
			{
				TimeStamp = university.TimeStamp;

				Faculties = new List<Faculty>(university.Faculties);

				Vacancies = new List<JobVacancy>(university.Vacancies);
				Titles = new List<JobTitle>(university.Titles);
				Employees = new List<Employee>(university.Employees);
			}

			public University(string name, string shortName, string address) : base(name, shortName, address) { }

			public List<Faculty> GetFaculties() => Faculties;

			public int AddFaculty(Faculty faculty)
			{
				Faculties.Add(faculty);

				return Faculties.Count;
			}

			public bool DeleteFaculty(int index)
			{
				if (index < 0 || index >= Faculties.Count - 1)
				{
					return false;
				}

				Faculties.RemoveAt(index);

				return true;
			}

			public bool UpdateFaculty(Faculty faculty)
			{
				if (!Faculties.Contains(faculty))
				{
					return false;
				}

				Faculties.Remove(faculty);
				Faculties.Add(faculty);

				return true;
			}

			public bool VerifyFaculty(int index)
			{
				if (index < 0 || index >= Faculties.Count - 1)
				{
					return false;
				}

				return true;
			}

			public override void PrintInfo()
			{
				base.PrintInfo();

				Console.WriteLine($"Faculties: {Faculties.Count}");
			}
		}

		public class Faculty : Organization, IStaff
		{
			protected List<Department> Departments = new List<Department>();

			public Faculty() : base() { }

			public Faculty(Faculty faculty) : base(faculty.Name, faculty.ShortName, faculty.Address)
			{
				TimeStamp = faculty.TimeStamp;

				Departments = new List<Department>(faculty.Departments);

				Vacancies = new List<JobVacancy>(faculty.Vacancies);
				Titles = new List<JobTitle>(faculty.Titles);
				Employees = new List<Employee>(faculty.Employees);
			}

			public Faculty(string name, string shortName, string address) : base(name, shortName, address) { }

			public List<Department> GetDepartments() => Departments;

			public int DeleteDepartment(Department department)
			{
				Departments.Add(department);

				return Departments.Count;
			}

			public bool DeleteDepartment(int index)
			{
				if (index < 0 || index >= Departments.Count - 1)
				{
					return false;
				}

				Departments.RemoveAt(index);

				return true;
			}

			public bool UpdateDepartment(Department department)
			{
				if (!Departments.Contains(department))
				{
					return false;
				}

				Departments.Remove(department);
				Departments.Add(department);

				return true;
			}

			public bool VerifyDepartment(int index)
			{
				if (index < 0 || index >= Departments.Count - 1)
				{
					return false;
				}

				return true;
			}

			public override void PrintInfo()
			{
				base.PrintInfo();

				Console.WriteLine($"Departments: {Departments.Count}");
			}
		}

		public interface IStaff
		{
			List<JobVacancy> GetJobVacancies();
			List<Employee> GetEmployees();
			List<JobTitle> GetJobTitles();
			int AddJobTitle(JobTitle jobTitle);
			bool DeleteJobTitle(int index);
			void PrintJobVacancies();
			int OpenJobVacancy(JobVacancy vacancy);
			bool CloseJobVacancy(int index);
			Employee Recruit(JobVacancy vacancy, Person person);
			bool Dismiss(int index, string reason);
		}

		public class StaffObject
		{
			public string Name;

			public StaffObject(string name)
			{
				Name = name;
			}

			public override bool Equals(object? obj)
			{
				if (obj is StaffObject staffObj)
				{
					return staffObj.Name == Name;
				}

				return false;
			}

			public override string ToString()
			{
				return Name;
			}
		}

		public class JobVacancy : StaffObject
		{
			public JobVacancy(string name) : base(name) { }
		}

		public class JobTitle : StaffObject
		{
			public JobTitle(string name) : base(name) { }
		}

		public class Person : StaffObject
		{
			public Person(string name) : base(name) { }
		}

		public class Employee : StaffObject
		{
			public JobTitle Title;

			public Employee(Person person, JobVacancy vacancy) : base(person.Name)
			{
				Title = new JobTitle(vacancy.Name);
			}
		}

		public class Department : StaffObject
		{
			public Department(string name) : base(name) { }
		}

		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.UTF8;
			Console.OutputEncoding = Encoding.UTF8;

			//showcase
			Organization organization = new Organization();
			University university = new University();
			Faculty faculty = new Faculty("Prog obesp and sec of mobile systems", "POASOMS", "lr.200.3a");
			Console.WriteLine(faculty.Name);
			Console.WriteLine(faculty.ID);
			faculty.PrintInfo();
			Console.WriteLine(faculty);
			Console.WriteLine(faculty.GetHashCode());
			Console.WriteLine(faculty.Equals(faculty));
			faculty.OpenJobVacancy(new JobVacancy("C# trainee"));
			faculty.OpenJobVacancy(new JobVacancy("JavaScript senior"));
			faculty.CloseJobVacancy(0);
			faculty.PrintJobVacancies();
			faculty.AddJobTitle(new JobTitle("C# team lead"));
			Console.WriteLine(faculty.GetJobTitles()[0]);
			faculty.Recruit(faculty.GetJobVacancies()[0], new Person("Artem"));
			Console.WriteLine(faculty.GetEmployees()[0]);
			faculty.Dismiss(0, "roftprosto");
			Console.WriteLine(faculty.GetEmployees().Count);
			faculty.DeleteJobTitle(0);
			Console.WriteLine(faculty.GetJobTitles().Count);
		}
	}
}