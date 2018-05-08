using System;

namespace UmlRelationshipExample
{
    public class Association
    {
        // In an association Foo and Bar are existing next to one other.
        // When the program calls Foo, it needs to make sure that Bar is available.
        // Foo uses Bar
        public class Foo1
        {
            public void DoSomethingWith(Bar1 bar)
            {
                if (bar == null)
                {
                    Console.WriteLine("Too bad. bar is null.");
                    return;
                }

                Console.WriteLine($"1) Foo Uses bar as an association... {bar.SomeInformation} which is used in {nameof(Foo1)}");
            }

            public void PrintBarMessage()
            {
                if(this.Bar == null)
                {
                    Console.WriteLine("Too bad. Bar is not set.");
                    return;
                }
                Console.WriteLine($"2) Foo Uses bar as an association... {this.Bar.SomeInformation} which is used in {nameof(Foo1)}");
            }

            public Bar1 Bar { get; set; }
        }

        public class Bar1
        {
            public string SomeInformation { get; } = $"This is some information from {nameof(Bar1)}";
        }
    }    
}
