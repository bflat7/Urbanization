﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Urbanization.Data.Models
{
    public class UrbanizationByState
    {
        public int Id { get; set; }
        public int StateFips { get; set; }
        public string StateName { get; set; }
        public string GISJoin { get; set; }
        public float Latitude { get; set; }
        public float Longditude { get; set; }
        public int Population { get; set; }
        public float? FiveMileAdjRadiusPop { get; set; }
        public float UrbanIndex { get; set; }
    }
}
