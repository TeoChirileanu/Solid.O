public interface ICurrency {
        string Abbreviation { get; }
        string Symbol { get; }
        decimal ExchangeRate { get; }
    }