namespace KPIPractice2
{
    /// Box<T> — універсальний контейнер
    /// - Оголосіть клас Box<T>, який має поле чи властивість T Value.
    /// - Додайте метод void Display(), що виводить у консоль значення Value.
    /// - У методі Main продемонструйте роботу Box<int>, Box<string> та Box<Person>,
    /// де Person — ваш власний клас із полями Name і Age.
    public class Task1
    {
        public void Main()
        {
            Box<int> box = new Box<int>(66);
            box.Display();
            Box<string> box1 = new Box<string>("Miku");
            box1.Display();
            Person person=new Person(25,"Hoshina");
            Box<Person> box2 = new Box<Person>(person);
            box2.Display();
        }
    }

    class Person
    {
        public int Age;
        public string Name;
        public Person(int Age,string Name)
        {
            this.Age=Age;
            this.Name=Name;
        }
        public override string ToString()
        {
            return $"Name {Name} || Age {Age}";
        }

    }
    class Box<T>
    {
        public T Value;
        public Box(T Value)
        {
            this.Value = Value;
        }
        public void Display()
        {
            Console.WriteLine($"Value: {Value}");
        }
    }
}
