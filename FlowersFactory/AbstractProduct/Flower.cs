namespace FlowersFactory.AbstractProduct
{
    public abstract class Flower
    {
        protected Flower(string name, int numberOfPetals, string color)
        {
            Name = name;
            NumberOfPetals = numberOfPetals;
            Color = color;
        }

        public int NumberOfPetals { get; protected set; }
        public string Color { get; }
        public string Name { get; }

        public virtual void Grow()
        {
            NumberOfPetals++;
            System.Console.WriteLine($"Growing {Color} {Name}. Number of petals: {NumberOfPetals}.");
        }
    }
}
