﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Hero
    {
        public Guid id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string ButtonText { get; set; }
        public string ButtonLink { get; set; }
    }

}
