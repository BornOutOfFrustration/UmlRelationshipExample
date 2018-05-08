using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlRelationshipExample
{
    public class Composition
    {
        // In a composition Foo always has a Bar.
        // Ownership of Bar lies with Foo.
        // Also, Foo can listens to Bar (not in this example, Disposing Bar is the responsibility of Foo, just as unsubscribing is the responsibility of Foo).
        // Foo owns a Bar
        public class Foo4
        {
            private Bar4 LocalBar = new Bar4();

            public void DoSomething()
            {
                Console.WriteLine($"{nameof(Foo4)} can always access info from {nameof(Bar4)}. {this.LocalBar.SomeInformation}");
            }
        }

        public class Bar4
        {
            public string SomeInformation { get; } = $"This is some information from {nameof(Bar4)}";
        }
    }
}
