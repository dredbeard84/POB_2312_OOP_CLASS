using oop_01_классы_и_методы;

//Console.Write("Введите 1-е число: ");
//int x = int.Parse(Console.ReadLine()!);
//Console.Write("Введите 2-е число: ");
//int y = int.Parse(Console.ReadLine()!);

//Pair p1 = new Pair(x, y);
//p1.Print();
//p1.setA(10);
//p1.setB(18);
//p1.Print();
//Console.WriteLine(p1.Sum());
//Console.WriteLine(p1.Max());


//NewPair p2 = new NewPair
//{
//    A = x,
//    B = y
//};
//Console.WriteLine($"A = {p2.A}, B = {p2.B}");
//p2.A = 10;
//p2.B = 18;
//p2.Print();
//Console.WriteLine(p2.Sum());
//Console.WriteLine(p2.Max());


//Counter c1 = new Counter();
//Console.WriteLine(c1.Count);
//c1.Increment();
//c1.Increment();
//c1.Increment();
//c1.Increment();
//Console.WriteLine(c1.Count);
//c1.Decrement();
//Console.WriteLine(c1.Count);

//Random random = new Random();
//Counter c2 = new Counter(random.Next(-10, 10), -10, 10);
//Console.WriteLine(c2.Count);
//c2.Increment();
//Console.WriteLine(c2.Count);


// # 1.2.2

/* 2. Создайте структуру (класс?) с именем train, содержащую поля: 
 * название пункта назначения, 
 * номер поезда, 
 * время отправления. 
 * Ввести данные в массив из пяти элементов типа train, упорядочить элементы по номерам поездов. Добавить возможность вывода информации о поезде, номер которого введён пользователем. 
   Добавить возможность сортировки массив по пункту назначения, причём поезда с одинаковыми пунктами назначения должны быть упорядочены по времени отправления. */

//Solution solution = new Solution();
//solution.AddTrain(new Train { Destination = "Москва", Number = 3, TimeOfdeparture = DateTime.Parse("12:30") });
//solution.AddTrain(new Train { Destination = "Москва", Number = 5, TimeOfdeparture = DateTime.Parse("11:30") });
//solution.AddTrain(new Train { Destination = "Волгоград", Number = 6, TimeOfdeparture = DateTime.Parse("18:40") });
//solution.AddTrain(new Train { Destination = "Москва", Number = 8, TimeOfdeparture = DateTime.Parse("9:15") });
//solution.AddTrain(new Train { Destination = "Питер", Number = 1, TimeOfdeparture = DateTime.Parse("16:10") });
//solution.Print();
//Console.Write("Введите номер поезда: ");
//int numberOfTrain = int.Parse(Console.ReadLine());
//solution.Find(numberOfTrain).Print();
//solution.PrintByDestination();


