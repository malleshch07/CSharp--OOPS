namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            InheritanceParent objin = new InheritanceParent();

            Console.WriteLine("the dervied calling ");

            DerivedInheritance objDerived = new DerivedInheritance();
            Console.WriteLine("===========================================");

            objDerived.orderConfirmed();

    

        }
    }


    public class InheritanceParent
    {

        static InheritanceParent()
        {
            Console.WriteLine("the static constructor loading first in InheritanceParent");
        }

        public InheritanceParent()
        {
            Console.WriteLine("Default or without parameter constrcutor loaded");
        }

        public InheritanceParent(int a)
        {
            Console.WriteLine("parameterized Constructor loaded " + a);

        }


        public void prodcutlog()
        {
            Console.WriteLine("the logging happening");
            Console.WriteLine("=====================");
            Console.WriteLine("End of file");

        }
    }
    public class DerivedInheritance : InheritanceParent
    {

        static DerivedInheritance()
        {
            Console.WriteLine("Derived class static constructor called");
        }

        public DerivedInheritance(): base()
        {

            Console.WriteLine("derived class calling parent class method");

        }

        public void orderConfirmed()
        {

            Console.WriteLine("order confirmed and loggin below ");
            prodcutlog();
        
        }
    }

}
