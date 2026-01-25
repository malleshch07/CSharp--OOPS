using System.ComponentModel;
using System.Globalization;

namespace Pub_Sub_ActionDelgate
{



    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string str = Console.ReadLine();
            PostOrderactions objpostmenthods = new PostOrderactions();

            OrderPlaceService objservice = new OrderPlaceService();
            objservice.PostOrderExecuteDelegare = objpostmenthods.Sendemail;
            objservice.PostOrderExecuteDelegare += objpostmenthods.StockUpdate;
            objservice.OrderPlace(str);

        }
    }

    public class OrderPlaceService
    {
        public Action<string>? PostOrderExecuteDelegare;
      
        public void OrderPlace(String pro)
        {

            Console.WriteLine("order placed continue call the delgate for rest" + pro);
            PostOrderExecuteDelegare?.Invoke(pro);
        }
    }

    public class PostOrderactions
    {

        public void Sendemail(string product)
        {
            Console.WriteLine("email sent for " + product);
        }

        public void StockUpdate(string product)
        {

            Console.WriteLine("stock updated" + product);
        }
    }


}
