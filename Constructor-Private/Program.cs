namespace Constructor_Private
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Console.WriteLine("we can call without reference varaiable");

            //PrivateConstructorDemo.getInstance().display();
            Console.WriteLine("we can call with reference varaiable");

            //var obj= PrivateConstructorDemo.getInstance();
            //  obj.display();


            Parallel.For(1, 20, i => { PrivateConstructorDemo_withoutLock.getInstance(); });



            Console.WriteLine("with lock example");

            Parallel.For(0, 20, i => { PrivateConstructorDemo_WithLock.getInstance(); });

            Console.WriteLine("with lazy example");

            Parallel.For(0, 10, i => { PrivateConstructorDemo_Lazy.Instance(); });

        }
    }
    public class PrivateConstructorDemo_withoutLock
    {
        public static int counter;


        private static PrivateConstructorDemo_withoutLock _instance;

        private PrivateConstructorDemo_withoutLock()
        {
            counter = counter + 1;
            Console.WriteLine("inside private constructor" + counter);
        }

        public static PrivateConstructorDemo_withoutLock getInstance()
        {

            return _instance ??= new PrivateConstructorDemo_withoutLock();
        }
        public void display()
        {

            Console.WriteLine("hi im called with signleton");
        }

    }


    public class PrivateConstructorDemo_WithLock
    {


        public static PrivateConstructorDemo_WithLock _instance;

        public readonly static object _lock = new object();

        public static int counter;
        private PrivateConstructorDemo_WithLock()
        {
            counter++;
            Console.WriteLine($"private constructor called {counter} time");
        }

        public static PrivateConstructorDemo_WithLock getInstance()
        {

            if (_instance == null)
            {
                lock (_lock)
                {

                    if (_instance == null)
                    {
                        _instance = new PrivateConstructorDemo_WithLock();
                    }
                }

            }
            return _instance;
        }
        public void Display()
        {


            Console.WriteLine("im display method for private constructor where lock implemented");

        }
    }


    public class PrivateConstructorDemo_Lazy
    {

        public static readonly Lazy<PrivateConstructorDemo_Lazy> _instance = new Lazy<PrivateConstructorDemo_Lazy>(()=>new PrivateConstructorDemo_Lazy());
        private PrivateConstructorDemo_Lazy()
        {
            Console.WriteLine("im private constructor");
        }

        //public static PrivateConstructorDemo_Lazy Instance
        //{
        //    get
        //    {
        //     return   _instance.Value;

        //    }
        //}
        //or

        public static PrivateConstructorDemo_Lazy Instance() => _instance.Value;
    }
}
