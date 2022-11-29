public class Product
{
 
 public int ProdId { get; set; }    
 public string ProdcutsName { get; set; }    
 public int Weight {get;set;}
 public int price {get;set;}

}

public class Order
{ 
 public int OrderId { get; set; }    
 public int CustId { get; set; }
 public List<Product> lstProducts { get;set;}
 public OrderStatus OrderStatus { get; set; }

}

public class Customer
{ 
 public int CustId { get; set; }    
 public int CustName { get; set; }
 public List<Order> ord {get;set;}
}

public class TrackOrder
{
    public int TrackId {get;set;}
    public int OrderId {get;set;}
    public Tracking Status {get;set;}
    public string GPSLocation {get;set;}
}

enum Tracking
{
    Shop,
    Hub,
    NearHome
}


enum OrderStatus
{
    Procesing,
    Canceled,
    Develi
    shipped
}


class DeliveryMode
{
    public string GetDeliveryMode(Order order)
    {
        int weight = 0;
       foreach (var product in order.lstProdcuts)
       {
           weight =  weight + product.Weight;
       }

       switch (weight)
       {
         
         case when weight == 100
            "Bike"
            break;
         case when weight == 1000
            "Truck"
            break;
        default:
       }

       
    }
}

class TrackingService
{

    public bool CreateOrderTracking(Order ord)
    {
        if(ord.OrderStatus == "shipped")
        {
        TrackOrder trackContext = new TrackOrder();

            trackContext.OrderId = ord.OrderId;
            trackContext.Status = "";
        }
    }

    public Tracking GetOrderTrackingStatus(Order ord)
    {
        
        TrackOrder trackContext = new TrackOrder();
        trackContext.where(o => o.OrderId).Status;
    }


}

class OrderService
{

private _lstProdcuts = null;
public OrderService(IList<Products> lstProdcuts)
{
    _lstProdcuts = lstProdcuts;
}

public void PlaceOrder()
{

}

}

class CartService
{

private _prod = null;
public OrderService(Prodcuts prod)
{
    _prod = prod;
}

public void PlaceOrder()
{

}

}

