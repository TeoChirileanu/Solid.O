using System;

namespace Solid.O.Libraries {
    public class ConsoleGetter : IGetter {
        public string Get() => Console.ReadLine();
    }
}