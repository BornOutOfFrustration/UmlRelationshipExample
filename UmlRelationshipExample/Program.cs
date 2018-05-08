using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlRelationshipExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // The difference between using, depending, having and owning.
            Console.WriteLine("--- ASSOCIATION ---");
            DemonstrateAssociation();
            Console.WriteLine();

            Console.WriteLine("--- DEPENDENCY ---");
            DemonstrateDependency();
            Console.WriteLine();

            Console.WriteLine("--- AGGREGATION ---");
            DemonstrateAggregation();
            Console.WriteLine();

            Console.WriteLine("--- COMPOSITION ---");
            DemonstrateComposition();
            Console.WriteLine();
        }

        static void DemonstrateAssociation()
        {
            // Association. Existence of Foo and Bar are unconnected Foo is using Bar.
            Association.Foo1 foo1 = new Association.Foo1();
            Association.Bar1 bar1 = new Association.Bar1();

            foo1.DoSomethingWith(null);
            foo1.DoSomethingWith(bar1);

            foo1.PrintBarMessage();
            foo1.Bar = bar1;
            foo1.PrintBarMessage();
        }

        static void DemonstrateDependency()
        {
            // Dependency (slightly more interaction. Foo is using Bar and Foo is depending on Bar for events)
            Dependency.Foo2 foo2 = new Dependency.Foo2();
            Dependency.Bar2 bar2 = new Dependency.Bar2();

            foo2.AssignBarToFoo(bar2);

            bar2.OnSomethingHappened();

            foo2.Bar = bar2;
            bar2.OnSomethingHappened();
        }

        static void DemonstrateAggregation()
        {
            // Aggregation. Foo is set up so that it always has a Bar. It can also listen to events from Bar.
            // Foo has a Bar
            Aggregation.Bar3 bar3 = new Aggregation.Bar3();
            Aggregation.Foo3 foo3 = new Aggregation.Foo3(bar3);
            
            foo3.DoSomething();
        }

        static void DemonstrateComposition()
        {
            // Composition. Foo is set up so that it creates a Bar. It can also listen to events from Bar.
            // Foo owns a Bar
            Composition.Foo4 foo4 = new Composition.Foo4();

            foo4.DoSomething();
        }
    }
}
