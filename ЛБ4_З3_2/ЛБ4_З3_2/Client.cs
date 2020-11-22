using System.Diagnostics;

namespace ЛБ4_З3_2
{
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
}
