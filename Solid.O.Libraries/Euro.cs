namespace Solid.O.Libraries {
    public class Euro : ICurrency {
        public string Abbreviation { get; } = "EUR";
        public string Symbol { get; } = "€";
        public decimal ExchangeRate { get; } = 1.0m;
    }
}