namespace Struct_samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SampleStruct obj = new SampleStruct();
            obj.display();
            obj.a1 = 10;
            obj.b1 = 20;
            obj.c1 = "asdas".ToString();
            obj.display();
        }
    }


    public struct SampleStruct
    {

       public int a1;
        public int b1;
        public string c1;

        public SampleStruct()
        {
        
        }

        public void display()
        {
            Console.WriteLine("display in sturct" + a1 + b1+ c1);
        }
    
    }

}
