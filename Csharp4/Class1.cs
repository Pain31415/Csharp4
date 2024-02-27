namespace Csharp4
{
    public class CreditCard
    {
        public string CardNumber { get; }
        public int CVC { get; }
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative");
                }
                balance = value;
            }
        }

        public CreditCard(string cardNumber, int cvc, decimal balance)
        {
            CardNumber = cardNumber;
            CVC = cvc;
            Balance = balance;
        }

        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            card.Balance += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            card.Balance -= amount;
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.CVC == card2.CVC;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !(card1 == card2);
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CreditCard))
            {
                return false;
            }
            CreditCard otherCard = (CreditCard)obj;
            return this.CVC == otherCard.CVC;
        }
    }
}
