﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW3.Observer
{
    public interface IObserver
    {
        void update(string availability);
    }
}
