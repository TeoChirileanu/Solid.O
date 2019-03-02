using Solid.O.Libraries.Currencies;

namespace Solid.O.Libraries.DynamicCurrencyPrinters {
    public class UsDollarPrinter
        : DynamicCurrencyPrinter {
        protected override ICurrency 
            Currency { get; } = 
                new UsDollar();
    }
}