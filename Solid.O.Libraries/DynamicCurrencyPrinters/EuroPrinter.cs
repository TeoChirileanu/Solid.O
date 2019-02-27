using Solid.O.Libraries.Currencies;

namespace Solid.O.Libraries.DynamicCurrencyPrinters {
    public class EuroPrinter : DynamicCurrencyPrinter {
        protected override ICurrency Currency { get; } = new Euro();
    }
}