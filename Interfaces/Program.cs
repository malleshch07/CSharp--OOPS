namespace Interfaces
{


    interface IInterface1
    {
        void Defaultprint()
        {
            Console.WriteLine("Im print from Default Interface ");

        }

        void FirstInterfacePrint1();
        void FirstInterfacePrint2();

        void CommonMethod();

    }



    interface IInterface2 : IInterface1,iaaa
    {
        void Defaultprint()
        {
            Console.WriteLine("Im print from Default Interface 2");

        }

        void SecondInterfacePrint1();
        void SecondInterfacePrint2();
        void CommonMethod();
    }

    public class abc
    { }

    public class bcd
    { }


    interface iaaa
    { }


    public class ImplementClass : abc, IInterface1, IInterface2
    {

        public void FirstInterfacePrint1()
        {
            Console.WriteLine("im from implmentcalss for FirstI interface print 1 method");

        }

        public void FirstInterfacePrint2()
        {

            Console.WriteLine("im from implmentclass fro  FirstI interface print 2 method");

        }
        public void SecondInterfacePrint1()
        {
            Console.WriteLine("im from implmentcalss for Second interface print 1 method");

        }

        public void SecondInterfacePrint2()
        {

            Console.WriteLine("im from implmentclass fro Second  interface print 2 method");

        }

        void IInterface1.CommonMethod()
        {
            Console.WriteLine("common method to chcek explicit interface   IInterface1");

        }

        void IInterface2.CommonMethod()
        {
            Console.WriteLine("common method to chcek explicit interface   IInterface2");

        }

        public void CommonMethod()
        {
            Console.WriteLine("common method to chcek class from default");

        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            Console.WriteLine("calling from interface reference to derived class object");

            IInterface1 objinter = new ImplementClass();

            objinter.FirstInterfacePrint1();
            objinter.FirstInterfacePrint2();

            objinter.CommonMethod();
            objinter.Defaultprint();

            ImplementClass objimple = new ImplementClass();
            objimple.CommonMethod();
            objimple.FirstInterfacePrint1();
            objimple.SecondInterfacePrint2();
            ((IInterface1)objimple).CommonMethod();
            ((IInterface2)objimple).CommonMethod();
            ((IInterface2)objimple).Defaultprint();





        }
    }





}
