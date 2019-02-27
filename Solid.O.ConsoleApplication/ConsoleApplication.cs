using System;
using System.Text;
using Solid.O.Libraries;
using Solid.O.Libraries.Currencies;
using Solid.O.Libraries.DynamicCurrencyPrinters;

namespace Solid.O.ConsoleApplication {
    public static class ConsoleApplication {
        public static void Main() {
            Console.OutputEncoding = Encoding.UTF8;
            UseDynamicPolymorphism();
            UseStaticPolymorphism();
        }

        private static void UseStaticPolymorphism() {
            Console.WriteLine("Printing using static polymorphism:\n");

            StaticCurrencyPrinter.PrintCurrency<Euro>();
            StaticCurrencyPrinter.PrintCurrency<PoundSterling>();
            StaticCurrencyPrinter.PrintCurrency<UnitedStatesDollar>();
        }

        private static void UseDynamicPolymorphism() {
            Console.WriteLine("Printing using Dynamic Polymorphism\n");

            DynamicCurrencyPrinter currencyPrinter = new EuroPrinter();
            currencyPrinter.PrintCurrency();

            currencyPrinter = new PoundSterlingPrinter();
            currencyPrinter.PrintCurrency();

            currencyPrinter = new UnitedStatesDollarPrinter();
            currencyPrinter.PrintCurrency();
        }
    }
}