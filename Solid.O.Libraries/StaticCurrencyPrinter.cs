using System;

namespace Solid.O.Libraries {
    public static class StaticCurrencyPrinter {
        public static void PrintCurrency<T>() where T : ICurrency, new() {
            var currency = new T();
            var message = $"Currency {currency.Abbreviation}\n" +
                          $"Symbol: {currency.Symbol}\n" +
                          $"Exchange rate: 1 {currency.Symbol} = {currency.ExchangeRate} EUR\n";
            Console.WriteLine(message);
        }
    }
}