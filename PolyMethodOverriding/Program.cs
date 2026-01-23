namespace PolyMethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            polyyOVR obj = new PolyOVRChild();

            obj.GetDetailsfromDB();


            //PolyOVRChild objc = new PolyOVRChild();

            //objc.GetDetailsfromDB();
        }
    }


    public class polyyOVR
    {

        public virtual void GetDetailsfromDB()
        {

            Console.WriteLine("details pulling from parent method");
        }
    
    }

    public class PolyOVRChild:polyyOVR
    {

        public override void GetDetailsfromDB()
        {

            Console.WriteLine("details pulling from child method");
        }
    
    
    }
}
