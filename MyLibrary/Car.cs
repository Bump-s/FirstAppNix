namespace MyLibrary
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public double СalculateOverclocking(double weight, int horsePower)
        {
            return weight * horsePower;
        }
    }
}
