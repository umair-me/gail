﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CharitiesOnline.Models;
using hmrcclasses;

namespace CharitiesOnline.Strategies.ErrorReader
{
    public interface IErrorReturnCalculator
    {
        string CalculateErrorReturn(GovTalkMessageGovTalkDetailsError error);
    }
}
