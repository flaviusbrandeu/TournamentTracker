﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}