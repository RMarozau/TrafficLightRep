using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    public class SourceOfPower
    {
        public bool Electriсity;

        public SourceOfPower()
        {
            
        }

        public SourceOfPower(bool _electriсity)
        {
            Electriсity = _electriсity;
        }

        public void SetElectrisity(bool _electriсity)
        {
            Electriсity = _electriсity;
        }

        public bool GetElectrisity()
        {
            return Electriсity;
        }

    }
}
