using System.Reflection;

namespace DelegateSample
{


    public delegate dynamic DelegateExample(string ProductName);


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ProductInformation objPB = new ProductInformation();


            DelegateExample objDelegate = objPB.OrderProduct;
            objDelegate += objPB.EmailNotification;
            objDelegate += objPB.StockUpdate;

            productSerice objprod = new productSerice();
            objprod._delegateCall = objDelegate;
            objprod.MakePyment("laptop");

            //objDelegate.Invoke("laptop");


            //var MethodDetails = objDelegate.GetInvocationList();

            //foreach (DelegateExample item in MethodDetails)
            //{

            //    dynamic MethodName = item("laptop new");

            //    Console.WriteLine($"the method name {item.Method.Name} and the productname {MethodName}");

        }


    }

    public class productSerice
    {

        public DelegateExample? _delegateCall;

        public void MakePyment(string Product)
        {

            Console.WriteLine("payment done" + Product);


            // calling delgate after payment

            _delegateCall.Invoke(Product);


        }

    }

    public class ProductInformation
    {


        public dynamic OrderProduct(string ProductName)
        {

            Console.WriteLine($"the order placed for {ProductName}");

            return ProductName;

        }
        public dynamic EmailNotification(string ProductName)
        {

            Console.WriteLine($"the Email sent for the {ProductName}");
            return ProductName;

        }
        public dynamic StockUpdate(string ProductName)
        {

            Console.WriteLine($"the order placed and Stock Update {ProductName}");
            return ProductName;

        }



    }
}
