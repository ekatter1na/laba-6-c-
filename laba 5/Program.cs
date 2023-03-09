namespace laba_6
{
    class Animal
    {
        public string name;
        public string food;
        public string location;

        public Animal(string name, string food, string location)
        {
            this.name = name;
            this.food = food;
            this.location = location;
        }

       
        public virtual void makeNoise()
        {
            Console.WriteLine("издает звуки");
        }
        public virtual void Eat()
        {
            Console.WriteLine("ест");
        }
        public virtual void Sleep()
        {

            Console.WriteLine("спит");
        }
    }
    class Dog : Animal
    {
        public Dog(string name, string food, string location) : base(name, food, location) { }
        public override void makeNoise()
        {
            Console.WriteLine($"{name} гавкает");
        }
        public override void Eat()
        {
            Console.WriteLine($"{name} кушает: " + food);
        }
        public override void Sleep()
        {
            Console.WriteLine($"{name} спит");
        }


    }
    class Cat : Animal
    {
        public Cat(string name, string food, string location) : base(name, food, location) { }
        public override void makeNoise()
        {
            Console.WriteLine($"{name} мяучит");
        }
        public override void Eat()
        {
            Console.WriteLine($"{name} кушает: " + food);
        }
        public override void Sleep()
        {
            Console.WriteLine($"{name} спит");
        }
    }
    class Horse : Animal
    {
        public Horse(string name, string food, string location) : base(name, food, location) { }
        public override void makeNoise()
        {
            Console.WriteLine($"{name} цокает");
        }
        public override void Eat()
        {
            Console.WriteLine($"{name} кушает: " + food);
        }
        public override void Sleep()
        {
            Console.WriteLine($"{name} спит");
        }
    }

    class Vetirinar
    {
        public void treatAnimal(Animal animal)
        {
            Console.WriteLine(animal.name + " - на приеме у врача");
            Console.WriteLine("кушает: " + animal.food);
            Console.WriteLine("проживает: " + animal.location);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vetirinar vetirinar = new Vetirinar();

            Dog dog = new Dog("Шарик", "мясные продукты", "будка");
            Cat cat = new Cat("Фиби", "лакомства, корм, мясные продукты", "в квартире");
            Horse horse = new Horse("Гоша", "овощи, фрукты", "в конюшне");

            vetirinar.treatAnimal(dog);
            Console.WriteLine();
            vetirinar.treatAnimal(cat);
            Console.WriteLine();
            vetirinar.treatAnimal(horse);

            Console.ReadLine();
        }
    }
}