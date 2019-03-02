namespace Solid.O.Libraries.Currencies {
    public class UsDollar : ICurrency {
        public string Abbreviation { get; } = "USD";
        public string Symbol { get; } = "$";
        public decimal ExchangeRate { get; } = 0.88m;
    }
}