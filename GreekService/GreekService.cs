using System;
using System.Linq;

namespace GreekService {
    public class GreekService {
        public string Greet(string name) {
            if (name is null)
                name = "my friend.";

            if (IsAllUpperCase(name))
                return $"HELLO {name}!";

            return $"Hello, {name}";
        }

        public bool IsAllUpperCase(string name) {
            return !name.Any(l => char.IsLower(l));
        }
    }
}
