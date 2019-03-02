using Solid.O.Libraries.Currencies;

namespace Solid.O.Libraries.DynamicCurrencyPrinters {
    public class PoundSterlingPrinter : 
        DynamicCurrencyPrinter {
        protected override ICurrency 
            Currency { get; } = new PoundSterling();
    }
}