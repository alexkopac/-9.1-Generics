using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{//1
    /*public abstract class SeaCreature
    {
        public string Num { get; }
        public string Species { get; }
        protected SeaCreature(string name, string species)
                                { Num = name; Species = species; }
        public abstract void DisplayInfo();
        public override string ToString() => $"{Num} ({Species})";
    }

    public class Fish : SeaCreature
    {
        public string FinType { get; }
        public Fish(string name, string species, string finType)
            : base(name, species) { FinType = finType; }
        public override void DisplayInfo() => Console.WriteLine($"Риба: {Num}, Вид: {Species}");
    }

    public class Oceanarium : IEnumerable<SeaCreature>
    {
        private List<SeaCreature> inhabitants = new List<SeaCreature>();
        public string Num { get; }
        public Oceanarium(string name) { Num = name; }
        public void AddInhabitant(SeaCreature creature) => inhabitants.Add(creature);
        public int InhabitantCount => inhabitants.Count;

        public IEnumerator<SeaCreature> GetEnumerator()
        {
            foreach (SeaCreature creature in inhabitants)
            {
                yield return creature;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Oceanarium ocean = new Oceanarium("Мій Океан");
            ocean.AddInhabitant(new Fish("Немо", "хз кто", "Грудні"));
            ocean.AddInhabitant(new Fish("Дорі", "хз кто", "Хвостовий"));

            Console.WriteLine($"В океанаріумі \"{ocean.Num}\" є:");
            foreach (SeaCreature creature in ocean)
            {
                creature.DisplayInfo();
            }
        }
    }*/
//3
    public class Employee
    {
        public string Name { get; }
        public string Position { get; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Position: {Position}");
        }

        public override string ToString() => $"{Name} ({Position})";
    }

    public class Cafe : IEnumerable<Employee>
    {
        private List<Employee> employees = new List<Employee>();
        public string Name { get; }

        public Cafe(string name)
        {
            Name = name;
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public int EmployeeCount => employees.Count;

        public IEnumerator<Employee> GetEnumerator()
        {
            foreach (Employee employee in employees)
            {
                yield return employee;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Cafe myCafe = new Cafe("Cozy Coffee");
            myCafe.AddEmployee(new Employee("Anna", "Barista"));
            myCafe.AddEmployee(new Employee("Ivan", "Waiter"));
            myCafe.AddEmployee(new Employee("Olga", "Chef"));

            Console.WriteLine($"У кафе \"{myCafe.Name}\" працюють:");
            foreach (Employee employee in myCafe)
            {
                employee.DisplayInfo();
            }

            Console.WriteLine($"Загальна кількість працівників: {myCafe.EmployeeCount}");
        }
    }
}
