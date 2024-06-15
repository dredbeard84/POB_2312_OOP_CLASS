// Тема 7: Частичные классы, пространство имён

// у пространства имён модификатор доступа всегда public, поэтому его указывать не нужно


using oop_05__тема_7_частичные_классы_;

Person person = new Person();
person.Move();
person.Eat();
person.Read();


People people = new People(610);
people.ID = 67;

public record People    // запись
{
    public People(int id) => ID = id;

    public int ID { get; set; }
}


// практика

// # 1 : 7 чудес света

