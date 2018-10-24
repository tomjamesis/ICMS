using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types.File
{
    public class External
    {
        public Enums.KnownFileCategory Category { get; set; }
        public String href { get; set; }
        public List<object> Any { get; set; }

        public External()
        { }
    }
}
