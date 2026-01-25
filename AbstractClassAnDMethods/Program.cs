namespace AbstractClassAnDMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            AbstractParent objparent = new DerivedAbstractParent();
            objparent.a = 100;
            objparent.NonAbstractMethod();

            objparent.VirtualMethodwith();
            objparent.AbstractMethod1();
            objparent.AbstractMethod2();
        }
    }


    abstract class AbstractParent
    {
        public int a;
        public AbstractParent()
        {
            a = 10;
        }

        public void NonAbstractMethod()
        {
            Console.WriteLine("non abstract method can run without creating override in child class" + a);
        }

        public abstract void AbstractMethod1();
        public abstract void AbstractMethod2();
        public virtual void VirtualMethodwith()
        {
            throw new NotFiniteNumberException();
        }
    }

     abstract class sam : AbstractParent
    {

    }
    abstract class AbstractParent2: AbstractParent, iabc, iabca
    {
        int a;
        public void NonAbstractMethod()
        {
            Console.WriteLine("non abstract method can run without creating override in child class");
        }

        public virtual void VirtualMethodwith()
        {
            throw new NotFiniteNumberException();
        }
    }
    class MyClass1
    {

    }
    class MyClass
    {

    }
    interface iabc
    { }

    interface iabca
    { }
    class DerivedAbstractParent:AbstractParent,iabc,iabca
    {

        public override void AbstractMethod1()
        {
            Console.WriteLine("override happened in derivced class for absttract method 1 ");
        }
        public override void AbstractMethod2()
        {
            Console.WriteLine("override happened in derivced class for absttract method 2");
        }

        public override void VirtualMethodwith()
        {
            Console.WriteLine("override happened in derivced class for virtual method");
        }

        //public override void NonAbstractMethod()
        //{


        //}



    }
}
