using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types.File
{
    public class Internal 
    {
        public Enums.KnownFileCategory Category { get; set; }
        public Enums.KnownFileExtension Format { get; set; }
        public List<object> Any { get; set; }

        public Internal()
        { }
    }
}
