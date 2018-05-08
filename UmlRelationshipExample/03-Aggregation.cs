using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlRelationshipExample
{
    public class Aggregation
    {
        // In an aggregation Foo always has a Bar.
        // Ownership of Bar however lies outside Foo.
        // Also, Foo can listens to Bar (not in this example, Disposing Bar is not responsibility of Foo, unsubscribing is responsibility of Foo).
        // Foo has a Bar

        public class Foo3
        {
            private readonly Bar3 LocalBar;

            public Foo3(Bar3 bar)
            {
                this.LocalBar = bar ?? throw new ArgumentNullException();
            }

            public void DoSomething()
            {
                Console.WriteLine($"{nameof(Foo3)} can always access info from {nameof(Bar3)}. {this.LocalBar.SomeInformation}");
            }
        }

        public class Bar3
        {
            public string SomeInformation { get; } = $"This is some information from {nameof(Bar3)}";
        }
    }
}
