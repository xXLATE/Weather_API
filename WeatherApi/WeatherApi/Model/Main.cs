﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApi.Model
{
    public class Main
    {
        public float Temp { get; set; }
        public float Feels_like { get; set; }
        public float Temp_min { get; set; }
        public float Temp_max { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }
}
