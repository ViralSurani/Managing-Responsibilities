using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    public class Engine
    {
        public float Power { get; private set; }
        public float CylinderVolumn { get; private set; }

        public Engine(float power, float cylinderVolumn)
        {
            this.Power = power;
            this.CylinderVolumn = cylinderVolumn;
        }
    }
}
