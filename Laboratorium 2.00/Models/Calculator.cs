namespace Laboratorium_2._00.Models
{
    public enum Operators
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    public class Calculator
    {
        public Operators? Operator { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        public string Op
        {
            get
            {
                switch (Operator)
                {
                    case Operators.Add:
                        return "+";
                    case Operators.Subtract:
                        return "-";
                    case Operators.Multiply:
                        return "*";
                    case Operators.Divide:
                        return "/";
                    default:
                        return "";
                }
            }
        }

        public bool IsValid()
        {
            return Operator != null && X != null && Y != null;
        }

        public double Calculate()
        {
            switch (Operator)
            {
                case Operators.Add:
#pragma warning disable CS8629 // Тип значения, допускающего NULL, может быть NULL.
                    return (double)(X + Y);
#pragma warning restore CS8629 // Тип значения, допускающего NULL, может быть NULL.
                case Operators.Subtract:
#pragma warning disable CS8629 // Тип значения, допускающего NULL, может быть NULL.
                    return (double)(X - Y);
#pragma warning restore CS8629 // Тип значения, допускающего NULL, может быть NULL.
                case Operators.Multiply:
#pragma warning disable CS8629 // Тип значения, допускающего NULL, может быть NULL.
                    return (double)(X * Y);
#pragma warning restore CS8629 // Тип значения, допускающего NULL, может быть NULL.
                case Operators.Divide:
#pragma warning disable CS8629 // Тип значения, допускающего NULL, может быть NULL.
                    return (double)(X / Y);
#pragma warning restore CS8629 // Тип значения, допускающего NULL, может быть NULL.
                default:
                    return double.NaN;
            }
        }
    }

}
