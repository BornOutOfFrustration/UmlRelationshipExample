using System;

namespace UmlRelationshipExample
{
    public class Dependency
    {
        // In a dependency Foo and Bar are not depending on each other.
        // When the program calls Foo, it needs to make sure that Bar is available.
        // Also, Foo listens to Bar, and when Bar state changes, Foo changes as well.
        // Foo depends on Bar

        public class Foo2
        {
            private Bar2 LocalBar;

            public Bar2 Bar {
                get { return LocalBar; }
                set {
                    UnSubscribeFromEvents(LocalBar);
                    LocalBar = value;
                    SubscribeToEvents(LocalBar);
                }
            }

            public void AssignBarToFoo(Bar2 bar)
            {
                SubscribeToEvents(bar);
            }

            public void DoSomething()
            {
                if(this.LocalBar == null)
                {
                    Console.WriteLine($"Too bad. There is no {nameof(Bar2)}.");
                    return;
                }

                Console.WriteLine($"Dependency can access the same as Associations: {this.LocalBar.SomeInformation}");
            }

            private void SubscribeToEvents(Bar2 bar)
            {
                if (bar == null) { return; }
                bar.SomethingHappened += this.Bar_SomethingHappened;
            }

            private void UnSubscribeFromEvents(Bar2 bar)
            {
                if (bar == null) { return; }
                bar.SomethingHappened -= this.Bar_SomethingHappened;
            }

            private void Bar_SomethingHappened(object sender, EventArgs e) 
                => Console.WriteLine($"Something happened in {nameof(sender)}. {nameof(Bar2)} depends on this information to do something.");
        }

        public class Bar2
        {
            public event EventHandler SomethingHappened;

            public void OnSomethingHappened()
            {
                SomethingHappened?.Invoke(this, EventArgs.Empty);
            }

            public string SomeInformation { get; } = $"This is some information from {nameof(Bar2)}";
        }
    }
}
