// Тема 6: Ключевое слово static


// Практика

// 1

using oop_05__тема_6_static_;

Point p1 = new Point(7, 9);
Point p2 = new Point(12, 10);

Console.WriteLine(Point.count); // 2 - создано 2 объекта класса Point


// 2 (модификация)

Console.WriteLine($"Расстояние между точками: {Point.LengthPoints(p1, p2):F2}");  // 5,10


Person person = new Person(60);
person.CheckAge();
Person.RetirementAge = 70;
person.CheckAge();



// структуры - являются примитивным типом данных, а не ссылочным, поэтому занимает память в стеке, а не в куче

PointStruct ps1 = new PointStruct();
ps1.x = 5;
ps1.y = 9;

struct PointStruct
{
    public double x;
    public double y;
}
