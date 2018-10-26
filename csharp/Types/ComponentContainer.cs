using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.Types
{
    public class ComponentContainer
    {
        public List<ComponentMeasurement> ComponentMeasurement { get; set; }

        public ComponentContainer()
        {
            ComponentMeasurement = new List<ComponentMeasurement>();
        }
    }
}
