namespace InterfaceLab
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public void Eat();
        public void Cry();
    }

    class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public void Cry()
        {
            Console.WriteLine("Woof!");
        }
    }

    class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public void Cry()
        {
            Console.WriteLine("Meow!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Please enter the dogs name");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter the dogs age");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the dogs color");
            var color = Console.ReadLine();

            dog.Name = name;
            dog.Age = age;
            dog.Color = color;

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Age);
            Console.WriteLine(dog.Color);
            dog.Eat();
            dog.Cry();

            Cat cat = new Cat();
            Console.WriteLine("Please enter the cats name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the cats age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the cats color");
            color = Console.ReadLine();

            cat.Name = name;
            cat.Age = age;
            cat.Color = color;

            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Age);
            Console.WriteLine(cat.Color);
            cat.Cry();
            cat.Eat();

            List<IAnimal> list = [cat, dog];
            var cat2 = new Cat();
            cat2.Name = "Marshmallow";
            list.Add(cat2);
            var dog2 = new Dog();
            dog2.Name = "Roofus";
            list.Add(dog2);

            foreach (var item in list)
            {
                if(item.GetType() == typeof(Cat))
                {
                    Console.WriteLine("Cat's Name is " + item.Name);
                }
                else // If its not a cat, it must be a dog
                {
                    Console.WriteLine("Dog's Name is " + item.Name);
                }
            }
        }
    }
}
