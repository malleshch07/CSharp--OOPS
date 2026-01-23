namespace MethodHidding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ChildClass obj = new ChildClass();

            obj.callMethod();
            Console.WriteLine("parent calling even it method hiding! with type casting");

            ((ParentClass)obj).callMethod();

            Console.WriteLine("parent calling even it method hiding! with base");

            ParentClass obj1 = new ChildClass();
            obj1.callMethod();
        }


    }



    public class ParentClass
    {

        public virtual void   callMethod()
        {

            Console.WriteLine("Parent method invoked");

        }

    }

    public class ChildClass:ParentClass
    {
        public  new void  callMethod()
        {
            Console.WriteLine("the child invoked because its new method hiding");
            base.callMethod();

        }
    }
}
