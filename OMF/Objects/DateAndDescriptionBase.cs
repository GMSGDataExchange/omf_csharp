﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMF.Objects
{
    public class DateAndDescriptionBase : DateBase
    {
        public DateAndDescriptionBase()
        {
            description = "";
        }
        public string description { get; set; }
    }
}