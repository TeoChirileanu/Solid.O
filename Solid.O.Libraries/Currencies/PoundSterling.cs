namespace Solid.O.Libraries.Currencies {
    public class PoundSterling : ICurrency {
        public string Abbreviation { get; } = "GBP";
        public string Symbol { get; } = "£";
        public decimal ExchangeRate { get; } = 1.16m;
    }
}