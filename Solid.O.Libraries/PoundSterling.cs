namespace Solid.O.Libraries {
    public class PoundSterling : ICurrency {
        public string Abbreviation { get; } = "GBP";
        public string Symbol { get; } = "£";
        public decimal ExchangeRate { get; } = 1.16m;
    }
}