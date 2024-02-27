namespace Csharp4
{
    public class Store
    {
        public string Name { get; }
        private double area;

        public double Area
        {
            get { return area; }
            set
            {
                if (value >= 0)
                    area = value;
                else
                    throw new ArgumentException("Area cannot be negative");
            }
        }

        public Store(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public static Store operator +(Store store, double increase)
        {
            store.Area += increase;
            return store;
        }

        public static Store operator -(Store store, double decrease)
        {
            store.Area -= decrease;
            return store;
        }

        public static bool operator ==(Store store1, Store store2)
        {
            return store1.Area == store2.Area;
        }

        public static bool operator !=(Store store1, Store store2)
        {
            return !(store1 == store2);
        }

        public static bool operator >(Store store1, Store store2)
        {
            return store1.Area > store2.Area;
        }

        public static bool operator <(Store store1, Store store2)
        {
            return store1.Area < store2.Area;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Store))
                return false;

            Store otherStore = (Store)obj;
            return this.Area == otherStore.Area;
        }
    }
}
