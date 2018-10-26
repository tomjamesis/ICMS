using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Tunnel : CostedProject
    {
        public TunnelWorks Works { get; set; }
        public TunnelQuantities Quantities { get; set; }

        public Tunnel()
        { }
    }
}
