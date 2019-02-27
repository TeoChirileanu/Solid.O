using System;

namespace Solid.O.Libraries {
    public abstract class DynamicCurrencyPrinter {
        protected abstract ICurrency Currency { get; }

        public void PrintCurrency() =>
            Console.WriteLine($"Currency {Currency.Abbreviation}\n" +
                              $"Symbol: {Currency.Symbol}\n" +
                              $"Exchange rate: 1 {Currency.Symbol} = {Currency.ExchangeRate} EUR\n");
    }
}