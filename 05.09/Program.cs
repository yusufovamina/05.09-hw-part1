using Task1;


Article article1 = new Article(1, "Laptop", 999.99, ArticleType.Electronics);
Article article2 = new Article(2, "T-shirt", 19.99, ArticleType.Clothing);


Client client1 = new Client(101, "Atilla Ismail", "Baku", "991234567", 3, 1500.00, ClientType.Normal);
Client client2 = new Client(102, "Jane Popova", "Saint Petersburg", "9399876523", 4, 3000.00, ClientType.Premium);


RequestItem item1 = new RequestItem(article1, 2);
RequestItem item2 = new RequestItem(article2, 4);


Request request1 = new Request(1001, client1, DateTime.Now, new RequestItem[] { item1 }, PayType.CreditCard);
Request request2 = new Request(1002, client2, DateTime.Now, new RequestItem[] { item2 }, PayType.PayPal);


Console.WriteLine("Information about articles:");
Console.WriteLine($"Article 1: {article1.ProductName}, Price: {article1.Price}, Type: {article1.Type}");
Console.WriteLine($"Article 2: {article2.ProductName}, Price: {article2.Price}, Type: {article2.Type}");
Console.WriteLine();


Console.WriteLine("Information about clients:");
Console.WriteLine($"Client 1: {client1.FullName}, Address: {client1.Address}, Phone: {client1.PhoneNumber}, " +
    $"Orders: {client1.OrderCount}, Total Order Amount: {client1.TotalOrderAmount}, Type: {client1.Type}");
Console.WriteLine($"Client 2: {client2.FullName}, Address: {client2.Address}, Phone: {client2.PhoneNumber}, " +
    $"Orders: {client2.OrderCount}, Total Order Amount: {client2.TotalOrderAmount}, Type: {client2.Type}");
Console.WriteLine();


Console.WriteLine("Information about orders:");
Console.WriteLine($"Order 1: Code: {request1.OrderCode}, Date: {request1.OrderDate}, Amount: {request1.TotalOrderAmount()}, " +
    $"Payment Type: {request1.PaymentType}");
Console.WriteLine($"Order 2: Code: {request2.OrderCode}, Date: {request2.OrderDate}, Amount: {request2.TotalOrderAmount()}, " +
    $"Payment Type: {request2.PaymentType}");

namespace Task1
{

    enum ArticleType
    {
        Electronics,
        Clothing,
        Food,
        Books,
        Other
    }

    
    struct Article
    {
        public int ProductCode;     
        public string ProductName;  
        public double Price;        
        public ArticleType Type;    

        public Article(int code, string name, double price, ArticleType type)
        {
            ProductCode = code;
            ProductName = name;
            Price = price;
            Type = type;
        }
    }

  
    enum ClientType
    {
        Normal,
        Premium,
        VIP
    }

   
    struct Client
    {
        public int ClientCode;            
        public string FullName;           
        public string Address;            
        public string PhoneNumber;        
        public int OrderCount;            
        public double TotalOrderAmount;   
        public ClientType Type;           

        public Client(int code, string name, string address, string phone, int orderCount, double totalAmount, ClientType type)
        {
            ClientCode = code;
            FullName = name;
            Address = address;
            PhoneNumber = phone;
            OrderCount = orderCount;
            TotalOrderAmount = totalAmount;
            Type = type;
        }
    }

    struct RequestItem
    {
        public Article Product;     
        public int Amount;        

        public RequestItem(Article product, int quantity)
        {
            Product = product;
            Amount = quantity;
        }
    }

    
    enum PayType
    {  CreditCard,
        Cash,
        PayPal,
        BankTransfer
    }

   
    struct Request
    {
        public int OrderCode;                
        public Client Customer;              
        public DateTime OrderDate;           
        public RequestItem[] OrderedItems;   
        public PayType PaymentType;          

        public double TotalOrderAmount ()      
        {
       
                double total = 0;
                foreach (var item in OrderedItems)
                {
                    total += item.Product.Price * item.Amount;
                }
                return total;
            
        }

        public Request(int code, Client customer, DateTime date, RequestItem[] items, PayType paymentType)
        {
            OrderCode = code;
            Customer = customer;
            OrderDate = date;
            OrderedItems = items;
            PaymentType = paymentType;
        }
    }

}


