﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houses
{
    public interface IPainter
    {
        double Paint(double houses);
        double EstimateDays(double houses);
    }
}
