﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarShop
{
    public interface ICarVisitor : ICarPartVisitor
    {
        void Visit(Car car);
    }
}