using System.Diagnostics;

namespace ЛБ4_З3_2
{
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
}
