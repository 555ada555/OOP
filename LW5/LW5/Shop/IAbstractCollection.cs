﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW5.Shop
{
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
