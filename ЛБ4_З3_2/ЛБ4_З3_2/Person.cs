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
}
