using System;
using System.Diagnostics;

namespace ЛБ4_З3_2
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Debug.WriteLine($"Person: {Name}");
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
        public override void Display()
        {
            base.Display();
            Debug.WriteLine($"Employee of: {Company}");
        }
    }

    class Client : Person
    {
        public string Bank { get; set; }
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }
        public override void Display()
        {
            base.Display();
            Debug.WriteLine($"Client of: {Bank}");
        }
    }
    class Student : Person
    {
        public string University { get; set; }
        public Student(string name, string university) : base(name)
        {
            University = university;
        }
        public override void Display()
        {
            base.Display();
            Debug.WriteLine($"Student of: {University}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Tom", "Microsoft");
            Client client1 = new Client("Bob", "ContosoBank");
            Student student1 = new Student("Tim", "Boston University");

            client1.Display();
            employee1.Display();
            student1.Display();

            Console.ReadKey();
        }
    }
}
