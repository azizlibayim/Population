using Population;

namespace Population
{
    class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }

        private Person(string name, string surname, int age, int height, int weight)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public static Person EnterDetails()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Height:");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Weight:");
            int weight = int.Parse(Console.ReadLine());

            return new Person(name, surname, age, height, weight);
        }

        public string ToString()
        {
            return $"Details: \nName: {Name}\nSurname: {Surname}\nAge: {Age} \nHeight: {Height}cm\nWeight: {Weight}kg";
        }
    }

}
internal class Program
{
    static void Main(string[] args)
    {
        Person person = Person.EnterDetails();
        Console.WriteLine(person.ToString());
    }
}