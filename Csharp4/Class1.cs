namespace Csharp4
{
    public class City
    {
        private string name;
        private int population;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Population
        {
            get { return population; }
            set
            {
                if (value >= 0)
                    population = value;
                else
                    throw new ArgumentException("Population cannot be negative");
            }
        }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public static City operator +(City city, int increase)
        {
            city.Population += increase;
            return city;
        }

        public static City operator -(City city, int decrease)
        {
            city.Population -= decrease;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.Population == city2.Population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return !(city1 == city2);
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is City))
                return false;

            return this == (City)obj;
        }
    }
}
