using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlRelationshipExample
{
    class Dependency
    {
    }

    class Foo2
    {
        void SubscribeToEvents(Bar2 bar)
        {
            bar.SomethingHappened += this.Bar_SomethingHappened;
        }

        private void Bar_SomethingHappened(object sender, EventArgs e) => throw new NotImplementedException();
    }

    class Bar2
    {
        public event EventHandler SomethingHappened;

        void OnSomethingHappened()
        {
            SomethingHappened?.Invoke(this, EventArgs.Empty);
        }
    }
}
