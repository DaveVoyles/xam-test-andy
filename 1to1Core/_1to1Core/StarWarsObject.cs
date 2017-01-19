﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1to1Core
{
    /// <summary>
    /// Deserialize objects from Star Wars API: https://swapi.co/
    /// </summary>
    public class StarWarsObject
    {
        public string name { get; set; }
        public string height { get; set; }
        public string mass { get; set; }
        public string hair_color { get; set; }
        public string skin_color { get; set; }
        public string eye_color { get; set; }
        public string birth_year { get; set; }
        public string gender { get; set; }
        public string homeworld { get; set; }
        public List<string> films { get; set; }
    }
}
