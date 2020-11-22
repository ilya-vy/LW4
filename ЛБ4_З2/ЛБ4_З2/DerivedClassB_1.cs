using System.Diagnostics;


namespace ЛБ4_З2
{
    class DerivedClassB_1 : BaseClassB
    {
        public override void ShowArgInfo()
        {
            Debug.WriteLine("Argument value: " + Arg1 + " Argument type: " + Arg1.GetType());
        }
    }
}
