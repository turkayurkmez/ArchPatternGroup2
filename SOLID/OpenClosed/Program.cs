// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * Bir nesne gelişime AÇIK değişime KAPALI olmalıdır.
 * Bir nesnenin işlevlerini ya da property'lerine yeni bir özellik ya davranış kazandırmak istediğinizde kodda değişiklik yapıyorsanız prensibe uymuyorsunuz...
 */
Customer customer = new Customer() {  Cart = new Premium()};
OrderManager orderManager = new OrderManager { Customer = customer };
var price = orderManager.GetTotalDiscount(1000);
Console.WriteLine(price);

public class Customer
{
    public CartType Cart { get; set; }

}
public class OrderManager
{
    public Customer Customer { get; set; }
    public decimal GetTotalDiscount(decimal price)
    {
        return Customer.Cart.GetDiscountedPrice(price);
        //switch (Customer.Cart)
        //{
        //    case CartType.Standard:
        //        return price * 0.95m;
           
        //    case CartType.Silver:
        //        return price * 0.90m;
        //    case CartType.Gold:
        //        return price * 0.85m;
        //    case CartType.Premium:
        //        return price * .8m;
        //    default:
        //        return price * 1m;
        //}
    }
}

public abstract class CartType {
    public abstract decimal GetDiscountedPrice(decimal price);
}

public class Standard : CartType
{
    public override decimal GetDiscountedPrice(decimal price)
    {
        return price * .95M;
    }

}

public class Silver : CartType
{
    public override decimal GetDiscountedPrice(decimal price)
    {
        return price * .90M;
    }
}

public class Gold : CartType
{
    public override decimal GetDiscountedPrice(decimal price)
    {
        return price * .85M;
    }
}

public class Premium : CartType
{
    public override decimal GetDiscountedPrice(decimal price)
    {
        return price * .80M;
    }
}