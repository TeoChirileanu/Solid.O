using Solid.O.Libraries.Currencies;

namespace Solid.O.Libraries.DynamicCurrencyPrinters {
    public class UnitedStatesDollarPrinter : DynamicCurrencyPrinter {
        protected override ICurrency Currency { get; } = new UnitedStatesDollar();
    }
}