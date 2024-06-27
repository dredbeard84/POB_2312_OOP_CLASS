using oop_L08_T13_абстрактные_классы;

Rectangle rect = new Rectangle
{
    Width = 5,
    Height = 10,
    Name = "Прямоугольник"
};
Console.WriteLine($"{rect.Name} {rect.getPerimetr():F2} {rect.getArea():F2}");

Circle circ = new Circle
{
    Name = "Окружность",
    Radius = 40
};
Console.WriteLine($"{circ.Name} {circ.getPerimetr():F2} {circ.getArea():F2}");

Cube cube = new Cube
{
    Name = "Куб",
    Height = 20,
};
Console.WriteLine($"{cube.Name} {cube.getVolume():F2} {cube.getArea():F2}");
