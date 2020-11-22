using System.Diagnostics;

namespace ЛБ4_З3_2
{
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
}
