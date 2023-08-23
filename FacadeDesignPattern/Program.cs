namespace FacadeDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //The Client will use the Facade Class instead of the Subsystems(i.e Invoice, Payment, Product).
            FacadeClass_Order order = new FacadeClass_Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}