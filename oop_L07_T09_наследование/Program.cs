// тема 9: наследование

// sealed class ClassParent - запрет наследования

//class ClassParent
//{
//    private int x;

//    protected int y;

//    public int getX { get { return x; } }

//    public ClassParent(int x, int y)
//    {
//        this.x = x;
//        this.y = y;
//    }

//    public ClassParent(int y)
//    {
//        this.y = y;
//    }
//}

//class Child : ClassParent
//{
//    public Child(int y) : base(y)
//    {}

//    public void Method()
//    {
//        //int x = base.x;     // x не доступен из-за его уровня защиты
//        Console.WriteLine(base.y);
//        double d = y;
//        Console.WriteLine(d);
//    }
//}

// полный код выше смотри на гите



// практика

Student vasia = new Student("Иванов", "Василий", 4.5);
Console.WriteLine(vasia.GetScholarship());

Aspirant borya = new Aspirant("Петров", "Борис", 5, "Геофизика");
Console.WriteLine(borya.GetScholarship());

class Student
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    private string? group;

    public string? Group { get; }

    private double averageMark;

    public double AverageMark
    {
        get { return averageMark; }
        set
        { 
            if (2 <= value && value <= 5) averageMark = value;
            else value = 0; 
        }
    }

    public Student(string? firstName, string? lastName, string? group, double averageMark)
    {
        FirstName = firstName;
        LastName = lastName;
        this.group = group;
        AverageMark = averageMark;
    }

    public Student(string? firstName, string? lastName, double averageMark)
    {
        FirstName = firstName;
        LastName = lastName;
        AverageMark = averageMark;
    }

    // virtual, чтобы наследники переопределяли метод
    public virtual decimal GetScholarship()
    {
        return (averageMark == 5) ? 5000 : 3000;
    }
}

class Aspirant : Student
{
    public string ScientificWork { get; set; }
    
    public Aspirant(string? firstName, string? lastName, double averageMark) : base(firstName, lastName, averageMark)
    {
    }

    public Aspirant(string? firstName, string? lastName, double averageMark, string scientificWork) : base(firstName, lastName, averageMark)
    {
        this.ScientificWork = scientificWork;
    }

    // создать переопределение
    // override - перегрузка 
    public override decimal GetScholarship()
    {
        return (AverageMark == 5) ? 25000 : 15000;
    }
}