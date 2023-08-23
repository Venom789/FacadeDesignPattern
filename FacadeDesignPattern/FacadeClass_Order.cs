namespace FacadeDesignPattern
{
    public class FacadeClass_Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            //Get the Product Details
            Product product = new Product();
            product.GetProductDetails();
            //Make the Payment
            Payment payment = new Payment();
            payment.MakePayment();
            //Send the Invoice
            Invoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }
}
