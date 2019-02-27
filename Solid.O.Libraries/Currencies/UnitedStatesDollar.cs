namespace Solid.O.Libraries.Currencies {
    public class UnitedStatesDollar : ICurrency {
        public string Abbreviation { get; } = "USD";
        public string Symbol { get; } = "$";
        public decimal ExchangeRate { get; } = 0.88m;
    }
}