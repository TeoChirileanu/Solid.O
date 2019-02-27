using System;
using System.Text;
using Solid.O.Libraries;

namespace Solid.O.ConsoleApplication {
    public static class ConsoleApplication {
        public static void Main() {
            Console.OutputEncoding = Encoding.UTF8;
            UseStaticPolymorphism();
            UseDynamicPolymorphism();
        }

        private static void UseStaticPolymorphism() {
            CurrencyPrinter.PrintCurrency<Euro>();
            CurrencyPrinter.PrintCurrency<PoundSterling>();
            CurrencyPrinter.PrintCurrency<UnitedStatesDollar>();
        }

        private static void UseDynamicPolymorphism() {
            throw new NotImplementedException();
        }
    }
}