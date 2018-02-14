using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlRelationshipExample
{
    class Aggregation
    {
    }

    class Foo3
    {
        private readonly Bar3 bar;

        Foo3(Bar3 bar)
        {
            this.bar = bar;
        }
    }
    class Bar3
    {
    }
}
