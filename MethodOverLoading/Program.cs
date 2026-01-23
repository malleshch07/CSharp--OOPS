namespace MethodOverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MethodOverlaodDemo objDemo = new MethodOverlaodDemo()
            { EmployeeId=1,EmployeeName="mallesh"};
            objDemo.OverloadMethod();
            objDemo.OverloadMethod(1);
            objDemo.OverloadMethod(new int[] { 1, 2, 2, 4, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 3 });

            SubClass pbj = new SubClass();
            objDemo.OverloadMethod(1);


        }

    }

    public class MethodOverlaodDemo
    {

        private string _EmployeeName;


        public string EmployeeName
        {
            get { return _EmployeeName; }
            set { _EmployeeName = value; }

        }

        public int EmployeeId { get; set; }

        public void OverloadMethod()
        {

            Console.WriteLine("without parameter" + EmployeeId);
        }

        public void OverloadMethod(int a)
        {
            Console.WriteLine("with parameter" + a + EmployeeName);
        }

        //return type wont work 
        //public int OverloadMethod(int a)
        //{

        //    Console.WriteLine("with parameter" + a);
        //    return 1;
        //}

        public void OverloadMethod(int[] a)
        {
            Console.WriteLine("without parameter parms" + a.Count());

        }
        //params wont work 
        //public void OverloadMethod(params int[] a)
        //{
        //    Console.WriteLine("without parameter parms" + a.Count());

        //}
    }

    public class SubClass : MethodOverlaodDemo
    {
        public void OverloadMethod(int a, string b)
        {

            Console.WriteLine("without parameter");
        }

    }


}
