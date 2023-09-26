namespace ModernCSharpFeatures;

public class ExpressionBodiedMembersOldFeatures
{
    public class Money
    {
        private decimal value;
        
        public decimal Value
        {
            get
            {
                return value;
            }
            set
            {
                SetValue(value);
            }
        }

        public Money(decimal value)
        {
            SetValue(value);
        }

        private void SetValue(decimal newValue)
        {
            value = newValue >= 0 ? newValue : throw new Exception();
        }

        public string AsString
        {
            get { return "£" + value; }
        }

        public override string ToString()
        {
            return $"Your money is {AsString}";
        }
    }    

    public ExpressionBodiedMembersOldFeatures()
    {
        var money = new Money(10);

        Console.WriteLine(money);

        try
        {
            money.Value = -100;
        }
        catch (Exception)
        {
            Console.WriteLine("You can't set money to a negative number!");
        }

        money.Value = 100;

        Console.WriteLine(money);
    }
}
