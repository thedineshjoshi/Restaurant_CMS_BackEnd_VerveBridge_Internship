﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CustomerTestimonial
    {
        public Guid id { get; set; }
        public string CustomerSaying { get; set; }
        public string CustomerName { get; set; }
        public string CustomerImageUrl { get; set; }
    }

}
