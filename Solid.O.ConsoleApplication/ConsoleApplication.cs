using System;
using System.Text;
using Solid.O.Libraries;
using Solid.O.Libraries.Currencies;
using Solid.O.Libraries.DynamicCurrencyPrinters;

namespace Solid.O.ConsoleApplication {
    public static class ConsoleApplication {
        private static DynamicCurrencyPrinter _currencyPrinter;

        public static void Main() {
            Console.OutputEncoding = Encoding.UTF8;
            UseDynamicPolymorphism();
            UseStaticPolymorphism();
        }

        private static void UseStaticPolymorphism() {
            Console.WriteLine("Printing using static polymorphism:\n");
            StaticCurrencyPrinter.PrintCurrency<Euro>();
            StaticCurrencyPrinter.PrintCurrency<PoundSterling>();
            StaticCurrencyPrinter.PrintCurrency<UsDollar>();
        }

        private static void UseDynamicPolymorphism() {
            Console.WriteLine("Printing using Dynamic Polymorphism\n");
            _currencyPrinter = new EuroPrinter();
            _currencyPrinter.PrintCurrency();
            _currencyPrinter = new PoundSterlingPrinter();
            _currencyPrinter.PrintCurrency();
            _currencyPrinter = new UsDollarPrinter();
            _currencyPrinter.PrintCurrency();
        }
    }
}