using oop_L08_T12_перегрузка_операций;

Complex c1 = new Complex { Re = 4, Im = 3 };
Complex c2 = new Complex { Re = 4, Im = 3 };
Complex c3 = new Complex { Re = 8, Im = 12 };


Console.WriteLine(c1 == c2);
Console.WriteLine(c1 == c3);

Complex z1 = c1 + c2;
Console.WriteLine(z1);

Complex z2 = c2 + c3;
Console.WriteLine(z2);

Complex z3 = c1 * c2;
Console.WriteLine(z3);

Complex z4 = c1 / c2;
Console.WriteLine(z4);

//