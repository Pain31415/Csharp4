namespace Csharp4
{
    public class Journal
    {
        public string Name { get; }
        private int numberOfEmployees;

        public int NumberOfEmployees
        {
            get { return numberOfEmployees; }
            set
            {
                if (value >= 0)
                    numberOfEmployees = value;
                else
                    throw new ArgumentException("Number of employees cannot be negative");
            }
        }

        public Journal(string name, int numberOfEmployees)
        {
            Name = name;
            NumberOfEmployees = numberOfEmployees;
        }

        public static Journal operator +(Journal journal, int increase)
        {
            journal.NumberOfEmployees += increase;
            return journal;
        }

        public static Journal operator -(Journal journal, int decrease)
        {
            journal.NumberOfEmployees -= decrease;
            return journal;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            return journal1.NumberOfEmployees == journal2.NumberOfEmployees;
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return !(journal1 == journal2);
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1.NumberOfEmployees > journal2.NumberOfEmployees;
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            return journal1.NumberOfEmployees < journal2.NumberOfEmployees;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Journal))
                return false;

            Journal otherJournal = (Journal)obj;
            return this.NumberOfEmployees == otherJournal.NumberOfEmployees;
        }
    }
}
