﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class NumObject : Prototype
    {
        public NumObject(int id) : base(id)
        {

        }

        public override Prototype Clone()
        {
            return new NumObject(Id);
        }
    }
}
