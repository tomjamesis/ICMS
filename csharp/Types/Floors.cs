using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class Floors
    {
        public List<Floor> FloorLevel { get; set; }

        public Floors()
        {
            FloorLevel = new List<Floor>();
        }
    }
}
