//string? name = null;            // ? - суффикс, позволяющий пройти проверку на null
//PrintUpper(name);


//int? val = null;
//IsNull(val);
//val = 23;
//IsNull(val);
//Nullable<int> val2 = 6;


//PrintNullanle(5);
//PrintNullanle(null);

//int? x = val + 8;
//Console.WriteLine((x is null) ? "null" : x);
//Console.WriteLine((x is not null) ? x : "null");


// ?? - null-объединение
// лев. операнд ?? прав. операнд
//string? text = null;
//text = "Tom";
//string name = text ?? "MyName";     // если text является null, то выведет "MyName"
//Console.WriteLine(name);



//void PrintNullanle(int? n)
//{
//    Console.WriteLine((n.HasValue) ? n.Value : "null");
//}

//void IsNull(int? obj)
//{
//    Console.WriteLine((obj == null) ? "null" : obj);
//}

//void PrintUpper(string? text)
//{
//    Console.WriteLine(text!.ToUpper());     // ! - null-forgiving operator - указывает на то, что переменная ссылочного типа != null
//}



//Company company = new Company { WebSite = "www.microsoft" };
//Person person = new Person { Company = company };

//PrintWebSite(person);

//void PrintWebSite(Person? person)
//{
//    //if (person != null)
//    //{
//    //    if (person.Company != null)
//    //    {
//    //        if (person.Company.WebSite != null)
//    //        {
//    //            Console.WriteLine(person.Company.WebSite.ToUpper());
//    //        }
//    //    }    
//    //}
//    Console.WriteLine(person?.Company?.WebSite?.ToUpper());
//}

//class Person
//{
//    public Company? Company { get; set; }
//}

//class Company
//{
//    public string? WebSite { get; set; }
//}


// Практика

/* # 1. Задача на взаимодействие между классами. 
Разработать систему «Платежи». 
Клиент имеет Счёт в банке и Банковскую карту (КК). 
Клиент может
 * - оплатить Заказ,
 * - сделать платеж на другой Счёт,
 * - заблокировать КК и
 * - аннулировать Счет. 
Администратор может
- заблокировать КК за превышение платежа.*/


//Schet schet = new Schet { Number = "123456", Enable = true, Money = 50000 };
//Card card = new Card { Schet = schet, Block = false };
//Client client = new Client { Card = card };
//Administrator administrator = new Administrator();
//Order order = new Order { Client = client, Price = 24000 };

//order.Sdelka();
//Console.WriteLine(client.Card.Schet.Money);

//Order order2 = new Order { Client = client, Price = 30000 };
//if (order2.Price > client.Card.Schet.Money)
//{
//    order2.Sdelka();
//    administrator.BlockCard(card);
//}
//order2.Sdelka();
//Console.WriteLine(client.Card.Schet.Money);


//class Schet
//{
//    public string? Number { get; set; }
//    public decimal Money { get; set; }
//    public bool Enable { get; set; }
//    public void Sub(decimal money)
//    {
//        Money -= money;
//    }
//}

//class Card
//{
//    public Schet Schet { get; set; }
//    public bool Block { get; set; }
//}

//class Client
//{
//    public Card? Card { get; set; }
//    public void BlockCard(Card card)
//    {
//        card.Block = true;
//    }
//    public void EnabledSchet(Schet schet)
//    {
//        schet.Enable = false;
//    }
//}

//class Order
//{
//    public Client Client { get; set; }
//    public decimal Price { get; set; }
//    public void Sdelka()
//    {
//        if (Client?.Card?.Schet?.Enable != false && Client?.Card?.Block != true)
//        {
//            if (Price < Client?.Card?.Schet.Money)
//            {
//                Client?.Card?.Schet?.Sub(Price);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Счёт (карта) заблокирован(а)");
//        }
//    }
//}

//class Administrator
//{
//    public void BlockCard(Card card)
//    {
//        card.Block = true;
//    }
//}


Console.Write("1: ");
double one = double.Parse(Console.ReadLine());
Console.Write("2: ");
double two = double.Parse(Console.ReadLine());
double three = one / two;
Console.WriteLine($"{three:F2}");

