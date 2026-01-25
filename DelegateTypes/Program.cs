namespace DelegateTypes
{
    internal class Program
    {
        public delegate void anonymousdelegate();


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

           
            // individual invoke
            anonymousdelegate objanonDel = delegate () { Console.WriteLine("Hi im anonymousdelegate"); } ;
            objanonDel.Invoke();

            anonymousdelegate objanonDellamda = delegate () { Console.WriteLine("Hi im lamda"); };
            objanonDellamda.Invoke();



            //combines invoke just adding to the anonymous += same delegate
            anonymousdelegate objanonDelcombinacall = delegate () { Console.WriteLine("Hi im combin anonymousdelegate"); };

            objanonDelcombinacall += () => { Console.WriteLine("im combin lamda "); };
            objanonDelcombinacall.Invoke();




            //without lambda normal declare delagae and method then call
            Action<string> actiondel =actiondelgate;

            void actiondelgate(string str)
            {
                Console.WriteLine($"im action without lambda{str}");
            }
            actiondel("JHIIII");


            Console.WriteLine("action delegate with lamda");
            Action<string> actiondellamda = logging  => { Console.WriteLine("Hi world im action delgate"); };

            actiondellamda("hi");




            Console.WriteLine("action delegate with lamda with 0 params");
            Action noparam = () => { Console.WriteLine("no param action method"); };
            noparam();
            Console.WriteLine("action delegate with lamda with 1 params");

            Action<string> oneparadel = (msg) => { Console.WriteLine("one param action delegate" + msg); };
            oneparadel("Hi delgata");


            Console.WriteLine("action delegate with lamda with 3 params");

            Action<int, int, string> threeparamdelgaction = (a, b, c) => { Console.WriteLine($"three param{a} ,{b}, {c} = {a+b}"); };

            threeparamdelgaction(10, 20, "sum");


            Console.WriteLine("func delegate with no para but one return");

            Func<string> noparafun = () => { Console.WriteLine("func with one return mandatory"); return "Hi"; };

            noparafun();
            Console.WriteLine("func delegate with no para but one return");

            Func<int, int, string> twoparafanc = (a, b) => { Console.WriteLine($"three param{a} ,{b}, = {a + b}"); return (a+b).ToString(); };
            twoparafanc(10, 20);

            Console.WriteLine("predicate delegate with lamda with 1 params");

            Predicate<int> noparapredicate = (a) => { Console.WriteLine("one param Predicate delegate"); return (a > 20); };

            noparapredicate(10);

        }



    }
}
