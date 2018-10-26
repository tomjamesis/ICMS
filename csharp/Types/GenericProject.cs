using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class GenericProject : CostedProject
    {
        public object Works { get; set; }
        public object Quantities { get; set; }

        public GenericProject()
        { }
    }
}
