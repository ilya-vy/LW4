using System;

namespace ЛБ4_З3_2
{
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
