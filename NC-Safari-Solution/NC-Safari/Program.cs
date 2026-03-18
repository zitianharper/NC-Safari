namespace NC_Safari
{
    public class Program
    {
        public static void Main()
        {
            Tiger fluffy = new Tiger(80);
            Penguin penny = new Penguin(20.4f);
            Goose jeff = new Goose(3);
            Bat betty = new Bat(0.7f);

            // Sky animals 
            Sky sky = new Sky();
            sky.AddAnimalInEnvironment(betty);
            sky.AddAnimalInEnvironment(jeff);

            sky.CheckAnimalsInEnvironment();

            // Hunting animals
            HuntingGround hunting = new HuntingGround();
            hunting.AddAnimalInEnvironment(betty);
            hunting.AddAnimalInEnvironment(fluffy);
            hunting.AddAnimalInEnvironment(penny);

            hunting.CheckAnimalsInEnvironment();

            List<Animal> animalsToSee = new List<Animal>
            {   
                  new Tiger(70),
                  new Goose(5.2f),
                  new Bat(0.9f),
                  new Goose(4),
                  new Tiger(90),
                  new Penguin(15.8f)
            };
            animalsToSee.Sort(new CompareWeight(false));

            animalsToSee.ForEach(animal => Console.WriteLine($" {animal.GetType().Name} - {animal.Weight}kg"));

        }

        public abstract class Animal
        {
            public float Weight { get; set; }

            public Animal(float weight)
            {
                Weight = weight;
            }

            public abstract void MakeSound();
        }
        public abstract class SafariEnvironment<IEnvironment>
        {
            protected List<Animal> animalsInEnvironment = new List<Animal>();

            public abstract void CheckAnimalsInEnvironment();

            public void AddAnimalInEnvironment(Animal animal)
            {
                this.animalsInEnvironment.Add(animal);
            }
        }

    }
}
