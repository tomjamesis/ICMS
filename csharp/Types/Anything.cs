using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Anything
    {
        public List<object> skip { get; set; } 

        public Anything()
        {
            skip = new List<object>();
        }
    }
}
